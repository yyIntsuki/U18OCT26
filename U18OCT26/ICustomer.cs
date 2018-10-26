using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U18OCT26
{
    public interface ICustomer
    {
        void Register();
        void ViewList();
        void ShowCustomerDetails();
        void EditCustomerDetails();
        void RemoveCustomer();
    }
}
