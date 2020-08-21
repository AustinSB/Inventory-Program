using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProgram
{
    public partial class ModifyProduct_Form : Form
    {
        Part allPartsIndex = null;
        Part associateIndex = null;
        Product tempProduct = new Product("",0,2,1,3);

        public ModifyProduct_Form()
        {
            InitializeComponent();

            Inventory.partsIndex = null;

            productID_TextBox.Text = Inventory.productIndex.ProductID.ToString();
            productName_TextBox.Text = Inventory.productIndex.Name;
            productPrice_TextBox.Text = Inventory.productIndex.Price.ToString();
            productInventory_TextBox.Text = Inventory.productIndex.InStock.ToString();
            productMin_TextBox.Text = Inventory.productIndex.Min.ToString();
            productMax_TextBox.Text = Inventory.productIndex.Max.ToString();

            all_DataGrid.DataSource = Inventory.AllParts;
            
            CreateTemporaryList();
            associate_DataGrid.DataSource = tempProduct.AssociatedParts;
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
                associateIndex = tempProduct.AssociatedParts[0];
                associate_DataGrid.Rows[0].Selected = true;
            }
            else
            {
                associateIndex = tempProduct.AssociatedParts[e.RowIndex];
            }
            Debug.WriteLine($"Associate ID: {associateIndex.PartID} Name: {associateIndex.Name}");
        }

        private void productPartAdd_Button_Click(object sender, EventArgs e)
        {
            

            if (allPartsIndex == null)
            {
                MessageBox.Show("Must select a part to add.", "Invalid Selection");
                DeselectAllRows();
                return;
            }
            
            foreach (var part in tempProduct.AssociatedParts)
            {
                if (part.PartID == allPartsIndex.PartID)
                {
                    MessageBox.Show("This part has already been associated with this product.","Duplicate Add");
                    DeselectAllRows();
                    return;
                }
            }
            
            tempProduct.addAssociatedPart(allPartsIndex);
            DeselectAllRows();
        }

        private void productPartDelete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tempProduct.removeAssociatedPart(associateIndex.PartID))
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
                associate_DataGrid.DataSource = tempProduct.AssociatedParts;
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
                searchedPart = tempProduct.lookupAssociatedPart(searchID);
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
                searchedPart = tempProduct.lookupAssociatedPart(searchName);
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

        //Event Handler to send to Main Form to let it know the data on this form has been saved
        public event EventHandler SaveClicked;

        private void productSave_Button_Click(object sender, EventArgs e)
        {
            if (!Inventory.ValidateNumericValues(ProductsName, ProductsPrice, ProductsInventory, ProductsMax, ProductsMin)) { return; }

            foreach (var part in tempProduct.AssociatedParts)
            {
                Inventory.productIndex.AssociatedParts.Add(part);
            }

            Inventory.updateProduct(Inventory.productIndex, this);

            SaveClicked(this, e);
            
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

        public void CreateTemporaryList()
        {
            foreach (var part in Inventory.productIndex.AssociatedParts)
            {
                tempProduct.AssociatedParts.Add(part);
            }
        }
    }
}
