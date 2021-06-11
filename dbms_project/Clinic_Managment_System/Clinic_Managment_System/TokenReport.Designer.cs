namespace Clinic_Managment_System
{
    partial class TokenReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.leftpanel.SuspendLayout();
            this.topleftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.toprightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(196, 465);
            // 
            // topleftpanel
            // 
            this.topleftpanel.Size = new System.Drawing.Size(196, 60);
            // 
            // welcomelabel
            // 
            this.welcomelabel.Location = new System.Drawing.Point(71, 15);
            this.welcomelabel.Click += new System.EventHandler(this.welcomelabel_Click);
            // 
            // backbutton
            // 
            this.backbutton.FlatAppearance.BorderSize = 0;
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.reportViewer1);
            this.rightpanel.Location = new System.Drawing.Point(196, 0);
            this.rightpanel.Size = new System.Drawing.Size(353, 465);
            this.rightpanel.Controls.SetChildIndex(this.toprightpanel, 0);
            this.rightpanel.Controls.SetChildIndex(this.pictureBox1, 0);
            this.rightpanel.Controls.SetChildIndex(this.clinicmanegment, 0);
            this.rightpanel.Controls.SetChildIndex(this.systemtext, 0);
            this.rightpanel.Controls.SetChildIndex(this.reportViewer1, 0);
            // 
            // toprightpanel
            // 
            this.toprightpanel.Size = new System.Drawing.Size(353, 60);
            // 
            // userlabel
            // 
            this.userlabel.Size = new System.Drawing.Size(60, 30);
            this.userlabel.Text = "User";
            // 
            // systemtext
            // 
            this.systemtext.Location = new System.Drawing.Point(1126, 599);
            this.systemtext.Size = new System.Drawing.Size(0, 51);
            this.systemtext.Text = "";
            // 
            // clinicmanegment
            // 
            this.clinicmanegment.Location = new System.Drawing.Point(1132, 617);
            this.clinicmanegment.Size = new System.Drawing.Size(0, 67);
            this.clinicmanegment.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1122, 559);
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(353, 405);
            this.reportViewer1.TabIndex = 6;
            // 
            // TokenReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 465);
            this.Name = "TokenReport";
            this.Text = "TokenReport";
            this.Load += new System.EventHandler(this.TokenReport_Load);
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

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}