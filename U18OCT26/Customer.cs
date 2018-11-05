using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U18OCT26
{
    class Customer : ICustomer
    {
        public string UserName { get; set; }
        public int CustomerID { get; set; }

        public static BindingList<Customer> customers;

        public void Register(string name, int id)
        {
            customers = new BindingList<Customer>
            {
                new Customer()
                {
                    UserName = name,
                    CustomerID = id,
                }
            };
        }
    }
}