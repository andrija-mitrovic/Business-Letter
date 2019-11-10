using BusinessLetter.Design;
using BusinessLetter.Validation;
using Data.BusinessLetter;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLetter
{
    public partial class Meni : Form
    {
        private AutoSize _form_resize;
        private readonly IExcelDoc _excel;
        private DataTable dt;
        Microsoft.Office.Interop.Excel.Application ExcelObj = new Microsoft.Office.Interop.Excel.Application();
        Microsoft.Office.Interop.Excel.Workbook theWorkbook = null;

        public Meni(IExcelDoc excel)
        {
            InitializeComponent();
            _excel = excel;

            gridView.ReadOnly = true;
            gridView.AllowUserToResizeColumns = false;
            gridView.AllowUserToResizeRows = false;

            _form_resize = new AutoSize(this);
            this.Resize += _form_resize.Resize;
            _form_resize._get_initial_size();

            this.KeyUp += Valid._KeyUp;

            browse.Click += browse_Click;
            _print.Click += print_Click;
            _search.TextChanged += _pretraga_TextChanged;
            _open.Click += open_Click;

            this._open.Enabled = false;
            this._print.Enabled = false;
            this._search.Enabled = false;
        }

        private void open_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this._open.Enabled = false;
           
            dt = _excel.ReadExcel(fileName.Text,cmbSheet.Text);

            gridView.DataSource = dt;
            gridView.AllowUserToAddRows = false;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this._open.Enabled = true;
            this._print.Enabled = true;
            this._search.Enabled = true;
        }

        private void browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
                { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if(openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    this._open.Enabled = true;

                    fileName.Text = openFileDialog.FileName;

                    theWorkbook = ExcelObj.Workbooks.Open(fileName.Text);
                    Microsoft.Office.Interop.Excel.Sheets sheets = theWorkbook.Worksheets;

                    cmbSheet.Items.Clear();
                    var numSheet = sheets.Count;
                    for(int i = 1; i <= numSheet; i++)
                    {
                        Microsoft.Office.Interop.Excel.Worksheet worksheet =
                           (Microsoft.Office.Interop.Excel.Worksheet)sheets.get_Item(i);
                        cmbSheet.Items.Add(worksheet.Name);
                        cmbSheet.SelectedIndex = 0;
                    }
                }
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            Form stampa = new Print(dt);
            stampa.ShowDialog();
        }
        private void _pretraga_TextChanged(object sender, EventArgs e)
        {
            gridView.DataSource = _excel.SearchByName(dt, this._search.Text);
            gridView.AllowUserToAddRows = false;
        }

    }
}
