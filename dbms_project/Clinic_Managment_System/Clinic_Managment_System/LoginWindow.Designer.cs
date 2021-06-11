namespace Clinic_Managment_System
{
    partial class LoginWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.usertext = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.leftpanel.SuspendLayout();
            this.topleftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.toprightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.loginbutton);
            this.leftpanel.Controls.Add(this.passwordtext);
            this.leftpanel.Controls.Add(this.label2);
            this.leftpanel.Controls.Add(this.usertext);
            this.leftpanel.Controls.Add(this.label1);
            this.leftpanel.Size = new System.Drawing.Size(256, 746);
            this.leftpanel.Controls.SetChildIndex(this.topleftpanel, 0);
            this.leftpanel.Controls.SetChildIndex(this.label1, 0);
            this.leftpanel.Controls.SetChildIndex(this.usertext, 0);
            this.leftpanel.Controls.SetChildIndex(this.label2, 0);
            this.leftpanel.Controls.SetChildIndex(this.passwordtext, 0);
            this.leftpanel.Controls.SetChildIndex(this.loginbutton, 0);
            // 
            // backbutton
            // 
            this.backbutton.FlatAppearance.BorderSize = 0;
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(508, 746);
            // 
            // toprightpanel
            // 
            this.toprightpanel.Size = new System.Drawing.Size(508, 60);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(27, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserName";
            // 
            // usertext
            // 
            this.usertext.Location = new System.Drawing.Point(31, 293);
            this.usertext.MaxLength = 50;
            this.usertext.Name = "usertext";
            this.usertext.Size = new System.Drawing.Size(189, 20);
            this.usertext.TabIndex = 5;
            this.usertext.TextChanged += new System.EventHandler(this.usertext_TextChanged);
            // 
            // passwordtext
            // 
            this.passwordtext.Location = new System.Drawing.Point(31, 342);
            this.passwordtext.MaxLength = 30;
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(189, 20);
            this.passwordtext.TabIndex = 7;
            this.passwordtext.UseSystemPasswordChar = true;
            this.passwordtext.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(27, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.loginbutton.Location = new System.Drawing.Point(54, 368);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(139, 35);
            this.loginbutton.TabIndex = 8;
            this.loginbutton.Text = "LOGIN";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // LoginWindow
            // 
            this.AcceptButton = this.loginbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 746);
            this.Name = "LoginWindow";
            this.Text = "LoginWindow";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
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

        protected System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox usertext;
        private System.Windows.Forms.Button loginbutton;
    }
}