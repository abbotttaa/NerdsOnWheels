using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NerdsOnWheels.Models
{
    public class Technician
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
      
        public string Schedule { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        public double Rating { get; set; }



    }
}