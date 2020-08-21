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
    public partial class ModifyPart_Form : Form
    {
        public ModifyPart_Form()
        {
            InitializeComponent();

            partCompanyName_Label.Location = new Point(25, 400);
            partCompanyName_TextBox.Location = new Point(125, 400);

            SetUpForm();
        }

        //Properties for the textboxes.
        public string PartID
        {
            get { return partID_TextBox.Text; }
            set { partID_TextBox.Text = value; }
        }
        public string PartName
        {
            get { return partName_TextBox.Text; }
            set { partName_TextBox.Text = value; }
        }
        public string PartPrice
        {
            get { return partPrice_TextBox.Text; }
            set { partPrice_TextBox.Text = value; }
        }
        public string InStock
        {
            get { return partInventory_TextBox.Text; }
            set { partInventory_TextBox.Text = value; }
        }
        public string PartMin
        {
            get { return partMin_TextBox.Text; }
            set { partMin_TextBox.Text = value; }
        }
        public string PartMax
        {
            get { return partMax_TextBox.Text; }
            set { partMax_TextBox.Text = value; }
        }
        public string PartCompanyName
        {
            get { return partCompanyName_TextBox.Text; }
            set { partCompanyName_TextBox.Text = value; }
        }
        public string PartMachineID
        {
            get { return partMachineID_TextBox.Text; }
            set { partMachineID_TextBox.Text = value; }
        }
        //Properties for the radio buttons.
        public bool InHouseIsChecked
        {
            get { return partInHouse_Radio.Checked; }
            set { partInHouse_Radio.Checked = value; }
        }
        public bool OutsourcedIsChecked
        {
            get { return partOutsourced_Radio.Checked; }
            set { partOutsourced_Radio.Checked = value; }
        }

        private void partInHouse_Radio_CheckedChanged(object sender, EventArgs e)
        {
            partMachineID_Label.Visible = true;
            partMachineID_TextBox.Visible = true;

            partCompanyName_Label.Visible = false;
            partCompanyName_TextBox.Visible = false;
        }

        private void partOutsourced_Radio_CheckedChanged(object sender, EventArgs e)
        {
            partMachineID_Label.Visible = false;
            partMachineID_TextBox.Visible = false;

            partCompanyName_Label.Visible = true;
            partCompanyName_TextBox.Visible = true;
        }

        public event EventHandler SaveClicked;

        private void partSave_Button_Click(object sender, EventArgs e)
        {
            if (!Inventory.ValidateNumericValues(PartName, PartPrice, InStock, PartMax, PartMin)) 
            { 
                return; 
            }

            if (OutsourcedIsChecked == true)
            {
                if (!Inventory.ValidateCompanyName(PartCompanyName)) { return; }
            }
            else if (InHouseIsChecked == true) 
            {
                if (!Inventory.ValidateMachineID(PartMachineID)) { return; }
            }
            
            Inventory.updatePart(Inventory.partsIndex, this);

            SaveClicked(this, e);

            this.Close();
        }

        private void partCancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Helper Methods

        private void SetUpForm() 
        {
            Inventory.outsource = null;
            Inventory.inhouse = null;

            if (Inventory.partsIndex is Outsourced)
            {
                Inventory.outsource = (Outsourced)Inventory.partsIndex;
                OutsourcedIsChecked = true;

                PartID = Inventory.outsource.PartID.ToString();
                PartName = Inventory.outsource.Name;
                PartPrice = Inventory.outsource.Price.ToString();
                InStock = Inventory.outsource.InStock.ToString();
                PartMin = Inventory.outsource.Min.ToString();
                PartMax = Inventory.outsource.Max.ToString();
                PartCompanyName = Inventory.outsource.CompanyName;
                
            }
            else if (Inventory.partsIndex is Inhouse) 
            {
                Inventory.inhouse = (Inhouse)Inventory.partsIndex;
                InHouseIsChecked = true;

                PartID = Inventory.inhouse.PartID.ToString();
                PartName = Inventory.inhouse.Name;
                PartPrice = Inventory.inhouse.Price.ToString();
                InStock = Inventory.inhouse.InStock.ToString();
                PartMin = Inventory.inhouse.Min.ToString();
                PartMax = Inventory.inhouse.Max.ToString();
                PartMachineID = Inventory.inhouse.MachineID.ToString();
            }
        }
    }
}
