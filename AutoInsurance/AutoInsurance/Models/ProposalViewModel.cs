using AutoInsurance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoInsurance.Web.Models
{
    public class ProposalViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public List<Car> Cars { get; set; }
        public int CarId { get; set; }

        public double ProposalValue { get; set; }
    }
}