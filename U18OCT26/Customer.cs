using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U18OCT26
{
    class Customer : Form1, ICustomer
    {
        public string UserName { get; set; }
        public int CustomerID { get; set; }
        private List<Customer> customers;

        public void Register(string name, int id)
        {
            foreach (Customer customer in customers)
            {
                customers.Add(new Customer
                {
                    UserName = name,
                    CustomerID = id,
                });

            // Make this return something to the Form.
            }
        }
    }
}