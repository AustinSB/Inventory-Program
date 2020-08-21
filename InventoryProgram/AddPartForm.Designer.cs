﻿namespace InventoryProgram
{
    partial class AddPart_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.addPart_Label = new System.Windows.Forms.Label();
			this.partInHouse_Radio = new System.Windows.Forms.RadioButton();
			this.partOutsourced_Radio = new System.Windows.Forms.RadioButton();
			this.partID_Label = new System.Windows.Forms.Label();
			this.partName_Label = new System.Windows.Forms.Label();
			this.partInventory_Label = new System.Windows.Forms.Label();
			this.partPrice_Label = new System.Windows.Forms.Label();
			this.partMax_Label = new System.Windows.Forms.Label();
			this.partMin_Label = new System.Windows.Forms.Label();
			this.partMachineID_Label = new System.Windows.Forms.Label();
			this.partID_TextBox = new System.Windows.Forms.TextBox();
			this.partName_TextBox = new System.Windows.Forms.TextBox();
			this.partInventory_TextBox = new System.Windows.Forms.TextBox();
			this.partPrice_TextBox = new System.Windows.Forms.TextBox();
			this.partMax_TextBox = new System.Windows.Forms.TextBox();
			this.partMin_TextBox = new System.Windows.Forms.TextBox();
			this.partMachineID_TextBox = new System.Windows.Forms.TextBox();
			this.partCancel_Button = new System.Windows.Forms.Button();
			this.partSave_Button = new System.Windows.Forms.Button();
			this.partCompanyName_Label = new System.Windows.Forms.Label();
			this.partCompanyName_TextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// addPart_Label
			// 
			this.addPart_Label.AutoSize = true;
			this.addPart_Label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addPart_Label.Location = new System.Drawing.Point(15, 15);
			this.addPart_Label.Name = "addPart_Label";
			this.addPart_Label.Size = new System.Drawing.Size(105, 32);
			this.addPart_Label.TabIndex = 0;
			this.addPart_Label.Text = "Add Part";
			// 
			// partInHouse_Radio
			// 
			this.partInHouse_Radio.AutoSize = true;
			this.partInHouse_Radio.Checked = true;
			this.partInHouse_Radio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partInHouse_Radio.Location = new System.Drawing.Point(200, 15);
			this.partInHouse_Radio.Name = "partInHouse_Radio";
			this.partInHouse_Radio.Size = new System.Drawing.Size(101, 27);
			this.partInHouse_Radio.TabIndex = 1;
			this.partInHouse_Radio.TabStop = true;
			this.partInHouse_Radio.Text = "In-House";
			this.partInHouse_Radio.UseVisualStyleBackColor = true;
			this.partInHouse_Radio.CheckedChanged += new System.EventHandler(this.partInHouse_Radio_CheckedChanged);
			// 
			// partOutsourced_Radio
			// 
			this.partOutsourced_Radio.AutoSize = true;
			this.partOutsourced_Radio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partOutsourced_Radio.Location = new System.Drawing.Point(325, 15);
			this.partOutsourced_Radio.Name = "partOutsourced_Radio";
			this.partOutsourced_Radio.Size = new System.Drawing.Size(120, 27);
			this.partOutsourced_Radio.TabIndex = 2;
			this.partOutsourced_Radio.Text = "Outsourced";
			this.partOutsourced_Radio.UseVisualStyleBackColor = true;
			this.partOutsourced_Radio.CheckedChanged += new System.EventHandler(this.partOutsourced_Radio_CheckedChanged);
			// 
			// partID_Label
			// 
			this.partID_Label.AutoSize = true;
			this.partID_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partID_Label.Location = new System.Drawing.Point(25, 100);
			this.partID_Label.Name = "partID_Label";
			this.partID_Label.Size = new System.Drawing.Size(27, 23);
			this.partID_Label.TabIndex = 3;
			this.partID_Label.Text = "ID";
			// 
			// partName_Label
			// 
			this.partName_Label.AutoSize = true;
			this.partName_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partName_Label.Location = new System.Drawing.Point(25, 150);
			this.partName_Label.Name = "partName_Label";
			this.partName_Label.Size = new System.Drawing.Size(56, 23);
			this.partName_Label.TabIndex = 4;
			this.partName_Label.Text = "Name";
			// 
			// partInventory_Label
			// 
			this.partInventory_Label.AutoSize = true;
			this.partInventory_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partInventory_Label.Location = new System.Drawing.Point(25, 250);
			this.partInventory_Label.Name = "partInventory_Label";
			this.partInventory_Label.Size = new System.Drawing.Size(82, 23);
			this.partInventory_Label.TabIndex = 5;
			this.partInventory_Label.Text = "Inventory";
			// 
			// partPrice_Label
			// 
			this.partPrice_Label.AutoSize = true;
			this.partPrice_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partPrice_Label.Location = new System.Drawing.Point(25, 200);
			this.partPrice_Label.Name = "partPrice_Label";
			this.partPrice_Label.Size = new System.Drawing.Size(98, 23);
			this.partPrice_Label.TabIndex = 6;
			this.partPrice_Label.Text = "Price / Cost";
			// 
			// partMax_Label
			// 
			this.partMax_Label.AutoSize = true;
			this.partMax_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partMax_Label.Location = new System.Drawing.Point(25, 300);
			this.partMax_Label.Name = "partMax_Label";
			this.partMax_Label.Size = new System.Drawing.Size(42, 23);
			this.partMax_Label.TabIndex = 7;
			this.partMax_Label.Text = "Max";
			// 
			// partMin_Label
			// 
			this.partMin_Label.AutoSize = true;
			this.partMin_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partMin_Label.Location = new System.Drawing.Point(25, 350);
			this.partMin_Label.Name = "partMin_Label";
			this.partMin_Label.Size = new System.Drawing.Size(39, 23);
			this.partMin_Label.TabIndex = 8;
			this.partMin_Label.Text = "Min";
			// 
			// partMachineID_Label
			// 
			this.partMachineID_Label.AutoSize = true;
			this.partMachineID_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partMachineID_Label.Location = new System.Drawing.Point(25, 400);
			this.partMachineID_Label.Name = "partMachineID_Label";
			this.partMachineID_Label.Size = new System.Drawing.Size(97, 23);
			this.partMachineID_Label.TabIndex = 9;
			this.partMachineID_Label.Text = "Machine ID";
			// 
			// partID_TextBox
			// 
			this.partID_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partID_TextBox.Location = new System.Drawing.Point(125, 100);
			this.partID_TextBox.Name = "partID_TextBox";
			this.partID_TextBox.ReadOnly = true;
			this.partID_TextBox.Size = new System.Drawing.Size(100, 30);
			this.partID_TextBox.TabIndex = 10;
			// 
			// partName_TextBox
			// 
			this.partName_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partName_TextBox.Location = new System.Drawing.Point(125, 150);
			this.partName_TextBox.Name = "partName_TextBox";
			this.partName_TextBox.Size = new System.Drawing.Size(100, 30);
			this.partName_TextBox.TabIndex = 11;
			// 
			// partInventory_TextBox
			// 
			this.partInventory_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partInventory_TextBox.Location = new System.Drawing.Point(125, 250);
			this.partInventory_TextBox.Name = "partInventory_TextBox";
			this.partInventory_TextBox.Size = new System.Drawing.Size(100, 30);
			this.partInventory_TextBox.TabIndex = 12;
			// 
			// partPrice_TextBox
			// 
			this.partPrice_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partPrice_TextBox.Location = new System.Drawing.Point(125, 200);
			this.partPrice_TextBox.Name = "partPrice_TextBox";
			this.partPrice_TextBox.Size = new System.Drawing.Size(100, 30);
			this.partPrice_TextBox.TabIndex = 13;
			// 
			// partMax_TextBox
			// 
			this.partMax_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partMax_TextBox.Location = new System.Drawing.Point(125, 300);
			this.partMax_TextBox.Name = "partMax_TextBox";
			this.partMax_TextBox.Size = new System.Drawing.Size(50, 30);
			this.partMax_TextBox.TabIndex = 14;
			// 
			// partMin_TextBox
			// 
			this.partMin_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partMin_TextBox.Location = new System.Drawing.Point(125, 350);
			this.partMin_TextBox.Name = "partMin_TextBox";
			this.partMin_TextBox.Size = new System.Drawing.Size(50, 30);
			this.partMin_TextBox.TabIndex = 15;
			// 
			// partMachineID_TextBox
			// 
			this.partMachineID_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partMachineID_TextBox.Location = new System.Drawing.Point(125, 400);
			this.partMachineID_TextBox.Name = "partMachineID_TextBox";
			this.partMachineID_TextBox.Size = new System.Drawing.Size(100, 30);
			this.partMachineID_TextBox.TabIndex = 16;
			// 
			// partCancel_Button
			// 
			this.partCancel_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.partCancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.partCancel_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partCancel_Button.Location = new System.Drawing.Point(300, 400);
			this.partCancel_Button.Name = "partCancel_Button";
			this.partCancel_Button.Size = new System.Drawing.Size(65, 40);
			this.partCancel_Button.TabIndex = 17;
			this.partCancel_Button.Text = "Cancel";
			this.partCancel_Button.UseVisualStyleBackColor = false;
			this.partCancel_Button.Click += new System.EventHandler(this.partCancel_Button_Click);
			// 
			// partSave_Button
			// 
			this.partSave_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.partSave_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.partSave_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partSave_Button.Location = new System.Drawing.Point(400, 400);
			this.partSave_Button.Name = "partSave_Button";
			this.partSave_Button.Size = new System.Drawing.Size(65, 40);
			this.partSave_Button.TabIndex = 18;
			this.partSave_Button.Text = "Save";
			this.partSave_Button.UseVisualStyleBackColor = false;
			this.partSave_Button.Click += new System.EventHandler(this.partSave_Button_Click);
			// 
			// partCompanyName_Label
			// 
			this.partCompanyName_Label.AutoSize = true;
			this.partCompanyName_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partCompanyName_Label.Location = new System.Drawing.Point(354, 168);
			this.partCompanyName_Label.Name = "partCompanyName_Label";
			this.partCompanyName_Label.Size = new System.Drawing.Size(83, 23);
			this.partCompanyName_Label.TabIndex = 19;
			this.partCompanyName_Label.Text = "Company";
			this.partCompanyName_Label.Visible = false;
			// 
			// partCompanyName_TextBox
			// 
			this.partCompanyName_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partCompanyName_TextBox.Location = new System.Drawing.Point(357, 201);
			this.partCompanyName_TextBox.Name = "partCompanyName_TextBox";
			this.partCompanyName_TextBox.Size = new System.Drawing.Size(100, 30);
			this.partCompanyName_TextBox.TabIndex = 20;
			this.partCompanyName_TextBox.Visible = false;
			// 
			// AddPart_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(488, 450);
			this.Controls.Add(this.partCompanyName_TextBox);
			this.Controls.Add(this.partCompanyName_Label);
			this.Controls.Add(this.partSave_Button);
			this.Controls.Add(this.partCancel_Button);
			this.Controls.Add(this.partMachineID_TextBox);
			this.Controls.Add(this.partMin_TextBox);
			this.Controls.Add(this.partMax_TextBox);
			this.Controls.Add(this.partPrice_TextBox);
			this.Controls.Add(this.partInventory_TextBox);
			this.Controls.Add(this.partName_TextBox);
			this.Controls.Add(this.partID_TextBox);
			this.Controls.Add(this.partMachineID_Label);
			this.Controls.Add(this.partMin_Label);
			this.Controls.Add(this.partMax_Label);
			this.Controls.Add(this.partPrice_Label);
			this.Controls.Add(this.partInventory_Label);
			this.Controls.Add(this.partName_Label);
			this.Controls.Add(this.partID_Label);
			this.Controls.Add(this.partOutsourced_Radio);
			this.Controls.Add(this.partInHouse_Radio);
			this.Controls.Add(this.addPart_Label);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "AddPart_Form";
			this.Text = "Part";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPart_Label;
        private System.Windows.Forms.RadioButton partInHouse_Radio;
        private System.Windows.Forms.RadioButton partOutsourced_Radio;
        private System.Windows.Forms.Label partID_Label;
        private System.Windows.Forms.Label partName_Label;
        private System.Windows.Forms.Label partInventory_Label;
        private System.Windows.Forms.Label partPrice_Label;
        private System.Windows.Forms.Label partMax_Label;
        private System.Windows.Forms.Label partMin_Label;
        private System.Windows.Forms.Label partMachineID_Label;
        private System.Windows.Forms.TextBox partID_TextBox;
        private System.Windows.Forms.TextBox partName_TextBox;
        private System.Windows.Forms.TextBox partInventory_TextBox;
        private System.Windows.Forms.TextBox partPrice_TextBox;
        private System.Windows.Forms.TextBox partMax_TextBox;
        private System.Windows.Forms.TextBox partMin_TextBox;
        private System.Windows.Forms.TextBox partMachineID_TextBox;
        private System.Windows.Forms.Button partCancel_Button;
        private System.Windows.Forms.Button partSave_Button;
        private System.Windows.Forms.Label partCompanyName_Label;
        private System.Windows.Forms.TextBox partCompanyName_TextBox;
    }
}