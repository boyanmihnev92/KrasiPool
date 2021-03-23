// ReSharper disable VirtualMemberCallInConstructor
using System;
using System.Collections.Generic;

using KrasiPool.Data.Common.Models;

using Microsoft.AspNetCore.Identity;

namespace KrasiPool.Data.Models
{
    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.Territories = new HashSet<Polygon>();
            this.Services = new HashSet<Service>();
            this.Visits = new HashSet<Visit>();
        }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        public virtual ICollection<Polygon> Territories { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
