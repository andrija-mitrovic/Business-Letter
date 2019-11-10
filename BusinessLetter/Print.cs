using BusinessLetter.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLetter
{
    public partial class Print : Form
    {
        private DataTable _dt;
        public Print(DataTable dt)
        {
            InitializeComponent();

            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this._dt = dt;
            this.KeyPreview = true;

            this.odBroja.Text = "1";
            this.doBroja.Text = dt.Rows.Count.ToString();

            this.odBroja.Validating += Valid.f_int;
            this.doBroja.Validating += Valid.f_int;

            this.KeyUp += Valid._KeyUp;
            this._print.Click += stampa_Click;
        }
        private void stampa_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(odBroja.Text) > 0 && 
                Convert.ToInt32(doBroja.Text) <= Convert.ToInt32(_dt.Rows.Count))
            {
                this._print.Enabled = false;

                 //dtSelected.WriteXmlSchema("dsprint.xsd");
                string[] par = { };
                Form stampa = new Report("c_print.rpt", _dt, par);
                stampa.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Numbers must be between 1 and " + _dt.Rows.Count.ToString());
            }
        }

    }
}
