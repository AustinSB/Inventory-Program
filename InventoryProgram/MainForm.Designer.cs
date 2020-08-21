namespace InventoryProgram
{
    partial class mainScreen_Form
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
			this.mainScreen_Label = new System.Windows.Forms.Label();
			this.parts_Label = new System.Windows.Forms.Label();
			this.products_Label = new System.Windows.Forms.Label();
			this.partSearch_Button = new System.Windows.Forms.Button();
			this.productSearch_Button = new System.Windows.Forms.Button();
			this.partSearch_TextBox = new System.Windows.Forms.TextBox();
			this.productSearch_TextBox = new System.Windows.Forms.TextBox();
			this.partsAdd_Button = new System.Windows.Forms.Button();
			this.partsModify_Button = new System.Windows.Forms.Button();
			this.partsDelete_Button = new System.Windows.Forms.Button();
			this.productsAdd_Button = new System.Windows.Forms.Button();
			this.productsModify_Button = new System.Windows.Forms.Button();
			this.productsDelete_Button = new System.Windows.Forms.Button();
			this.mainScreenExit_Button = new System.Windows.Forms.Button();
			this.parts_DataGrid = new System.Windows.Forms.DataGridView();
			this.product_DataGrid = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.parts_DataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.product_DataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// mainScreen_Label
			// 
			this.mainScreen_Label.AutoSize = true;
			this.mainScreen_Label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainScreen_Label.Location = new System.Drawing.Point(12, 9);
			this.mainScreen_Label.Name = "mainScreen_Label";
			this.mainScreen_Label.Size = new System.Drawing.Size(349, 32);
			this.mainScreen_Label.TabIndex = 0;
			this.mainScreen_Label.Text = "Inventory Management System";
			// 
			// parts_Label
			// 
			this.parts_Label.AutoSize = true;
			this.parts_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.parts_Label.Location = new System.Drawing.Point(7, 102);
			this.parts_Label.Name = "parts_Label";
			this.parts_Label.Size = new System.Drawing.Size(54, 28);
			this.parts_Label.TabIndex = 1;
			this.parts_Label.Text = "Parts";
			// 
			// products_Label
			// 
			this.products_Label.AutoSize = true;
			this.products_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.products_Label.Location = new System.Drawing.Point(550, 102);
			this.products_Label.Name = "products_Label";
			this.products_Label.Size = new System.Drawing.Size(89, 28);
			this.products_Label.TabIndex = 2;
			this.products_Label.Text = "Products";
			// 
			// partSearch_Button
			// 
			this.partSearch_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.partSearch_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.partSearch_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partSearch_Button.Location = new System.Drawing.Point(299, 97);
			this.partSearch_Button.Name = "partSearch_Button";
			this.partSearch_Button.Size = new System.Drawing.Size(72, 30);
			this.partSearch_Button.TabIndex = 3;
			this.partSearch_Button.Text = "Search";
			this.partSearch_Button.UseVisualStyleBackColor = false;
			this.partSearch_Button.Click += new System.EventHandler(this.partSearch_Button_Click);
			// 
			// productSearch_Button
			// 
			this.productSearch_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.productSearch_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.productSearch_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productSearch_Button.Location = new System.Drawing.Point(839, 97);
			this.productSearch_Button.Name = "productSearch_Button";
			this.productSearch_Button.Size = new System.Drawing.Size(75, 30);
			this.productSearch_Button.TabIndex = 4;
			this.productSearch_Button.Text = "Search";
			this.productSearch_Button.UseVisualStyleBackColor = false;
			this.productSearch_Button.Click += new System.EventHandler(this.productSearch_Button_Click);
			// 
			// partSearch_TextBox
			// 
			this.partSearch_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partSearch_TextBox.Location = new System.Drawing.Point(377, 97);
			this.partSearch_TextBox.Name = "partSearch_TextBox";
			this.partSearch_TextBox.Size = new System.Drawing.Size(150, 30);
			this.partSearch_TextBox.TabIndex = 5;
			// 
			// productSearch_TextBox
			// 
			this.productSearch_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productSearch_TextBox.Location = new System.Drawing.Point(920, 97);
			this.productSearch_TextBox.Name = "productSearch_TextBox";
			this.productSearch_TextBox.Size = new System.Drawing.Size(150, 30);
			this.productSearch_TextBox.TabIndex = 6;
			// 
			// partsAdd_Button
			// 
			this.partsAdd_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.partsAdd_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.partsAdd_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partsAdd_Button.Location = new System.Drawing.Point(12, 400);
			this.partsAdd_Button.Name = "partsAdd_Button";
			this.partsAdd_Button.Size = new System.Drawing.Size(65, 40);
			this.partsAdd_Button.TabIndex = 9;
			this.partsAdd_Button.Text = "Add";
			this.partsAdd_Button.UseVisualStyleBackColor = false;
			this.partsAdd_Button.Click += new System.EventHandler(this.partsAdd_Button_Click);
			// 
			// partsModify_Button
			// 
			this.partsModify_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.partsModify_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.partsModify_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partsModify_Button.Location = new System.Drawing.Point(83, 400);
			this.partsModify_Button.Name = "partsModify_Button";
			this.partsModify_Button.Size = new System.Drawing.Size(72, 40);
			this.partsModify_Button.TabIndex = 10;
			this.partsModify_Button.Text = "Modify";
			this.partsModify_Button.UseVisualStyleBackColor = false;
			this.partsModify_Button.Click += new System.EventHandler(this.partsModify_Button_Click);
			// 
			// partsDelete_Button
			// 
			this.partsDelete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.partsDelete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.partsDelete_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.partsDelete_Button.Location = new System.Drawing.Point(161, 400);
			this.partsDelete_Button.Name = "partsDelete_Button";
			this.partsDelete_Button.Size = new System.Drawing.Size(72, 40);
			this.partsDelete_Button.TabIndex = 11;
			this.partsDelete_Button.Text = "Delete";
			this.partsDelete_Button.UseVisualStyleBackColor = false;
			this.partsDelete_Button.Click += new System.EventHandler(this.partsDelete_Button_Click);
			// 
			// productsAdd_Button
			// 
			this.productsAdd_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.productsAdd_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.productsAdd_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productsAdd_Button.Location = new System.Drawing.Point(555, 400);
			this.productsAdd_Button.Name = "productsAdd_Button";
			this.productsAdd_Button.Size = new System.Drawing.Size(65, 40);
			this.productsAdd_Button.TabIndex = 12;
			this.productsAdd_Button.Text = "Add";
			this.productsAdd_Button.UseVisualStyleBackColor = false;
			this.productsAdd_Button.Click += new System.EventHandler(this.productsAdd_Button_Click);
			// 
			// productsModify_Button
			// 
			this.productsModify_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.productsModify_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.productsModify_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productsModify_Button.Location = new System.Drawing.Point(626, 400);
			this.productsModify_Button.Name = "productsModify_Button";
			this.productsModify_Button.Size = new System.Drawing.Size(78, 40);
			this.productsModify_Button.TabIndex = 13;
			this.productsModify_Button.Text = "Modify";
			this.productsModify_Button.UseVisualStyleBackColor = false;
			this.productsModify_Button.Click += new System.EventHandler(this.productsModify_Button_Click);
			// 
			// productsDelete_Button
			// 
			this.productsDelete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.productsDelete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.productsDelete_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productsDelete_Button.Location = new System.Drawing.Point(710, 400);
			this.productsDelete_Button.Name = "productsDelete_Button";
			this.productsDelete_Button.Size = new System.Drawing.Size(74, 40);
			this.productsDelete_Button.TabIndex = 14;
			this.productsDelete_Button.Text = "Delete";
			this.productsDelete_Button.UseVisualStyleBackColor = false;
			this.productsDelete_Button.Click += new System.EventHandler(this.productsDelete_Button_Click);
			// 
			// mainScreenExit_Button
			// 
			this.mainScreenExit_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.mainScreenExit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mainScreenExit_Button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainScreenExit_Button.Location = new System.Drawing.Point(1005, 398);
			this.mainScreenExit_Button.Name = "mainScreenExit_Button";
			this.mainScreenExit_Button.Size = new System.Drawing.Size(65, 40);
			this.mainScreenExit_Button.TabIndex = 15;
			this.mainScreenExit_Button.Text = "Exit";
			this.mainScreenExit_Button.UseVisualStyleBackColor = false;
			this.mainScreenExit_Button.Click += new System.EventHandler(this.mainScreenExit_Button_Click);
			// 
			// parts_DataGrid
			// 
			this.parts_DataGrid.AllowUserToAddRows = false;
			this.parts_DataGrid.AllowUserToDeleteRows = false;
			this.parts_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.parts_DataGrid.Cursor = System.Windows.Forms.Cursors.Default;
			this.parts_DataGrid.Location = new System.Drawing.Point(12, 133);
			this.parts_DataGrid.MultiSelect = false;
			this.parts_DataGrid.Name = "parts_DataGrid";
			this.parts_DataGrid.ReadOnly = true;
			this.parts_DataGrid.RowHeadersVisible = false;
			this.parts_DataGrid.RowHeadersWidth = 51;
			this.parts_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.parts_DataGrid.Size = new System.Drawing.Size(515, 260);
			this.parts_DataGrid.TabIndex = 16;
			this.parts_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.parts_DataGrid_CellClick);
			// 
			// product_DataGrid
			// 
			this.product_DataGrid.AllowUserToAddRows = false;
			this.product_DataGrid.AllowUserToDeleteRows = false;
			this.product_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.product_DataGrid.Location = new System.Drawing.Point(555, 133);
			this.product_DataGrid.MultiSelect = false;
			this.product_DataGrid.Name = "product_DataGrid";
			this.product_DataGrid.ReadOnly = true;
			this.product_DataGrid.RowHeadersVisible = false;
			this.product_DataGrid.RowHeadersWidth = 51;
			this.product_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.product_DataGrid.Size = new System.Drawing.Size(515, 260);
			this.product_DataGrid.TabIndex = 17;
			this.product_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_DataGrid_CellClick);
			// 
			// mainScreen_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(1084, 461);
			this.Controls.Add(this.product_DataGrid);
			this.Controls.Add(this.parts_DataGrid);
			this.Controls.Add(this.mainScreenExit_Button);
			this.Controls.Add(this.productsDelete_Button);
			this.Controls.Add(this.productsModify_Button);
			this.Controls.Add(this.productsAdd_Button);
			this.Controls.Add(this.partsDelete_Button);
			this.Controls.Add(this.partsModify_Button);
			this.Controls.Add(this.partsAdd_Button);
			this.Controls.Add(this.productSearch_TextBox);
			this.Controls.Add(this.partSearch_TextBox);
			this.Controls.Add(this.productSearch_Button);
			this.Controls.Add(this.partSearch_Button);
			this.Controls.Add(this.products_Label);
			this.Controls.Add(this.parts_Label);
			this.Controls.Add(this.mainScreen_Label);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "mainScreen_Form";
			this.Text = "Main Screen";
			this.Load += new System.EventHandler(this.mainScreen_Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.parts_DataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.product_DataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainScreen_Label;
        private System.Windows.Forms.Label parts_Label;
        private System.Windows.Forms.Label products_Label;
        private System.Windows.Forms.Button partSearch_Button;
        private System.Windows.Forms.Button productSearch_Button;
        private System.Windows.Forms.TextBox partSearch_TextBox;
        private System.Windows.Forms.TextBox productSearch_TextBox;
        private System.Windows.Forms.Button partsAdd_Button;
        private System.Windows.Forms.Button partsModify_Button;
        private System.Windows.Forms.Button partsDelete_Button;
        private System.Windows.Forms.Button productsAdd_Button;
        private System.Windows.Forms.Button productsModify_Button;
        private System.Windows.Forms.Button productsDelete_Button;
        private System.Windows.Forms.Button mainScreenExit_Button;
        private System.Windows.Forms.DataGridView parts_DataGrid;
        private System.Windows.Forms.DataGridView product_DataGrid;
    }
}

