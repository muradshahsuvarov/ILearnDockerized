using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ILearnCoreV19.Areas.Identity.Data
{
    public class ApplicationSubscription
    {
        [PersonalData]
        [Column(TypeName = "INT")]
        [Key]
        public int Id { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; }

        [PersonalData]
        [Column(TypeName = "DATETIME")]
        public DateTime? StartDate { get; set; }


        [PersonalData]
        [Column(TypeName = "DATETIME")]
        public DateTime? EndDate { get; set; }


        [PersonalData]
        [Column(TypeName = "BIT")]
        public Boolean IsActivated { get; set; }

        [PersonalData]
        [Column(TypeName = "NVARCHAR(250)")]
        public string Price { get; set; }

        [PersonalData]
        [Column(TypeName = "BIT")]
        public Boolean Cancelled { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(256)")]
        public string UserName { get; set; }
    }
}
