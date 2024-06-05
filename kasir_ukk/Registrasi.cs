using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasir_ukk
{
    public partial class Registrasi : Form
    {
        SqlConnection koneksi;
        int SelectedRow = 0;
        public Registrasi()
        {
            InitializeComponent();
            koneksi = DatabaseManager.GetConnection();
        }

        private void Registrasi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtbNama.Text) || String.IsNullOrWhiteSpace(txtbAlamat.Text) || String.IsNullOrWhiteSpace(txtbNomorTelepon.Text))
            {
                MessageBox.Show("Harap isi Semua Kolom!");
                return;
            }

            DialogResult result = MessageBox.Show("Apakah Anda Yakin Ingin Menambahkan Data Tersebut?", "", MessageBoxButtons.YesNo);

            switch (result)
            {
                case DialogResult.No:
                    return;
                default:
                    break;
            }

            string nama = txtbNama.Text;
            string alamat = txtbAlamat.Text;
            string noTelepon = txtbNomorTelepon.Text;

            string query = "INSERT INTO pelanggan(nama, alamat, nomor_telepon) VALUES (@nama, @alamat, @no_telepon)";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@alamat", alamat);
            cmd.Parameters.AddWithValue("@no_telepon", noTelepon);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Berhasil Dimasukkan!");

            ClearTextBox();
        }

        private void Registrasi_Activated(object sender, EventArgs e)
        {
            LoadData();
        }

        //---LIST FUNGSI---//
        private void ClearTextBox()
        {
            txtbNama.Clear();
            txtbAlamat.Clear();
            txtbNomorTelepon.Clear();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM pelanggan";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvPelanggan.AutoGenerateColumns = false;
            dgvPelanggan.DataSource = dt;
        }

        private void EditData()
        {
            DialogResult result = MessageBox.Show("Apakah Anda Yakin Ingin Mengupdate Data Id" + SelectedRow, "", MessageBoxButtons.YesNo);

            switch (result)
            {
                case DialogResult.No:
                    return;
                default:
                    break;
            }

            string query = "UPDATE pelanggan SET nama = @nama, alamat = @alamat, nomor_telepon = @nomor_telepon WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.Parameters.AddWithValue("@nama", txtbNama.Text);
            cmd.Parameters.AddWithValue("@alamat", txtbAlamat.Text);
            cmd.Parameters.AddWithValue("@nomor_telepon", txtbNomorTelepon.Text);
            cmd.Parameters.AddWithValue("@id", SelectedRow);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Berhasil Diperbaharui!");

            SelectedRow = 0;
        }

        private void HapusData()
        {
            DialogResult result = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Id " + SelectedRow, "", MessageBoxButtons.YesNo);

            switch (result)
            {
                case DialogResult.No:
                    return;
                default:
                    break;
            }

            string query = "DELETE FROM pelanggan WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.Parameters.AddWithValue("@id", SelectedRow);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Berhasil Dihapus!");
        }

        private void FindData(int id)
        {
            string query = "SELECT nama, alamat, nomor_telepon FROM pelanggan WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtbNama.Text = reader["nama"].ToString();
                txtbAlamat.Text = reader["alamat"].ToString();
                txtbNomorTelepon.Text = reader["nomor_telepon"].ToString();
            }

            reader.Close();
        }

        //NOT USE!;
        private void dgvPelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        //-----

        private void dgvPelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearTextBox();
            SelectedRow = int.Parse(dgvPelanggan.CurrentRow.Cells["clmId"].Value.ToString());
            FindData(SelectedRow);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void txtbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            HapusData();
            ClearTextBox();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
