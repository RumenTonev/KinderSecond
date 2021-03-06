﻿using KinderSecond.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderSecond.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
    }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public virtual IDbSet<PromoCode> Codes { get; set; }

    }
}
