using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoiseFlight
{
    public partial class AddDataForm : Form
    {
        public AddDataForm()
        {
            InitializeComponent();

            GetComments();
            GetComments2();
        }

        private void GetComments()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=aeroport;user=root;password=root");

            string query = "SELECT * FROM reis";

            using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection))
            {

                DataSet dset = new DataSet();

                adpt.Fill(dset);

                dataGridView1.DataSource = dset.Tables[0];

            }
        }

        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=aeroport;user=root;password=root");
        DataSet dset = new DataSet();
        MySqlConnection adap = new MySqlConnection();
        DataTable dataTable = new DataTable();

        private void GetComments2()
        {
            
            connection.Open();
            string query = "SELECT * FROM compani";

            using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection))
            {

                

                adpt.Fill(dset);

                dataGridView2.DataSource = dset.Tables[0];

            }
            connection.Close();
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("SAVED");
        }
    }
}
