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
    public partial class AddPart_Form : Form
    {
        public AddPart_Form()
        {
            InitializeComponent();

            partCompanyName_Label.Location = new Point(25, 400);
            partCompanyName_TextBox.Location = new Point(125, 400);
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

        private void partSave_Button_Click(object sender, EventArgs e)
        {
            if (!Inventory.ValidateNumericValues(partName_TextBox.Text, partPrice_TextBox.Text, partInventory_TextBox.Text,
                                                 partMax_TextBox.Text, partMin_TextBox.Text)) { return; }

            if (partInHouse_Radio.Checked)
            {
                if (!Inventory.ValidateMachineID(partMachineID_TextBox.Text)) { return; }

                Inventory.addPart(new Inhouse(partName_TextBox.Text,
                                       Convert.ToDecimal(partPrice_TextBox.Text),
                                       Convert.ToInt32(partInventory_TextBox.Text),
                                       Convert.ToInt32(partMin_TextBox.Text),
                                       Convert.ToInt32(partMax_TextBox.Text),
                                       Convert.ToInt32(partMachineID_TextBox.Text)));
                this.Close();
            }
            else if (partOutsourced_Radio.Checked)
            {
                if (!Inventory.ValidateCompanyName(partCompanyName_TextBox.Text)) { return; }

                Inventory.addPart(new Outsourced(partName_TextBox.Text,
                                       Convert.ToDecimal(partPrice_TextBox.Text),
                                       Convert.ToInt32(partInventory_TextBox.Text),
                                       Convert.ToInt32(partMin_TextBox.Text),
                                       Convert.ToInt32(partMax_TextBox.Text),
                                       partCompanyName_TextBox.Text));
                this.Close();
            }
        }

        private void partCancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
