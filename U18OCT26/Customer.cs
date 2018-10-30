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
        public string phoneNumber { get; set; }
        public string customerID { get; set; }
        public string email { get; set; }
        public string shippingAddress { get; set; }
        public string vipStatus { get; set; }
        public string regDate { get; set; }

        public string Register(string name, string customerID)
        {
            return name + customerID;
        }

        public void ViewList()
        {
            throw new NotImplementedException();
        }

        public void ShowCustomerDetails()
        {
            throw new NotImplementedException();
        }

        public void EditCustomerDetails()
        {
            throw new NotImplementedException();
        }

        public void RemoveCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
