using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_csharp.Singleton
{
    public class DatabaseHelper
    {
        private static Connection conn;

        /// <summary>
        /// method GetConnection berfungsi untuk membuat koneksi ke database. method ini menggunakan design pattern untuk meminimalisir koneksi ke db.
        /// jika koneksi sudah pernah di buat maka koneksi yang telah dibuat akan di gunakan
        /// </summary>
        /// <returns>instance dari Connection</returns>
        public static Connection GetConnection()
        {
            if (conn == null)
            {
                conn = new Connection("localhost", "andi", "password");
            }
            return conn;
        }
    }
}
