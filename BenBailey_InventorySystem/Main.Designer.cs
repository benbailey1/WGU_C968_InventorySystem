using System;
using System.Data;
using System.Data.SqlClient;

namespace BenBailey_InventorySystem
{
    partial class Main : System.Windows.Forms.Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventoryManagementSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.btnDeleteProducts = new System.Windows.Forms.Button();
            this.btnModifyProducts = new System.Windows.Forms.Button();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnSearchProducts = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.btnDeleteParts = new System.Windows.Forms.Button();
            this.btnModifyParts = new System.Windows.Forms.Button();
            this.btnAddParts = new System.Windows.Forms.Button();
            this.btnSearchParts = new System.Windows.Forms.Button();
            this.textBoxPartsSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryManagementSystemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inventoryManagementSystemToolStripMenuItem
            // 
            this.inventoryManagementSystemToolStripMenuItem.Name = "inventoryManagementSystemToolStripMenuItem";
            this.inventoryManagementSystemToolStripMenuItem.Size = new System.Drawing.Size(184, 20);
            this.inventoryManagementSystemToolStripMenuItem.Text = "Inventory Management System";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewProducts);
            this.groupBox1.Controls.Add(this.btnExitApp);
            this.groupBox1.Controls.Add(this.btnDeleteProducts);
            this.groupBox1.Controls.Add(this.btnModifyProducts);
            this.groupBox1.Controls.Add(this.btnAddProducts);
            this.groupBox1.Controls.Add(this.btnSearchProducts);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(432, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 393);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(4, 72);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(415, 181);
            this.dataGridViewProducts.TabIndex = 11;
            // 
            // btnExitApp
            // 
            this.btnExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitApp.Location = new System.Drawing.Point(369, 365);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(51, 22);
            this.btnExitApp.TabIndex = 10;
            this.btnExitApp.Text = "Exit";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnDeleteProducts
            // 
            this.btnDeleteProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteProducts.Location = new System.Drawing.Point(351, 273);
            this.btnDeleteProducts.Name = "btnDeleteProducts";
            this.btnDeleteProducts.Size = new System.Drawing.Size(51, 22);
            this.btnDeleteProducts.TabIndex = 9;
            this.btnDeleteProducts.Text = "Delete";
            this.btnDeleteProducts.UseVisualStyleBackColor = true;
            // 
            // btnModifyProducts
            // 
            this.btnModifyProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifyProducts.Location = new System.Drawing.Point(294, 273);
            this.btnModifyProducts.Name = "btnModifyProducts";
            this.btnModifyProducts.Size = new System.Drawing.Size(51, 22);
            this.btnModifyProducts.TabIndex = 8;
            this.btnModifyProducts.Text = "Modify";
            this.btnModifyProducts.UseVisualStyleBackColor = true;
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProducts.Location = new System.Drawing.Point(237, 273);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(51, 22);
            this.btnAddProducts.TabIndex = 7;
            this.btnAddProducts.Text = "Add";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            // 
            // btnSearchProducts
            // 
            this.btnSearchProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchProducts.Location = new System.Drawing.Point(229, 23);
            this.btnSearchProducts.Name = "btnSearchProducts";
            this.btnSearchProducts.Size = new System.Drawing.Size(51, 22);
            this.btnSearchProducts.TabIndex = 3;
            this.btnSearchProducts.Text = "Search";
            this.btnSearchProducts.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewParts);
            this.groupBox2.Controls.Add(this.btnDeleteParts);
            this.groupBox2.Controls.Add(this.btnModifyParts);
            this.groupBox2.Controls.Add(this.btnAddParts);
            this.groupBox2.Controls.Add(this.btnSearchParts);
            this.groupBox2.Controls.Add(this.textBoxPartsSearch);
            this.groupBox2.Location = new System.Drawing.Point(11, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 392);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parts";
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.Location = new System.Drawing.Point(6, 72);
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.Size = new System.Drawing.Size(403, 181);
            this.dataGridViewParts.TabIndex = 12;
            // 
            // btnDeleteParts
            // 
            this.btnDeleteParts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteParts.Location = new System.Drawing.Point(346, 273);
            this.btnDeleteParts.Name = "btnDeleteParts";
            this.btnDeleteParts.Size = new System.Drawing.Size(51, 22);
            this.btnDeleteParts.TabIndex = 3;
            this.btnDeleteParts.Text = "Delete";
            this.btnDeleteParts.UseVisualStyleBackColor = true;
            this.btnDeleteParts.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnModifyParts
            // 
            this.btnModifyParts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifyParts.Location = new System.Drawing.Point(289, 273);
            this.btnModifyParts.Name = "btnModifyParts";
            this.btnModifyParts.Size = new System.Drawing.Size(51, 22);
            this.btnModifyParts.TabIndex = 7;
            this.btnModifyParts.Text = "Modify";
            this.btnModifyParts.UseVisualStyleBackColor = true;
            this.btnModifyParts.Click += new System.EventHandler(this.btnModifyParts_Click);
            // 
            // btnAddParts
            // 
            this.btnAddParts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddParts.Location = new System.Drawing.Point(232, 274);
            this.btnAddParts.Name = "btnAddParts";
            this.btnAddParts.Size = new System.Drawing.Size(51, 22);
            this.btnAddParts.TabIndex = 6;
            this.btnAddParts.Text = "Add";
            this.btnAddParts.UseVisualStyleBackColor = true;
            this.btnAddParts.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnSearchParts
            // 
            this.btnSearchParts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchParts.Location = new System.Drawing.Point(224, 23);
            this.btnSearchParts.Name = "btnSearchParts";
            this.btnSearchParts.Size = new System.Drawing.Size(51, 22);
            this.btnSearchParts.TabIndex = 2;
            this.btnSearchParts.Text = "Search";
            this.btnSearchParts.UseVisualStyleBackColor = true;
            this.btnSearchParts.Click += new System.EventHandler(this.btnSearchParts_Click);
            // 
            // textBoxPartsSearch
            // 
            this.textBoxPartsSearch.Location = new System.Drawing.Point(281, 25);
            this.textBoxPartsSearch.Name = "textBoxPartsSearch";
            this.textBoxPartsSearch.Size = new System.Drawing.Size(116, 20);
            this.textBoxPartsSearch.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inventoryManagementSystemToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchProducts;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSearchParts;
        private System.Windows.Forms.TextBox textBoxPartsSearch;
        private System.Windows.Forms.Button btnDeleteParts;
        private System.Windows.Forms.Button btnModifyParts;
        private System.Windows.Forms.Button btnAddParts;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Button btnDeleteProducts;
        private System.Windows.Forms.Button btnModifyProducts;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridView dataGridViewParts;
    }
}

