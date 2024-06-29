using BenBailey_InventorySystem.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BenBailey_InventorySystem.Forms
{
    public partial class ModifyPartScreen : Form
    {
        MainScreen mainScreen = (MainScreen)Application.OpenForms["MainScreen"];

        private bool sourceInHouse = false;

        private bool sourceOutsourced = false;

        public ModifyPartScreen(Part part)
        {
            InitializeComponent();
            LoadPart(part);

            this.AutoValidate = AutoValidate.Disable;
            partName.Validating += new CancelEventHandler(partName_Validating);
            inventory.Validating += new CancelEventHandler(inventory_Validating);
            partPrice.Validating += new CancelEventHandler(partPrice_Validating);
            partMax.Validating += new CancelEventHandler(partMax_Validating);
            partMin.Validating += new CancelEventHandler(partMin_Validating);
            tbSourceID.Validating += new CancelEventHandler(tbSourceID_Validating);
        }
        
        /// <summary>
        /// Loads part selected to modify on main screen 
        /// </summary>
        /// <param name="part"></param>
        private void LoadPart(Part part)
        {
            PartID.Text = part.PartID.ToString();
            //PartID.Enabled = false;
            partName.Text = part.Name;
            inventory.Text = part.Inventory.ToString();
            partPrice.Text = part.Price.ToString();
            partMax.Text = part.Max.ToString();
            partMin.Text = part.Min.ToString();

            if (part.Source == true)
            {
                radioInHouse.Select();
                sourceIDLabel.Text = "Machine ID";
                tbSourceID.Text = part.MachineID.ToString();
            }
            else if (part.Source == false)
            {
                radioButtonOutsourced.Select();
                sourceIDLabel.Text = "Company Name";
                tbSourceID.Text = part.CompanyName;
            }
        }

        /// <summary>
        /// Sets the label to Machine ID if In House is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioInHouse_CheckedChanged(object sender, System.EventArgs e)
        {
            sourceIDLabel.Text = "Machine ID";
            sourceInHouse = true;
            sourceOutsourced = false;
        }

        /// <summary>
        /// Sets the label to Company Name if Outsourced is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            sourceIDLabel.Text = "Company Name";
            sourceOutsourced = true;
            sourceInHouse = false;
        }

        /// <summary>
        /// Validates form inputs.
        /// Saves modifications to part. 
        /// Error handling via Try Catch blocks 
        /// </summary>
        public void SaveItem()
        {
            //if (sourceInHouse || sourceOutsourced)
            //{
            //    MessageBox.Show("Source type cannot be changed after part is created. Delete the part and create a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
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
                    Part updatedPart;

                    if (radioInHouse.Checked)
                    {
                        try
                        {
                            updatedPart = new InHousePart(
                                Convert.ToInt32(PartID.Text),
                                partName.Text,
                                Convert.ToDecimal(partPrice.Text),
                                Convert.ToInt32(inventory.Text),
                                Convert.ToInt32(partMin.Text),
                                Convert.ToInt32(partMax.Text),
                                Convert.ToInt32(tbSourceID.Text)
                            );
                            Inventory.UpdateInHousePart(Convert.ToInt32(PartID.Text), (InHousePart)updatedPart);
                            MessageBox.Show("Part updated successfully.");
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
                            updatedPart = new OutsourcedPart(
                                Convert.ToInt32(PartID.Text),
                                partName.Text,
                                Convert.ToDecimal(partPrice.Text),
                                Convert.ToInt32(inventory.Text),
                                Convert.ToInt32(partMin.Text),
                                Convert.ToInt32(partMax.Text),
                                tbSourceID.Text
                            );
                            Inventory.UpdateOutsourcedPart(Convert.ToInt32(PartID.Text), (OutsourcedPart)updatedPart);
                            MessageBox.Show("Part updated successfully.");
                            this.Close();
                            mainScreen.refreshDataGrids();
                            mainScreen.Show();
                        }
                        catch (Exception ex2)
                        {
                            MessageBox.Show("An error has occured. Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            throw (ex2);
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
        /// Validates the Machine ID or Company Name input field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSourceID_Validating(object sender, CancelEventArgs e)
        {
            if (radioInHouse.Checked)
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
            else if (radioButtonOutsourced.Checked)
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
        /// Calls saveItem method when save button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SaveItem();
        }

        /// <summary>
        /// Asks user to confirm they want to cancel adding a new part. If yes, closes the form. If no, returns to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel modifying this part? All unsaved changes will be lost.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                mainScreen.Show();
            }
            else
                return;
        }
    }
}
