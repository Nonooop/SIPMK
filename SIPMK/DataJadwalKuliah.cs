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
    
    public partial class DataJadwalKuliah : Form
    {
        private SqlCommand cmd;
        private SqlDataReader dr;
        public DataJadwalKuliah()
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
                    SqlDataAdapter sqlDisplay = new SqlDataAdapter("EXEC spDataJadwalKuliah", SqlConnect);
                    sqlDisplay.SelectCommand.ExecuteNonQuery();

                    DataTable data = new DataTable();
                    sqlDisplay.Fill(data);

                    dgvJadwal.DataSource = data;
                    comboMK();
                    comboDosen();
                    comboRuangan();
                    comboProdi();
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
                    SqlDataAdapter GetCari = new SqlDataAdapter("EXEC spCariDataJadwalKuliah @CARI", SqlConnect);
                    GetCari.SelectCommand.Parameters.AddWithValue("@CARI", txtCari.Text.Trim());
                    GetCari.SelectCommand.ExecuteNonQuery();

                    DataTable data = new DataTable();
                    GetCari.Fill(data);

                    dgvJadwal.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void IdOtomatis()
        {
            long itung;
            string urut;
            SqlDataReader dr;
            using (SqlConnection IdSqlConnect = new SqlConnection(Koneksi.Connect))
            {
                IdSqlConnect.Open();
                cmd = new SqlCommand("EXECUTE spIdJadwalKuliah", IdSqlConnect);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    itung = Convert.ToInt64(dr[0].ToString().Substring(dr["kd_jadwal"].ToString().Length - 4, 4)) + 1;
                    string idurut = "0000" + itung;
                    urut = "JD" + idurut.Substring(idurut.Length - 4, 4);
                }
                else
                {
                    urut = "JD0001";
                }
                dr.Close();
                txtID.Text = urut;
            }

        }

        void comboMK()
        {
            using (SqlConnection IdSqlConnect = new SqlConnection(Koneksi.Connect))
            {
                IdSqlConnect.Open();
                cmd = new SqlCommand("EXEC spDataMK", IdSqlConnect);
                dr = cmd.ExecuteReader();
                dr.Read();
                while (dr.Read())
                {
                    cbMK.Items.Add(dr[1].ToString());
                }
                IdSqlConnect.Close();

            }
        }

        void comboDosen()
        {
            using (SqlConnection IdSqlConnect = new SqlConnection(Koneksi.Connect))
            {
                IdSqlConnect.Open();
                cmd = new SqlCommand("EXEC spDataDosen", IdSqlConnect);
                dr = cmd.ExecuteReader();
                dr.Read();
                while (dr.Read())
                {
                    cbDosen.Items.Add(dr[1].ToString());
                }
                IdSqlConnect.Close();
            }
        }

        void comboRuangan()
        {
            using (SqlConnection IdSqlConnect = new SqlConnection(Koneksi.Connect))
            {
                IdSqlConnect.Open();
                cmd = new SqlCommand("EXEC spDataRuangan", IdSqlConnect);
                dr = cmd.ExecuteReader();
                dr.Read();
                while (dr.Read())
                {
                    cbRuangan.Items.Add(dr[1].ToString());
                }
                IdSqlConnect.Close();
            }
        }

        void comboProdi()
        {
            using (SqlConnection IdSqlConnect = new SqlConnection(Koneksi.Connect))
            {
                IdSqlConnect.Open();
                cmd = new SqlCommand("EXEC spDataProdi", IdSqlConnect);
                dr = cmd.ExecuteReader();
                dr.Read();
                while (dr.Read())
                {
                    cbProdi.Items.Add(dr[1].ToString());
                }
                IdSqlConnect.Close();
            }
        }
        void ClearData()
        {
            txtID.Clear();
            cbHari.Text="";
            cbJam.Text = "";
            cbMK.Text = "";
            cbDosen.Text = "";
            cbRuangan.Text = "";
            cbProdi.Text = "";
        }


        private void DataJadwalKuliah_Load(object sender, EventArgs e)
        {
            ClearData();
            IdOtomatis();
            Display();
        }


        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() == "" || cbHari.Text.Trim() == ""
                    || cbJam.Text.Trim() == "" || cbMK.Text.Trim() == "" 
                    || cbDosen.Text.Trim() == "" || cbRuangan.Text.Trim() == "" || cbProdi.Text.Trim() == "")
                {
                    MessageBox.Show("Data tidak boleh dikosongkan");
                }
                else
                {
                    using (SqlConnection SqlConnectSimpan = new SqlConnection(Koneksi.Connect))
                    {
                        SqlConnectSimpan.Open();
                        SqlDataAdapter Insert = new SqlDataAdapter("EXEC spInputJadwalKuliah @ID, @HARI,@JAM,@MK, @NIDN ,@R, @PRODI", SqlConnectSimpan);
                        Insert.SelectCommand.Parameters.AddWithValue("@ID", txtID.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@HARI", cbHari.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@JAM", cbJam.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@MK", cbMK.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@NIDN", cbDosen.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@R", cbRuangan.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@PRODI", cbProdi.Text.Trim());
                        Insert.SelectCommand.ExecuteNonQuery();

                        MessageBox.Show("Data Tersimpan");
                        ClearData();
                        Display();
                        IdOtomatis();
                        //SqlConnectSimpan.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvJadwal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvJadwal.SelectedRows)
                {
                    txtID.Text = row.Cells[0].Value.ToString();
                    cbHari.Text = row.Cells[1].Value.ToString();
                    cbJam.Text = row.Cells[2].Value.ToString();
                    cbMK.Text = row.Cells[3].Value.ToString();
                    cbDosen.Text = row.Cells[4].Value.ToString();
                    cbRuangan.Text = row.Cells[5].Value.ToString();
                    cbProdi.Text = row.Cells[6].Value.ToString();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection IdSqlConnectEdit = new SqlConnection(Koneksi.Connect))
                {
                    IdSqlConnectEdit.Open();
                    DialogResult dr = MessageBox.Show("Anda yakin ingin mengubah data " + cbMK.Text + " pada Hari " + cbHari.Text + "?",
                        "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        SqlCommand update = new SqlCommand("EXEC spUpdateJadwalKuliah @ID, @HARI, @JAM, @MK, @DOSEN, @R, @PRODI", IdSqlConnectEdit);
                        update.Parameters.AddWithValue("@ID", txtID.Text.Trim());
                        update.Parameters.AddWithValue("@HARI", cbHari.Text.Trim());
                        update.Parameters.AddWithValue("@JAM", cbJam.Text.Trim());
                        update.Parameters.AddWithValue("@MK", cbMK.Text.Trim());
                        update.Parameters.AddWithValue("@DOSEN", cbDosen.Text.Trim());
                        update.Parameters.AddWithValue("@R", cbRuangan.Text.Trim());
                        update.Parameters.AddWithValue("@PRODI", cbProdi.Text.Trim());
                        update.ExecuteNonQuery();

                        MessageBox.Show("Jadwal  Terupdate");
                        ClearData();
                        Display();
                        IdOtomatis();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection IdSqlConnectHps = new SqlConnection(Koneksi.Connect))
                {
                    IdSqlConnectHps.Open();
                    DialogResult dr = MessageBox.Show("Anda yakin ingin menghapus jadwal " + cbMK.Text + " pada Hari " + cbHari.Text + "?",
                        "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        SqlCommand hapus = new SqlCommand("EXEC spHapusJadwalKuliah @ID ", IdSqlConnectHps);
                        hapus.Parameters.AddWithValue("@ID", txtID.Text);
                        hapus.ExecuteNonQuery();

                        MessageBox.Show("Data  Terhapus");
                        ClearData();
                        Display();
                        IdOtomatis();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

    }
}
