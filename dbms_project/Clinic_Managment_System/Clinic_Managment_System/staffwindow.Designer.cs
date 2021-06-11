namespace Clinic_Managment_System
{
    partial class staffwindow
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
            this.nametext = new System.Windows.Forms.TextBox();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.phonetext = new System.Windows.Forms.TextBox();
            this.roleDD = new System.Windows.Forms.ComboBox();
            this.addresstext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Size = new System.Drawing.Size(1129, 84);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(293, 84);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Size = new System.Drawing.Size(1129, 626);
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.label2);
            this.leftpanel.Controls.Add(this.addresstext);
            this.leftpanel.Controls.Add(this.roleDD);
            this.leftpanel.Controls.Add(this.phonetext);
            this.leftpanel.Controls.Add(this.passwordtext);
            this.leftpanel.Controls.Add(this.usernametext);
            this.leftpanel.Controls.Add(this.nametext);
            this.leftpanel.Controls.Add(this.label1);
            this.leftpanel.Size = new System.Drawing.Size(293, 770);
            this.leftpanel.Controls.SetChildIndex(this.topleftpanel, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.label1, 0);
            this.leftpanel.Controls.SetChildIndex(this.nametext, 0);
            this.leftpanel.Controls.SetChildIndex(this.usernametext, 0);
            this.leftpanel.Controls.SetChildIndex(this.passwordtext, 0);
            this.leftpanel.Controls.SetChildIndex(this.phonetext, 0);
            this.leftpanel.Controls.SetChildIndex(this.roleDD, 0);
            this.leftpanel.Controls.SetChildIndex(this.addresstext, 0);
            this.leftpanel.Controls.SetChildIndex(this.label2, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            // 
            // topleftpanel
            // 
            this.topleftpanel.Size = new System.Drawing.Size(293, 60);
            // 
            // welcomelabel
            // 
            this.welcomelabel.Location = new System.Drawing.Point(165, 15);
            // 
            // backbutton
            // 
            this.backbutton.FlatAppearance.BorderSize = 0;
            // 
            // rightpanel
            // 
            this.rightpanel.Location = new System.Drawing.Point(293, 0);
            this.rightpanel.Size = new System.Drawing.Size(1129, 770);
            // 
            // toprightpanel
            // 
            this.toprightpanel.Size = new System.Drawing.Size(1129, 60);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(29, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nametext
            // 
            this.nametext.Enabled = false;
            this.nametext.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametext.Location = new System.Drawing.Point(33, 222);
            this.nametext.MaxLength = 50;
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(226, 26);
            this.nametext.TabIndex = 6;
            this.nametext.TextChanged += new System.EventHandler(this.nametext_TextChanged);
            // 
            // usernametext
            // 
            this.usernametext.Enabled = false;
            this.usernametext.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametext.Location = new System.Drawing.Point(33, 278);
            this.usernametext.MaxLength = 50;
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(226, 26);
            this.usernametext.TabIndex = 8;
            this.usernametext.TextChanged += new System.EventHandler(this.usernametext_TextChanged);
            // 
            // passwordtext
            // 
            this.passwordtext.Enabled = false;
            this.passwordtext.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtext.Location = new System.Drawing.Point(33, 334);
            this.passwordtext.MaxLength = 50;
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(226, 26);
            this.passwordtext.TabIndex = 10;
            this.passwordtext.UseSystemPasswordChar = true;
            this.passwordtext.TextChanged += new System.EventHandler(this.passwordtext_TextChanged);
            // 
            // phonetext
            // 
            this.phonetext.Enabled = false;
            this.phonetext.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetext.Location = new System.Drawing.Point(33, 393);
            this.phonetext.MaxLength = 10;
            this.phonetext.Name = "phonetext";
            this.phonetext.Size = new System.Drawing.Size(226, 26);
            this.phonetext.TabIndex = 12;
            this.phonetext.TextChanged += new System.EventHandler(this.phonetext_TextChanged);
            // 
            // roleDD
            // 
            this.roleDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleDD.Enabled = false;
            this.roleDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roleDD.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleDD.FormattingEnabled = true;
            this.roleDD.Location = new System.Drawing.Point(32, 506);
            this.roleDD.Name = "roleDD";
            this.roleDD.Size = new System.Drawing.Size(226, 31);
            this.roleDD.TabIndex = 13;
            this.roleDD.SelectedIndexChanged += new System.EventHandler(this.roleDD_SelectedIndexChanged);
            // 
            // addresstext
            // 
            this.addresstext.Enabled = false;
            this.addresstext.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstext.Location = new System.Drawing.Point(33, 450);
            this.addresstext.MaxLength = 500;
            this.addresstext.Name = "addresstext";
            this.addresstext.Size = new System.Drawing.Size(226, 26);
            this.addresstext.TabIndex = 16;
            this.addresstext.TextChanged += new System.EventHandler(this.addresstext_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(29, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(27, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(27, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(27, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(27, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Role";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
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
            this.userIDgv,
            this.nameGV,
            this.UsernameGV,
            this.passwordGV,
            this.phoneGV,
            this.addressGV,
            this.RoleGV,
            this.roleIDGV});
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
            this.dataGridView1.Size = new System.Drawing.Size(1123, 607);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 39;
            // 
            // userIDgv
            // 
            this.userIDgv.HeaderText = "Id";
            this.userIDgv.Name = "userIDgv";
            this.userIDgv.ReadOnly = true;
            this.userIDgv.Visible = false;
            // 
            // nameGV
            // 
            this.nameGV.HeaderText = "Name";
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            // 
            // UsernameGV
            // 
            this.UsernameGV.HeaderText = "UserName";
            this.UsernameGV.Name = "UsernameGV";
            this.UsernameGV.ReadOnly = true;
            // 
            // passwordGV
            // 
            this.passwordGV.HeaderText = "Password";
            this.passwordGV.Name = "passwordGV";
            this.passwordGV.ReadOnly = true;
            this.passwordGV.Visible = false;
            // 
            // phoneGV
            // 
            this.phoneGV.HeaderText = "Phone";
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "Address";
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            // 
            // RoleGV
            // 
            this.RoleGV.FillWeight = 110.7445F;
            this.RoleGV.HeaderText = "Role";
            this.RoleGV.Name = "RoleGV";
            this.RoleGV.ReadOnly = true;
            // 
            // roleIDGV
            // 
            this.roleIDGV.HeaderText = "RoleID";
            this.roleIDGV.Name = "roleIDGV";
            this.roleIDGV.ReadOnly = true;
            this.roleIDGV.Visible = false;
            // 
            // staffwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 770);
            this.Name = "staffwindow";
            this.Text = "staffwindow";
            this.Load += new System.EventHandler(this.staffwindow_Load);
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

        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addresstext;
        private System.Windows.Forms.ComboBox roleDD;
        private System.Windows.Forms.TextBox phonetext;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.TextBox usernametext;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIDGV;
    }
}