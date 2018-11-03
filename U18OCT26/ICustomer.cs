using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U18OCT26
{
    public interface ICustomer
    {
        // Commenting out properties to test out just a few first before adding the rest. Making sure it works first.
        string Name { get; set; }
        // string phoneNumber { get; set; }
        int CustomerID { get; set; }
        // string email { get; set; }
        // string shippingAddress { get; set; }
        // string vipStatus { get; set; }
        //string regDate { get; set; }

        void Register();
        // void ViewList();
        //void ShowCustomerDetails();
        // void EditCustomerDetails();
        // void RemoveCustomer();
    }
}
