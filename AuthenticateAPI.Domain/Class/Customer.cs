using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticateAPI.Domain.Class
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public bool Blocked { get; set; }

    }
}
