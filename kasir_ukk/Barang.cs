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
    public partial class Barang : Form
    {
        SqlConnection koneksi;
        int SelectedRow = 0;
        public Barang()
        {
            InitializeComponent();
            koneksi = DatabaseManager.GetConnection();
        }

        //LIST FUNGSI
        private void TambahData(string nama, decimal harga, int stok)
        {

            string query = "INSERT INTO produk (nama, harga, stok) VALUES (@nama, @harga, @stok)";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@stok", stok);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Berhasil Dimasukkan!");
        }

        private void LoadData()
        {
            string query = "SELECT * FROM produk";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dgvBarang.AutoGenerateColumns = false;
            dgvBarang.DataSource = dataTable;
        }

        private void ClearTextBox()
        {
            txtbNama.Clear();
            txtbHarga.Clear();
            txtbStok.Clear();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtbNama.Text) || String.IsNullOrWhiteSpace(txtbHarga.Text) || String.IsNullOrWhiteSpace(txtbStok.Text))
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
            decimal harga = 0;
            int stok = 0;

            if (!decimal.TryParse(txtbHarga.Text, out harga) || !int.TryParse(txtbStok.Text, out stok))
            {
                MessageBox.Show("Kolom Harga atau Barang Harus Berupa Angka!");
                return;
            }


            TambahData(nama, harga, stok);
            LoadData();
            ClearTextBox();
        }

        private void Barang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvBarang_Click(object sender, EventArgs e)
        {

        }

        private void dgvBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = int.Parse(dgvBarang.CurrentRow.Cells["clmId"].Value.ToString());

            string query = "SELECT nama, harga, stok FROM produk WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.Parameters.AddWithValue("@id", SelectedRow);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtbNama.Text = reader["nama"].ToString();
                txtbHarga.Text = reader["harga"].ToString();
                txtbStok.Text = reader["stok"].ToString();
            }

            reader.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtbNama.Text) || String.IsNullOrWhiteSpace(txtbHarga.Text) || String.IsNullOrWhiteSpace(txtbStok.Text))
            {
                MessageBox.Show("Harap isi Semua Kolom!");
                return;
            }

            DialogResult result = MessageBox.Show("Apakah Anda Yakin Ingin Memperbaharui Data Id " + SelectedRow + " ?", "", MessageBoxButtons.YesNo);

            switch (result)
            {
                case DialogResult.No:
                    return;
                default:
                    break;
            }

            string nama = txtbNama.Text;
            decimal harga = 0;
            int stok = 0;

            if (!decimal.TryParse(txtbHarga.Text, out harga) || !int.TryParse(txtbStok.Text, out stok))
            {
                MessageBox.Show("Kolom Harga atau Stok Harus Berupa Angka!");
                return;
            }

            string query = "UPDATE produk SET nama = @nama, harga = @harga, stok = @stok WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@stok", stok);
            cmd.Parameters.AddWithValue("@id", SelectedRow);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Berhasil Diperbaharui!");
            SelectedRow = 0;
            LoadData();
            ClearTextBox();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Id " + SelectedRow + " ?", "", MessageBoxButtons.YesNo);

            switch (result)
            {
                case DialogResult.No:
                    return;
                default:
                    break;
            }


            string query = "DELETE FROM produk WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.Parameters.AddWithValue("@id", SelectedRow);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Berhasil Dihapus!");
            SelectedRow = 0;
            ClearTextBox();
            LoadData();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Barang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
