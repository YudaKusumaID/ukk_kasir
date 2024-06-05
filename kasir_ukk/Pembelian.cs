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
    public partial class Pembelian : Form
    {
        SqlConnection koneksi;
        public Pembelian()
        {
            InitializeComponent();
            koneksi = DatabaseManager.GetConnection();
        }

        //LIST FUNGSI
        private void CariBarang(int id)
        {
            string query = "SELECT nama, harga FROM produk WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtbNamaBarang.Text = reader["nama"].ToString();
                txtbHargaSatuan.Text = reader["harga"].ToString();
            }

            reader.Close();
        }

        private void HitungTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow rows in dgvPembelian.Rows)
            {
                total += Convert.ToDecimal(rows.Cells["clmSubtotal"].Value.ToString());
            }

            txtbTotal.Text = total.ToString();
        }

        private void ResetTransaksi()
        {
            txtbIdPelanggan.Clear();
            txtbIdBarang.Clear();
            txtbNamaBarang.Clear();
            txtbHargaSatuan.Clear();
            txtbKuantitas.Clear();
            txtbSubtotal.Clear();
            dgvPembelian.Rows.Clear();
            txtbTotal.Clear();
            txtbTunai.Clear();
            txtbKembalian.Clear();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtbIdPelanggan.Text) || String.IsNullOrWhiteSpace(txtbIdBarang.Text) || String.IsNullOrWhiteSpace(txtbKuantitas.Text))
            {
                MessageBox.Show("Harap Isi Kolom Pelanggan, Barang, atau Kuantitas!");
                return;
            }

            dgvPembelian.Rows.Add(txtbIdBarang.Text, txtbNamaBarang.Text, txtbHargaSatuan.Text, txtbKuantitas.Text, txtbSubtotal.Text);

            HitungTotal();
        }

        private void txtbIdBarang_TextChanged(object sender, EventArgs e)
        {
            txtbNamaBarang.Clear();
            txtbHargaSatuan.Clear();
            txtbKuantitas.Clear();
            txtbSubtotal.Clear();

            try
            {
                if (!String.IsNullOrWhiteSpace(txtbIdBarang.Text))
                {

                    int idBarang = Convert.ToInt32(txtbIdBarang.Text.ToString());

                    CariBarang(idBarang);
                }

                //else
                //{
                //    txtbNamaBarang.Clear();
                //    txtbHargaSatuan.Clear();
                //    txtbKuantitas.Clear();
                //    txtbSubtotal.Clear();
                //}
            }
            catch
            {
                MessageBox.Show("Id Barang Tidak Valid!");
                return;
            }
        }

        private void txtbKuantitas_TextChanged(object sender, EventArgs e)
        {
            txtbSubtotal.Clear();

            try
            {
                if (!String.IsNullOrWhiteSpace(txtbKuantitas.Text))
                {
                    int kuantias = Convert.ToInt32(txtbKuantitas.Text);
                    decimal harga = Convert.ToDecimal(txtbHargaSatuan.Text);
                    decimal subTotal = kuantias * harga;
                    txtbSubtotal.Text = subTotal.ToString();
                }
            }

            catch
            {
                MessageBox.Show("Harap Masukkan Angka!");
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvPembelian.Rows.Clear();
            txtbTotal.Clear();
            txtbTunai.Clear();
            txtbKembalian.Clear();
        }

        private void txtbTunai_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(txtbTunai.Text))
                {
                    decimal total = Convert.ToDecimal(txtbTotal.Text);
                    decimal tunai = Convert.ToDecimal(txtbTunai.Text);
                    decimal kembalian = tunai - total;

                    txtbKembalian.Text = kembalian.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Harap Masukkan Angka!");
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda Yakin Ingin Menyimpan Transaksi Saat Ini?", "", MessageBoxButtons.YesNo);

            switch (result)
            {
                case DialogResult.No:
                    return;
                default:
                    break;
            }

            decimal total = 0;
            int idPelanggan = 0;

            try
            {
                total = Convert.ToDecimal(txtbTotal.Text);
                idPelanggan = Convert.ToInt32(txtbIdPelanggan.Text);
            }

            catch
            {
                MessageBox.Show("ID Pelanggan Tidak Valid!");
                return;
            }

            string query = "INSERT INTO penjualan (tanggal_penjualan, total_harga, id_pelanggan) VALUES (CURRENT_TIMESTAMP, @total_harga, @id_pelanggan)";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.Parameters.AddWithValue("@total_harga", total);
            cmd.Parameters.AddWithValue("@id_pelanggan", idPelanggan);
            cmd.ExecuteNonQuery();


            string query2 = "SELECT TOP 1 id FROM penjualan ORDER BY id DESC";
            SqlCommand cmd2 = new SqlCommand(query2, koneksi);
            SqlDataReader reader = cmd2.ExecuteReader();
            reader.Read();
            int idPenjualan = Convert.ToInt32(reader["id"]);
            reader.Close();

            foreach (DataGridViewRow rows in dgvPembelian.Rows)
            {
                string idBarang = rows.Cells["clmId"].Value.ToString();
                string kuantitas = rows.Cells["clmKuantitas"].Value.ToString();
                decimal subTotal = Convert.ToDecimal(rows.Cells["clmSubtotal"].Value.ToString());

                string query3 = "INSERT INTO detail_penjualan(id_penjualan, id_produk, jumlah, subtotal) VALUES (@id_penjualan, @id_produk,@jumlah_produk, @subtotal)";
                SqlCommand cmd3 = new SqlCommand(query3, koneksi);
                cmd3.Parameters.AddWithValue("@id_penjualan", idPenjualan);
                cmd3.Parameters.AddWithValue("@id_produk", idBarang);
                cmd3.Parameters.AddWithValue("@jumlah_produk", kuantitas);
                cmd3.Parameters.AddWithValue("@subtotal", subTotal);
                cmd3.ExecuteNonQuery();

            }

            MessageBox.Show("Transaksi Berhasil Disimpan!");

            ResetTransaksi();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Pembelian_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
