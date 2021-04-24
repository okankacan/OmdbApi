﻿using Microsoft.AspNetCore.Identity;

namespace Omdbapi.InfraStructure
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
