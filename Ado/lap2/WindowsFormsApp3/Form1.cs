using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader dReader;
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }
            this.sqlCommand1.CommandText = "SELECT id, name FROM department";
            //sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            while (dReader.Read())
            {
                string str = ((int)dReader[0]).ToString() + "\t" + dReader[1].ToString();
                listBox1.Items.Add(str);
            }
            dReader.Close();
            //sqlConnection1.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "Insert Into department Values(" + textBox1.Text + ", '" + textBox2.Text + "')";
            //MessageBox.Show(str);
            ExecuteStatement(str, "Inserted");
            //sqlCommand1.CommandText = str;
            //sqlConnection1.Open();
            //int affectedRows = sqlCommand1.ExecuteNonQuery();
            //sqlConnection1.Close();
            //MessageBox.Show(affectedRows.ToString() + " Records Inserted");
            //textBox1.Text = textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string str = "Update department Set name = '" + textBox2.Text + "' Where id = " + textBox1.Text;
            //MessageBox.Show(str);
            //ExecuteStatement(str, "Updated");
            //sqlCommand1.CommandText = str;
            //sqlConnection1.Open();
            //int affectedRows = sqlCommand1.ExecuteNonQuery();
            //sqlConnection1.Close();
            //MessageBox.Show(affectedRows.ToString() + " Records Updated");
            //textBox1.Text = textBox2.Text = "";
            string str = "Update department Set name = '" + textBox2.Text + "' Where Id = '" + textBox1.Text + "'";
            ExecuteStatement(str, "Updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "Delete From department Where name = '" + textBox2.Text + "'";
            //MessageBox.Show(str);
            sqlCommand1.CommandText = str;
            ExecuteStatement(str, "Deleted");
            //sqlConnection1.Open();
            //int affectedRows = sqlCommand1.ExecuteNonQuery();
            //sqlConnection1.Close();
            //MessageBox.Show(affectedRows.ToString() + " Records Deleted");
            //textBox1.Text = textBox2.Text = "";
        }
        private void ExecuteStatement(string str, string State)
        {
            sqlCommand1.CommandText = str;
            //sqlConnection1.Open();
            int affectedRows = sqlCommand1.ExecuteNonQuery();
            //sqlConnection1.Close();
            MessageBox.Show(affectedRows.ToString() + " Records " + State);
            textBox1.Text = textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            MessageBox.Show("Connection Opened");
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            sqlConnection1.Close();
            MessageBox.Show("Connection Closed");
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
            button5.Enabled = true;
        }
    }
}
