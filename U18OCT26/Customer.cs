using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U18OCT26
{
    class Customer : ICustomer
    {
        // Details for Customer
        public string name { get; set; }
        public int phoneNumber { get; set; }
        public int customerID { get; set; }
        public string email { get; set; }
        public string shippingAddress { get; set; }
        public bool vipStatus { get; set; }
        public string regDate { get; set; }

        public void EditCustomerDetails()
        {
            throw new NotImplementedException();
        }

        public void Register()
        {
            throw new NotImplementedException();
        }

        public void RemoveCustomer()
        {
            throw new NotImplementedException();
        }

        public void ShowCustomerDetails()
        {
            throw new NotImplementedException();
        }

        public void ViewList()
        {
            throw new NotImplementedException();
        }
    }
}
