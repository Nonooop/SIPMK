using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace SIPMK
{
    public partial class ReportJadwal : Form
    {
        public ReportJadwal()
        {
            InitializeComponent();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlConnect = new SqlConnection(Koneksi.Connect))
            {
                SqlConnect.Open();
                ReportDocument rd = new ReportDocument();
                SqlDataAdapter da = new SqlDataAdapter("EXEC spFilterMK '" + txtCari.Text + "','" + txtProdi.Text + "' ", SqlConnect);
                DataSet dst = new DataSet();
                da.Fill(dst, "spDashboard");
                rd.Load(@"D:\SEMESTER 5\PEMROGRAMAN VISUAL\SIPMK fix\SIPMK\SIPMK\ReportMK.rpt");
                rd.SetDataSource(dst);
                crystalReportViewer1.ReportSource = rd;
            }
        }

        private void btnShowall_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlConnect = new SqlConnection(Koneksi.Connect))
            {
                SqlConnect.Open();
                ReportDocument rd = new ReportDocument();
                SqlDataAdapter da = new SqlDataAdapter(" EXEC spDashboard", SqlConnect);
                DataSet dst = new DataSet();
                da.Fill(dst, "spDashboard");
                rd.Load(@"D:\a. Semester 5\Pemrograman Visual\UAS\SIPMK\SIPMK\ReportMK.rpt");
                rd.SetDataSource(dst);
                crystalReportViewer1.ReportSource = rd;
            }
        }
    }
}
