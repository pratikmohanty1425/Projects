namespace Clinic_Managment_System
{
    partial class UserWindow
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
            this.rolelabel = new System.Windows.Forms.Label();
            this.roletextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Size = new System.Drawing.Size(1133, 84);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Size = new System.Drawing.Size(1133, 698);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.rolelabel);
            this.leftpanel.Controls.Add(this.roletextBox);
            this.leftpanel.Controls.Add(this.label1);
            this.leftpanel.Controls.Add(this.textBox1);
            this.leftpanel.Controls.Add(this.comboBox1);
            this.leftpanel.Controls.Add(this.label2);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.textBox2);
            this.leftpanel.Controls.Add(this.textBox4);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.textBox3);
            this.leftpanel.Size = new System.Drawing.Size(256, 842);
            this.leftpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftpanel_Paint);
            this.leftpanel.Controls.SetChildIndex(this.textBox3, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.textBox4, 0);
            this.leftpanel.Controls.SetChildIndex(this.textBox2, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.label2, 0);
            this.leftpanel.Controls.SetChildIndex(this.comboBox1, 0);
            this.leftpanel.Controls.SetChildIndex(this.textBox1, 0);
            this.leftpanel.Controls.SetChildIndex(this.topleftpanel, 0);
            this.leftpanel.Controls.SetChildIndex(this.label1, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.roletextBox, 0);
            this.leftpanel.Controls.SetChildIndex(this.rolelabel, 0);
            // 
            // topleftpanel
            // 
            this.topleftpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topleftpanel_Paint);
            // 
            // welcomelabel
            // 
            this.welcomelabel.Click += new System.EventHandler(this.welcomelabel_Click);
            // 
            // backbutton
            // 
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(1133, 842);
            this.rightpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightpanel_Paint);
            // 
            // toprightpanel
            // 
            this.toprightpanel.Size = new System.Drawing.Size(1133, 60);
            this.toprightpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.toprightpanel_Paint);
            // 
            // userlabel
            // 
            this.userlabel.Click += new System.EventHandler(this.userlabel_Click);
            // 
            // systemtext
            // 
            this.systemtext.Click += new System.EventHandler(this.systemtext_Click);
            // 
            // clinicmanegment
            // 
            this.clinicmanegment.Click += new System.EventHandler(this.clinicmanegment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rolelabel
            // 
            this.rolelabel.AutoSize = true;
            this.rolelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rolelabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolelabel.Location = new System.Drawing.Point(25, 196);
            this.rolelabel.Margin = new System.Windows.Forms.Padding(25, 0, 3, 0);
            this.rolelabel.Name = "rolelabel";
            this.rolelabel.Size = new System.Drawing.Size(53, 23);
            this.rolelabel.TabIndex = 8;
            this.rolelabel.Text = "Name";
            this.rolelabel.Click += new System.EventHandler(this.rolelabel_Click);
            // 
            // roletextBox
            // 
            this.roletextBox.Location = new System.Drawing.Point(25, 222);
            this.roletextBox.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.roletextBox.MaxLength = 50;
            this.roletextBox.Name = "roletextBox";
            this.roletextBox.Size = new System.Drawing.Size(208, 20);
            this.roletextBox.TabIndex = 7;
            this.roletextBox.TextChanged += new System.EventHandler(this.roletextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(25, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "UserName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 271);
            this.textBox1.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(25, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 320);
            this.textBox2.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 343);
            this.label3.Margin = new System.Windows.Forms.Padding(25, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(25, 369);
            this.textBox3.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.textBox3.MaxLength = 50;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(208, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 392);
            this.label4.Margin = new System.Windows.Forms.Padding(25, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(25, 418);
            this.textBox4.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.textBox4.MaxLength = 50;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(208, 20);
            this.textBox4.TabIndex = 15;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 446);
            this.label5.Margin = new System.Windows.Forms.Padding(25, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Role";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 448);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.userIDGV,
            this.nameGV,
            this.UsernameGV,
            this.PasswordGV,
            this.PhoneGV,
            this.AddressGV,
            this.roleIDGV,
            this.RoleGV});
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
            this.dataGridView1.Size = new System.Drawing.Size(1127, 679);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 39;
            // 
            // userIDGV
            // 
            this.userIDGV.FillWeight = 110.7445F;
            this.userIDGV.HeaderText = "UserID";
            this.userIDGV.Name = "userIDGV";
            this.userIDGV.ReadOnly = true;
            // 
            // nameGV
            // 
            this.nameGV.FillWeight = 110.7445F;
            this.nameGV.HeaderText = "Name";
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            // 
            // UsernameGV
            // 
            this.UsernameGV.FillWeight = 110.7445F;
            this.UsernameGV.HeaderText = "Username";
            this.UsernameGV.Name = "UsernameGV";
            this.UsernameGV.ReadOnly = true;
            // 
            // PasswordGV
            // 
            this.PasswordGV.HeaderText = "Password";
            this.PasswordGV.Name = "PasswordGV";
            this.PasswordGV.ReadOnly = true;
            this.PasswordGV.Visible = false;
            // 
            // PhoneGV
            // 
            this.PhoneGV.FillWeight = 110.7445F;
            this.PhoneGV.HeaderText = "Phone";
            this.PhoneGV.Name = "PhoneGV";
            this.PhoneGV.ReadOnly = true;
            // 
            // AddressGV
            // 
            this.AddressGV.FillWeight = 110.7445F;
            this.AddressGV.HeaderText = "Address";
            this.AddressGV.Name = "AddressGV";
            this.AddressGV.ReadOnly = true;
            // 
            // roleIDGV
            // 
            this.roleIDGV.HeaderText = "RoleID";
            this.roleIDGV.Name = "roleIDGV";
            this.roleIDGV.ReadOnly = true;
            this.roleIDGV.Visible = false;
            // 
            // RoleGV
            // 
            this.RoleGV.FillWeight = 110.7445F;
            this.RoleGV.HeaderText = "Role";
            this.RoleGV.Name = "RoleGV";
            this.RoleGV.ReadOnly = true;
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 842);
            this.Name = "UserWindow";
            this.Text = "UserWindow";
            this.Load += new System.EventHandler(this.UserWindow_Load);
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
        private System.Windows.Forms.Label rolelabel;
        private System.Windows.Forms.TextBox roletextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleGV;
    }
}