using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasir_ukk
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            lblTipeUser.Text = Users.role;

            if (Users.role != "admin" && Users.role != "Admin" && Users.role != "ADMIN")
            {
                btnRegistrasi.Visible = false;
            }

            //if (Users.role != "admin" || Users.role != "ADMIN" || Users.role != "Admin")
            //{
            //    btnRegistrasi.Visible = false;
            //}


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrasi_Click(object sender, EventArgs e)
        {
            Registrasi registrasi = new Registrasi();
            registrasi.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            Barang barang = new Barang();
            barang.Show();
            this.Hide();
        }

        private void Kasir_Click(object sender, EventArgs e)
        {
            Pembelian kasir = new Pembelian();
            kasir.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Users.id = 0;
            Users.nama = null;
            Users.username = null;
            Users.email = null;
            Users.role = null;

            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
