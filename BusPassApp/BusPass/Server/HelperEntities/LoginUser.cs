using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace BussPass.Server.HelperEntities {
    public class LoginUser {
        [Required]
        [RegularExpression (@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")]
        public string Email { get; set; }

        public string Password { get; set; }

        public string PasswordPlain {
            // get { return Decrypt(Password); }
            set { Password = Encrypt (value); }
        }
        private string Encrypt (string clearText) {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes (clearText);
            using (Aes encryptor = Aes.Create ()) {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes (EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes (32);
                encryptor.IV = pdb.GetBytes (16);
                using (MemoryStream ms = new MemoryStream ()) {
                    using (CryptoStream cs = new CryptoStream (ms, encryptor.CreateEncryptor (), CryptoStreamMode.Write)) {
                        cs.Write (clearBytes, 0, clearBytes.Length);
                        cs.Close ();
                    }
                    clearText = Convert.ToBase64String (ms.ToArray ());
                }
            }
            return clearText;
        }
    }
}