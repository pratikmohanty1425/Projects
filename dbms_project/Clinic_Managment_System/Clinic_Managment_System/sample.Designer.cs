namespace Clinic_Managment_System
{
    partial class sample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sample));
            this.leftpanel = new System.Windows.Forms.Panel();
            this.topleftpanel = new System.Windows.Forms.Panel();
            this.welcomelabel = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.systemtext = new System.Windows.Forms.Label();
            this.clinicmanegment = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toprightpanel = new System.Windows.Forms.Panel();
            this.userlabel = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.topleftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toprightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.leftpanel.Controls.Add(this.topleftpanel);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(256, 710);
            this.leftpanel.TabIndex = 0;
            // 
            // topleftpanel
            // 
            this.topleftpanel.Controls.Add(this.welcomelabel);
            this.topleftpanel.Controls.Add(this.backbutton);
            this.topleftpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topleftpanel.Location = new System.Drawing.Point(0, 0);
            this.topleftpanel.Name = "topleftpanel";
            this.topleftpanel.Size = new System.Drawing.Size(256, 60);
            this.topleftpanel.TabIndex = 3;
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelabel.ForeColor = System.Drawing.SystemColors.Window;
            this.welcomelabel.Location = new System.Drawing.Point(134, 15);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(122, 30);
            this.welcomelabel.TabIndex = 1;
            this.welcomelabel.Text = "WELCOME";
            // 
            // backbutton
            // 
            this.backbutton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Image = global::Clinic_Managment_System.Properties.Resources.iconfinder_173_Arrow_Loop_Loop_Arrow_Back_5172489;
            this.backbutton.Location = new System.Drawing.Point(0, 0);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 60);
            this.backbutton.TabIndex = 0;
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // rightpanel
            // 
            this.rightpanel.BackColor = System.Drawing.SystemColors.Window;
            this.rightpanel.Controls.Add(this.systemtext);
            this.rightpanel.Controls.Add(this.clinicmanegment);
            this.rightpanel.Controls.Add(this.pictureBox1);
            this.rightpanel.Controls.Add(this.toprightpanel);
            this.rightpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightpanel.Location = new System.Drawing.Point(256, 0);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(449, 710);
            this.rightpanel.TabIndex = 1;
            // 
            // systemtext
            // 
            this.systemtext.AutoSize = true;
            this.systemtext.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemtext.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.systemtext.Location = new System.Drawing.Point(747, 812);
            this.systemtext.Name = "systemtext";
            this.systemtext.Size = new System.Drawing.Size(153, 51);
            this.systemtext.TabIndex = 5;
            this.systemtext.Text = "System";
            this.systemtext.Click += new System.EventHandler(this.systemtext_Click);
            // 
            // clinicmanegment
            // 
            this.clinicmanegment.AutoSize = true;
            this.clinicmanegment.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinicmanegment.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.clinicmanegment.Location = new System.Drawing.Point(380, 745);
            this.clinicmanegment.Name = "clinicmanegment";
            this.clinicmanegment.Size = new System.Drawing.Size(427, 67);
            this.clinicmanegment.TabIndex = 4;
            this.clinicmanegment.Text = "Clinic Managment";
            this.clinicmanegment.Click += new System.EventHandler(this.clinicmanegment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clinic_Managment_System.Properties.Resources.patient__1_;
            this.pictureBox1.Location = new System.Drawing.Point(539, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 530);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toprightpanel
            // 
            this.toprightpanel.Controls.Add(this.userlabel);
            this.toprightpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toprightpanel.Location = new System.Drawing.Point(0, 0);
            this.toprightpanel.Name = "toprightpanel";
            this.toprightpanel.Size = new System.Drawing.Size(449, 60);
            this.toprightpanel.TabIndex = 2;
            this.toprightpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.toprightpanel_Paint);
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.userlabel.Location = new System.Drawing.Point(3, 15);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(69, 30);
            this.userlabel.TabIndex = 2;
            this.userlabel.Text = "USER";
            // 
            // sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 710);
            this.ControlBox = false;
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.leftpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sample";
            this.Text = "Clinic Managment Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftpanel.ResumeLayout(false);
            this.topleftpanel.ResumeLayout(false);
            this.topleftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.rightpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toprightpanel.ResumeLayout(false);
            this.toprightpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel leftpanel;
        protected System.Windows.Forms.Panel topleftpanel;
        protected System.Windows.Forms.Label welcomelabel;
        protected System.Windows.Forms.Button backbutton;
        protected System.Windows.Forms.Panel rightpanel;
        protected System.Windows.Forms.Panel toprightpanel;
        protected System.Windows.Forms.Label userlabel;
        protected System.Windows.Forms.Label systemtext;
        protected System.Windows.Forms.Label clinicmanegment;
        protected System.Windows.Forms.PictureBox pictureBox1;
    }
}

