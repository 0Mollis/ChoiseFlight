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
            connection = new MySqlConnection(server);
        }

        public string server = "Server=localhost;Database=aeroport;Uid=root;pwd=root;charset=utf8;";
        public MySqlConnection connection;
        public MySqlCommand command;
        public DataTable dataTable;

        private void ButtonLoadCompani_Click(object sender, EventArgs e)
        {
            GetCompaniDB();
        }

        public void GetCompaniDB()
        {
            connection.Open();
            dataGridCompani.AutoGenerateColumns=false;
            IDcol.DataPropertyName = "id";
            NameCompani.DataPropertyName = "name";
            YearCompani.DataPropertyName = "year";
            ReitingCompani.DataPropertyName = "raiting";
            string infoDB = "SELECT id, name, year, raiting FROM compani";
            MySqlDataAdapter adpt = new MySqlDataAdapter(infoDB, connection);
            dataTable = new DataTable();
            adpt.Fill(dataTable);
            dataGridCompani.DataSource = dataTable;
            connection.Close();
        }

        private void buttonSaveCompani_Click(object sender, EventArgs e)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `compani` (`name`, `year`, `raiting`) VALUE (@n, @year, @raiting);", connection);
            command.Parameters.Add("@year", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@raiting", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = textBox1.Text;
            command.ExecuteNonQuery(); 

            connection.Close();

            GetCompaniDB();
        }

        private void buttonLoadReis_Click(object sender, EventArgs e)
        {
            GetReisDB();
        }

        private void buttonCompaniDelete_Click(object sender, EventArgs e)
        {
            iDeleteC();
        }

        private void iDeleteC()
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM `compani` WHERE `compani`.`id` = @id", connection);
            command.Parameters.Add("@id", MySqlDbType.Int16).Value = GetIdC();
            command.ExecuteNonQuery();
            connection.Close();

            dataGridCompani.Rows.RemoveAt(dataGridCompani.SelectedRows[0].Index);
        }

        private object GetIdC()
        {
            return dataGridCompani.SelectedRows[0].Cells[0].Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iDeleteR();
        }

        private void iDeleteR()
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM `reis` WHERE `reis`.`id` = @id", connection);
            command.Parameters.Add("@id", MySqlDbType.Int16).Value = GetIdR();
            command.ExecuteNonQuery();
            connection.Close();

            dataGridReis.Rows.RemoveAt(dataGridReis.SelectedRows[0].Index);
        }

        private object GetIdR()
        {
            return dataGridReis.SelectedRows[0].Cells[0].Value;
        }

        private void iExit()
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            iExit();
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }


        private void buttonSaveReis_Click(object sender, EventArgs e)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `reis` (`№`, `SityFly`, `SityFall`, `TimeFly`, `TimeFall`) VALUE (@num, @Sfly, @Sfall, @Tfly, @TFall);", connection);
           
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = textBoxNumR.Text;
            command.Parameters.Add("@Sfly", MySqlDbType.VarChar).Value = textBoxSFly.Text;
            command.Parameters.Add("@Sfall", MySqlDbType.VarChar).Value = textBoxSfall.Text;
            command.Parameters.Add("@Tfly", MySqlDbType.VarChar).Value = textBoxTfly.Text;
            command.Parameters.Add("@Tfall", MySqlDbType.VarChar).Value = textBoxTfall.Text;
           
            command.ExecuteNonQuery();

            connection.Close();

            GetReisDB();
        }

        private void GetReisDB()
        {
            connection = new MySqlConnection(server);
            connection.Open();
            dataGridReis.AutoGenerateColumns = false;
            NumReis.DataPropertyName = "№";
            SityFly.DataPropertyName = "SityFly";
            SityFall.DataPropertyName = "SityFall";
            TimeFly.DataPropertyName = "TimeFly";
            TimeFall.DataPropertyName = "TimeFall";
            IDReis.DataPropertyName = "ID";
            string infoDB = "SELECT * FROM reis";
            MySqlDataAdapter adpt = new MySqlDataAdapter(infoDB, connection);
            dataTable = new DataTable();
            adpt.Fill(dataTable);
            dataGridReis.DataSource = dataTable;
            connection.Close();
        }
    }
}
