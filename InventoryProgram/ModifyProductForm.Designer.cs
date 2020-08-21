﻿namespace InventoryProgram
{
    partial class ModifyProduct_Form
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
			this.productCancel_Button = new System.Windows.Forms.Button();
			this.productSave_Button = new System.Windows.Forms.Button();
			this.productMax_TextBox = new System.Windows.Forms.TextBox();
			this.productMin_TextBox = new System.Windows.Forms.TextBox();
			this.productPrice_TextBox = new System.Windows.Forms.TextBox();
			this.productInventory_TextBox = new System.Windows.Forms.TextBox();
			this.productName_TextBox = new System.Windows.Forms.TextBox();
			this.productID_TextBox = new System.Windows.Forms.TextBox();
			this.productMin_Label = new System.Windows.Forms.Label();
			this.productMax_Label = new System.Windows.Forms.Label();
			this.productPrice_Label = new System.Windows.Forms.Label();
			this.productInventory_Label = new System.Windows.Forms.Label();
			this.productName_Label = new System.Windows.Forms.Label();
			this.productID_Label = new System.Windows.Forms.Label();
			this.productPartDelete_Button = new System.Windows.Forms.Button();
			this.productPartAdd_Button = new System.Windows.Forms.Button();
			this.associate_Label = new System.Windows.Forms.Label();
			this.all_Label = new System.Windows.Forms.Label();
			this.allSearch_TextBox = new System.Windows.Forms.TextBox();
			this.allSearch_Button = new System.Windows.Forms.Button();
			this.modifyProduct_Label = new System.Windows.Forms.Label();
			this.all_DataGrid = new System.Windows.Forms.DataGridView();
			this.associate_DataGrid = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.all_DataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.associate_DataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// productCancel_Button
			// 
			this.productCancel_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.productCancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.productCancel_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productCancel_Button.Location = new System.Drawing.Point(720, 472);
			this.productCancel_Button.Name = "productCancel_Button";
			this.productCancel_Button.Size = new System.Drawing.Size(77, 40);
			this.productCancel_Button.TabIndex = 45;
			this.productCancel_Button.Text = "Cancel";
			this.productCancel_Button.UseVisualStyleBackColor = false;
			this.productCancel_Button.Click += new System.EventHandler(this.productCancel_Button_Click);
			// 
			// productSave_Button
			// 
			this.productSave_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.productSave_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.productSave_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productSave_Button.Location = new System.Drawing.Point(805, 472);
			this.productSave_Button.Name = "productSave_Button";
			this.productSave_Button.Size = new System.Drawing.Size(65, 40);
			this.productSave_Button.TabIndex = 44;
			this.productSave_Button.Text = "Save";
			this.productSave_Button.UseVisualStyleBackColor = false;
			this.productSave_Button.Click += new System.EventHandler(this.productSave_Button_Click);
			// 
			// productMax_TextBox
			// 
			this.productMax_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productMax_TextBox.Location = new System.Drawing.Point(125, 300);
			this.productMax_TextBox.Name = "productMax_TextBox";
			this.productMax_TextBox.Size = new System.Drawing.Size(50, 30);
			this.productMax_TextBox.TabIndex = 43;
			// 
			// productMin_TextBox
			// 
			this.productMin_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productMin_TextBox.Location = new System.Drawing.Point(125, 350);
			this.productMin_TextBox.Name = "productMin_TextBox";
			this.productMin_TextBox.Size = new System.Drawing.Size(50, 30);
			this.productMin_TextBox.TabIndex = 42;
			// 
			// productPrice_TextBox
			// 
			this.productPrice_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productPrice_TextBox.Location = new System.Drawing.Point(125, 200);
			this.productPrice_TextBox.Name = "productPrice_TextBox";
			this.productPrice_TextBox.Size = new System.Drawing.Size(100, 30);
			this.productPrice_TextBox.TabIndex = 41;
			// 
			// productInventory_TextBox
			// 
			this.productInventory_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productInventory_TextBox.Location = new System.Drawing.Point(125, 250);
			this.productInventory_TextBox.Name = "productInventory_TextBox";
			this.productInventory_TextBox.Size = new System.Drawing.Size(100, 30);
			this.productInventory_TextBox.TabIndex = 40;
			// 
			// productName_TextBox
			// 
			this.productName_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productName_TextBox.Location = new System.Drawing.Point(125, 150);
			this.productName_TextBox.Name = "productName_TextBox";
			this.productName_TextBox.Size = new System.Drawing.Size(100, 30);
			this.productName_TextBox.TabIndex = 39;
			// 
			// productID_TextBox
			// 
			this.productID_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productID_TextBox.Location = new System.Drawing.Point(125, 100);
			this.productID_TextBox.Name = "productID_TextBox";
			this.productID_TextBox.ReadOnly = true;
			this.productID_TextBox.Size = new System.Drawing.Size(100, 30);
			this.productID_TextBox.TabIndex = 38;
			// 
			// productMin_Label
			// 
			this.productMin_Label.AutoSize = true;
			this.productMin_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productMin_Label.Location = new System.Drawing.Point(25, 350);
			this.productMin_Label.Name = "productMin_Label";
			this.productMin_Label.Size = new System.Drawing.Size(39, 23);
			this.productMin_Label.TabIndex = 37;
			this.productMin_Label.Text = "Min";
			// 
			// productMax_Label
			// 
			this.productMax_Label.AutoSize = true;
			this.productMax_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productMax_Label.Location = new System.Drawing.Point(25, 300);
			this.productMax_Label.Name = "productMax_Label";
			this.productMax_Label.Size = new System.Drawing.Size(42, 23);
			this.productMax_Label.TabIndex = 36;
			this.productMax_Label.Text = "Max";
			// 
			// productPrice_Label
			// 
			this.productPrice_Label.AutoSize = true;
			this.productPrice_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productPrice_Label.Location = new System.Drawing.Point(25, 200);
			this.productPrice_Label.Name = "productPrice_Label";
			this.productPrice_Label.Size = new System.Drawing.Size(98, 23);
			this.productPrice_Label.TabIndex = 35;
			this.productPrice_Label.Text = "Price / Cost";
			// 
			// productInventory_Label
			// 
			this.productInventory_Label.AutoSize = true;
			this.productInventory_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productInventory_Label.Location = new System.Drawing.Point(25, 250);
			this.productInventory_Label.Name = "productInventory_Label";
			this.productInventory_Label.Size = new System.Drawing.Size(82, 23);
			this.productInventory_Label.TabIndex = 34;
			this.productInventory_Label.Text = "Inventory";
			// 
			// productName_Label
			// 
			this.productName_Label.AutoSize = true;
			this.productName_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productName_Label.Location = new System.Drawing.Point(25, 150);
			this.productName_Label.Name = "productName_Label";
			this.productName_Label.Size = new System.Drawing.Size(56, 23);
			this.productName_Label.TabIndex = 33;
			this.productName_Label.Text = "Name";
			// 
			// productID_Label
			// 
			this.productID_Label.AutoSize = true;
			this.productID_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productID_Label.Location = new System.Drawing.Point(25, 100);
			this.productID_Label.Name = "productID_Label";
			this.productID_Label.Size = new System.Drawing.Size(27, 23);
			this.productID_Label.TabIndex = 32;
			this.productID_Label.Text = "ID";
			// 
			// productPartDelete_Button
			// 
			this.productPartDelete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.productPartDelete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.productPartDelete_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productPartDelete_Button.Location = new System.Drawing.Point(282, 471);
			this.productPartDelete_Button.Name = "productPartDelete_Button";
			this.productPartDelete_Button.Size = new System.Drawing.Size(74, 40);
			this.productPartDelete_Button.TabIndex = 31;
			this.productPartDelete_Button.Text = "Delete";
			this.productPartDelete_Button.UseVisualStyleBackColor = false;
			this.productPartDelete_Button.Click += new System.EventHandler(this.productPartDelete_Button_Click);
			// 
			// productPartAdd_Button
			// 
			this.productPartAdd_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.productPartAdd_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.productPartAdd_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productPartAdd_Button.Location = new System.Drawing.Point(282, 233);
			this.productPartAdd_Button.Name = "productPartAdd_Button";
			this.productPartAdd_Button.Size = new System.Drawing.Size(65, 40);
			this.productPartAdd_Button.TabIndex = 30;
			this.productPartAdd_Button.Text = "Add";
			this.productPartAdd_Button.UseVisualStyleBackColor = false;
			this.productPartAdd_Button.Click += new System.EventHandler(this.productPartAdd_Button_Click);
			// 
			// associate_Label
			// 
			this.associate_Label.AutoSize = true;
			this.associate_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.associate_Label.Location = new System.Drawing.Point(278, 293);
			this.associate_Label.Name = "associate_Label";
			this.associate_Label.Size = new System.Drawing.Size(267, 23);
			this.associate_Label.TabIndex = 27;
			this.associate_Label.Text = "Parts Associated with this Product";
			// 
			// all_Label
			// 
			this.all_Label.AutoSize = true;
			this.all_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.all_Label.Location = new System.Drawing.Point(278, 55);
			this.all_Label.Name = "all_Label";
			this.all_Label.Size = new System.Drawing.Size(151, 23);
			this.all_Label.TabIndex = 26;
			this.all_Label.Text = "All candidate Parts";
			// 
			// allSearch_TextBox
			// 
			this.allSearch_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.allSearch_TextBox.Location = new System.Drawing.Point(720, 278);
			this.allSearch_TextBox.Name = "allSearch_TextBox";
			this.allSearch_TextBox.Size = new System.Drawing.Size(150, 30);
			this.allSearch_TextBox.TabIndex = 25;
			// 
			// allSearch_Button
			// 
			this.allSearch_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.allSearch_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.allSearch_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.allSearch_Button.Location = new System.Drawing.Point(634, 277);
			this.allSearch_Button.Name = "allSearch_Button";
			this.allSearch_Button.Size = new System.Drawing.Size(80, 30);
			this.allSearch_Button.TabIndex = 24;
			this.allSearch_Button.Text = "Search";
			this.allSearch_Button.UseVisualStyleBackColor = false;
			this.allSearch_Button.Click += new System.EventHandler(this.allSearch_Button_Click);
			// 
			// modifyProduct_Label
			// 
			this.modifyProduct_Label.AutoSize = true;
			this.modifyProduct_Label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modifyProduct_Label.Location = new System.Drawing.Point(12, 18);
			this.modifyProduct_Label.Name = "modifyProduct_Label";
			this.modifyProduct_Label.Size = new System.Drawing.Size(180, 32);
			this.modifyProduct_Label.TabIndex = 23;
			this.modifyProduct_Label.Text = "Modify Product";
			// 
			// all_DataGrid
			// 
			this.all_DataGrid.AllowUserToAddRows = false;
			this.all_DataGrid.AllowUserToDeleteRows = false;
			this.all_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.all_DataGrid.Location = new System.Drawing.Point(282, 80);
			this.all_DataGrid.MultiSelect = false;
			this.all_DataGrid.Name = "all_DataGrid";
			this.all_DataGrid.ReadOnly = true;
			this.all_DataGrid.RowHeadersVisible = false;
			this.all_DataGrid.RowHeadersWidth = 51;
			this.all_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.all_DataGrid.Size = new System.Drawing.Size(588, 150);
			this.all_DataGrid.TabIndex = 46;
			this.all_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.all_DataGrid_CellClick);
			// 
			// associate_DataGrid
			// 
			this.associate_DataGrid.AllowUserToAddRows = false;
			this.associate_DataGrid.AllowUserToDeleteRows = false;
			this.associate_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.associate_DataGrid.Location = new System.Drawing.Point(282, 315);
			this.associate_DataGrid.MultiSelect = false;
			this.associate_DataGrid.Name = "associate_DataGrid";
			this.associate_DataGrid.ReadOnly = true;
			this.associate_DataGrid.RowHeadersVisible = false;
			this.associate_DataGrid.RowHeadersWidth = 51;
			this.associate_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.associate_DataGrid.Size = new System.Drawing.Size(588, 150);
			this.associate_DataGrid.TabIndex = 47;
			this.associate_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.associate_DataGrid_CellClick);
			// 
			// ModifyProduct_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(882, 528);
			this.Controls.Add(this.associate_DataGrid);
			this.Controls.Add(this.all_DataGrid);
			this.Controls.Add(this.productCancel_Button);
			this.Controls.Add(this.productSave_Button);
			this.Controls.Add(this.productMax_TextBox);
			this.Controls.Add(this.productMin_TextBox);
			this.Controls.Add(this.productPrice_TextBox);
			this.Controls.Add(this.productInventory_TextBox);
			this.Controls.Add(this.productName_TextBox);
			this.Controls.Add(this.productID_TextBox);
			this.Controls.Add(this.productMin_Label);
			this.Controls.Add(this.productMax_Label);
			this.Controls.Add(this.productPrice_Label);
			this.Controls.Add(this.productInventory_Label);
			this.Controls.Add(this.productName_Label);
			this.Controls.Add(this.productID_Label);
			this.Controls.Add(this.productPartDelete_Button);
			this.Controls.Add(this.productPartAdd_Button);
			this.Controls.Add(this.associate_Label);
			this.Controls.Add(this.all_Label);
			this.Controls.Add(this.allSearch_TextBox);
			this.Controls.Add(this.allSearch_Button);
			this.Controls.Add(this.modifyProduct_Label);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "ModifyProduct_Form";
			this.Text = "Product";
			this.Load += new System.EventHandler(this.ModifyProduct_Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.all_DataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.associate_DataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button productCancel_Button;
        private System.Windows.Forms.Button productSave_Button;
        private System.Windows.Forms.TextBox productMax_TextBox;
        private System.Windows.Forms.TextBox productMin_TextBox;
        private System.Windows.Forms.TextBox productPrice_TextBox;
        private System.Windows.Forms.TextBox productInventory_TextBox;
        private System.Windows.Forms.TextBox productName_TextBox;
        private System.Windows.Forms.TextBox productID_TextBox;
        private System.Windows.Forms.Label productMin_Label;
        private System.Windows.Forms.Label productMax_Label;
        private System.Windows.Forms.Label productPrice_Label;
        private System.Windows.Forms.Label productInventory_Label;
        private System.Windows.Forms.Label productName_Label;
        private System.Windows.Forms.Label productID_Label;
        private System.Windows.Forms.Button productPartDelete_Button;
        private System.Windows.Forms.Button productPartAdd_Button;
        private System.Windows.Forms.Label associate_Label;
        private System.Windows.Forms.Label all_Label;
        private System.Windows.Forms.TextBox allSearch_TextBox;
        private System.Windows.Forms.Button allSearch_Button;
        private System.Windows.Forms.Label modifyProduct_Label;
        private System.Windows.Forms.DataGridView all_DataGrid;
        private System.Windows.Forms.DataGridView associate_DataGrid;
    }
}