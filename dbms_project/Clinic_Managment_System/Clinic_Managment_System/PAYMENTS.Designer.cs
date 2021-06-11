namespace Clinic_Managment_System
{
    partial class PAYMENTS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.loadbutton = new System.Windows.Forms.Button();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fmgGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointdateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printbtnGV = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.panel1.Size = new System.Drawing.Size(1111, 84);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Size = new System.Drawing.Size(1111, 639);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.loadbutton);
            this.leftpanel.Controls.Add(this.dateTimePicker1);
            this.leftpanel.Controls.Add(this.label1);
            this.leftpanel.Size = new System.Drawing.Size(256, 783);
            this.leftpanel.Controls.SetChildIndex(this.topleftpanel, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.label1, 0);
            this.leftpanel.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.leftpanel.Controls.SetChildIndex(this.loadbutton, 0);
            // 
            // backbutton
            // 
            this.backbutton.FlatAppearance.BorderSize = 0;
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(1111, 783);
            // 
            // toprightpanel
            // 
            this.toprightpanel.Size = new System.Drawing.Size(1111, 60);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.turnGV,
            this.patientIDgv,
            this.PatientGV,
            this.fmgGV,
            this.ageGV,
            this.genderGV,
            this.phoneGV,
            this.appointdateGV,
            this.doctorGV,
            this.doctorIDGV,
            this.appIDGV,
            this.statusGV,
            this.printbtnGV});
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
            this.dataGridView1.Size = new System.Drawing.Size(1105, 620);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // loadbutton
            // 
            this.loadbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loadbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadbutton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbutton.Location = new System.Drawing.Point(15, 221);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(200, 33);
            this.loadbutton.TabIndex = 7;
            this.loadbutton.Text = "LOAD";
            this.loadbutton.UseVisualStyleBackColor = true;
            this.loadbutton.Click += new System.EventHandler(this.loadbutton_Click);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 39;
            // 
            // turnGV
            // 
            this.turnGV.HeaderText = "Turn";
            this.turnGV.Name = "turnGV";
            this.turnGV.ReadOnly = true;
            // 
            // patientIDgv
            // 
            this.patientIDgv.HeaderText = "Id";
            this.patientIDgv.Name = "patientIDgv";
            this.patientIDgv.ReadOnly = true;
            this.patientIDgv.Visible = false;
            // 
            // PatientGV
            // 
            this.PatientGV.HeaderText = "Patient";
            this.PatientGV.Name = "PatientGV";
            this.PatientGV.ReadOnly = true;
            // 
            // fmgGV
            // 
            this.fmgGV.HeaderText = "Gardian";
            this.fmgGV.Name = "fmgGV";
            this.fmgGV.ReadOnly = true;
            // 
            // ageGV
            // 
            this.ageGV.HeaderText = "Age";
            this.ageGV.Name = "ageGV";
            this.ageGV.ReadOnly = true;
            // 
            // genderGV
            // 
            this.genderGV.HeaderText = "Gender";
            this.genderGV.Name = "genderGV";
            this.genderGV.ReadOnly = true;
            // 
            // phoneGV
            // 
            this.phoneGV.HeaderText = "Phone";
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
            // 
            // appointdateGV
            // 
            this.appointdateGV.HeaderText = "Appointment Date";
            this.appointdateGV.Name = "appointdateGV";
            this.appointdateGV.ReadOnly = true;
            // 
            // doctorGV
            // 
            this.doctorGV.HeaderText = "Doctor";
            this.doctorGV.Name = "doctorGV";
            this.doctorGV.ReadOnly = true;
            // 
            // doctorIDGV
            // 
            this.doctorIDGV.HeaderText = "DoctorID";
            this.doctorIDGV.Name = "doctorIDGV";
            this.doctorIDGV.ReadOnly = true;
            this.doctorIDGV.Visible = false;
            // 
            // appIDGV
            // 
            this.appIDGV.HeaderText = "APPID";
            this.appIDGV.Name = "appIDGV";
            this.appIDGV.ReadOnly = true;
            this.appIDGV.Visible = false;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // printbtnGV
            // 
            this.printbtnGV.HeaderText = "Acition";
            this.printbtnGV.Name = "printbtnGV";
            this.printbtnGV.ReadOnly = true;
            this.printbtnGV.Text = "Print";
            this.printbtnGV.UseColumnTextForButtonValue = true;
            // 
            // PAYMENTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 783);
            this.Name = "PAYMENTS";
            this.Text = "PAYMENTS";
            this.Load += new System.EventHandler(this.PAYMENTS_Load);
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

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button loadbutton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn fmgGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointdateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
        private System.Windows.Forms.DataGridViewButtonColumn printbtnGV;
    }
}