using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projekt_topAPP.třídy
{
    public class User
    {
        public string Name { get; }
        public byte[] PasswordSalt { get; internal set; }
        public byte[] PasswordHash { get; internal set; }
        public string Role { get; set; }


        public User(string name, byte[] passwordHash, byte[] passwordSalt, string role)
        {
            Name = name;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            Role = role;
        }
        public
            User(string name, string password, string role)
        {
            Name = name;
            Role = role;
            CreatePasswordHash(password);
        }
        public bool VerifyPassword(string text)
        {
            byte[] hash;
            using (var hmac = new HMACSHA512(PasswordSalt))
            {
                hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(text));
            }
            return hash.SequenceEqual(PasswordHash);
        }

        public void CreatePasswordHash(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                PasswordSalt = hmac.Key;
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        public void ChangePassword(string password)
        {
            CreatePasswordHash(password);
        }
    }
}
