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

namespace SIPMK
{
    public partial class PanelDashboard : Form
    {
        public PanelDashboard()
        {
            InitializeComponent();
        }
        void Display()
        {
            try
            {

                using (SqlConnection SqlConnect = new SqlConnection(Koneksi.Connect))
                {
                    SqlConnect.Open();
                    SqlDataAdapter sqlDisplay = new SqlDataAdapter("EXEC spDashboard", SqlConnect);
                    sqlDisplay.SelectCommand.ExecuteNonQuery();

                    DataTable data = new DataTable();
                    sqlDisplay.Fill(data);

                    dgvTransaksiPenjualan.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Search()
        {
            try
            {
                using (SqlConnection SqlConnect = new SqlConnection(Koneksi.Connect))
                {
                    SqlConnect.Open();
                    SqlDataAdapter carisemua = new SqlDataAdapter("EXEC spCariDb @CARI", SqlConnect);
                    carisemua.SelectCommand.Parameters.AddWithValue("@CARI", txtCari.Text.Trim());
                    carisemua.SelectCommand.ExecuteNonQuery();

                    DataTable data = new DataTable();
                    carisemua.Fill(data);

                    dgvTransaksiPenjualan.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PanelDashboard_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dgvTransaksiPenjualan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
