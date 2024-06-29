using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BenBailey_InventorySystem.DataContracts;
using BenBailey_InventorySystem.Forms;
using BenBailey_InventorySystem.Models;

namespace BenBailey_InventorySystem
{
    public partial class MainScreen : Form
    {
        public static BindingSource boundProds = new BindingSource();
        public static BindingSource boundParts = new BindingSource();
        public static BindingList<Product> boundProductsList = new BindingList<Product>(Inventory.Products);
        public static BindingList<Part> boundPartsList = new BindingList<Part>(Inventory.Parts);
        
        public MainScreen()
        {
            InitializeComponent();
            dataGridViewParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            textBoxPartsSearch.KeyDown += new KeyEventHandler(textBoxPartsSearch_KeyDown);
            textBoxProductSearch.KeyDown += new KeyEventHandler(textBoxProductSearch_KeyDown);

            textBoxPartsSearch.Enter += new EventHandler(textBoxPartsSearch_Enter);
            textBoxPartsSearch.Leave += new EventHandler(textBoxPartsSearch_Leave);
            textBoxPartsSearch.Text = "Search by Part ID or Part Name";
            textBoxPartsSearch.ForeColor = Color.Gray;

            textBoxProductSearch.Enter += new EventHandler(textBoxProductSearch_Enter);
            textBoxProductSearch.Leave += new EventHandler(textBoxProductSearch_Leave);
            textBoxProductSearch.Text = "Search by Product ID or Name";
            textBoxProductSearch.ForeColor = Color.Gray;


        }

        private void TextBoxPartsSearch_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Loads form with Product and Part data and creates DataGridViews
        /// </summary>
        public void LoadMainScreen()
        {
            Inventory.PopulateLists();

            var bPart = new BindingSource();
            bPart.DataSource = Inventory.Parts;
            dataGridViewParts.DataSource = bPart;
            dataGridViewParts.Columns["PartID"].HeaderText = "Part ID";
            dataGridViewParts.Columns["Name"].HeaderText = "Part Name";
            dataGridViewParts.Columns["Price"].HeaderText = "Price";
            dataGridViewParts.Columns["Inventory"].HeaderText = "Inventory";
            dataGridViewParts.Columns["Min"].HeaderText = "Min";
            dataGridViewParts.Columns["Max"].HeaderText = "Max";
            dataGridViewParts.Columns["Source"].Visible = false;
            dataGridViewParts.Columns["MachineID"].Visible = false;
            dataGridViewParts.Columns["CompanyName"].Visible = false;

            var bProd = new BindingSource();
            bProd.DataSource = Inventory.Products;
            dataGridViewProducts.DataSource = bProd;
            dataGridViewProducts.Columns["ProductID"].HeaderText = "Product ID";
            dataGridViewProducts.Columns["Name"].HeaderText = "Product Name";
            dataGridViewProducts.Columns["Price"].HeaderText = "Price";
            dataGridViewProducts.Columns["Inventory"].HeaderText = "Inventory";
            dataGridViewProducts.Columns["Min"].HeaderText = "Min";
            dataGridViewProducts.Columns["Max"].HeaderText = "Max";
        }

        public void refreshDataGrids()
        {
            dataGridViewParts.Update();
            dataGridViewProducts.Update();
            dataGridViewParts.Refresh();
            dataGridViewProducts.Refresh();

        }

        /// <summary>
        /// Loads Main Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMainScreen();
        }

// ********************* PART Methods ********************

        /// <summary>
        /// search for part and selects row in datagrid 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchParts_Click(object sender, EventArgs e)
        {
            dataGridViewParts.SelectedRows[0].Selected = false;
            
            string searchText = textBoxPartsSearch.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridViewParts.Rows)
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

