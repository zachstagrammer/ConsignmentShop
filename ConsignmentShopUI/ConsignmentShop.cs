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

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        BindingSource itemsBinding = new BindingSource();

        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items;
            itemsListBox.DataSource = itemsBinding;

            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }
        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Zach", LastName = "Phillips" });
            store.Vendors.Add(new Vendor { FirstName = "John", LastName = "Smith" });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "Book about a Whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "A Tale Of Two Cities",
                Description = "Book about a Revolution",
                Price = 3.80M,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Title = "Harry Potter",
                Description = "Book about a Wizard Boy",
                Price = 6.20M,
                Owner = store.Vendors[1]
            }); store.Items.Add(new Item
            {
                Title = "Jane Eyre",
                Description = "Book about a Girl",
                Price = 2.50M,
                Owner = store.Vendors[0]
            });

            store.Name = "Bookworms4Life";

        }
    }
}
