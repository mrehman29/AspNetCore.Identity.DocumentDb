﻿using AspNetCore.Identity.DocumentDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AspNetCore.Identity.DocumentDb
{
    public class DocumentDbIdentityUser : DocumentDbIdentityDocument
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string NormalizedUserName { get; set; }
        public string NormalizedEmail { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public IList<DocumentDbIdentityRole> Roles { get; set; }
        public IList<UserLogin> Logins { get; set; }
        public IList<Claim> Claims { get; set; }
        public DateTimeOffset? LockoutEndDate { get; set; }
        public int AccessFailedCount { get; set; }
        public bool LockoutEnabled { get; set; }
    }
}
