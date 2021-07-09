﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Phonebook.Client.Web
{
    public class AppSettings
    {
        public string IDP { get; set; }
        public string ClientAppId { get; set; }
        public string ClientSecret { get; set; }
        public string APIScope { get; set; }
    }
}
