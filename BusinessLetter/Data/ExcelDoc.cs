using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data.BusinessLetter
{
    public class ExcelDoc : IExcelDoc
    {
        private DataTable dt;
        private DataTable dtpom;

        public DataTable ReadExcel(string path, string sheetName)
        {
            try
            {
                 var conStr = "PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" + path 
                    + ";Extended Properties = 'Excel 12.0; HDR=yes'";

                OleDbConnection con = new OleDbConnection(conStr);
                OleDbCommand cmd = new OleDbCommand("select * from [" + sheetName + "$]", con);
                con.Open();

                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return dt;
        }

        public DataTable SearchByName(DataTable dt, string pretraga)
        {
            dtpom = dt.Clone();
            var a = dt.Rows.Count;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Company name"].ToString().Trim(' ').ToLower().Contains(pretraga.ToLower().Trim(' ')))
                {
                    dtpom.ImportRow(dt.Rows[i]);
                };
            }
            return dtpom;
        }
    }
}
