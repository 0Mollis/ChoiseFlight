using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoiseFlight
{
    public partial class ChoseData : Form
    {
        public ChoseData()
        {
            InitializeComponent();

            LoadDataC();

            LoadDataR();

        }

        public MySqlConnection connection;
        public DataTable dataTable;
        public string server = "Server=localhost;Database=aeroport;Uid=root;pwd=root;charset=utf8;";

        public void LoadDataC()
        {
            connection = new MySqlConnection(server);
            connection.Open();
            string infoDB = "SELECT name FROM compani";
            MySqlDataAdapter adpt = new MySqlDataAdapter(infoDB, connection);
            dataTable = new DataTable();
            adpt.Fill(dataTable);
            dataGridCompani.DataSource = dataTable;
            connection.Close();
        }

        public void LoadDataR()
        {
            connection = new MySqlConnection(server);
            connection.Open();
            string infoDB = "SELECT № FROM reis";
            MySqlDataAdapter adpt = new MySqlDataAdapter(infoDB, connection);
            dataTable = new DataTable();
            adpt.Fill(dataTable);
            dataGridReis.DataSource = dataTable;
            connection.Close();
        }
    }
}
