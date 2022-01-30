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
using System.IO;

namespace SIPMK
{
    public partial class DataUser : Form
    {
        private SqlCommand cmd;
        public DataUser()
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
                    SqlDataAdapter sqlDisplay = new SqlDataAdapter("EXEC spDataUser", SqlConnect);
                    sqlDisplay.SelectCommand.ExecuteNonQuery();

                    DataTable data = new DataTable();
                    sqlDisplay.Fill(data);

                    dgvUser.DataSource = data;
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
                    SqlDataAdapter GetUser = new SqlDataAdapter("EXEC spCariDataUser @CARI", SqlConnect);
                    GetUser.SelectCommand.Parameters.AddWithValue("@CARI", txtCari.Text.Trim());
                    GetUser.SelectCommand.ExecuteNonQuery();

                    DataTable data = new DataTable();
                    GetUser.Fill(data);

                    dgvUser.DataSource = data;
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
                cmd = new SqlCommand("EXECUTE spIdUser", IdSqlConnect);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    itung = Convert.ToInt64(dr[0].ToString().Substring(dr["kd_user"].ToString().Length - 3, 3)) + 1;
                    string idurut = "000" + itung;
                    urut = "USR" + idurut.Substring(idurut.Length - 3, 3);
                }
                else
                {
                    urut = "USR001";
                }
                dr.Close();
                txtID.Text = urut;
            }

        }

        void ClearData()
        {
            txtID.Clear();
            txtNama.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            cbLevel.Text = "Pilih Level User";
            PictureBox1.Image = null;
        }
        private void DataUser_Load(object sender, EventArgs e)
        {
            Display();
            ClearData();
            IdOtomatis();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() == "" || txtNama.Text.Trim() == "" || cbLevel.Text.Trim() == "" ||
                txtEmail.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Data tidak boleh dikosongkan");
                }
                else
                {
                    using (SqlConnection SqlConnectSimpan = new SqlConnection(Koneksi.Connect))
                    {
                        byte[] images = null;
                        FileStream streem = new FileStream(imgLocation,FileMode.Open,FileAccess.Read);
                        BinaryReader brs = new BinaryReader(streem);
                        images = brs.ReadBytes((int)streem.Length);

                        SqlConnectSimpan.Open();
                        SqlDataAdapter Insert = new SqlDataAdapter("EXEC spInputUser @ID, @NAMA,@IMAGES, @EMAIL, @PASSWD, @LEVEL", SqlConnectSimpan);
                        Insert.SelectCommand.Parameters.AddWithValue("@ID", txtID.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@NAMA", txtNama.Text.Trim());
                        //Insert.SelectCommand.Parameters.AddWithValue("@IMAGES", images);
                        Insert.SelectCommand.Parameters.AddWithValue("@IMAGES", txtLokasi.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@EMAIL", txtEmail.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@PASSWD", txtPassword.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@LEVEL", cbLevel.Text.Trim());
                        Insert.SelectCommand.ExecuteNonQuery();

                        MessageBox.Show("Data Tersimpan");
                        ClearData();
                        Display();
                        IdOtomatis();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvUser.SelectedRows)
                {
                    txtID.Text = row.Cells[0].Value.ToString();
                    txtNama.Text = row.Cells[1].Value.ToString();
                    //txtNama.Text = row.Cells[1].Value.ToString();
                    //Byte[] image = Encoding.ASCII.GetBytes(row.Cells[1].Value.ToString());
                    //var data = (Byte[])(row.Cells[2].Value);
                    //var stream = new MemoryStream(data);
                    //PictureBox1.Image = Image.FromStream(stream);
                    PictureBox1.ImageLocation = row.Cells[2].Value.ToString();
                    txtLokasi.Text=row.Cells[2].Value.ToString(); ;
                    txtEmail.Text = row.Cells[3].Value.ToString();
                    txtPassword.Text = row.Cells[4].Value.ToString();
                    cbLevel.Text = row.Cells[5].Value.ToString();
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

                    byte[] images = null;
                    FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(streem);
                    images = brs.ReadBytes((int)streem.Length);

                    IdSqlConnectEdit.Open();
                    DialogResult dr = MessageBox.Show("Anda yakin ingin mengubah data " + txtID.Text + " ?",
                        "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        SqlCommand update = new SqlCommand("EXEC spUpdateUser @ID, @NAMA, @IMAGES, @EMAIL, @PASSWD, @LEVEL", IdSqlConnectEdit);
                        update.Parameters.AddWithValue("@ID", txtID.Text.Trim());
                        update.Parameters.AddWithValue("@NAMA", txtNama.Text.Trim());
                        update.Parameters.AddWithValue("@IMAGES", txtLokasi.Text.Trim());
                        update.Parameters.AddWithValue("@EMAIL", txtEmail.Text.Trim());
                        update.Parameters.AddWithValue("@PASSWD", txtPassword.Text.Trim());
                        update.Parameters.AddWithValue("@LEVEL", cbLevel.Text.Trim());
                        update.ExecuteNonQuery();

                        MessageBox.Show("Data " + txtNama.Text + "  Terupdate");
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
                    DialogResult dr = MessageBox.Show("Anda yakin ingin menghapus data " + txtNama.Text + " ?",
                        "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        SqlCommand hapus = new SqlCommand("EXEC spHapusUser @ID ", IdSqlConnectHps);
                        hapus.Parameters.AddWithValue("@ID", txtID.Text);
                        hapus.ExecuteNonQuery();

                        MessageBox.Show("Data " + txtNama.Text + "  Terhapus");
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Display();
            ClearData();
            IdOtomatis();
        }
        public string imgLocation = "";
        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                PictureBox1.ImageLocation = imgLocation;
                txtLokasi.Text = imgLocation;
            }
        }

        private void txtLokasi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
