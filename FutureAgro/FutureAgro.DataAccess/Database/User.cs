﻿using System;
using System.Collections.Generic;

namespace FutureAgro.DataAccess.Database
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
