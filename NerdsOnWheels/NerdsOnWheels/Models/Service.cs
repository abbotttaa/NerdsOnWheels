using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NerdsOnWheels.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }




        [Display(Name = "Customer")]
        public string CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual ApplicationUser Users { get; set; }    


        //[ForeignKey("CustomerId")]
        //public virtual ICollection<RegisterViewModel> CustomerID { get; set; }

        //[ForeignKey("TechnicianId")]
        //public virtual ICollection<RegisterViewModel> TechnicianId { get; set; }

        [Required]
        public string AssistanceRequestType { get; set; }

        [Display(Name= "Describe your issue: ")]
        public string AssistanceRequestDescription { get; set; }

        [Display(Name ="Ticket Availability: ")]
        public bool IsTicketOpen { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public string DateOfEvent { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public string CloseDate { get; set; }

        //[ForeignKey("CustomerID")]
        //public int CustomerID { get; set; }

        //[ForeignKey("TechnicianID")]
        //public int TechnicianID { get; set; }



    }
}