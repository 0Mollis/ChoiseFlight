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
            this.ButtonLoadCompani = new System.Windows.Forms.Button();
            this.buttonSaveCompani = new System.Windows.Forms.Button();
            this.dataGridCompani = new System.Windows.Forms.DataGridView();
            this.reis = new System.Windows.Forms.TabPage();
            this.buttonLoadReis = new System.Windows.Forms.Button();
            this.buttonSaveReis = new System.Windows.Forms.Button();
            this.dataGridReis = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NameCompani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearCompani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReitingCompani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumReis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SityFly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SityFall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeFly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeFall = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.kompany.Size = new System.Drawing.Size(984, 608);
            this.kompany.TabIndex = 1;
            // 
            // tabButton
            // 
            this.tabButton.Controls.Add(this.company);
            this.tabButton.Controls.Add(this.reis);
            this.tabButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabButton.ItemSize = new System.Drawing.Size(71, 21);
            this.tabButton.Location = new System.Drawing.Point(0, 94);
            this.tabButton.Margin = new System.Windows.Forms.Padding(0);
            this.tabButton.Name = "tabButton";
            this.tabButton.SelectedIndex = 0;
            this.tabButton.Size = new System.Drawing.Size(984, 514);
            this.tabButton.TabIndex = 1;
            // 
            // company
            // 
            this.company.Controls.Add(this.button1);
            this.company.Controls.Add(this.ButtonLoadCompani);
            this.company.Controls.Add(this.buttonSaveCompani);
            this.company.Controls.Add(this.dataGridCompani);
            this.company.Location = new System.Drawing.Point(4, 25);
            this.company.Name = "company";
            this.company.Padding = new System.Windows.Forms.Padding(3);
            this.company.Size = new System.Drawing.Size(976, 485);
            this.company.TabIndex = 0;
            this.company.Text = "Компания";
            this.company.UseVisualStyleBackColor = true;
            // 
            // ButtonLoadCompani
            // 
            this.ButtonLoadCompani.Location = new System.Drawing.Point(632, 434);
            this.ButtonLoadCompani.Name = "ButtonLoadCompani";
            this.ButtonLoadCompani.Size = new System.Drawing.Size(114, 44);
            this.ButtonLoadCompani.TabIndex = 3;
            this.ButtonLoadCompani.Text = "Загрузить БД";
            this.ButtonLoadCompani.UseVisualStyleBackColor = true;
            this.ButtonLoadCompani.Click += new System.EventHandler(this.ButtonLoadCompani_Click);
            // 
            // buttonSaveCompani
            // 
            this.buttonSaveCompani.Location = new System.Drawing.Point(752, 434);
            this.buttonSaveCompani.Name = "buttonSaveCompani";
            this.buttonSaveCompani.Size = new System.Drawing.Size(127, 44);
            this.buttonSaveCompani.TabIndex = 2;
            this.buttonSaveCompani.Text = "Сохранить БД";
            this.buttonSaveCompani.UseVisualStyleBackColor = true;
            this.buttonSaveCompani.Click += new System.EventHandler(this.buttonSaveCompani_Click);
            // 
            // dataGridCompani
            // 
            this.dataGridCompani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompani.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCompani,
            this.YearCompani,
            this.ReitingCompani});
            this.dataGridCompani.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridCompani.Location = new System.Drawing.Point(3, 3);
            this.dataGridCompani.Name = "dataGridCompani";
            this.dataGridCompani.RowHeadersWidth = 51;
            this.dataGridCompani.RowTemplate.Height = 24;
            this.dataGridCompani.Size = new System.Drawing.Size(970, 425);
            this.dataGridCompani.TabIndex = 1;
            // 
            // reis
            // 
            this.reis.Controls.Add(this.button2);
            this.reis.Controls.Add(this.buttonLoadReis);
            this.reis.Controls.Add(this.buttonSaveReis);
            this.reis.Controls.Add(this.dataGridReis);
            this.reis.Location = new System.Drawing.Point(4, 25);
            this.reis.Name = "reis";
            this.reis.Padding = new System.Windows.Forms.Padding(3);
            this.reis.Size = new System.Drawing.Size(976, 485);
            this.reis.TabIndex = 1;
            this.reis.Text = "Рейс";
            this.reis.UseVisualStyleBackColor = true;
            // 
            // buttonLoadReis
            // 
            this.buttonLoadReis.Location = new System.Drawing.Point(632, 435);
            this.buttonLoadReis.Name = "buttonLoadReis";
            this.buttonLoadReis.Size = new System.Drawing.Size(114, 44);
            this.buttonLoadReis.TabIndex = 5;
            this.buttonLoadReis.Text = "Загрузить БД";
            this.buttonLoadReis.UseVisualStyleBackColor = true;
            this.buttonLoadReis.Click += new System.EventHandler(this.buttonLoadReis_Click);
            // 
            // buttonSaveReis
            // 
            this.buttonSaveReis.Location = new System.Drawing.Point(752, 435);
            this.buttonSaveReis.Name = "buttonSaveReis";
            this.buttonSaveReis.Size = new System.Drawing.Size(127, 44);
            this.buttonSaveReis.TabIndex = 4;
            this.buttonSaveReis.Text = "Сохранить БД";
            this.buttonSaveReis.UseVisualStyleBackColor = true;
            // 
            // dataGridReis
            // 
            this.dataGridReis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridReis.Size = new System.Drawing.Size(970, 425);
            this.dataGridReis.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(162)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 94);
            this.panel2.TabIndex = 0;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(885, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(885, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NameCompani
            // 
            this.NameCompani.HeaderText = "Название";
            this.NameCompani.MinimumWidth = 6;
            this.NameCompani.Name = "NameCompani";
            this.NameCompani.Width = 125;
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
            // NumReis
            // 
            this.NumReis.HeaderText = "Номер рейса";
            this.NumReis.MinimumWidth = 6;
            this.NumReis.Name = "NumReis";
            this.NumReis.Width = 123;
            // 
            // SityFly
            // 
            this.SityFly.HeaderText = "Город вылета";
            this.SityFly.MinimumWidth = 6;
            this.SityFly.Name = "SityFly";
            this.SityFly.Width = 150;
            // 
            // SityFall
            // 
            this.SityFall.HeaderText = "Город прилёта";
            this.SityFall.MinimumWidth = 6;
            this.SityFall.Name = "SityFall";
            this.SityFall.Width = 150;
            // 
            // TimeFly
            // 
            this.TimeFly.HeaderText = "Время вылета";
            this.TimeFly.MinimumWidth = 6;
            this.TimeFly.Name = "TimeFly";
            this.TimeFly.Width = 125;
            // 
            // TimeFall
            // 
            this.TimeFall.HeaderText = "Время прилёта";
            this.TimeFall.MinimumWidth = 6;
            this.TimeFall.Name = "TimeFall";
            this.TimeFall.Width = 125;
            // 
            // AddDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 608);
            this.Controls.Add(this.kompany);
            this.Name = "AddDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDataForm";
            this.kompany.ResumeLayout(false);
            this.tabButton.ResumeLayout(false);
            this.company.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompani)).EndInit();
            this.reis.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCompani;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearCompani;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReitingCompani;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumReis;
        private System.Windows.Forms.DataGridViewTextBoxColumn SityFly;
        private System.Windows.Forms.DataGridViewTextBoxColumn SityFall;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeFly;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeFall;
    }
}