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
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.reis = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kompany.SuspendLayout();
            this.tabButton.SuspendLayout();
            this.company.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.reis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.kompany.Size = new System.Drawing.Size(984, 660);
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
            this.tabButton.Size = new System.Drawing.Size(984, 566);
            this.tabButton.TabIndex = 1;
            // 
            // company
            // 
            this.company.Controls.Add(this.buttonSave);
            this.company.Controls.Add(this.dataGridView2);
            this.company.Location = new System.Drawing.Point(4, 25);
            this.company.Name = "company";
            this.company.Padding = new System.Windows.Forms.Padding(3);
            this.company.Size = new System.Drawing.Size(976, 537);
            this.company.TabIndex = 0;
            this.company.Text = "Компания";
            this.company.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(371, 470);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "button1";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(970, 425);
            this.dataGridView2.TabIndex = 1;
            // 
            // reis
            // 
            this.reis.Controls.Add(this.dataGridView1);
            this.reis.Location = new System.Drawing.Point(4, 25);
            this.reis.Name = "reis";
            this.reis.Padding = new System.Windows.Forms.Padding(3);
            this.reis.Size = new System.Drawing.Size(976, 537);
            this.reis.TabIndex = 1;
            this.reis.Text = "Рейс";
            this.reis.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(970, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(162)))), ((int)(((byte)(163)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 94);
            this.panel2.TabIndex = 0;
            // 
            // AddDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 660);
            this.Controls.Add(this.kompany);
            this.Name = "AddDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDataForm";
            this.kompany.ResumeLayout(false);
            this.tabButton.ResumeLayout(false);
            this.company.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.reis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel kompany;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabButton;
        private System.Windows.Forms.TabPage company;
        private System.Windows.Forms.TabPage reis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonSave;
    }
}