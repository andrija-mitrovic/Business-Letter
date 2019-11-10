using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Report : Form
    {
        private ReportDocument m_cizv;
        private string m_cime;
        private DataTable m_dt;
        private string[] m_ipar;
        public Report(string cime, DataTable dt, string[] c_ipar)
        {
            InitializeComponent();

            m_cime = cime;
            m_ipar = c_ipar;
            m_dt = dt;
            m_cizv = new ReportDocument();
            this.Load += cizvLoad;
        }
        private void cizvLoad(object sender, EventArgs e)
        {
            try
            {
                m_cizv.Load(m_cime);
                m_cizv.SetDataSource(m_dt);

                for (int i = 0; i < m_ipar.Length; i++)
                {
                    m_cizv.SetParameterValue("p_p" + (i + 1).ToString(), m_ipar[i]);
                }

                c_viewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                c_viewer.ReportSource = m_cizv;
                c_viewer.Zoom(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