            //foreach (DataGridViewRow row in dataGridViewParts.Rows)
            //{
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
            //        {
            //            row.Selected = true;
            //            break;
            //        }
            //    }
            //}
        }

        ///<summary>
        /// Input to search for part and selects in datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPartsSearch_TextChanged(object sender, EventArgs e)
        {
            //string searchText = textBoxPartsSearch.Text.Trim().ToLower();

            //if (!string.IsNullOrEmpty(searchText))
            //{
            //    foreach (DataGridViewRow row in dataGridViewParts.Rows)
            //    {
            //        if (row.Cells["PartID"] != null && row.Cells["PartID"].Value != null && row.Cells["PartID"].Value.ToString().Contains(searchText)
            //            || row.Cells["Name"] != null && row.Cells["Name"].Value != null && row.Cells["Name"].Value.ToString().ToLower().Contains(searchText))

            //        {
            //            row.Selected = true;
            //        }
            //        else
            //        {
            //            row.Selected = false;
            //        }
            //    }
            //}
            //else
            //{
            //    foreach (DataGridViewRow row in dataGridViewParts.Rows)
            //    {
            //        row.Selected = true;
            //    }
            //}
        }

        /// <summary>
        /// Button open Add Part screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPart_Click(object sender, EventArgs e)
        {

            AddPartScreen addPartScreen = new AddPartScreen();
            addPartScreen.Show();
        }

        /// <summary>
        /// Button opens Modify Part screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifyParts_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow usrSelectedRow = dataGridViewParts.SelectedRows[0];
                var value = usrSelectedRow.Cells["PartID"].Value;

                if (value.Equals(null))
                {
                    throw new NullReferenceException("Selected row does not contain a valid Part ID.");
                }
                int partID = Convert.ToInt32(usrSelectedRow.Cells["PartID"].Value);
                Part part = Inventory.LookupPart(partID);
                ModifyPartScreen frm = new ModifyPartScreen(part);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Deletes selected row in parts datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeletePart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridViewParts.SelectedRows)
                {
                    dataGridViewParts.Rows.RemoveAt(row.Index);
                }
            }
            else
                return; 
        }

        /// <summary>
        /// Selects full row of cell that was clicked in Parts table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the index of the clicked cell
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            // Check if the clicked cell is not a column header
            if (rowIndex >= 0 && columnIndex >= 0)
            {
                // Clear the current selection
                dataGridViewParts.ClearSelection();

                // Select the whole row
                dataGridViewParts.Rows[rowIndex].Selected = true;
            }
        }

        private void textBoxPartsSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchParts_Click(sender, e);
                e.Handled = true;
            }
        }

        private void textBoxPartsSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxPartsSearch.Text == "Search by Part ID or Part Name")
            {
                textBoxPartsSearch.Text = "";
                textBoxPartsSearch.ForeColor = Color.White;
            }
        }

        private void textBoxPartsSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPartsSearch.Text))
            {
                textBoxPartsSearch.Text = "Search by Part ID or Part Name";
                textBoxPartsSearch.ForeColor = Color.Gray;
            }
        }

        // ******************************* PRODUCT Methods ****************************************

        /// <summary>
        /// search for product and selects row in datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
            dataGridViewProducts.SelectedRows[0].Selected = false;
            
            string searchText = textBoxProductSearch.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                if (row.Cells["ProductID"] != null && row.Cells["ProductID"].Value != null && row.Cells["ProductID"].Value.ToString().Contains(searchText)
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

        /// <summary>
        /// Opens Add Product screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProducts_Click_1(object sender, EventArgs e)
        {
            AddProductScreen addProductScreen = new AddProductScreen();
            addProductScreen.Show();
        }

        /// <summary>
        /// Opens Modify Product Screen 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifyProducts_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow usrSelectedRow = dataGridViewProducts.SelectedRows[0];
                var value = usrSelectedRow.Cells["ProductID"].Value;

                if (value.Equals(null))
                {
                    throw new NullReferenceException("Selected row does not contain a valid Product ID.");
                }
                int productID = Convert.ToInt32(value);
                Product product = Inventory.LookupProduct(productID);
                ModifyProductScreen frm = new ModifyProductScreen(product);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Deletes product selected in Product Datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteProducts_Click(object sender, EventArgs e)
        {
            Product selectedProd = (Product)dataGridViewProducts.CurrentRow.DataBoundItem;
            if (selectedProd.AssociatedParts.Count != 0)
            {
                MessageBox.Show("Product contains one or more Associated Parts. \nPlease remove all associated parts from this Product and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridViewProducts.SelectedRows)
                    {
                        dataGridViewProducts.Rows.RemoveAt(row.Index);
                    }
                }
                else
                    return;
            }
            
        }
        

        /// <summary>
        /// Exits the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want quit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                return;
            
        }
        
        /// <summary>
        /// Selects full row of cell that was clicked in All Products table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the index of the clicked cell
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            // Check if the clicked cell is not a column header
            if (rowIndex >= 0 && columnIndex >= 0)
            {
                // Clear the current selection
                dataGridViewProducts.ClearSelection();

                // Select the whole row
                dataGridViewProducts.Rows[rowIndex].Selected = true;
            }
        }

        private void textBoxProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchProducts_Click(sender, e);
                e.Handled = true;
            }
        }

        private void textBoxProductSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxProductSearch.Text == "Search by Product ID or Name")
            {
                textBoxProductSearch.Text = "";
                textBoxProductSearch.ForeColor = Color.White;
            }
        }

        private void textBoxProductSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxProductSearch.Text))
            {
                textBoxProductSearch.Text = "Search by Product ID or Name";
                textBoxProductSearch.ForeColor = Color.Gray;
            }
        }
        
    }
}
