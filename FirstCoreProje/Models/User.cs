using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreProje.Models
{
    public class User:Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public byte[] Password { get; set; }
        public byte[] Salt { get; set; }
        public string Image { get; set; }
        public int UserStatusId { get; set; }
        public UserStatus UserStatus { get; set; }
        public int UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
    }
}
