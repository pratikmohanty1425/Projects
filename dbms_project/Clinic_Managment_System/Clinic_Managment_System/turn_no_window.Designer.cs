namespace Clinic_Managment_System
{
    partial class turn_no_window
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tokenlabel = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.topleftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.toprightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(256, 752);
            // 
            // backbutton
            // 
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.tokenlabel);
            this.rightpanel.Controls.Add(this.label1);
            this.rightpanel.Size = new System.Drawing.Size(800, 752);
            this.rightpanel.Controls.SetChildIndex(this.toprightpanel, 0);
            this.rightpanel.Controls.SetChildIndex(this.pictureBox1, 0);
            this.rightpanel.Controls.SetChildIndex(this.clinicmanegment, 0);
            this.rightpanel.Controls.SetChildIndex(this.systemtext, 0);
            this.rightpanel.Controls.SetChildIndex(this.label1, 0);
            this.rightpanel.Controls.SetChildIndex(this.tokenlabel, 0);
            // 
            // toprightpanel
            // 
            this.toprightpanel.Size = new System.Drawing.Size(800, 60);
            // 
            // userlabel
            // 
            this.userlabel.Size = new System.Drawing.Size(60, 30);
            this.userlabel.Text = "User";
            // 
            // systemtext
            // 
            this.systemtext.Location = new System.Drawing.Point(1170, 911);
            // 
            // clinicmanegment
            // 
            this.clinicmanegment.Location = new System.Drawing.Point(803, 844);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(962, 299);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(67, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "It\'s Your Turn Number...";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tokenlabel
            // 
            this.tokenlabel.AutoSize = true;
            this.tokenlabel.Font = new System.Drawing.Font("Comic Sans MS", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenlabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tokenlabel.Location = new System.Drawing.Point(405, 399);
            this.tokenlabel.Name = "tokenlabel";
            this.tokenlabel.Size = new System.Drawing.Size(282, 136);
            this.tokenlabel.TabIndex = 7;
            this.tokenlabel.Text = "Wait";
            // 
            // turn_no_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 752);
            this.Name = "turn_no_window";
            this.Text = "turn_no_window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.turn_no_window_FormClosing);
            this.Load += new System.EventHandler(this.turn_no_window_Load);
            this.leftpanel.ResumeLayout(false);
            this.topleftpanel.ResumeLayout(false);
            this.topleftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.rightpanel.PerformLayout();
            this.toprightpanel.ResumeLayout(false);
            this.toprightpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tokenlabel;
    }
}