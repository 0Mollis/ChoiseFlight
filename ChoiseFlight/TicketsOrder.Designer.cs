namespace ChoiseFlight
{
    partial class TicketsOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Chost = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.dateTimePickerFall = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFly = new System.Windows.Forms.DateTimePicker();
            this.textBoxReis2 = new System.Windows.Forms.TextBox();
            this.textBoxCompani2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.Chost);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonPay);
            this.panel1.Controls.Add(this.buttonOrder);
            this.panel1.Controls.Add(this.dateTimePickerFall);
            this.panel1.Controls.Add(this.dateTimePickerFly);
            this.panel1.Controls.Add(this.textBoxReis2);
            this.panel1.Controls.Add(this.textBoxCompani2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 393);
            this.panel1.TabIndex = 1;
            // 
            // Chost
            // 
            this.Chost.AutoSize = true;
            this.Chost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chost.ForeColor = System.Drawing.Color.White;
            this.Chost.Location = new System.Drawing.Point(449, 297);
            this.Chost.Name = "Chost";
            this.Chost.Size = new System.Drawing.Size(45, 20);
            this.Chost.TabIndex = 19;
            this.Chost.Text = "0000";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 383);
            this.progressBar1.Maximum = 600;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(601, 10);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(500, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "р. Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(350, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Дата возвращения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(350, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Дата вылета";
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(343, 329);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(94, 29);
            this.buttonPay.TabIndex = 14;
            this.buttonPay.Text = "Оплатить";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(443, 329);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(131, 29);
            this.buttonOrder.TabIndex = 13;
            this.buttonOrder.Text = "Забронировать";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // dateTimePickerFall
            // 
            this.dateTimePickerFall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerFall.Location = new System.Drawing.Point(354, 207);
            this.dateTimePickerFall.Name = "dateTimePickerFall";
            this.dateTimePickerFall.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerFall.TabIndex = 12;
            this.dateTimePickerFall.ValueChanged += new System.EventHandler(this.dateTimePickerFall_ValueChanged);
            // 
            // dateTimePickerFly
            // 
            this.dateTimePickerFly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerFly.Location = new System.Drawing.Point(354, 142);
            this.dateTimePickerFly.Name = "dateTimePickerFly";
            this.dateTimePickerFly.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerFly.TabIndex = 11;
            this.dateTimePickerFly.ValueChanged += new System.EventHandler(this.dateTimePickerFly_ValueChanged);
            // 
            // textBoxReis2
            // 
            this.textBoxReis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxReis2.Location = new System.Drawing.Point(43, 207);
            this.textBoxReis2.Name = "textBoxReis2";
            this.textBoxReis2.ReadOnly = true;
            this.textBoxReis2.Size = new System.Drawing.Size(227, 24);
            this.textBoxReis2.TabIndex = 10;
            // 
            // textBoxCompani2
            // 
            this.textBoxCompani2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCompani2.Location = new System.Drawing.Point(43, 142);
            this.textBoxCompani2.Name = "textBoxCompani2";
            this.textBoxCompani2.ReadOnly = true;
            this.textBoxCompani2.Size = new System.Drawing.Size(227, 24);
            this.textBoxCompani2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "№ Рейса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Авиакомпания";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(162)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.buttonBack);
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 100);
            this.panel2.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(55, 55);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(563, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(38, 38);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(182, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Заказ билетов";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TicketsOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 393);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(601, 393);
            this.MinimumSize = new System.Drawing.Size(601, 393);
            this.Name = "TicketsOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketsOrder";
            this.Load += new System.EventHandler(this.TicketsOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFall;
        private System.Windows.Forms.DateTimePicker dateTimePickerFly;
        private System.Windows.Forms.TextBox textBoxReis2;
        private System.Windows.Forms.TextBox textBoxCompani2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label Chost;
        private System.Windows.Forms.Timer timer1;
    }
}