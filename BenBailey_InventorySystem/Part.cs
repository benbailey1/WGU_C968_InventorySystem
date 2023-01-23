using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenBailey_InventorySystem
{
    public partial class Part : Form
    {
        public Part()
        {
            //TODO: Should I have a separate form for adding and modifying parts?
            InitializeComponent();
        }

        // TODO: if radioButton1 == true, then set label8 to "Machine ID"
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        // TODO: if radioButton2 == true, then set label8 to "Company Name"
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        //ID
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Name
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Inventory
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //Price/Cost
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        //Max
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        //Min
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        //Machine ID or Company Name?
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        // Label for Machine ID or Company Name?
        private void label8_Click(object sender, EventArgs e)
        {

        }

        // Save Button
        private void button3_Click(object sender, EventArgs e)
        {
            //TODO: Save part to database and return user to main screen

        }

        //Cancel Button
        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Return user to main screen without saving
        }
    }
}
