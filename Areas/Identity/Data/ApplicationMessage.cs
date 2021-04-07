using ILearnCoreV19.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ILearnCoreV19.Areas.Identity.Data
{
    public class ApplicationMessage
    {
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        public string ReceiverName { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime When { get; set; }

        public string UserID { get; set; }

        public string UserFirstName { get; set; }

        public string UserLastName { get; set; }

        public string ReceiverFirstName { get; set; }

        public string ReceiverLastName { get; set; }

        public virtual ApplicationUser Sender { get; set; } // Problem can occur here

        public ApplicationMessage()
        {
            When = DateTime.Now;
        }
    }
}
