﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehen_webgunea.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public int Name {  get; set; }
        public string? StreetAddress { get; set; }
        public string? City { get; set;}
        public string? State { get; set; }
        public string? PostalCode { get; set;}

    }
}
