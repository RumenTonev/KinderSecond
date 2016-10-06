using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace KinderSecond.Models
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        private ICollection<Quiz> takenQuizes;

        public ApplicationUser()
        {
            this.takenQuizes = new HashSet<Quiz>();
        }

        public virtual ICollection<Quiz> TakenQuizes
        {
            get { return this.takenQuizes; }
            set { this.takenQuizes = value; }
        }
    }
}
