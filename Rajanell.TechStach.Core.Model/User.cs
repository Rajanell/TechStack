using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStach.Core.Model
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
