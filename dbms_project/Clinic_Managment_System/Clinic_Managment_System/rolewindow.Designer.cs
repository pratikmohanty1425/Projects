namespace Clinic_Managment_System
{
    public partial class rolewindow
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
        public void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roletextBox = new System.Windows.Forms.TextBox();
            this.rolelabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Size = new System.Drawing.Size(1170, 84);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(253, 84);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Size = new System.Drawing.Size(1170, 657);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.roletextBox);
            this.leftpanel.Controls.Add(this.rolelabel);
            this.leftpanel.Size = new System.Drawing.Size(253, 801);
            this.leftpanel.Controls.SetChildIndex(this.topleftpanel, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.rolelabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.roletextBox, 0);
            // 
            // topleftpanel
            // 
            this.topleftpanel.Size = new System.Drawing.Size(253, 60);
            // 
            // backbutton
            // 
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.Click += new System.EventHandler(this.backbutton1_Click);
            // 
            // rightpanel
            // 
            this.rightpanel.Location = new System.Drawing.Point(253, 0);
            this.rightpanel.Size = new System.Drawing.Size(1170, 801);
            // 
            // toprightpanel
            // 
            this.toprightpanel.Size = new System.Drawing.Size(1170, 60);
            this.toprightpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.toprightpanel_Paint);
            // 
            // userlabel
            // 
            this.userlabel.Size = new System.Drawing.Size(60, 30);
            this.userlabel.Text = "User";
            this.userlabel.Click += new System.EventHandler(this.userlabel_Click);
            // 
            // roletextBox
            // 
            this.roletextBox.Enabled = false;
            this.roletextBox.Location = new System.Drawing.Point(12, 186);
            this.roletextBox.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.roletextBox.MaxLength = 50;
            this.roletextBox.Name = "roletextBox";
            this.roletextBox.Size = new System.Drawing.Size(225, 20);
            this.roletextBox.TabIndex = 5;
            this.roletextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rolelabel
            // 
            this.rolelabel.AutoSize = true;
            this.rolelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rolelabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolelabel.Location = new System.Drawing.Point(21, 160);
            this.rolelabel.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.rolelabel.Name = "rolelabel";
            this.rolelabel.Size = new System.Drawing.Size(41, 23);
            this.rolelabel.TabIndex = 6;
            this.rolelabel.Text = "Role";
            this.rolelabel.Click += new System.EventHandler(this.rolelabel_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(1164, 638);
            this.dataGridView1.TabIndex = 1;
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
            this.RoleGV.MaxInputLength = 32;
            this.RoleGV.Name = "RoleGV";
            this.RoleGV.ReadOnly = true;
            // 
            // rolewindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 801);
            this.Name = "rolewindow";
            this.Text = "rolewindow";
            this.Load += new System.EventHandler(this.rolewindow_Load);
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

        public System.Windows.Forms.Label rolelabel;
        public System.Windows.Forms.TextBox roletextBox;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleGV;
    }
}