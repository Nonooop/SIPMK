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
    public partial class DataDosen : Form
    {
        //private SqlCommand cmd;
        public string jk, keahlian;
        public DataDosen()
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
                    SqlDataAdapter sqlDisplay = new SqlDataAdapter("EXEC spDataDosen", SqlConnect);
                    sqlDisplay.SelectCommand.ExecuteNonQuery();

                    DataTable data = new DataTable();
                    sqlDisplay.Fill(data);

                    dgvDosen.DataSource = data;
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
                    SqlDataAdapter GetUser = new SqlDataAdapter("EXEC spCariDataDosen @CARI", SqlConnect);
                    GetUser.SelectCommand.Parameters.AddWithValue("@CARI", txtCari.Text.Trim());
                    GetUser.SelectCommand.ExecuteNonQuery();

                    DataTable data = new DataTable();
                    GetUser.Fill(data);

                    dgvDosen.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ClearData()
        {
            txtID.Clear();
            txtNama.Clear();
            txtEmail.Clear();
            txtTlp.Clear();
            txtAlamat.Clear();
        }
        private void DataDosen_Load(object sender, EventArgs e)
        {
            Display();
            ClearData();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() == "" || txtNama.Text.Trim() == "" || txtTlp.Text.Trim() == "" ||
                txtEmail.Text.Trim() == "" || txtAlamat.Text.Trim() == "")
                {
                    MessageBox.Show("Data tidak boleh dikosongkan");
                }
                else
                {
                    using (SqlConnection SqlConnectSimpan = new SqlConnection(Koneksi.Connect))
                    {
                        
                        SqlConnectSimpan.Open();
                        if (rbL.Checked == true)
                        {
                            jk = rbL.Text;
                        }
                        else if (rbP.Checked == true)
                        {
                            jk = rbP.Text;
                        }

                        
                        
                        if (cbCitraDigital.Checked == true && cbDatabase.Checked == true && cbDatascience.Checked == true && cbSA.Checked == true)
                        {
                            keahlian =  cbCitraDigital.Text + ',' + cbDatabase.Text + ',' + cbDatascience.Text + ',' + cbSA.Text;
                        }
                        else if (cbProgramming.Checked == true && cbCitraDigital.Checked == true && cbDatabase.Checked == true && cbDatascience.Checked == true && cbSA.Checked == true)
                        {
                            keahlian = cbProgramming.Text + ',' + cbCitraDigital.Text + ',' + cbDatabase.Text + ',' + cbDatascience.Text + ',' + cbSA.Text;
                        }
                        else if (cbDatabase.Checked == true && cbDatascience.Checked == true && cbSA.Checked == true)
                        {
                            keahlian =  cbDatabase.Text + ',' + cbDatascience.Text + ',' + cbSA.Text;
                        }
                        else if (cbProgramming.Checked == true && cbCitraDigital.Checked == true && cbDatabase.Checked == true && cbDatascience.Checked == true)
                        {
                            keahlian = cbProgramming.Text + ',' + cbCitraDigital.Text + ',' + cbDatabase.Text + ',' + cbDatascience.Text;
                        }
                        else if (cbLainnya.Checked == true && cbCitraDigital.Checked == true)
                        {
                            keahlian = cbLainnya.Text + ',' + cbCitraDigital.Text;
                        }
                        else if (cbDatabase.Checked == true && cbProgramming.Checked == true)
                        {
                            keahlian = cbDatabase.Text + ',' + cbProgramming.Text;
                        }
                        else if (cbDatascience.Checked == true && cbSA.Checked == true)
                        {
                            keahlian = cbDatascience.Text + ',' + cbSA.Text;
                        }
                        else if (cbDatabase.Checked == true)
                        {
                            keahlian = cbDatabase.Text;
                        }
                        else if (cbCitraDigital.Checked == true)
                        {
                            keahlian = cbCitraDigital.Text;
                        }
                        else if (cbDatascience.Checked == true)
                        {
                            keahlian = cbDatascience.Text;
                        }

                        else if (cbProgramming.Checked == true)
                        {
                            keahlian = cbProgramming.Text;
                        }
                        else if (cbSA.Checked == true)
                        {
                            keahlian = cbSA.Text;
                        }
                        else if (cbLainnya.Checked == true)
                        {
                            keahlian = cbLainnya.Text;
                        }
                        else
                        {
                            keahlian = "Tidak Ada";
                            //keahlian = cbProgramming.Text + ',' + cbCitraDigital.Text + ',' + cbDatabase.Text + ',' + cbDatascience.Text + ',' + cbSA.Text;
                        }

                        SqlDataAdapter Insert = new SqlDataAdapter("EXEC spInputDosen @ID, @NAMA,@JK, @ALAMAT, @TLP, @EMAIL, @AHLI", SqlConnectSimpan);
                        Insert.SelectCommand.Parameters.AddWithValue("@ID", txtID.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@NAMA", txtNama.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@JK", jk.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@ALAMAT", txtAlamat.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@TLP", txtTlp.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@EMAIL", txtEmail.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@AHLI", keahlian.Trim());
                        Insert.SelectCommand.ExecuteNonQuery();

                        MessageBox.Show("Data Tersimpan");
                        ClearData();
                        Display();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDosen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvDosen.SelectedRows)
                {
                    txtID.Text = row.Cells[0].Value.ToString();
                    txtNama.Text = row.Cells[1].Value.ToString();
                    if (row.Cells[2].Value.ToString() == "Laki-laki")
                    {
                        rbL.Checked = true;
                    }
                    else if (row.Cells[2].Value.ToString() == "Perempuan")
                    {
                        rbP.Checked = true;
                    }
                    
                    txtAlamat.Text = row.Cells[3].Value.ToString();
                    txtTlp.Text = row.Cells[4].Value.ToString();
                    txtEmail.Text = row.Cells[5].Value.ToString();

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

                    if (rbL.Checked == true)
                    {
                        jk = rbL.Text;
                    }
                    else if (rbP.Checked == true)
                    {
                        jk = rbP.Text;
                    }

                    if (cbCitraDigital.Checked == true && cbDatabase.Checked == true && cbDatascience.Checked == true && cbSA.Checked == true)
                    {
                        keahlian = cbCitraDigital.Text + ',' + cbDatabase.Text + ',' + cbDatascience.Text + ',' + cbSA.Text;
                    }
                    else if (cbProgramming.Checked == true && cbCitraDigital.Checked == true && cbDatabase.Checked == true && cbDatascience.Checked == true && cbSA.Checked == true)
                    {
                        keahlian = cbProgramming.Text + ',' + cbCitraDigital.Text + ',' + cbDatabase.Text + ',' + cbDatascience.Text + ',' + cbSA.Text;
                    }
                    else if (cbDatabase.Checked == true && cbDatascience.Checked == true && cbSA.Checked == true)
                    {
                        keahlian = cbDatabase.Text + ',' + cbDatascience.Text + ',' + cbSA.Text;
                    }
                    else if (cbProgramming.Checked == true && cbCitraDigital.Checked == true && cbDatabase.Checked == true && cbDatascience.Checked == true)
                    {
                        keahlian = cbProgramming.Text + ',' + cbCitraDigital.Text + ',' + cbDatabase.Text + ',' + cbDatascience.Text;
                    }
                    else if (cbLainnya.Checked == true && cbCitraDigital.Checked == true)
                    {
                        keahlian = cbLainnya.Text + ',' + cbCitraDigital.Text;
                    }
                    else if (cbDatabase.Checked == true && cbProgramming.Checked == true)
                    {
                        keahlian = cbDatabase.Text + ',' + cbProgramming.Text;
                    }
                    else if (cbDatascience.Checked == true && cbSA.Checked == true)
                    {
                        keahlian = cbDatascience.Text + ',' + cbSA.Text;
                    }
                    else if (cbDatabase.Checked == true)
                    {
                        keahlian = cbDatabase.Text;
                    }
                    else if (cbCitraDigital.Checked == true)
                    {
                        keahlian = cbCitraDigital.Text;
                    }
                    else if (cbDatascience.Checked == true)
                    {
                        keahlian = cbDatascience.Text;
                    }

                    else if (cbProgramming.Checked == true)
                    {
                        keahlian = cbProgramming.Text;
                    }
                    else if (cbSA.Checked == true)
                    {
                        keahlian = cbSA.Text;
                    }
                    else if (cbLainnya.Checked == true)
                    {
                        keahlian = cbLainnya.Text;
                    }
                    else
                    {
                        keahlian = "Tidak Ada";
                        //keahlian = cbProgramming.Text + ',' + cbCitraDigital.Text + ',' + cbDatabase.Text + ',' + cbDatascience.Text + ',' + cbSA.Text;
                    }
                    DialogResult dr = MessageBox.Show("Anda yakin ingin mengubah data " + txtID.Text + " ?",
                        "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        SqlCommand update = new SqlCommand("EXEC spUpdateDosen @ID, @NAMA, @ALAMAT, @TLP, @EMAIL", IdSqlConnectEdit);
                        update.Parameters.AddWithValue("@ID", txtID.Text.Trim());
                        update.Parameters.AddWithValue("@NAMA", txtNama.Text.Trim());
                        update.Parameters.AddWithValue("@ALAMAT", txtAlamat.Text.Trim());
                        update.Parameters.AddWithValue("@TLP", txtTlp.Text.Trim());
                        update.Parameters.AddWithValue("@EMAIL", txtEmail.Text.Trim());
                        update.ExecuteNonQuery();

                        MessageBox.Show("Data " + txtNama.Text + "  Terupdate");
                        ClearData();
                        Display();
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
                    DialogResult dr = MessageBox.Show("Anda yakin ingin menghapus data " + txtNama.Text + " ?",
                        "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        SqlCommand hapus = new SqlCommand("EXEC spHapusDosen @ID ", IdSqlConnectHps);
                        hapus.Parameters.AddWithValue("@ID", txtID.Text);
                        hapus.ExecuteNonQuery();

                        MessageBox.Show("Data " + txtNama.Text + "  Terhapus");
                        ClearData();
                        Display();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Display();
            ClearData();
        }
    }
}
