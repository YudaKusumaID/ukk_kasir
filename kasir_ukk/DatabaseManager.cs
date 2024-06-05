using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasir_ukk
{
    internal class DatabaseManager
    {
        static string server = @"database = kasir; data source = localhost\SQLEXPRESS; User Id = sa; Password = 1234";
        static SqlConnection koneksi;

        public static SqlConnection GetConnection()
        {
            if (koneksi == null || koneksi.State == System.Data.ConnectionState.Closed)
            {
                koneksi = new SqlConnection(server);
                koneksi.Open();
            }

            return koneksi;
        }

        public static void CloseConnection()
        {
            if (koneksi != null || koneksi.State == System.Data.ConnectionState.Open)
            {
                koneksi.Close();
            }
        }
    }
}
