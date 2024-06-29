namespace BenBailey_InventorySystem.Forms
{
    partial class ModifyProductScreen
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridAllParts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelZ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAddModify = new System.Windows.Forms.Label();
            this.prodMin = new System.Windows.Forms.TextBox();
            this.prodMax = new System.Windows.Forms.TextBox();
            this.prodPrice = new System.Windows.Forms.TextBox();
            this.prodInventory = new System.Windows.Forms.TextBox();
            this.prodName = new System.Windows.Forms.TextBox();
            this.prodID = new System.Windows.Forms.TextBox();
            this.Min = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Inventory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridAssocParts = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllParts)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssocParts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCancel);
            this.panel3.Controls.Add(this.buttonSave);
            this.panel3.Location = new System.Drawing.Point(612, 630);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 49);
            this.panel3.TabIndex = 18;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(343, 7);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(235, 7);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            this.dataGridAllParts.Location = new System.Drawing.Point(456, 69);
            this.dataGridAllParts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridAllParts.Name = "dataGridAllParts";
            this.dataGridAllParts.Size = new System.Drawing.Size(565, 209);
            this.dataGridAllParts.TabIndex = 18;
            this.dataGridAllParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAllParts_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.labelZ);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelAddModify);
            this.panel2.Controls.Add(this.prodMin);
            this.panel2.Controls.Add(this.prodMax);
            this.panel2.Controls.Add(this.prodPrice);
            this.panel2.Controls.Add(this.prodInventory);
            this.panel2.Controls.Add(this.prodName);
            this.panel2.Controls.Add(this.prodID);
            this.panel2.Controls.Add(this.Min);
            this.panel2.Controls.Add(this.Max);
            this.panel2.Controls.Add(this.Price);
            this.panel2.Controls.Add(this.Inventory);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.ID);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.dataGridAssocParts);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.dataGridAllParts);
            this.panel2.Location = new System.Drawing.Point(11, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 606);
            this.panel2.TabIndex = 19;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(673, 15);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 28);
            this.buttonSearch.TabIndex = 40;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSearch.Location = new System.Drawing.Point(797, 16);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(223, 22);
            this.textBoxSearch.TabIndex = 39;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZ.Location = new System.Drawing.Point(453, 336);
            this.labelZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(240, 16);
            this.labelZ.TabIndex = 38;
            this.labelZ.Text = "Parts Associated with this Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "All Candidate Parts";
            // 
            // labelAddModify
            // 
            this.labelAddModify.AutoSize = true;
            this.labelAddModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddModify.Location = new System.Drawing.Point(5, 14);
            this.labelAddModify.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddModify.Name = "labelAddModify";
            this.labelAddModify.Size = new System.Drawing.Size(108, 20);
            this.labelAddModify.TabIndex = 36;
            this.labelAddModify.Text = "Edit Product";
            // 
            // prodMin
            // 
            this.prodMin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodMin.ForeColor = System.Drawing.SystemColors.Window;
            this.prodMin.Location = new System.Drawing.Point(320, 347);
            this.prodMin.Margin = new System.Windows.Forms.Padding(4);
            this.prodMin.Name = "prodMin";
            this.prodMin.Size = new System.Drawing.Size(103, 22);
            this.prodMin.TabIndex = 35;
            // 
            // prodMax
            // 
            this.prodMax.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodMax.ForeColor = System.Drawing.SystemColors.Window;
            this.prodMax.Location = new System.Drawing.Point(116, 347);
            this.prodMax.Margin = new System.Windows.Forms.Padding(4);
            this.prodMax.Name = "prodMax";
            this.prodMax.Size = new System.Drawing.Size(103, 22);
            this.prodMax.TabIndex = 34;
            // 
            // prodPrice
            // 
            this.prodPrice.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.prodPrice.Location = new System.Drawing.Point(144, 295);
            this.prodPrice.Margin = new System.Windows.Forms.Padding(4);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(220, 22);
            this.prodPrice.TabIndex = 33;
            // 
            // prodInventory
            // 
            this.prodInventory.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodInventory.ForeColor = System.Drawing.SystemColors.Window;
            this.prodInventory.Location = new System.Drawing.Point(144, 246);
            this.prodInventory.Margin = new System.Windows.Forms.Padding(4);
            this.prodInventory.Name = "prodInventory";
            this.prodInventory.Size = new System.Drawing.Size(220, 22);
            this.prodInventory.TabIndex = 32;
            // 
            // prodName
            // 
            this.prodName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodName.ForeColor = System.Drawing.SystemColors.Window;
            this.prodName.Location = new System.Drawing.Point(144, 197);
            this.prodName.Margin = new System.Windows.Forms.Padding(4);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(223, 22);
            this.prodName.TabIndex = 31;
            // 
            // prodID
            // 
            this.prodID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodID.ForeColor = System.Drawing.SystemColors.Window;
            this.prodID.Location = new System.Drawing.Point(144, 145);
            this.prodID.Margin = new System.Windows.Forms.Padding(4);
            this.prodID.Name = "prodID";
            this.prodID.ReadOnly = true;
            this.prodID.Size = new System.Drawing.Size(223, 22);
            this.prodID.TabIndex = 30;
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min.Location = new System.Drawing.Point(261, 356);
            this.Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(31, 16);
            this.Min.TabIndex = 29;
            this.Min.Text = "Min";
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max.Location = new System.Drawing.Point(48, 356);
            this.Max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(35, 16);
            this.Max.TabIndex = 28;
            this.Max.Text = "Max";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(48, 299);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(43, 16);
            this.Price.TabIndex = 27;
            this.Price.Text = "Price";
            // 
            // Inventory
            // 
            this.Inventory.AutoSize = true;
            this.Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory.Location = new System.Drawing.Point(48, 250);
            this.Inventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(70, 16);
            this.Inventory.TabIndex = 26;
            this.Inventory.Text = "Inventory";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(48, 201);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(48, 149);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(22, 16);
            this.ID.TabIndex = 24;
            this.ID.Text = "ID";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(906, 573);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 23;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
            this.dataGridAssocParts.Location = new System.Drawing.Point(456, 356);
            this.dataGridAssocParts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridAssocParts.Name = "dataGridAssocParts";
            this.dataGridAssocParts.Size = new System.Drawing.Size(565, 209);
            this.dataGridAssocParts.TabIndex = 22;
            this.dataGridAssocParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAssocParts_CellClick);
            this.dataGridAssocParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAssocParts_CellClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(906, 287);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 21;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ModifyProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1081, 724);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModifyProductScreen";
            this.Text = "ModifyProduct";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllParts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssocParts)).EndInit();
            this.ResumeLayout(false);

        }

 

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridAllParts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridAssocParts;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox prodMin;
        private System.Windows.Forms.TextBox prodMax;
        private System.Windows.Forms.TextBox prodPrice;
        private System.Windows.Forms.TextBox prodInventory;
        private System.Windows.Forms.TextBox prodName;
        private System.Windows.Forms.TextBox prodID;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Inventory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAddModify;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}