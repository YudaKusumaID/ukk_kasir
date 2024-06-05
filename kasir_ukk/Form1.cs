using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace kasir_ukk
{
    public partial class Form1 : Form
    {
        SqlConnection koneksi;
        public Form1()
        {
            InitializeComponent();

            koneksi = DatabaseManager.GetConnection();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtbUsername.Text) || String.IsNullOrWhiteSpace(txtbUsername.Text))
            {
                MessageBox.Show("Harap isi Semua Kolom!");
                return;
            }

            string username = txtbUsername.Text;
            string password = txtbPassword.Text;

            string query = "SELECT * FROM users WHERE username = @username AND password = @password";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Users.id = int.Parse(reader["id"].ToString());
                Users.nama = reader["nama"].ToString();
                Users.email = reader["email"].ToString();
                Users.role = reader["role"].ToString();

                reader.Close();

                Main main = new Main();
                main.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Username atau Password Salah!");
            }


            reader.Close();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbUsername.Clear();
            txtbPassword.Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}