using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoiseFlight
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
            Places();
            PriceF();
            connection = new MySqlConnection(server);
            BookingCheck();
        }

        public string server = "Server=localhost;Database=aeroport;Uid=root;pwd=root;charset=utf8;";
        public MySqlConnection connection;
        public MySqlCommand command;

        private Control FindControlByName(Control container, string name)
        {
            if (container.Name == name)
            {
                return container;
            }

            foreach (Control childControl in container.Controls)
            {
                Control result = FindControlByName(childControl, name);
                if (result != null)
                {
                    return result;
                }
            }
            return null;
        }

        public int A()
        {
            MySqlCommand myCommand = new MySqlCommand("SELECT count(id) FROM `bookingbd`", connection);

            connection.Open();

            string count = (string)myCommand.ExecuteScalar().ToString();

            connection.Close();

            return Convert.ToInt32(count);
        }

        public void BookingCheck()
        {
            int count = A();
            for (int i = 1; i <= count; i++)
            {                  
                connection = new MySqlConnection(server);
                string bookingDB = $"SELECT `Book1`, `Book2`, `Book3`, `Book4`, `Book5`, `Beco`, `Bbusiness` FROM `bookingbd` WHERE id = {i}";
                command = new MySqlCommand(bookingDB, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int j = 0; j < 5; j++) 
                    {                     
                        string result = reader.GetString(j);
                        Buffer.bookingsDB.Add(result);
                        if(j == 0)
                        {
                            string DBBeco = reader.GetString(5);
                            string DBBbusines = reader.GetString(6);   
                            Buffer.Beco += Convert.ToInt32(DBBeco);
                            Buffer.Bbusiness += Convert.ToInt32(DBBbusines);  
                        }                      
                    }
                }

                reader.Close();

            }
            connection.Close();

            if (Buffer.bookingsDB.Count != 0)
            {
                for (int i = 0; i < Buffer.bookingsDB.Count; i++)
                {
                    Control foundButton = FindControlByName(this, $"{Buffer.bookingsDB[i]}");
                    if (foundButton != null)
                    {
                        foundButton.BackColor = Color.Gray;
                        foundButton.Enabled = false;
                    }
                }
            }

            int be = Beco - Buffer.Beco;
            int bb = Bbusiness - Buffer.Bbusiness;

            labelEco.Text = be.ToString();
            labelBusiness.Text = bb.ToString();
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            int counts = 0;
            if (Buffer.pay)
            {
                Buffer.bookings.Add(PChose1.Text); counts++;
                Buffer.bookings.Add(PChose2.Text); counts++; 
                Buffer.bookings.Add(PChose3.Text); counts++; 
                Buffer.bookings.Add(PChose4.Text); counts++; 
                Buffer.bookings.Add(PChose5.Text); counts++; 
                Buffer.pay = false;
                Buffer.Beco = 0;
                Buffer.Bbusiness = 0;
            }

            Buffer.BChost = Convert.ToInt32(Price.Text);
            if(counts != 0)
            {
                Buffer.inBDbe = inBDbe;
                Buffer.inBDbb = inBDbb;

                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Close();
            }
        }

        public int inBDbe = 0;
        public int inBDbb = 0;

        private void iExit()
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            iExit();
        }

        public int MaxChose;

        public void Places()
        {
            Nreis.Text = Buffer.ReisTxtBox.ToString();
        }

        public void ChoseInfoAdd(Button btn)
        {
            if (PChose1.Visible == false)
            {
                PriceChose(btn);
                Pprice1.Text = PriceCh.ToString();
                PChose1.Text = btn.Name;
                PChose1.Visible = true;
                Ptire1.Visible = true;
                Pprice1.Visible = true;
                PriceF();
            }
            else if (PChose2.Visible == false)
            {
                PriceChose(btn);
                Pprice2.Text = PriceCh.ToString();
                PChose2.Text = btn.Name;
                PChose2.Visible = true;
                Ptire2.Visible = true;
                Pprice2.Visible = true;
                PriceF();
            }
            else if (PChose3.Visible == false)
            {
                PriceChose(btn);
                Pprice3.Text = PriceCh.ToString();
                PChose3.Text = btn.Name;
                PChose3.Visible = true;
                Ptire3.Visible = true;
                Pprice3.Visible = true;
                PriceF();
            }
            else if (PChose4.Visible == false)
            {
                PriceChose(btn);
                Pprice4.Text = PriceCh.ToString();
                PChose4.Text = btn.Name;
                PChose4.Visible = true;
                Ptire4.Visible = true;
                Pprice4.Visible = true;
                PriceF();
            }
            else if (PChose5.Visible == false)
            {
                PriceChose(btn);
                Pprice5.Text = PriceCh.ToString();
                PChose5.Text = btn.Name;
                PChose5.Visible = true;
                Ptire5.Visible = true;
                Pprice5.Visible = true;
                PriceF();
            }
        }

        public void ChoseInfoDel(Button btn)
        {
            if (btn.Name == PChose1.Text)
            {
                Ptire1.Visible = false;
                Pprice1.Visible = false;
                PChose1.Visible = false;
                PChose1.Text = "A00";
                Pprice1.Text = "0";
            }
            else if (btn.Name == PChose2.Text)
            {
                Ptire2.Visible = false;
                Pprice2.Visible = false;
                PChose2.Visible = false;
                PChose2.Text = "A00";
                Pprice2.Text = "0";
            }
            else if (btn.Name == PChose3.Text)
            {
                Ptire3.Visible = false;
                Pprice3.Visible = false;
                PChose3.Visible = false;
                PChose3.Text = "A00";
                Pprice3.Text = "0";
            }
            else if (btn.Name == PChose4.Text)
            {
                Ptire4.Visible = false;
                Pprice4.Visible = false;
                PChose4.Visible = false;
                PChose4.Text = "A00";
                Pprice4.Text = "0";
            }
            else if (btn.Name == PChose5.Text)
            {
                Ptire5.Visible = false;
                Pprice5.Visible = false;
                PChose5.Visible = false;
                PChose5.Text = "A00";
                Pprice5.Text = "0";
            }
        }

        public string PriceCh;

        public void PriceChose(Button btn)
        {
            if (btn.Name == "F01")
            {
                PriceCh = "15000";
            }
            else if (btn.Name == "F02")
            {
                PriceCh = "15000";
            }
            else if (btn.Name == "D01")
            {
                PriceCh = "15000";
            }
            else if (btn.Name == "D02")
            {
                PriceCh = "15000";
            }
            else if (btn.Name == "C01")
            {
                PriceCh = "15000";
            }
            else if (btn.Name == "C02")
            {
                PriceCh = "15000";
            }
            else if (btn.Name == "A01")
            {
                PriceCh = "15000";
            }
            else if (btn.Name == "A02")
            {
                PriceCh = "15000";
            }
            else
            {
                PriceCh = "6200";
            }
        }

        public void PriceF()
        {
            int Chost = Convert.ToInt32(Pprice1.Text) + Convert.ToInt32(Pprice2.Text) + Convert.ToInt32(Pprice3.Text) + Convert.ToInt32(Pprice4.Text) + Convert.ToInt32(Pprice5.Text);
            Price.Text = Chost.ToString(); 

        }
//
        public int Beco = 156;
        public int Bbusiness = 8;

        public void Chose(object sender, EventArgs e)
        {
            if(sender is Button btn)
            {
                if (btn.BackColor == Color.Lime && MaxChose < 5)
                {
                    btn.BackColor = Color.Gold;
                    MaxChose++;
                    inBDbe++;
                    ChoseInfoAdd(btn);
                }
                else if (btn.BackColor == Color.FromArgb(0, 192, 0) && MaxChose < 5)
                {
                    btn.BackColor = Color.FromArgb(255, 220, 0);
                    MaxChose++;
                    inBDbb++;
                    ChoseInfoAdd(btn);
                }
                else if (btn.BackColor == Color.FromArgb(255, 220, 0))
                {
                    btn.BackColor = Color.FromArgb(0, 192, 0);
                    MaxChose--;
                    inBDbb--;
                    ChoseInfoDel(btn);
                    PriceF();
                }
                else if (btn.BackColor == Color.Gold)
                {
                    btn.BackColor = Color.Lime;
                    MaxChose--;
                    inBDbe--;
                    ChoseInfoDel(btn);
                    PriceF();
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Buffer.Beco = 0;
            Buffer.Bbusiness = 0;
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

    }
}
