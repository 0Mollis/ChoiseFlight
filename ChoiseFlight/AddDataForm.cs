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
            rowcount = dataGridCompani.Rows.Count;
            connection.Close();
        }
        int rowcount = 0;
        private void buttonSaveCompani_Click(object sender, EventArgs e)
        {//============================================================================================
            connection = new MySqlConnection(server);
            connection.Open();
            string infoDB = "SELECT id, name, year, raiting FROM compani";

            MySqlDataAdapter adapter2 = new MySqlDataAdapter(infoDB,connection);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter2);

            DataTable dataTable = new DataTable();
            //dataTable.Load(dataGridCompani.DataSource);
            
            MySqlDataAdapter adpt = new MySqlDataAdapter(infoDB, connection);


            int coulmneeded = 0;

            MySqlCommand command = new MySqlCommand("INSERT INTO `compani` (`name`, `year`, `raiting`) VALUE (@n, @year, @raiting);", connection);
            command.Parameters.Add("@year", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@raiting", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = textBox1.Text;
            command.ExecuteNonQuery(); 

            connection.Close();
        }

        private void buttonLoadReis_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(server);
            connection.Open();
            dataGridReis.AutoGenerateColumns=false;
            NumReis.DataPropertyName = "№";
            SityFly.DataPropertyName = "SityFly";
            SityFall.DataPropertyName = "SityFall";
            TimeFly.DataPropertyName = "TimeFly";
            TimeFall.DataPropertyName = "TimeFall";
            string infoDB = "SELECT * FROM reis";
            MySqlDataAdapter adpt = new MySqlDataAdapter(infoDB, connection);
            dataTable = new DataTable();
            adpt.Fill(dataTable);
            dataGridReis.DataSource = dataTable;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iDelete();//DELETE FROM `compani` WHERE `compani`.`id` = 2
        }

        private void iDelete()
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM `compani` WHERE `compani`.`id` = @id", connection);
            command.Parameters.Add("@id", MySqlDbType.Int16).Value = GetId();
            command.ExecuteNonQuery();
            connection.Close();

            dataGridCompani.Rows.RemoveAt(dataGridCompani.SelectedRows[0].Index);

        }

        private object GetId()
        {
            return dataGridCompani.SelectedRows[0].Cells[0].Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iDelete();
        }

        private void iExit()
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            iExit();
        }

        public static DataTable GetDTfromDGV(DataGridView dgv, int rowcount = 1, int colcount = 3)//row count used when rowpost paint used, default is zero...colcount is the coulmns needed to convert , default is 0
        {
            DataTable dt = new DataTable();
            int coulmneeded = dgv.Columns.Count - (dgv.Columns.Count - colcount);

            for (int ik = 0; ik < coulmneeded; ik++)
            {
                dt.Columns.Add(dgv.Columns[ik].HeaderText);
            }



            for (int i = 0; i < dgv.Rows.Count - rowcount; i++)
            {
                var dr = dt.NewRow();
                for (int j = 0; j < coulmneeded; j++)
                {
                    dr[j] = dgv.Rows[i].Cells[j].Value;
                }
                dt.Rows.Add(dr);
            }


            return dt;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void dataGridReis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSaveReis_Click(object sender, EventArgs e)
        {

        }

        private void dataGridCompani_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
