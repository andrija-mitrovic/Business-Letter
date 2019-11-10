namespace BusinessLetter
{
    partial class Report
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
            this.c_viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // c_viewer
            // 
            this.c_viewer.ActiveViewIndex = -1;
            this.c_viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.c_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_viewer.Location = new System.Drawing.Point(0, 0);
            this.c_viewer.Name = "c_viewer";
            this.c_viewer.Size = new System.Drawing.Size(1244, 815);
            this.c_viewer.TabIndex = 0;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 815);
            this.Controls.Add(this.c_viewer);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer c_viewer;
    }
}