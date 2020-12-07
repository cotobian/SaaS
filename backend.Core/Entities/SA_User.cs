using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Core.Entities
{
    public class SA_User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime update_time { get; set; }
    }
}
