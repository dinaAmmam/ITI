using System.Data;
using System.Data.SqlClient;
namespace AdoForm

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)

        {
            // Define connection string
            string connectionString = "Data Source=DESKTOP-ODUF6AM;Initial Catalog=ITIAdo;Integrated Security=SSPI;";
            // Define select query
            string selectQuery = "SELECT * FROM Employees";

            // Define insert query
            string insertQuery = "INSERT INTO Employees (name) VALUES (@InputValue)";

            // Create a DataSet to hold the data
            DataSet dataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create SqlDataAdapter with select, insert, update, and delete commands
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        // Select command to populate the DataSet
                        adapter.SelectCommand = new SqlCommand(selectQuery, connection);

                        // Insert command for the new data
                        adapter.InsertCommand = new SqlCommand(insertQuery, connection);
                        adapter.InsertCommand.Parameters.Add("@InputValue", SqlDbType.NVarChar, 255, "name");

                        // Fill the DataSet with existing data
                        adapter.Fill(dataSet, "Employees");

                        // Create a new row with the data to insert
                        DataRow newRow = dataSet.Tables["Employees"].NewRow();
                        newRow["name"] = textBox1.Text;
                        dataSet.Tables["Employees"].Rows.Add(newRow);

                        // Update the database with the changes
                        adapter.Update(dataSet, "Employees");
                    }

                    Console.WriteLine("Data inserted and updated successfully.");
                    textBox1.Text = "";
                    MessageBox.Show("Data inserted and updated successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
    
}
