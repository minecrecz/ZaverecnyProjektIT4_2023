using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TopAPP.classes
{
    public class User
    {
        public User(string name, byte[] passwordSalt, byte[] passwordash, string role)
        {
            Name = name;
            PasswordSalt = passwordSalt;
            PasswordHash = passwordash;
            Role = role;
        }

        public string Name { get;  }
        public byte[] PasswordSalt { get; internal set; }
        public byte[] PasswordHash { get; internal set; }
        public string Role { get;  set; }

        
        public bool VerifyPassword(string text)
        {
            byte[] hash;
            using (var hmac = new HMACSHA512(PasswordSalt))
            {
                hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(text));
            }
            return hash.SequenceEqual(PasswordHash);
        }
    }
}
