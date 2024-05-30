namespace ChoiseFlight
{
    partial class AddDataForm
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
            this.kompany = new System.Windows.Forms.Panel();
            this.tabButton = new System.Windows.Forms.TabControl();
            this.company = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCompaniDelete = new System.Windows.Forms.Button();
            this.ButtonLoadCompani = new System.Windows.Forms.Button();
            this.buttonSaveCompani = new System.Windows.Forms.Button();
            this.dataGridCompani = new System.Windows.Forms.DataGridView();
            this.IDcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCompani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearCompani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReitingCompani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reis = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTfall = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTfly = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSfall = new System.Windows.Forms.TextBox();
            this.textBoxSFly = new System.Windows.Forms.TextBox();
            this.textBoxNumR = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonLoadReis = new System.Windows.Forms.Button();
            this.buttonSaveReis = new System.Windows.Forms.Button();
            this.dataGridReis = new System.Windows.Forms.DataGridView();
            this.IDReis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumReis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SityFly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SityFall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeFly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeFall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kompany.SuspendLayout();
            this.tabButton.SuspendLayout();
            this.company.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompani)).BeginInit();
            this.reis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReis)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kompany
            // 
            this.kompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(162)))), ((int)(((byte)(163)))));
            this.kompany.Controls.Add(this.tabButton);
            this.kompany.Controls.Add(this.panel2);
            this.kompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kompany.Location = new System.Drawing.Point(0, 0);
            this.kompany.Name = "kompany";
            this.kompany.Size = new System.Drawing.Size(1002, 655);
            this.kompany.TabIndex = 1;
            // 
            // tabButton
            // 
            this.tabButton.Controls.Add(this.company);
            this.tabButton.Controls.Add(this.reis);
            this.tabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabButton.ItemSize = new System.Drawing.Size(71, 21);
            this.tabButton.Location = new System.Drawing.Point(0, 94);
            this.tabButton.Margin = new System.Windows.Forms.Padding(0);
            this.tabButton.Name = "tabButton";
            this.tabButton.SelectedIndex = 0;
            this.tabButton.Size = new System.Drawing.Size(1002, 561);
            this.tabButton.TabIndex = 1;
            // 
            // company
            // 
            this.company.Controls.Add(this.label4);
            this.company.Controls.Add(this.label3);
            this.company.Controls.Add(this.label2);
            this.company.Controls.Add(this.textBox3);
            this.company.Controls.Add(this.textBox2);
            this.company.Controls.Add(this.textBox1);
            this.company.Controls.Add(this.buttonCompaniDelete);
            this.company.Controls.Add(this.ButtonLoadCompani);
            this.company.Controls.Add(this.buttonSaveCompani);
            this.company.Controls.Add(this.dataGridCompani);
            this.company.Location = new System.Drawing.Point(4, 25);
            this.company.Name = "company";
            this.company.Padding = new System.Windows.Forms.Padding(3);
            this.company.Size = new System.Drawing.Size(994, 532);
            this.company.TabIndex = 0;
            this.company.Text = "Компания";
            this.company.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Рейтинг компании";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Год основания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(346, 452);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 24);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(177, 452);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 24);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(8, 452);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 24);
            this.textBox1.TabIndex = 5;
            // 
            // buttonCompaniDelete
            // 
            this.buttonCompaniDelete.Location = new System.Drawing.Point(900, 482);
            this.buttonCompaniDelete.Name = "buttonCompaniDelete";
            this.buttonCompaniDelete.Size = new System.Drawing.Size(88, 44);
            this.buttonCompaniDelete.TabIndex = 4;
            this.buttonCompaniDelete.Text = "Удалить";
            this.buttonCompaniDelete.UseVisualStyleBackColor = true;
            this.buttonCompaniDelete.Click += new System.EventHandler(this.buttonCompaniDelete_Click);
            // 
            // ButtonLoadCompani
            // 
            this.ButtonLoadCompani.Location = new System.Drawing.Point(622, 482);
            this.ButtonLoadCompani.Name = "ButtonLoadCompani";
            this.ButtonLoadCompani.Size = new System.Drawing.Size(125, 44);
            this.ButtonLoadCompani.TabIndex = 3;
            this.ButtonLoadCompani.Text = "Загрузить БД";
            this.ButtonLoadCompani.UseVisualStyleBackColor = true;
            this.ButtonLoadCompani.Click += new System.EventHandler(this.ButtonLoadCompani_Click);
            // 
            // buttonSaveCompani
            // 
            this.buttonSaveCompani.Location = new System.Drawing.Point(753, 482);
            this.buttonSaveCompani.Name = "buttonSaveCompani";
            this.buttonSaveCompani.Size = new System.Drawing.Size(141, 44);
            this.buttonSaveCompani.TabIndex = 2;
            this.buttonSaveCompani.Text = "Сохранить БД";
            this.buttonSaveCompani.UseVisualStyleBackColor = true;
            this.buttonSaveCompani.Click += new System.EventHandler(this.buttonSaveCompani_Click);
            // 
            // dataGridCompani
            // 
            this.dataGridCompani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompani.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDcol,
            this.NameCompani,
            this.YearCompani,
            this.ReitingCompani});
            this.dataGridCompani.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridCompani.Location = new System.Drawing.Point(3, 3);
            this.dataGridCompani.Name = "dataGridCompani";
            this.dataGridCompani.RowHeadersWidth = 51;
            this.dataGridCompani.RowTemplate.Height = 24;
            this.dataGridCompani.Size = new System.Drawing.Size(988, 425);
            this.dataGridCompani.TabIndex = 1;
            // 
            // IDcol
            // 
            this.IDcol.HeaderText = "id";
            this.IDcol.MinimumWidth = 6;
            this.IDcol.Name = "IDcol";
            this.IDcol.Width = 125;
            // 
            // NameCompani
            // 
            this.NameCompani.HeaderText = "Название";
            this.NameCompani.MinimumWidth = 6;
            this.NameCompani.Name = "NameCompani";
            this.NameCompani.Width = 150;
            // 
            // YearCompani
            // 
            this.YearCompani.HeaderText = "Год основания";
            this.YearCompani.MinimumWidth = 6;
            this.YearCompani.Name = "YearCompani";
            this.YearCompani.Width = 150;
            // 
            // ReitingCompani
            // 
            this.ReitingCompani.HeaderText = "Рейтинг компании";
            this.ReitingCompani.MinimumWidth = 6;
            this.ReitingCompani.Name = "ReitingCompani";
            this.ReitingCompani.Width = 160;
            // 
            // reis
            // 
            this.reis.Controls.Add(this.label9);
            this.reis.Controls.Add(this.textBoxTfall);
            this.reis.Controls.Add(this.label8);
            this.reis.Controls.Add(this.textBoxTfly);
            this.reis.Controls.Add(this.label5);
            this.reis.Controls.Add(this.label6);
            this.reis.Controls.Add(this.label7);
            this.reis.Controls.Add(this.textBoxSfall);
            this.reis.Controls.Add(this.textBoxSFly);
            this.reis.Controls.Add(this.textBoxNumR);
            this.reis.Controls.Add(this.button2);
            this.reis.Controls.Add(this.buttonLoadReis);
            this.reis.Controls.Add(this.buttonSaveReis);
            this.reis.Controls.Add(this.dataGridReis);
            this.reis.Location = new System.Drawing.Point(4, 25);
            this.reis.Name = "reis";
            this.reis.Padding = new System.Windows.Forms.Padding(3);
            this.reis.Size = new System.Drawing.Size(994, 532);
            this.reis.TabIndex = 1;
            this.reis.Text = "Рейс";
            this.reis.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(729, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Время прилёта";
            // 
            // textBoxTfall
            // 
            this.textBoxTfall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTfall.Location = new System.Drawing.Point(732, 453);
            this.textBoxTfall.Name = "textBoxTfall";
            this.textBoxTfall.Size = new System.Drawing.Size(139, 24);
            this.textBoxTfall.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(584, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Время вылета";
            // 
            // textBoxTfly
            // 
            this.textBoxTfly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTfly.Location = new System.Drawing.Point(587, 453);
            this.textBoxTfly.Name = "textBoxTfly";
            this.textBoxTfly.Size = new System.Drawing.Size(139, 24);
            this.textBoxTfly.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Город прилёта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Город вылета";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Номер рейса";
            // 
            // textBoxSfall
            // 
            this.textBoxSfall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSfall.Location = new System.Drawing.Point(382, 453);
            this.textBoxSfall.Name = "textBoxSfall";
            this.textBoxSfall.Size = new System.Drawing.Size(199, 24);
            this.textBoxSfall.TabIndex = 13;
            // 
            // textBoxSFly
            // 
            this.textBoxSFly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSFly.Location = new System.Drawing.Point(177, 453);
            this.textBoxSFly.Name = "textBoxSFly";
            this.textBoxSFly.Size = new System.Drawing.Size(199, 24);
            this.textBoxSFly.TabIndex = 12;
            // 
            // textBoxNumR
            // 
            this.textBoxNumR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumR.Location = new System.Drawing.Point(8, 453);
            this.textBoxNumR.Name = "textBoxNumR";
            this.textBoxNumR.Size = new System.Drawing.Size(163, 24);
            this.textBoxNumR.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(900, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonLoadReis
            // 
            this.buttonLoadReis.Location = new System.Drawing.Point(622, 482);
            this.buttonLoadReis.Name = "buttonLoadReis";
            this.buttonLoadReis.Size = new System.Drawing.Size(125, 44);
            this.buttonLoadReis.TabIndex = 5;
            this.buttonLoadReis.Text = "Загрузить БД";
            this.buttonLoadReis.UseVisualStyleBackColor = true;
            this.buttonLoadReis.Click += new System.EventHandler(this.buttonLoadReis_Click);
            // 
            // buttonSaveReis
            // 
            this.buttonSaveReis.Location = new System.Drawing.Point(753, 482);
            this.buttonSaveReis.Name = "buttonSaveReis";
            this.buttonSaveReis.Size = new System.Drawing.Size(141, 44);
            this.buttonSaveReis.TabIndex = 4;
            this.buttonSaveReis.Text = "Сохранить БД";
            this.buttonSaveReis.UseVisualStyleBackColor = true;
            this.buttonSaveReis.Click += new System.EventHandler(this.buttonSaveReis_Click);
            // 
            // dataGridReis
            // 
            this.dataGridReis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDReis,
            this.NumReis,
            this.SityFly,
            this.SityFall,
            this.TimeFly,
            this.TimeFall});
            this.dataGridReis.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridReis.Location = new System.Drawing.Point(3, 3);
            this.dataGridReis.Name = "dataGridReis";
            this.dataGridReis.RowHeadersWidth = 51;
            this.dataGridReis.RowTemplate.Height = 24;
            this.dataGridReis.Size = new System.Drawing.Size(988, 425);
            this.dataGridReis.TabIndex = 0;
            // 
            // IDReis
            // 
            this.IDReis.HeaderText = "id";
            this.IDReis.MinimumWidth = 6;
            this.IDReis.Name = "IDReis";
            this.IDReis.Width = 70;
            // 
            // NumReis
            // 
            this.NumReis.HeaderText = "Номер рейса";
            this.NumReis.MinimumWidth = 6;
            this.NumReis.Name = "NumReis";
            this.NumReis.Width = 125;
            // 
            // SityFly
            // 
            this.SityFly.HeaderText = "Город вылета";
            this.SityFly.MinimumWidth = 6;
            this.SityFly.Name = "SityFly";
            this.SityFly.Width = 125;
            // 
            // SityFall
            // 
            this.SityFall.HeaderText = "Город прилёта";
            this.SityFall.MinimumWidth = 6;
            this.SityFall.Name = "SityFall";
            this.SityFall.Width = 125;
            // 
            // TimeFly
            // 
            this.TimeFly.HeaderText = "Время вылета";
            this.TimeFly.MinimumWidth = 6;
            this.TimeFly.Name = "TimeFly";
            this.TimeFly.Width = 121;
            // 
            // TimeFall
            // 
            this.TimeFall.HeaderText = "Время прилёта";
            this.TimeFall.MinimumWidth = 6;
            this.TimeFall.Name = "TimeFall";
            this.TimeFall.Width = 121;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(162)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.buttonBack);
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 94);
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
            this.ExitButton.Location = new System.Drawing.Point(964, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(38, 38);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(342, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление данных";
            // 
            // AddDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 655);
            this.Controls.Add(this.kompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1002, 655);
            this.MinimumSize = new System.Drawing.Size(1002, 655);
            this.Name = "AddDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDataForm";
            this.kompany.ResumeLayout(false);
            this.tabButton.ResumeLayout(false);
            this.company.ResumeLayout(false);
            this.company.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompani)).EndInit();
            this.reis.ResumeLayout(false);
            this.reis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReis)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel kompany;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabButton;
        private System.Windows.Forms.TabPage company;
        private System.Windows.Forms.TabPage reis;
        private System.Windows.Forms.DataGridView dataGridReis;
        private System.Windows.Forms.DataGridView dataGridCompani;
        private System.Windows.Forms.Button buttonSaveCompani;
        private System.Windows.Forms.Button ButtonLoadCompani;
        private System.Windows.Forms.Button buttonLoadReis;
        private System.Windows.Forms.Button buttonSaveReis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCompaniDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCompani;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearCompani;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReitingCompani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSfall;
        private System.Windows.Forms.TextBox textBoxSFly;
        private System.Windows.Forms.TextBox textBoxNumR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTfall;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTfly;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDReis;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumReis;
        private System.Windows.Forms.DataGridViewTextBoxColumn SityFly;
        private System.Windows.Forms.DataGridViewTextBoxColumn SityFall;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeFly;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeFall;
    }
}