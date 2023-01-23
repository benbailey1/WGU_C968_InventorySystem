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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            //Delete selected part from database
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            Part frm = new Part();
            frm.Show();
        }

        //search button at top of Parts section
        private void btnSearchParts_Click(object sender, EventArgs e)
        {
            //Search database for part and display in datagrid
        }

        private void btnModifyParts_Click(object sender, EventArgs e)
        {
            Part frm = new Part();
            //get data for part in database
            //align data with form fields
            frm.Show();
        }

        //search button at top of Products section
        private void btnSearchProducts_Click(object sender, EventArgs e)
        {

        }
        
        //Input to search database for part and display in datagrid
        private void textBoxPartsSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Input to search database for product and display in datagrid
        private void textBoxProductSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
