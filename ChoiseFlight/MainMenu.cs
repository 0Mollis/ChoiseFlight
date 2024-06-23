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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToolStripDropDownButton toolStripDropDownButton1 = new ToolStripDropDownButton();

            var item1 = new ToolStripButton("my button");
            toolStripDropDownButton1.DropDownItems.Add(item1);

            var item2 = new ToolStripComboBox("my combo");
            toolStripDropDownButton1.DropDownItems.Add(item2);
        }

        private void AddDataToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(180, 211, 255);
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 84, 208);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(244, 244, 244);
            button1.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TicketsOrder ticketsOrder = new TicketsOrder();
            ticketsOrder.Show();
        }

        private void AddDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDataForm addDataForm = new AddDataForm();
            addDataForm.Show();
        }

        private void SeeDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChoseData choseData = new ChoseData();
            choseData.Show();
        }

        private void iExit()
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            iExit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.Show();
            this.Hide();
        }
    }
}
