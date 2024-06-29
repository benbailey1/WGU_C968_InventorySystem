using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenBailey_InventorySystem
{
    public class DataAccess
    {
        string connString = @"Data Source=ACE-2434-LT\SQLEXPRESS;Initial Catalog=InventorySystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlDataAdapter dataAdapter;
        DataTable table;
        SqlCommandBuilder commandBuilder;

        string getInventory = "SELECT * FROM Inventory";

        protected string ConnectionString { get; set; }

        public void BaseDataAccess()
        {
        }
        
        public  DataTable GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connString);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);

                return table;
            } 
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); //display error message and return blank datatable 
                return table;
            }
        }

        /*
         *using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        // Connection string
        string connectionString = "Data Source=<server_name>;Initial Catalog=<database_name>;User ID=<username>;Password=<password>;";

        // Machine table CRUD operations
        MachineCRUD(connectionString);

        // OutsourcedCompany table CRUD operations
        OutsourcedCompanyCRUD(connectionString);

        // Part table CRUD operations
        PartCRUD(connectionString);

        // Product table CRUD operations
        ProductCRUD(connectionString);

        // ProductParts table CRUD operations
        ProductPartsCRUD(connectionString);
    }

    // Machine table CRUD operations
    static void MachineCRUD(string connectionString)
    {
        // Create
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand("INSERT INTO Machine (MachineID, SerialNumber) VALUES (@MachineID, @SerialNumber)", connection))
            {
                command.Parameters.Add("@MachineID", SqlDbType.Int).Value = 1;
                command.Parameters.Add("@SerialNumber", SqlDbType.VarChar, 20).Value = "1234567890";

                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine("Rows affected during INSERT: " + rowsAffected);
            }
        }

        // Read
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM Machine", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("MachineID: " + reader["MachineID"] + ", SerialNumber: " + reader["SerialNumber"]);
                    }
                }
            }
        }

        // Update
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand("UPDATE Machine SET SerialNumber = @SerialNumber WHERE MachineID = @MachineID", connection))
            {
                command.Parameters.Add("@MachineID", SqlDbType.Int).Value = 1;
                command.Parameters.Add("@SerialNumber", SqlDbType.VarChar, 20).Value = "0987654321";

               
 
         * 
        */



    }
}
