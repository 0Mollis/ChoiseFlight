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
    public partial class TicketsOrder : Form
    {
        public TicketsOrder()
        {
            InitializeComponent();
            connection = new MySqlConnection(server);
            Check();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            iExit();
        }

        private void iExit()
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
        
        public void GetInfo()
        {
            textBoxCompani2.Text = Buffer.CompaniTxtBox;

            textBoxReis2.Text = Buffer.ReisTxtBox;
            dateTimePickerFly.MinDate = DateTime.Now;
        }

        public void Check()
        {
            if (Buffer.CompaniTxtBox == "Выберите авиакомпанию")
            {
                if (Buffer.CompaniTxtBox == "Выберите авиакомпанию" && Buffer.ReisTxtBox == "Выберите номер рейса")
                {
                    MessageBox.Show("Вы не выбрали авиакомпанию и номер рейса", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else MessageBox.Show("Вы не выбрали авиакомпанию", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (Buffer.ReisTxtBox == "Выберите номер рейса")
            {
                MessageBox.Show("Вы не выбрали номер рейса", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TicketsOrder_Load(object sender, EventArgs e)
        {
            GetInfo();
            buttonFalse();
            progressHide();
        }

        public void progressHide()
        {
            progressBar1.Visible = false;
        }

        private void dateTimePickerFall_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFly.Value>dateTimePickerFall.Value)
            {
                MessageBox.Show("Ошибка дата прилёта не может быть раньше даты вылета", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerFall.Value = dateTimePickerFly.Value;
            }

            CheckPrice();

        }

        private void dateTimePickerFly_ValueChanged(object sender, EventArgs e)
        {
            CheckPrice();
        }

        public void CheckPrice()
        {
            if (dateTimePickerFly.Value > dateTimePickerFall.Value)
            {
                dateTimePickerFall.Value = dateTimePickerFly.Value;
            }

            int price = Buffer.BChost;
            bool checkweek1 = true;
            bool checkweek2 = true;

            if (dateTimePickerFall.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                price = (price / 100) * 110;
                checkweek1 = false;
                checkweek2 = false;
            }
            if (dateTimePickerFall.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                if (checkweek1) 
                { 
                    price = (price / 100) * 110;
                    checkweek1 = false;
                    checkweek2 = false;
                }
            }
            if (dateTimePickerFly.Value.DayOfWeek == DayOfWeek.Saturday && checkweek2)
            {
                price = (price / 100) * 110;
                checkweek1 = false;
                checkweek2 = false;
            }
            if (dateTimePickerFly.Value.DayOfWeek == DayOfWeek.Sunday && checkweek2)
            {
                price = (price / 100) * 110;
                checkweek1 = false;
                checkweek2 = false;
            }
            Chost.Text = price.ToString();
        }
        
        public void buttonFalse()
        {
            buttonPay.Enabled = false;
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            progress = 0;
            mseconds = 600;
            buttonPay.Enabled = true;
            timer1.Start();
            progressBar1.Visible = true;
            buttonOrder.Enabled = false;
        }
        int progress;
        int mseconds; 
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //label7.Text = mseconds--.ToString();
            mseconds--;
            progress++;
            progressBar1.Value = progress;            
            
            if (mseconds <= 0)
            {
                
                timer1.Stop();
                MessageBox.Show("Вы не успели оплатить", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Buffer.pay = true;
                Buffer.bookings.Clear();
                progressBar1.Visible=false;
                buttonPay.Enabled=false;
                buttonOrder.Enabled=true;
                dateTimePickerFly.Value = DateTime.Now;
                dateTimePickerFall.Value = DateTime.Now;
                Buffer.CompaniTxtBox = "Выберите авиакомпанию";
                Buffer.ReisTxtBox = "Выберите номер рейса";
                textBoxCompani2.Text = "Выберите авиакомпанию";
                textBoxReis2.Text = "Выберите номер рейса";
            }
        }

        public string server = "Server=localhost;Database=aeroport;Uid=root;pwd=root;charset=utf8;";
        public MySqlConnection connection;
        public MySqlCommand command;

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (Buffer.pay == false)
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("INSERT INTO `bookingBD` (`Book1`, `Book2`, `Book3`, `Book4`, `Book5`, `Beco`, `Bbusiness`) VALUE (@b1, @b2, @b3, @b4, @b5, @be, @bb);", connection);

                command.Parameters.Add("@b1", MySqlDbType.VarChar).Value = Buffer.bookings[0];
                command.Parameters.Add("@b2", MySqlDbType.VarChar).Value = Buffer.bookings[1];
                command.Parameters.Add("@b3", MySqlDbType.VarChar).Value = Buffer.bookings[2];
                command.Parameters.Add("@b4", MySqlDbType.VarChar).Value = Buffer.bookings[3];
                command.Parameters.Add("@b5", MySqlDbType.VarChar).Value = Buffer.bookings[4];
                command.Parameters.Add("@be", MySqlDbType.VarChar).Value = Buffer.inBDbe.ToString();
                command.Parameters.Add("@bb", MySqlDbType.VarChar).Value = Buffer.inBDbb.ToString();

                command.ExecuteNonQuery();

                connection.Close();

                Buffer.bookings.Clear();

                Buffer.pay = true;

                this.Close();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                MessageBox.Show("Оплачено :)", "", MessageBoxButtons.OK);

            }
        }
    }
}
