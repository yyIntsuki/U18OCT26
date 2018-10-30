using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U18OCT26
{
    public partial class Form1 : Form
    {

        private ICustomer cust;

        public Form1()
        {
            InitializeComponent();

            cust = new Customer();
            List<ICustomer> customers = new List<ICustomer>();

            button1.Text = "Register";
            button1.Click += new EventHandler(DoStuff);

        }

        private void DoStuff(object sender, EventArgs e)
        {
            // "do" prefix due to not getting confused with variables in Customer class.
            string doname = textBox1.Text;
            string douserID = textBox2.Text;

            List<ICustomer> customers = new List<ICustomer>()
            {
                new Customer() { name = doname , customerID = douserID}
            };
 

            foreach (var item in customers)
            {
                listBox1.Items.Add(((Customer)item).name);
                listBox1.Items.Add(((Customer)item).customerID);
            }
            textBox1.Text = string.Empty;
            textBox1.Focus();
        }
    }
}
