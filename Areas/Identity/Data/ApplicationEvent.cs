using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ILearnCoreV19.Areas.Identity.Data
{
    public class ApplicationEvent
    {
        [PersonalData]
        [Column(TypeName = "INT")]
        [Key] 
        public int EventId { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string text { get; set; }

        [PersonalData]
        [DataType(DataType.Date)]
        [Column(TypeName = "DATETIME NOT NULL")]
        public DateTime start_date { get; set; }

        [PersonalData]
        [DataType(DataType.Date)]
        [Column(TypeName = "DATETIME")]
        public DateTime? end_date { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(450)")]
        public string userId { get; set; }

        [PersonalData]
        [Column(TypeName = "NVARCHAR(50)  DEFAULT('AVAILABLE')")]
        public string status { get; set; }

        [PersonalData]
        [Column(TypeName = "NVARCHAR(50)")]
        public string subscriberEmail { get; set; }

        [PersonalData]
        [Column(TypeName = "NVARCHAR(300)")]
        public string description { get; set; }

        [PersonalData]
        [Column(TypeName = "NVARCHAR(10)")]
        public string ThemeColor { get; set; }

        [PersonalData]
        [Column(TypeName = "BIT")]
        public Boolean isFullDay { get; set; }

        [PersonalData]
        [Column(TypeName = "NVARCHAR(50) DEFAULT ('0')")]
        public string Price { get; set; }

        [PersonalData]
        [Column(TypeName = "NVARCHAR(450)")]
        public string Token { get; set; }

        [PersonalData]
        [Column(TypeName = "BIT")]
        public Boolean IsPaid { get; set; }

        [PersonalData]
        [Column(TypeName = "NVARCHAR(450)")]
        public string? subscriberFirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "NVARCHAR(450)")]
        public string? subscriberLastName { get; set; }

        [PersonalData]
        [Column(TypeName = "NVARCHAR(450)")]
        public string payment { get; set; }

        [PersonalData]
        [Column(TypeName = "NVARCHAR(450)")]
        public string ownerFirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "NVARCHAR(450)")]
        public string ownerLastName { get; set; }
    }
}
