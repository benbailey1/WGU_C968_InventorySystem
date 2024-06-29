using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BenBailey_InventorySystem.Models;

namespace BenBailey_InventorySystem
{
    public partial class AddProductScreen : Form
    {
        BindingList<Part> assocParts = new BindingList<Part>();
        public AddProductScreen()
        {
            InitializeComponent();
            dataGridAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAssocParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AddProductScreenLoad();
            prodID.Text = Convert.ToString(BenBailey_InventorySystem.Models.Inventory.Products.Count + 1);
            //prodID.Enabled = false;
            
        }

        /// <summary>
        /// Loads form and creates DataGridViews for all parts and associated parts.
        /// </summary>
        /// <param name="product"></param>
        public void AddProductScreenLoad()
        {
            //All Parts
            var allParts = new BindingSource();
            allParts.DataSource = BenBailey_InventorySystem.Models.Inventory.Parts;
            dataGridAllParts.DataSource = allParts;
            dataGridAllParts.Columns["PartID"].HeaderText = "Part ID";
            dataGridAllParts.Columns["Name"].HeaderText = "Part Name";
            dataGridAllParts.Columns["Price"].HeaderText = "Price";
            dataGridAllParts.Columns["Inventory"].HeaderText = "Inventory";
            dataGridAllParts.Columns["Min"].HeaderText = "Min";
            dataGridAllParts.Columns["Max"].HeaderText = "Max";
            dataGridAllParts.Columns["Source"].Visible = false;
            dataGridAllParts.Columns["MachineID"].Visible = false;
            dataGridAllParts.Columns["CompanyName"].Visible = false;

            //Associated Parts
            var assocParts = new BindingSource();
            assocParts.DataSource = this.assocParts;
            dataGridAssocParts.DataSource = assocParts;
            dataGridAssocParts.Columns["PartID"].HeaderText = "Part ID";
            dataGridAssocParts.Columns["Name"].HeaderText = "Part Name";
            dataGridAssocParts.Columns["Price"].HeaderText = "Price";
            dataGridAssocParts.Columns["Inventory"].HeaderText = "Inventory";
            dataGridAssocParts.Columns["Min"].HeaderText = "Min";
            dataGridAssocParts.Columns["Max"].HeaderText = "Max";
            dataGridAssocParts.Columns["Source"].Visible = false;
            dataGridAssocParts.Columns["MachineID"].Visible = false;
            dataGridAssocParts.Columns["CompanyName"].Visible = false;
        }

        /// <summary>
        /// Searches All Parts for value in input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int searchPartID = Convert.ToInt32(textBoxSearch.Text); //textBoxSearch.Text.Trim().ToLower();

            Part result = BenBailey_InventorySystem.Models.Inventory.LookupPart(searchPartID);

            foreach (DataGridViewRow row in dataGridAllParts.Rows)
            {
                Part part = (Part)row.DataBoundItem;

                if (part.PartID == result.PartID)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        /// <summary>
        /// Searches All Parts table as user inputs text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchText))
            {
                foreach (DataGridViewRow row in dataGridAllParts.Rows)
                {
                    if (row.Cells["PartID"] != null && row.Cells["PartID"].Value != null && row.Cells["PartID"].Value.ToString().Contains(searchText)
                        || row.Cells["Name"] != null && row.Cells["Name"].Value != null && row.Cells["Name"].Value.ToString().ToLower().Contains(searchText))

                    {
                        row.Selected = true;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridAllParts.Rows)
                {
                    row.Selected = true;
                }
            }
        }

        /// <summary>
        /// Adds part from All Parts table to Associated Parts Table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Part part = (Part)dataGridAllParts.CurrentRow.DataBoundItem;
            assocParts.Add(part);
        }

        /// <summary>
        /// Deletes part from Associated Parts Table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (result == DialogResult.Yes)
                {
                    Part part = (Part)dataGridAssocParts.CurrentRow.DataBoundItem;
                    assocParts.Remove(part);
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while trying to delete this part. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            
            
        }

        /// <summary>
        /// Saves modifications to product
        /// Error handling via try catch blocks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            int prodID = Convert.ToInt32(this.prodID.Text);
            string prodName = this.prodName.Text;
            int prodInventory = Convert.ToInt32(this.prodInventory.Text);
            decimal prodPrice = Convert.ToDecimal(this.prodPrice.Text);
            int prodMax = Convert.ToInt32(this.prodMax.Text);
            int prodMin = Convert.ToInt32(this.prodMin.Text);

            Product product = new Product(prodID, prodName, prodPrice, prodInventory, prodMin, prodMax);
            foreach (Part part in assocParts)
            {
                product.AddAssociatedPart(part);
            }
            BenBailey_InventorySystem.Models.Inventory.AddProduct(product);
            this.Close();
        }

        /// <summary>
        /// Asks user to confirm they want to cancel adding a new product. If yes, closes the form. If no, returns to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel adding this product? All unsaved changes will be lost.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        /// <summary>
        /// Selects full row of cell that was clicked in Associated Parts Table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridAssocParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the index of the clicked cell
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            // Check if the clicked cell is not a column header
            if (rowIndex >= 0 && columnIndex >= 0)
            {
                // Clear the current selection
                dataGridAssocParts.ClearSelection();

                // Select the whole row
                dataGridAssocParts.Rows[rowIndex].Selected = true;

            }
        }

        /// <summary>
        /// Selects full row of cell that was clicked in All Parts Table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the index of the clicked cell
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            // Check if the clicked cell is not a column header
            if (rowIndex >= 0 && columnIndex >= 0)
            {
                // Clear the current selection
                dataGridAllParts.ClearSelection();

                // Select the whole row
                dataGridAllParts.Rows[rowIndex].Selected = true;

            }
        }
    }
}

