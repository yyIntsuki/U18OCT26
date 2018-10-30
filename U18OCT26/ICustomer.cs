using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U18OCT26
{
    public interface ICustomer
    {
        string Register(string name, string customerID);
        void ViewList();
        void ShowCustomerDetails();
        void EditCustomerDetails();
        void RemoveCustomer();
    }
}
