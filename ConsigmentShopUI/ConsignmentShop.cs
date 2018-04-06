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
    public partial class ConsignmentShop : Form
    {

        private Store store = new Store();

        private List<Item> shoppingCartData = new List<Item>();

        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorBinding = new BindingSource();
        private decimal storeProfit = 0;


        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList(); ;
            itemsListBox.DataSource = itemsBinding;

            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            cartListBox.DataSource = cartBinding;

            cartListBox.DisplayMember = "Display";
            cartListBox.ValueMember = "Display";

            vendorBinding.DataSource = store.Vendors;
            vendorListBox.DataSource = vendorBinding;

            vendorListBox.DisplayMember = "Display";
            vendorListBox.ValueMember = "Display";

        }



        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });
            store.Vendors.Add(new Vendor { FirstName = "Mary", LastName = "Toms" });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "Book about big ass whale.",
                Price = 8.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Swoly Bible",
                Description = "Book about gettin' swole.",
                Price = 12.00M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Swagg Shirt",
                Description = "Shirt with Swagger",
                Price = 18.00M,
                Owner = store.Vendors[2]
            });

            store.Items.Add(new Item
            {
                Title = "Vappo Moddo",
                Description = "Good vaporizer.",
                Price = 24.00M,
                Owner = store.Vendors[2]
            });

            store.Name = "Seconds are Better";

            }

        private void addToCart_Click(object sender, EventArgs e)
        {
            // Determine which item(s) is/are selectected in items list.
            // Copy item(s) to shopping cart.
            // Do we remove item(s) from items list...no...?
            Item selectedItem = (Item)itemsListBox.SelectedItem;
            shoppingCartData.Add(selectedItem);

            cartBinding.ResetBindings(false);

        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            //Mark each item in cart as sold
            //Clear cart.

            foreach(Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1-(decimal)item.Owner.Commission) * item.Price;
            }

            shoppingCartData.Clear();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList(); ;

            storeProfitValue.Text = string.Format("${0}", storeProfit);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorBinding.ResetBindings(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
