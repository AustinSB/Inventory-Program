using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProgram
{
    public partial class AddProduct_Form : Form
    {
        Product newProduct = new Product("", 0, 0, 0, 0);
        Part allPartsIndex = null;
        Part associateIndex = null;


        public AddProduct_Form()
        {
            InitializeComponent();

            all_DataGrid.DataSource = Inventory.AllParts;
            associate_DataGrid.DataSource = newProduct.AssociatedParts;
        }

        private void ModifyProduct_Form_Load(object sender, EventArgs e)
        {
            DeselectAllRows();
        }


        //Properties for Product
        public string ProductsID
        {
            get { return productID_TextBox.Text; }
            set { productID_TextBox.Text = value; }
        }
        public string ProductsName
        {
            get { return productName_TextBox.Text; }
            set { productName_TextBox.Text = value; }
        }
        public string ProductsPrice
        {
            get { return productPrice_TextBox.Text; }
            set { productPrice_TextBox.Text = value; }
        }
        public string ProductsInventory
        {
            get { return productInventory_TextBox.Text; }
            set { productInventory_TextBox.Text = value; }
        }
        public string ProductsMin
        {
            get { return productMin_TextBox.Text; }
            set { productMin_TextBox.Text = value; }
        }
        public string ProductsMax
        {
            get { return productMax_TextBox.Text; }
            set { productMax_TextBox.Text = value; }
        }


        private void all_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                allPartsIndex = Inventory.AllParts[0];
                all_DataGrid.Rows[0].Selected = true;
            }
            else
            {
                allPartsIndex = Inventory.AllParts[e.RowIndex];
            }
        }

        private void associate_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                associateIndex = newProduct.AssociatedParts[0];
                associate_DataGrid.Rows[0].Selected = true;
            }
            else
            {
                associateIndex = newProduct.AssociatedParts[e.RowIndex];
            }
        }


        private void productPartAdd_Button_Click(object sender, EventArgs e)
        {
            if (allPartsIndex == null)
            {
                MessageBox.Show("Must select a part to add.", "Invalid Selection");
                DeselectAllRows();
                return;
            }

            foreach (var part in newProduct.AssociatedParts)
            {
                if (part.PartID == allPartsIndex.PartID)
                {
                    MessageBox.Show("This part has already been associated with this product.", "Duplicate Add");
                    DeselectAllRows();
                    return;
                }
            }

            newProduct.addAssociatedPart(allPartsIndex);
            DeselectAllRows();
        }


        private void productPartDelete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!newProduct.removeAssociatedPart(associateIndex.PartID))
                {
                    MessageBox.Show("Must select a part to remove.", "Invalid Selection");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Must select a part to remove.", "Invalid Selection");
            }
            DeselectAllRows();
        }

        private void allSearch_Button_Click(object sender, EventArgs e)
        {
            if (allSearch_Button.Text == "Clear")
            {
                associate_DataGrid.DataSource = newProduct.AssociatedParts;
                allSearch_TextBox.Text = "";
                allSearch_Button.Text = "Search";
                return;
            }

            int searchID = 0;
            string searchName = "";
            Part searchedPart = null;
            BindingList<Part> searchList = null;

            try
            {
                searchID = Convert.ToInt32(allSearch_TextBox.Text);
                searchedPart = newProduct.lookupAssociatedPart(searchID);
            }
            catch (Exception)
            {
                bool invalidEntry = allSearch_TextBox.Text.Any(x => char.IsDigit(x));

                if (invalidEntry)
                {
                    MessageBox.Show("Search entry is not valid. Please search for either part ID or Name.",
                                    "Invalid Entry", MessageBoxButtons.OK);
                    return;
                }

                searchName = allSearch_TextBox.Text;
                searchedPart = newProduct.lookupAssociatedPart(searchName);
            }

            if (searchedPart == null)
            {
                return;
            }
            else
            {
                searchList = new BindingList<Part> { searchedPart };
                associate_DataGrid.DataSource = searchList;

                allSearch_Button.Text = "Clear";
            }
        }

        private void productSave_Button_Click(object sender, EventArgs e)
        {
            if (!Inventory.ValidateNumericValues(ProductsName, ProductsPrice, ProductsInventory, ProductsMax, ProductsMin)) { return; }
            
            Inventory.addProduct(newProduct, this);
            this.Close();
        }


        private void productCancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Helper Methods
        public void DeselectAllRows()
        {
            for (int i = 0; i < all_DataGrid.Rows.Count; i++)
            {
                all_DataGrid.Rows[i].Selected = false;
            }
            allPartsIndex = null;

            for (int i = 0; i < associate_DataGrid.Rows.Count; i++)
            {
                associate_DataGrid.Rows[i].Selected = false;
            }
        }
    }
}
