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



        [Display(Name = "Technician")]
        public string TechnicianId { get; set; }
        [ForeignKey("TechnicianId")]
        public virtual ApplicationUser Techs { get; set; }

        [Required]
        public string AssistanceRequestType { get; set; }

        [Display(Name= "Describe your issue: ")]
        public string AssistanceRequestDescription { get; set; }

        [Display(Name ="Ticket Availability: ")]
        public bool IsTicketOpen { get; set; }

        [Display(Name ="Rating")]
        public int Rating { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public string DateOfEvent { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public string CloseDate { get; set; }

    }
}