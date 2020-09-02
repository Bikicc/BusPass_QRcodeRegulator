using System.Threading.Tasks;
using BusPass.Shared.HelperEntities;
using BusPass.Server.Repository;
using BusPass.Shared.Entities;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System;

namespace BusPass.Server.Services {
    public class UserService : IUserService {
        private readonly IUserRepository _repo;

        public UserService (IUserRepository repo) {
            _repo = repo;
        }
        public Task<User> LoginUser (LoginUser user) {
            user.Password = Encrypt(user.PasswordPlain);
            return _repo.LoginUser (user);
        }

        public async Task<bool> RegisterUser (User user) {
            if (await _repo.CheckIfUserExists (user)) {
                return false;
            } else {
                user.Password = Encrypt(user.PasswordPlain);
                return await _repo.RegisterUser (user);
            }
        }

        private string Encrypt (string passwordPlain) {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes (passwordPlain);
            using (Aes encryptor = Aes.Create ()) {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes (EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes (32);
                encryptor.IV = pdb.GetBytes (16);
                using (MemoryStream ms = new MemoryStream ()) {
                    using (CryptoStream cs = new CryptoStream (ms, encryptor.CreateEncryptor (), CryptoStreamMode.Write)) {
                        cs.Write (clearBytes, 0, clearBytes.Length);
                        cs.Close ();
                    }
                    passwordPlain = Convert.ToBase64String (ms.ToArray ());
                }
            }
            return passwordPlain;
        }
    }
}