namespace BenBailey_InventorySystem
{
    partial class AddProductScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridAllParts = new System.Windows.Forms.DataGridView();
            this.dataGridAssocParts = new System.Windows.Forms.DataGridView();
            this.labelAddModify = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.Inventory = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.prodID = new System.Windows.Forms.TextBox();
            this.prodName = new System.Windows.Forms.TextBox();
            this.prodInventory = new System.Windows.Forms.TextBox();
            this.prodPrice = new System.Windows.Forms.TextBox();
            this.prodMax = new System.Windows.Forms.TextBox();
            this.prodMin = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssocParts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAllParts
            // 
            this.dataGridAllParts.AllowUserToOrderColumns = true;
            this.dataGridAllParts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAllParts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAllParts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridAllParts.Location = new System.Drawing.Point(534, 119);
            this.dataGridAllParts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridAllParts.Name = "dataGridAllParts";
            this.dataGridAllParts.Size = new System.Drawing.Size(565, 209);
            this.dataGridAllParts.TabIndex = 0;
            this.dataGridAllParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAllParts_CellClick);
            // 
            // dataGridAssocParts
            // 
            this.dataGridAssocParts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridAssocParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAssocParts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAssocParts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridAssocParts.Location = new System.Drawing.Point(534, 402);
            this.dataGridAssocParts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridAssocParts.Name = "dataGridAssocParts";
            this.dataGridAssocParts.Size = new System.Drawing.Size(565, 209);
            this.dataGridAssocParts.TabIndex = 1;
            this.dataGridAssocParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAssocParts_CellClick);
            // 
            // labelAddModify
            // 
            this.labelAddModify.AutoSize = true;
            this.labelAddModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddModify.Location = new System.Drawing.Point(11, 8);
            this.labelAddModify.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddModify.Name = "labelAddModify";
            this.labelAddModify.Size = new System.Drawing.Size(108, 20);
            this.labelAddModify.TabIndex = 2;
            this.labelAddModify.Text = "Add Product";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(51, 180);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(22, 16);
            this.ID.TabIndex = 3;
            this.ID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(51, 232);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // Inventory
            // 
            this.Inventory.AutoSize = true;
            this.Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory.Location = new System.Drawing.Point(51, 281);
            this.Inventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(70, 16);
            this.Inventory.TabIndex = 5;
            this.Inventory.Text = "Inventory";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(51, 330);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(43, 16);
            this.Price.TabIndex = 6;
            this.Price.Text = "Price";
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max.Location = new System.Drawing.Point(51, 387);
            this.Max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(35, 16);
            this.Max.TabIndex = 7;
            this.Max.Text = "Max";
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min.Location = new System.Drawing.Point(264, 387);
            this.Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(31, 16);
            this.Min.TabIndex = 8;
            this.Min.Text = "Min";
            // 
            // prodID
            // 
            this.prodID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodID.ForeColor = System.Drawing.SystemColors.Window;
            this.prodID.Location = new System.Drawing.Point(147, 176);
            this.prodID.Margin = new System.Windows.Forms.Padding(4);
            this.prodID.Name = "prodID";
            this.prodID.ReadOnly = true;
            this.prodID.Size = new System.Drawing.Size(223, 22);
            this.prodID.TabIndex = 9;
            // 
            // prodName
            // 
            this.prodName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodName.ForeColor = System.Drawing.SystemColors.Window;
            this.prodName.Location = new System.Drawing.Point(147, 228);
            this.prodName.Margin = new System.Windows.Forms.Padding(4);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(223, 22);
            this.prodName.TabIndex = 10;
            // 
            // prodInventory
            // 
            this.prodInventory.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodInventory.ForeColor = System.Drawing.SystemColors.Window;
            this.prodInventory.Location = new System.Drawing.Point(147, 277);
            this.prodInventory.Margin = new System.Windows.Forms.Padding(4);
            this.prodInventory.Name = "prodInventory";
            this.prodInventory.Size = new System.Drawing.Size(223, 22);
            this.prodInventory.TabIndex = 11;
            // 
            // prodPrice
            // 
            this.prodPrice.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.prodPrice.Location = new System.Drawing.Point(147, 327);
            this.prodPrice.Margin = new System.Windows.Forms.Padding(4);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(223, 22);
            this.prodPrice.TabIndex = 12;
            // 
            // prodMax
            // 
            this.prodMax.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodMax.ForeColor = System.Drawing.SystemColors.Window;
            this.prodMax.Location = new System.Drawing.Point(119, 378);
            this.prodMax.Margin = new System.Windows.Forms.Padding(4);
            this.prodMax.Name = "prodMax";
            this.prodMax.Size = new System.Drawing.Size(103, 22);
            this.prodMax.TabIndex = 13;
            // 
            // prodMin
            // 
            this.prodMin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodMin.ForeColor = System.Drawing.SystemColors.Window;
            this.prodMin.Location = new System.Drawing.Point(323, 378);
            this.prodMin.Margin = new System.Windows.Forms.Padding(4);
            this.prodMin.Name = "prodMin";
            this.prodMin.Size = new System.Drawing.Size(66, 22);
            this.prodMin.TabIndex = 14;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSearch.Location = new System.Drawing.Point(875, 64);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(223, 22);
            this.textBoxSearch.TabIndex = 15;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(746, 62);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 28);
            this.buttonSearch.TabIndex = 16;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(979, 618);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(928, 679);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(1036, 679);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(979, 335);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "All Candidate Parts";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZ.Location = new System.Drawing.Point(530, 378);
            this.labelZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(212, 16);
            this.labelZ.TabIndex = 39;
            this.labelZ.Text = "Parts Associated with Product";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelZ);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.prodMin);
            this.panel1.Controls.Add(this.prodMax);
            this.panel1.Controls.Add(this.prodPrice);
            this.panel1.Controls.Add(this.prodInventory);
            this.panel1.Controls.Add(this.prodName);
            this.panel1.Controls.Add(this.prodID);
            this.panel1.Controls.Add(this.Min);
            this.panel1.Controls.Add(this.Max);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.Inventory);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.labelAddModify);
            this.panel1.Controls.Add(this.dataGridAssocParts);
            this.panel1.Controls.Add(this.dataGridAllParts);
            this.panel1.Location = new System.Drawing.Point(5, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 656);
            this.panel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 669);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 50);
            this.panel2.TabIndex = 41;
            // 
            // AddProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1187, 731);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProductScreen";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssocParts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAllParts;
        private System.Windows.Forms.DataGridView dataGridAssocParts;
        private System.Windows.Forms.Label labelAddModify;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label Inventory;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.TextBox prodID;
        private System.Windows.Forms.TextBox prodName;
        private System.Windows.Forms.TextBox prodInventory;
        private System.Windows.Forms.TextBox prodPrice;
        private System.Windows.Forms.TextBox prodMax;
        private System.Windows.Forms.TextBox prodMin;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}