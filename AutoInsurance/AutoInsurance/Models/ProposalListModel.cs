using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoInsurance.Web.Models
{
    public class ProposalListModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Value { get; set; }
        public string CarModel { get; set; }
    }
}