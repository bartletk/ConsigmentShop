using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }

        //public Vendor(string FirstName, string LastName, double Commission)
        //{
        //    this.FirstName = FirstName;
        //    this.LastName = LastName;
        //    this.Commission = Commission;
        //}
        //holy shit this part isn't needed

        public Vendor()
        {
            Commission = .5;//default commission
        }
       
    }
}
