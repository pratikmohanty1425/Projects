namespace Clinic_Managment_System
{
    partial class Medicine_Window
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.medicinetext = new System.Windows.Forms.TextBox();
            this.companytext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeDD = new System.Windows.Forms.ComboBox();
            this.costtext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.leftpanel.SuspendLayout();
            this.topleftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.toprightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(723, 84);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Size = new System.Drawing.Size(723, 632);
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.costtext);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.typeDD);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.companytext);
            this.leftpanel.Controls.Add(this.label2);
            this.leftpanel.Controls.Add(this.medicinetext);
            this.leftpanel.Controls.Add(this.label1);
            this.leftpanel.Size = new System.Drawing.Size(256, 776);
            this.leftpanel.Controls.SetChildIndex(this.label1, 0);
            this.leftpanel.Controls.SetChildIndex(this.medicinetext, 0);
            this.leftpanel.Controls.SetChildIndex(this.label2, 0);
            this.leftpanel.Controls.SetChildIndex(this.companytext, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.typeDD, 0);
            this.leftpanel.Controls.SetChildIndex(this.topleftpanel, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.costtext, 0);
            // 
            // backbutton
            // 
            this.backbutton.FlatAppearance.BorderSize = 0;
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(723, 776);
            // 
            // toprightpanel
            // 
            this.toprightpanel.Size = new System.Drawing.Size(723, 60);
            // 
            // userlabel
            // 
            this.userlabel.Size = new System.Drawing.Size(60, 30);
            this.userlabel.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(18, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Medicine";
            // 
            // medicinetext
            // 
            this.medicinetext.Enabled = false;
            this.medicinetext.Location = new System.Drawing.Point(22, 321);
            this.medicinetext.MaxLength = 100;
            this.medicinetext.Name = "medicinetext";
            this.medicinetext.Size = new System.Drawing.Size(200, 20);
            this.medicinetext.TabIndex = 6;
            this.medicinetext.TextChanged += new System.EventHandler(this.medicinetext_TextChanged);
            // 
            // companytext
            // 
            this.companytext.AllowDrop = true;
            this.companytext.Enabled = false;
            this.companytext.Location = new System.Drawing.Point(22, 368);
            this.companytext.MaxLength = 100;
            this.companytext.Name = "companytext";
            this.companytext.Size = new System.Drawing.Size(200, 20);
            this.companytext.TabIndex = 8;
            this.companytext.TextChanged += new System.EventHandler(this.companytext_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(18, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(18, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type";
            // 
            // typeDD
            // 
            this.typeDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeDD.Enabled = false;
            this.typeDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.typeDD.FormattingEnabled = true;
            this.typeDD.Items.AddRange(new object[] {
            "Internal",
            "External"});
            this.typeDD.Location = new System.Drawing.Point(64, 459);
            this.typeDD.Name = "typeDD";
            this.typeDD.Size = new System.Drawing.Size(158, 21);
            this.typeDD.TabIndex = 10;
            this.typeDD.SelectedIndexChanged += new System.EventHandler(this.typeDD_SelectedIndexChanged);
            // 
            // costtext
            // 
            this.costtext.AllowDrop = true;
            this.costtext.Enabled = false;
            this.costtext.Location = new System.Drawing.Point(22, 418);
            this.costtext.MaxLength = 100;
            this.costtext.Name = "costtext";
            this.costtext.Size = new System.Drawing.Size(200, 20);
            this.costtext.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(18, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cost";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.medicineIDGV,
            this.medicineGV,
            this.companyGV,
            this.typeGV,
            this.costGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(717, 613);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.snoGV.Width = 39;
            // 
            // medicineIDGV
            // 
            this.medicineIDGV.HeaderText = "MediID";
            this.medicineIDGV.Name = "medicineIDGV";
            this.medicineIDGV.ReadOnly = true;
            this.medicineIDGV.Visible = false;
            // 
            // medicineGV
            // 
            this.medicineGV.HeaderText = "Medicine";
            this.medicineGV.MaxInputLength = 60;
            this.medicineGV.Name = "medicineGV";
            this.medicineGV.ReadOnly = true;
            // 
            // companyGV
            // 
            this.companyGV.HeaderText = "Company";
            this.companyGV.MaxInputLength = 60;
            this.companyGV.Name = "companyGV";
            this.companyGV.ReadOnly = true;
            // 
            // typeGV
            // 
            this.typeGV.HeaderText = "Type";
            this.typeGV.MaxInputLength = 10;
            this.typeGV.Name = "typeGV";
            this.typeGV.ReadOnly = true;
            // 
            // costGV
            // 
            this.costGV.HeaderText = "Cost";
            this.costGV.MaxInputLength = 1000;
            this.costGV.Name = "costGV";
            this.costGV.ReadOnly = true;
            // 
            // Medicine_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 776);
            this.Name = "Medicine_Window";
            this.Text = "Medicine Window";
            this.Load += new System.EventHandler(this.Medicine_Window_Load);
            this.groupBox1.ResumeLayout(false);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.topleftpanel.ResumeLayout(false);
            this.topleftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.rightpanel.PerformLayout();
            this.toprightpanel.ResumeLayout(false);
            this.toprightpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox typeDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox companytext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox medicinetext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costtext;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn costGV;
    }
}