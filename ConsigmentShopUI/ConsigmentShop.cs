using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsigmentShopUI
{
    public partial class ConsigmentShop : Form
    {

        private Store store = new Store();

        public ConsigmentShop()
        {
            InitializeComponent();
            SetupData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetupData()
        {
            store.Vendors.Add(new Vendor {FirstName = "Bill", LastName = "Smith"});
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones"});
            store.Vendors.Add(new Vendor { FirstName = "Mary", LastName = "Toms"});
        }


    }
}
