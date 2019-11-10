namespace BusinessLetter
{
    partial class Print
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
            this._print = new System.Windows.Forms.Button();
            this.doBroja = new System.Windows.Forms.TextBox();
            this.odBroja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _print
            // 
            this._print.Location = new System.Drawing.Point(39, 123);
            this._print.Margin = new System.Windows.Forms.Padding(4);
            this._print.Name = "_print";
            this._print.Size = new System.Drawing.Size(136, 36);
            this._print.TabIndex = 7;
            this._print.Text = "Print";
            this._print.UseVisualStyleBackColor = true;
            // 
            // doBroja
            // 
            this.doBroja.Location = new System.Drawing.Point(90, 63);
            this.doBroja.Margin = new System.Windows.Forms.Padding(4);
            this.doBroja.Name = "doBroja";
            this.doBroja.Size = new System.Drawing.Size(124, 22);
            this.doBroja.TabIndex = 5;
            // 
            // odBroja
            // 
            this.odBroja.Location = new System.Drawing.Point(90, 28);
            this.odBroja.Margin = new System.Windows.Forms.Padding(4);
            this.odBroja.Name = "odBroja";
            this.odBroja.Size = new System.Drawing.Size(124, 22);
            this.odBroja.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "From:";
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 190);
            this.Controls.Add(this._print);
            this.Controls.Add(this.doBroja);
            this.Controls.Add(this.odBroja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stampa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _print;
        private System.Windows.Forms.TextBox doBroja;
        private System.Windows.Forms.TextBox odBroja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}