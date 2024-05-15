using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ndt.lesson04.Models
{
    public class NdtCustomer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MyProperty { get; set; }
        public string Address { get; set; }
        public int YearofBirth { get; set; }
    }
}