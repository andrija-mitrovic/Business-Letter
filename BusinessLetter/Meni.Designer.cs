namespace BusinessLetter
{
    partial class Meni
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
            this._search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.cmbSheet = new System.Windows.Forms.ComboBox();
            this._open = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _print
            // 
            this._print.Location = new System.Drawing.Point(198, 721);
            this._print.Margin = new System.Windows.Forms.Padding(4);
            this._print.Name = "_print";
            this._print.Size = new System.Drawing.Size(136, 36);
            this._print.TabIndex = 3;
            this._print.Text = "Print";
            this._print.UseVisualStyleBackColor = true;
            // 
            // _search
            // 
            this._search.ForeColor = System.Drawing.SystemColors.MenuText;
            this._search.Location = new System.Drawing.Point(106, 34);
            this._search.Margin = new System.Windows.Forms.Padding(4);
            this._search.Multiline = true;
            this._search.Name = "_search";
            this._search.Size = new System.Drawing.Size(287, 22);
            this._search.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 634);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Full name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 675);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sheet:";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(122, 631);
            this.fileName.Multiline = true;
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(718, 26);
            this.fileName.TabIndex = 0;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(850, 630);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(46, 30);
            this.browse.TabIndex = 9;
            this.browse.Text = "...";
            this.browse.UseVisualStyleBackColor = true;
            // 
            // cmbSheet
            // 
            this.cmbSheet.FormattingEnabled = true;
            this.cmbSheet.Location = new System.Drawing.Point(122, 672);
            this.cmbSheet.Name = "cmbSheet";
            this.cmbSheet.Size = new System.Drawing.Size(171, 24);
            this.cmbSheet.TabIndex = 10;
            // 
            // _open
            // 
            this._open.Location = new System.Drawing.Point(40, 721);
            this._open.Margin = new System.Windows.Forms.Padding(4);
            this._open.Name = "_open";
            this._open.Size = new System.Drawing.Size(136, 36);
            this._open.TabIndex = 11;
            this._open.Text = "Open";
            this._open.UseVisualStyleBackColor = true;
            // 
            // gridView
            // 
            this.gridView.BackgroundColor = System.Drawing.Color.White;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(42, 84);
            this.gridView.Margin = new System.Windows.Forms.Padding(4);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersVisible = false;
            this.gridView.Size = new System.Drawing.Size(1265, 524);
            this.gridView.TabIndex = 12;
            // 
            // Meni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1348, 783);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this._open);
            this.Controls.Add(this.cmbSheet);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._print);
            this.Name = "Meni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Business Proposal Letter";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _print;
        private System.Windows.Forms.TextBox _search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.ComboBox cmbSheet;
        private System.Windows.Forms.Button _open;
        private System.Windows.Forms.DataGridView gridView;
    }
}

