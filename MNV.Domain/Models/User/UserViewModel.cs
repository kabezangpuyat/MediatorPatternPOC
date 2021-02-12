﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MNV.Domain.Models.User
{
    public class UserViewModel
    {
        public long? ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
    }
}
