using NerdsOnWheels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NerdsOnWheels.ViewModels
{
    public class CustomerProfileViewModel
    {
        public Customer Customer { get; set; }
        public Service Service { get; set; }
        public CustomerProfileViewModel(Customer customer)
        {

        }
    }
}