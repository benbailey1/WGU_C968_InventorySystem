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
    public partial class AddPartScreen : Form
    {
        MainScreen mainScreen = (MainScreen)Application.OpenForms["MainScreen"];
        public AddPartScreen()
        {
            InitializeComponent();
            partID.Text = Convert.ToString(Inventory.Parts.Count + 1);

            this.AutoValidate = AutoValidate.Disable;
            partName.Validating += new CancelEventHandler(partName_Validating);
            inventory.Validating += new CancelEventHandler(inventory_Validating);
            partPrice.Validating += new CancelEventHandler(partPrice_Validating);
            partMax.Validating += new CancelEventHandler(partMax_Validating);
            partMin.Validating += new CancelEventHandler(partMin_Validating);
            tbSourceID.Validating += new CancelEventHandler(tbSourceID_Validating);

        }
        
        /// <summary>
        /// Sets the sourceID Label to Machine ID when In House is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sourceIDLabel.Text = "Machine ID";
        }

        /// <summary>
        /// Sets the sourceIDLabel to Company Name when Outsourced is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sourceIDLabel.Text = "Company Name";
        }

        /// <summary>
        /// Validates form inputs.
        /// Saves new Part. 
        /// Error handling via Try Catch blocks 
        /// </summary>
        private void button3_Click(object sender, EventArgs e)  
        {
            try
            {
                if (Convert.ToInt32(partMin.Text) > Convert.ToInt32(partMax.Text))
                {
                    MessageBox.Show("Minimum quantity must not be greater than Maximum quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    partMin.BackColor = Color.Red;
                    partMax.BackColor = Color.Red;
                    return;
                }

                if (this.ValidateChildren())
                {
                    Part newPart;

                    if (inHouseChecked.Checked)
                    {
                        try
                        {
                            newPart = new InHousePart(
                                Convert.ToInt32(partID.Text),
                                partName.Text,
                                Convert.ToDecimal(partPrice.Text),
                                Convert.ToInt32(inventory.Text),
                                Convert.ToInt32(partMin.Text),
                                Convert.ToInt32(partMax.Text),
                                Convert.ToInt32(tbSourceID.Text)
                                );
                            Inventory.AddPart(newPart);
                            MessageBox.Show("Part added successfully.");
                            this.Close();
                            mainScreen.refreshDataGrids();
                            mainScreen.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error has occured. Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            throw (ex);
                        }
                    }
                    else
                    {
                        try
                        {
                            newPart = new OutsourcedPart(
                                Convert.ToInt32(partID.Text),
                                partName.Text,
                                Convert.ToDecimal(partPrice.Text),
                                Convert.ToInt32(inventory.Text),
                                Convert.ToInt32(partMin.Text),
                                Convert.ToInt32(partMax.Text),
                                tbSourceID.Text
                                );
                            Inventory.AddPart(newPart);
                            MessageBox.Show("Part added successfully.");
                            this.Close();
                            mainScreen.refreshDataGrids();
                            mainScreen.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error has occured. Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            throw (ex);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please correct the errors and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            

        }

        /// <summary>
        /// Asks user to confirm they want to cancel adding a new part. If yes, closes the form. If no, returns to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel adding this part? All unsaved changes will be lost.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                mainScreen.Show();
            }
            else
                return;
        }

        /// <summary>
        /// Validates Part Name is a valid integer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void partName_Validating(object sender, CancelEventArgs e)
        {
            if (partName.Text.Length < 1)
            {
                e.Cancel = true;
                partName.BackColor = Color.Red;
            }
            else
            {
                e.Cancel = false;
            }
        }

        /// <summary>
        /// Validates inventory is a valid integer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inventory_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(inventory.Text, out int inventoryEntered) &&
                inventoryEntered >= Convert.ToInt32(partMin.Text) && 
                    inventoryEntered <= Convert.ToInt32(partMax.Text))
            {
                e.Cancel = false;
            }
            else
            {
                MessageBox.Show("Inventory must be a valid integer between Min and Max values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                inventory.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// Validates the price input is a valid decimal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partPrice_Validating(object sender, CancelEventArgs e)
        {
            if (decimal.TryParse(partPrice.Text, out decimal result))
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                partPrice.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// Validates the partMax field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partMax_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(partMax.Text, out int result))
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                partMax.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// Validates the partMin field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partMin_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(partMin.Text, out int result))
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                partMin.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// Validates the tbSourceID field based on if InHouse or Outsourced is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSourceID_Validating(object sender, CancelEventArgs e)
        {
            if (inHouseChecked.Checked)
            {
                if (int.TryParse(tbSourceID.Text, out int result))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    tbSourceID.BackColor = Color.Red;
                }
            }
            else if (outsourcedChecked.Checked)
            {
                if (tbSourceID.Text is String)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    tbSourceID.BackColor = Color.Red;
                }
            }
            else
            {
                e.Cancel = true;
                tbSourceID.BackColor = Color.Red;
            }
        }

        
    }
}
