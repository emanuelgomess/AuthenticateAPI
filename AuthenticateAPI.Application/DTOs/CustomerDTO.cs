﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticateAPI.Application.DTOs
{
    public class CustomerDTO
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
    }
}
