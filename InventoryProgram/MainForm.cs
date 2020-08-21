using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace InventoryProgram
{
    public partial class mainScreen_Form : Form
    {
        public mainScreen_Form()
        {
            InitializeComponent();

            parts_DataGrid.DataSource = Inventory.AllParts;
            product_DataGrid.DataSource = Inventory.Products;

        }

        private void mainScreen_Form_Load(object sender, EventArgs e)
        {
            parts_DataGrid.Rows[0].Selected = false;
            product_DataGrid.Rows[0].Selected = false;
        }


        ////Parts Controls
        private void partsAdd_Button_Click(object sender, EventArgs e)
        {
            var addPart_Form = new AddPart_Form();
            addPart_Form.Show();
        }

        private void partsModify_Button_Click(object sender, EventArgs e)
        {
            if(Inventory.partsIndex == null) 
            {
                MessageBox.Show("Must select part to modify.","No selection");
                return;
            }

            var modifyPart_Form = new ModifyPart_Form();
            modifyPart_Form.SaveClicked += new EventHandler(modifyPart_Form_SaveClicked);
            modifyPart_Form.Show();
        }

        void modifyPart_Form_SaveClicked(object sender, EventArgs e) 
        {
            parts_DataGrid.Refresh();

            for (int i = 0; i < parts_DataGrid.Rows.Count; i++)
            {
                parts_DataGrid.Rows[i].Selected = false;
            }

            Inventory.partsIndex = null;
        }

        private void parts_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                Inventory.partsIndex = Inventory.AllParts[0];
                parts_DataGrid.Rows[0].Selected = true;
            }
            else
            {
                Inventory.partsIndex = Inventory.AllParts[e.RowIndex];
            }
        }

        private void partsDelete_Button_Click(object sender, EventArgs e)
        {
            if (!Inventory.deletePart(Inventory.partsIndex))
            {
                MessageBox.Show("Must select part", "Invalid Selection", MessageBoxButtons.OK);
            }
        }

        private void partSearch_Button_Click(object sender, EventArgs e)
        {
            if(partSearch_Button.Text == "Clear")
            {
                parts_DataGrid.DataSource = Inventory.AllParts;
                partSearch_TextBox.Text = "";
                partSearch_Button.Text = "Search";
                return;
            }

            int searchID = 0;
            string searchName = "";
            Part searchedPart = null;
            BindingList<Part> searchList = null;

            try
            {
                searchID = Convert.ToInt32(partSearch_TextBox.Text);
                searchedPart = Inventory.lookupPart(searchID);
            }
            catch (Exception)
            {
                bool invalidEntry = partSearch_TextBox.Text.Any(x => char.IsDigit(x));

                if (invalidEntry)
                {
                    MessageBox.Show("Search entry is not valid. Please search for either part ID or Name.",
                                    "Invalid Entry", MessageBoxButtons.OK);
                    return;
                }

                searchName = partSearch_TextBox.Text;
                searchedPart = Inventory.lookupPart(searchName);
            }

            if(searchedPart == null)
            {
                return;
            }
            else
            {
                searchList = new BindingList<Part> { searchedPart };
                parts_DataGrid.DataSource = searchList;

                partSearch_Button.Text = "Clear";
            }
        }




        ////Products Controls
        private void productsAdd_Button_Click(object sender, EventArgs e)
        {
            var addProduct_Form = new AddProduct_Form();
            addProduct_Form.Show();
        }

        private void productsModify_Button_Click(object sender, EventArgs e)
        {
            if (Inventory.productIndex == null)
            {
                MessageBox.Show("Must select product to modify.", "No selection");
                return;
            }

            var modifyProduct_Form = new ModifyProduct_Form();
            modifyProduct_Form.SaveClicked += new EventHandler(modifyProduct_Form_SaveClicked);
            modifyProduct_Form.Show();
        }

        void modifyProduct_Form_SaveClicked(object sender, EventArgs e)
        {
            product_DataGrid.Refresh();

            for (int i = 0; i < product_DataGrid.Rows.Count; i++)
            {
                product_DataGrid.Rows[i].Selected = false;
            }

            Inventory.productIndex = null;
        }

        private void product_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                Inventory.productIndex = Inventory.Products[0];
                product_DataGrid.Rows[0].Selected = true;
            }
            else
            {
                Inventory.productIndex = Inventory.Products[e.RowIndex];
            }
        }

        private void productsDelete_Button_Click(object sender, EventArgs e)
        {
            if (!Inventory.deleteProduct(Inventory.Products.IndexOf(Inventory.productIndex)))
            {
                MessageBox.Show("Must select product", "Invalid Selection", MessageBoxButtons.OK);
            }
            
        }

        private void productSearch_Button_Click(object sender, EventArgs e)
        {
            if (productSearch_Button.Text == "Clear")
            {
                product_DataGrid.DataSource = Inventory.Products;
                productSearch_TextBox.Text = "";
                productSearch_Button.Text = "Search";
                return;
            }

            int searchID = 0;
            string searchName = "";
            Product searchedProduct = null;
            BindingList<Product> searchList = null;

            try
            {
                searchID = Convert.ToInt32(productSearch_TextBox.Text);
                searchedProduct = Inventory.lookupProduct(searchID);
            }
            catch (Exception)
            {
                bool invalidEntry = productSearch_TextBox.Text.Any(x => char.IsDigit(x));

                if (invalidEntry)
                {
                    MessageBox.Show("Search entry is not valid. Please search for either product ID or Name.",
                                    "Invalid Entry", MessageBoxButtons.OK);
                    return;
                }

                searchName = productSearch_TextBox.Text;
                searchedProduct = Inventory.lookupProduct(searchName);
            }

            if (searchedProduct == null)
            {
                return;
            }
            else
            {
                searchList = new BindingList<Product> { searchedProduct };
                product_DataGrid.DataSource = searchList;

                productSearch_Button.Text = "Clear";
            }
        }



        ////Exit Program
        private void mainScreenExit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
