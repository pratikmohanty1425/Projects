namespace Clinic_Managment_System
{
    partial class SettingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.SourceText = new System.Windows.Forms.TextBox();
            this.DBText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserIDText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.leftpanel.SuspendLayout();
            this.topleftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.toprightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.savebutton);
            this.leftpanel.Controls.Add(this.isCB);
            this.leftpanel.Controls.Add(this.PasswordText);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.UserIDText);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.DBText);
            this.leftpanel.Controls.Add(this.label2);
            this.leftpanel.Controls.Add(this.SourceText);
            this.leftpanel.Controls.Add(this.label1);
            this.leftpanel.Size = new System.Drawing.Size(256, 762);
            this.leftpanel.Controls.SetChildIndex(this.topleftpanel, 0);
            this.leftpanel.Controls.SetChildIndex(this.label1, 0);
            this.leftpanel.Controls.SetChildIndex(this.SourceText, 0);
            this.leftpanel.Controls.SetChildIndex(this.label2, 0);
            this.leftpanel.Controls.SetChildIndex(this.DBText, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.UserIDText, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.PasswordText, 0);
            this.leftpanel.Controls.SetChildIndex(this.isCB, 0);
            this.leftpanel.Controls.SetChildIndex(this.savebutton, 0);
            // 
            // backbutton
            // 
            this.backbutton.FlatAppearance.BorderSize = 0;
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(443, 762);
            // 
            // toprightpanel
            // 
            this.toprightpanel.Size = new System.Drawing.Size(443, 60);
            // 
            // userlabel
            // 
            this.userlabel.Size = new System.Drawing.Size(60, 30);
            this.userlabel.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(26, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "DataSource";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SourceText
            // 
            this.SourceText.Location = new System.Drawing.Point(30, 292);
            this.SourceText.MaxLength = 200;
            this.SourceText.Name = "SourceText";
            this.SourceText.Size = new System.Drawing.Size(184, 20);
            this.SourceText.TabIndex = 5;
            this.SourceText.TextChanged += new System.EventHandler(this.SourceText_TextChanged);
            // 
            // DBText
            // 
            this.DBText.Location = new System.Drawing.Point(30, 336);
            this.DBText.MaxLength = 200;
            this.DBText.Name = "DBText";
            this.DBText.Size = new System.Drawing.Size(184, 20);
            this.DBText.TabIndex = 7;
            this.DBText.TextChanged += new System.EventHandler(this.DBText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(26, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "DataBase";
            // 
            // UserIDText
            // 
            this.UserIDText.Location = new System.Drawing.Point(30, 380);
            this.UserIDText.MaxLength = 50;
            this.UserIDText.Name = "UserIDText";
            this.UserIDText.Size = new System.Drawing.Size(184, 20);
            this.UserIDText.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(26, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "UserID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(30, 425);
            this.PasswordText.MaxLength = 50;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(184, 20);
            this.PasswordText.TabIndex = 11;
            this.PasswordText.UseSystemPasswordChar = true;
            this.PasswordText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(27, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isCB.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.isCB.Location = new System.Drawing.Point(31, 452);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(155, 23);
            this.isCB.TabIndex = 12;
            this.isCB.Text = "Integrated Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
            // 
            // savebutton
            // 
            this.savebutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.savebutton.FlatAppearance.BorderSize = 2;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(30, 481);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(183, 37);
            this.savebutton.TabIndex = 13;
            this.savebutton.Text = "SAVE";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // SettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 762);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingWindow";
            this.Text = "Setting...";
            this.Load += new System.EventHandler(this.SettingWindow_Load);
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

        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserIDText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DBText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SourceText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.CheckBox isCB;
    }
}