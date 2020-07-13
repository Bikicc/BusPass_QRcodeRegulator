using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace BusPass.Shared.Entities
{
    public class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "OIB length must be 11 characters")]
        [RegularExpression(@"^[0-9]*$")]
        public string OIB { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Role { get; set; }
        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Password must contain at least 4 characters")]
        public string Password { get; set; }

        [NotMapped]
        public string PasswordPlain
        {
            get { return Decrypt(Password); }
            set { Password = Encrypt(value); }
        }

        public virtual BusPassport BusPass { get; set; }
        public virtual Account Account { get; set; }

        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }


    }
}
