using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NerdsOnWheels.Models
{
    public class Service
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "What's your issue?")]
        public string AssistanceRequestType { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public string DateOfEvent { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public string CloseDate { get; set; }

    }
}