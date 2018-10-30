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

            

            button1.Click += new EventHandler(DoStuff);

        }

        private void DoStuff(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            listBox1.Items.Add(name);

        }
    }
}
