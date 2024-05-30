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
            if (Buffer.CompaniTxtBox == "Выберите авиакомпанию" && Buffer.ReisTxtBox == "Выберите номер рейса")
            {
                MessageBox.Show("Вы не выбрали авиакомпанию и номер рейса", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Buffer.CheckString = false;
            }
            //else if (Buffer.CheckString == true && Buffer.CompaniTxtBox == "Выберите авиакомпанию")
            //{
            //    MessageBox.Show("Вы не выбрали авиакомпанию", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else if (Buffer.CheckString == true && Buffer.ReisTxtBox == "Выберите номер рейса")
            //{
            //    MessageBox.Show("Вы не выбрали номер рейса", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //} не проверяет эти if, ничего ни делает
        }

        private void TicketsOrder_Load(object sender, EventArgs e)
        {
            GetInfo();
            Check();
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
                MessageBox.Show("Ошибка дата посадки не может быть раньше даты вылета", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerFall.Value = DateTime.Now;
            }

            CheckPrice();

        }

        private void dateTimePickerFly_ValueChanged(object sender, EventArgs e)
        {
            CheckPrice();
        }

        public void CheckPrice()
        {
            int price = 1000;

            if (dateTimePickerFall.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                if (price < 1100)
                {
                    price += 100;
                }

            }
            if (dateTimePickerFall.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                if (price < 1100)
                {
                    price += 100;
                }

            }
            if (dateTimePickerFly.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                if (price < 1100)
                {
                    price += 100;
                }

            }
            if (dateTimePickerFly.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                if (price < 1100)
                {
                    price += 100;
                }
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
            if (mseconds <= 0)
            {
                timer1.Stop();
                progressBar1.Visible=false;
                buttonPay.Enabled=false;
                buttonOrder.Enabled=true;
            }

            progress++;
            progressBar1.Value = progress;


        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu(); 
            mainMenu.Show();
            MessageBox.Show("Оплачено :)", "", MessageBoxButtons.OK);
        }
    }
}
