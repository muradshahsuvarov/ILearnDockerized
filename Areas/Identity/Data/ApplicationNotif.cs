using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ILearnCoreV19.Areas.Identity.Data
{
    public class ApplicationNotif
    {
        [PersonalData]
        [Column(TypeName = "INT")]
        [Key]
        public int Id { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(256)")]
        public string UserName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(256)")]
        public string Header { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(256)")]
        public string? Body { get; set; }


        [PersonalData]
        [DataType(DataType.Date)]
        [Column(TypeName = "DATETIME")]
        public DateTime CreatedAt { get; set; }


        [PersonalData]
        [Column(TypeName = "BIT")]
        public Boolean IsRead { get; set; }

    }
}
