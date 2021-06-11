namespace Clinic_Managment_System
{
    partial class sample1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deletebutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.searchtextbox = new System.Windows.Forms.TextBox();
            this.searchtext = new System.Windows.Forms.Label();
            this.viewbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.leftpanel.SuspendLayout();
            this.topleftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.toprightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.panel2);
            this.leftpanel.Size = new System.Drawing.Size(256, 720);
            this.leftpanel.Controls.SetChildIndex(this.topleftpanel, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            // 
            // backbutton
            // 
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.groupBox1);
            this.rightpanel.Controls.Add(this.panel1);
            this.rightpanel.Size = new System.Drawing.Size(814, 720);
            this.rightpanel.Controls.SetChildIndex(this.pictureBox1, 0);
            this.rightpanel.Controls.SetChildIndex(this.clinicmanegment, 0);
            this.rightpanel.Controls.SetChildIndex(this.systemtext, 0);
            this.rightpanel.Controls.SetChildIndex(this.toprightpanel, 0);
            this.rightpanel.Controls.SetChildIndex(this.panel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // toprightpanel
            // 
            this.toprightpanel.Size = new System.Drawing.Size(814, 60);
            // 
            // userlabel
            // 
            this.userlabel.Size = new System.Drawing.Size(60, 30);
            this.userlabel.Text = "User";
            // 
            // systemtext
            // 
            this.systemtext.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemtext.Location = new System.Drawing.Point(1539, 807);
            this.systemtext.Size = new System.Drawing.Size(0, 27);
            this.systemtext.Text = "";
            this.systemtext.Click += new System.EventHandler(this.systemtext_Click);
            // 
            // clinicmanegment
            // 
            this.clinicmanegment.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinicmanegment.Location = new System.Drawing.Point(-2, 737);
            this.clinicmanegment.Size = new System.Drawing.Size(0, 27);
            this.clinicmanegment.Text = "";
            this.clinicmanegment.Click += new System.EventHandler(this.clinicmanegment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1545, 807);
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 84);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.deletebutton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.savebutton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addbutton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.editbutton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchtextbox, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.searchtext, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewbutton, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 84);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // deletebutton
            // 
            this.deletebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletebutton.FlatAppearance.BorderSize = 0;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebutton.Image = global::Clinic_Managment_System.Properties.Resources.icons8_delete_100;
            this.deletebutton.Location = new System.Drawing.Point(408, 3);
            this.deletebutton.Name = "deletebutton";
            this.tableLayoutPanel1.SetRowSpan(this.deletebutton, 2);
            this.deletebutton.Size = new System.Drawing.Size(129, 78);
            this.deletebutton.TabIndex = 3;
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savebutton.FlatAppearance.BorderSize = 0;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Image = global::Clinic_Managment_System.Properties.Resources.icons8_save_100;
            this.savebutton.Location = new System.Drawing.Point(273, 3);
            this.savebutton.Name = "savebutton";
            this.tableLayoutPanel1.SetRowSpan(this.savebutton, 2);
            this.savebutton.Size = new System.Drawing.Size(129, 78);
            this.savebutton.TabIndex = 2;
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addbutton.FlatAppearance.BorderSize = 0;
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbutton.Image = global::Clinic_Managment_System.Properties.Resources.icons8_add_100__1_;
            this.addbutton.Location = new System.Drawing.Point(3, 3);
            this.addbutton.Name = "addbutton";
            this.tableLayoutPanel1.SetRowSpan(this.addbutton, 2);
            this.addbutton.Size = new System.Drawing.Size(129, 78);
            this.addbutton.TabIndex = 0;
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editbutton.FlatAppearance.BorderSize = 0;
            this.editbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbutton.Image = global::Clinic_Managment_System.Properties.Resources.icons8_edit_100;
            this.editbutton.Location = new System.Drawing.Point(138, 3);
            this.editbutton.Name = "editbutton";
            this.tableLayoutPanel1.SetRowSpan(this.editbutton, 2);
            this.editbutton.Size = new System.Drawing.Size(129, 78);
            this.editbutton.TabIndex = 1;
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // searchtextbox
            // 
            this.searchtextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchtextbox.Location = new System.Drawing.Point(678, 45);
            this.searchtextbox.Name = "searchtextbox";
            this.searchtextbox.Size = new System.Drawing.Size(133, 20);
            this.searchtextbox.TabIndex = 5;
            this.searchtextbox.TextChanged += new System.EventHandler(this.searchtextbox_TextChanged);
            // 
            // searchtext
            // 
            this.searchtext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchtext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchtext.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtext.Location = new System.Drawing.Point(678, 0);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(133, 42);
            this.searchtext.TabIndex = 4;
            this.searchtext.Text = "SEARCH";
            this.searchtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewbutton
            // 
            this.viewbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewbutton.FlatAppearance.BorderSize = 0;
            this.viewbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewbutton.Image = global::Clinic_Managment_System.Properties.Resources.icons8_view_90;
            this.viewbutton.Location = new System.Drawing.Point(543, 3);
            this.viewbutton.Name = "viewbutton";
            this.tableLayoutPanel1.SetRowSpan(this.viewbutton, 2);
            this.viewbutton.Size = new System.Drawing.Size(129, 78);
            this.viewbutton.TabIndex = 6;
            this.viewbutton.UseVisualStyleBackColor = true;
            this.viewbutton.Click += new System.EventHandler(this.viewbutton_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 84);
            this.panel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 576);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // sample1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 720);
            this.Name = "sample1";
            this.Text = "sample1";
            this.Load += new System.EventHandler(this.sample1_Load);
            this.leftpanel.ResumeLayout(false);
            this.topleftpanel.ResumeLayout(false);
            this.topleftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.rightpanel.PerformLayout();
            this.toprightpanel.ResumeLayout(false);
            this.toprightpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button deletebutton;
        public System.Windows.Forms.Button savebutton;
        public System.Windows.Forms.Button addbutton;
        public System.Windows.Forms.Button editbutton;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label searchtext;
        public System.Windows.Forms.TextBox searchtextbox;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button viewbutton;
    }
}