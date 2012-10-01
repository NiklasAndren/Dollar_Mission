using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mission.Domain.Entities
{
    public enum Role { Admin, User }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public Guid ID { get; set; }
    }
}
