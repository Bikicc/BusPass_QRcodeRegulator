using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BusPass.Server.HelperClasses;
using BusPass.Server.Repository;
using BusPass.Shared.Entities;
using BusPass.Shared.HelperEntities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace BusPass.Server.Services {
    public class UserService : IUserService {
        private readonly IUserRepository _repo;
        private readonly AppSettings _appSettings;

        public UserService (IOptions<AppSettings> appSettings, IUserRepository repo) {
            _appSettings = appSettings.Value;
            _repo = repo;
        }
        
        public async Task<LoginUser> LoginUser (LoginUser user) {
            user.Password = Encrypt (user.PasswordPlain);
            var us = await _repo.LoginUser (user);

            if (us == null) {
                return null;
            }
            LoginUser lus = new LoginUser ();
            lus.Email = us.Email;
            lus.Name = us.Name;
            lus.Surname = us.Surname;
            lus.UserId = us.UserId;
            lus.Role = us.Role;
            lus.OIB = us.OIB;
            // lus.DOBstring = us.DOB.Date.ToShortDateString();
            lus.Token = generateJwtToken (lus);
            return lus;
        }

        public async Task<User> getUserById(int userId) {
            var user = await _repo.getUserById(userId);
            // user.DOBstring = user.DOB.Date.ToShortDateString();
            return user;
        }

        public async Task<User> RegisterUser (User user) {
            if (await _repo.CheckIfUserExists (user)) {
                return null;
            } else {
                user.Password = Encrypt (user.PasswordPlain);
                return await _repo.RegisterUser (user);
            }
        }

        private string generateJwtToken (LoginUser us) {
            var tokenHandler = new JwtSecurityTokenHandler ();
            var key = Encoding.ASCII.GetBytes (_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity (new Claim[] {
                new Claim (ClaimTypes.Name, us.UserId.ToString ()),
                new Claim (ClaimTypes.Role, us.Role)
                }),
                Expires = DateTime.UtcNow.AddDays (7),
                SigningCredentials = new SigningCredentials (new SymmetricSecurityKey (key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken (tokenDescriptor);
            return tokenHandler.WriteToken (token);
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