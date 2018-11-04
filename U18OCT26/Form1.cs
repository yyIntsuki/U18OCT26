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

            button1.Text = "Register";
            button1.Click += new EventHandler(Reg);
            listBox1.DataSource = customers;
        }

        private void Reg(object sender, EventArgs e)
        {
            cust.Register(textBox1.Text, int.Parse(textBox2.Text));
            // Show returned value from Customer Class.
        }
    }
}
