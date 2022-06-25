using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop.PageObjects.OnePageCheckOut
{
    internal class TestData
    {
        public class PersonalDetails
        {
            public string City { get; set; }
            public string Address1 { get; set; }
            public string ZipPostalCode { get; set; }
            public string PhoneNumber { get; set; }
        }
        public class PaymentInformation
        {
            public string CardholderName { get; set; }
            public string CardNumber { get; set; }
            public string CardCode { get; set; }
        }
    }   
}
