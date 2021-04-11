using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ILearnCoreV19.Models;
using Microsoft.AspNetCore.Identity;

namespace ILearnCoreV19.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Messages = new HashSet<ApplicationMessage>();
        }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string? FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string? LastName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string? Role { get; set; }

        [PersonalData]
        [Column(TypeName = "datetime")]
        public DateTime? DateOfBirth { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string? Paypal { get; set; }



        public virtual ICollection<ApplicationMessage> Messages { get; set; }
    }
}
