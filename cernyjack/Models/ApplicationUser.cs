﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cernyjack.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Wins { get; set; }
    }
}
