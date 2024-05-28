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

        }

        public string server = "Server=localhost;Database=aeroport;Uid=root;pwd=root;charset=utf8;";
        public MySqlConnection connection;
        public MySqlCommand command;
        public DataTable dataTable;

        private void ButtonLoadCompani_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(server);
            connection.Open();
            string infoDB = "SELECT name, year, raiting FROM compani";
            MySqlDataAdapter adpt = new MySqlDataAdapter(infoDB, connection);
            dataTable = new DataTable();
            adpt.Fill(dataTable);
            dataGridCompani.DataSource = dataTable;
            connection.Close();
        }
        private void buttonSaveCompani_Click(object sender, EventArgs e)
        {
            connection.Open();
            //MySqlDataAdapter.Update(dataSet); проблема что-то с dataSet наверное
            connection.Close();
        }

        private void buttonLoadReis_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(server);
            connection.Open();
            string infoDB = "SELECT * FROM reis";//Может из-за русских названий MySql.Data.MySqlClient.MySqlException: "Unknown column 'Город_вылета' in 'field list'"     SELECT №, Город_вылета, Город_прилёта, Время_вылета, Время_прилёта FROM reis
            MySqlDataAdapter adpt = new MySqlDataAdapter(infoDB, connection);
            dataTable = new DataTable();
            adpt.Fill(dataTable);
            dataGridReis.DataSource = dataTable;
            connection.Close();
        }
    }
}
