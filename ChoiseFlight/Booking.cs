using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            BookingCheck();
        }

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


        public void BookingCheck()
        {
            if (Buffer.bookings.Count != 0)
            {
                for (int i = 0; i < Buffer.bookings.Count; i++)
                {
                    Control foundButton = FindControlByName(this, $"{Buffer.bookings[i]}");
                    if (foundButton != null)
                    {
                        foundButton.BackColor = Color.Gray;
                        foundButton.Enabled = false;
                    }
                }
            }
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            int counts = 0;
            if (PChose1.Text != "A00"){ Buffer.bookings.Add(PChose1.Text); counts++; }
            if (PChose2.Text != "A00"){ Buffer.bookings.Add(PChose2.Text); counts++; }
            if (PChose3.Text != "A00"){ Buffer.bookings.Add(PChose3.Text); counts++; }
            if (PChose4.Text != "A00"){ Buffer.bookings.Add(PChose4.Text); counts++; }
            if (PChose5.Text != "A00"){ Buffer.bookings.Add(PChose5.Text); counts++; }
            Buffer.BChost = Convert.ToInt32(Price.Text);
            if(counts != 0)
            {
                Buffer.Beco = Beco;
                Buffer.Bbusiness = Bbusiness;

                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Close();
            }
        }

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

            labelEco.Text = Buffer.Beco.ToString();
            labelBusiness.Text = Buffer.Bbusiness.ToString();
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

        public int Beco = Buffer.Beco;
        public int Bbusiness = Buffer.Bbusiness;

        public void Chose(Button btn)
        {
            if (btn.BackColor == Color.Lime && MaxChose < 5)
            {
                btn.BackColor = Color.Gold;
                MaxChose++;
                Beco--;
                ChoseInfoAdd(btn);
            }
            else if (btn.BackColor == Color.FromArgb(0, 192, 0) && MaxChose < 5)
            {
                btn.BackColor = Color.FromArgb(255, 220, 0);
                MaxChose++;
                Bbusiness--;
                ChoseInfoAdd(btn);
            }
            else if (btn.BackColor == Color.FromArgb(255, 220, 0))
            {
                btn.BackColor = Color.FromArgb(0, 192, 0);
                MaxChose--;
                Bbusiness++;
                ChoseInfoDel(btn);
                PriceF();
            }
            else if (btn.BackColor == Color.Gold)
            {
                btn.BackColor = Color.Lime;
                MaxChose--;
                Beco++;
                ChoseInfoDel(btn);
                PriceF();
            }
        }

        private void F01_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F02_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F03_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F04_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F05_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F06_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F07_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F08_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F09_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F10_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F11_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F12_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F13_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F14_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F15_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F16_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F17_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F18_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F19_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F20_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F21_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F22_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F23_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F24_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F25_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F26_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F27_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void F28_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E03_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E04_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E05_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E06_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E07_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E08_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E09_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E10_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E11_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E12_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E13_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E14_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E15_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E16_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E17_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E18_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E19_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E20_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E21_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E22_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E23_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E24_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E25_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E26_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E27_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void E28_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D01_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D02_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D03_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D04_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D05_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D06_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D07_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D08_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D09_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D10_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D11_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D12_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D13_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D14_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D15_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D16_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D17_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D18_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D19_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D20_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D21_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D22_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D23_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D24_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D25_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D26_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D27_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void D28_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C01_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C02_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C03_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C04_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C05_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C06_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C07_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C08_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C09_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C10_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C11_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C12_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C13_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C14_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C15_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C16_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C17_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C18_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C19_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C20_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C21_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C22_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C23_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C24_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C25_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C26_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C27_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void C28_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B03_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B04_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B05_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B06_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B07_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B08_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B09_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B10_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B11_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B12_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B13_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B14_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B15_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B16_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B17_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B18_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B19_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B20_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B21_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B22_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B23_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B24_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B25_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B26_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B27_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void B28_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A01_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A02_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A03_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A04_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A05_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A06_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A07_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A08_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A09_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A10_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A11_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A12_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A13_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A14_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A15_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A16_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A17_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A18_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A19_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A20_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A21_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A22_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A23_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A24_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A25_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A26_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A27_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void A28_Click(object sender, EventArgs e)
        {
            Chose((Button)sender);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
