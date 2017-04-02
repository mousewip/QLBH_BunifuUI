using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace DTO
{
    public static class Helper
    {


        /// <summary>
        /// Test that the server is connected
        /// </summary>
        /// <param name="connectionString">The connection string</param>
        /// <returns>true if the connection is opened</returns>
        public static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
        public static string Md5Encrypt(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(Encoding.ASCII.GetBytes(text));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            foreach (var t in result)
            {
//change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(t.ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
