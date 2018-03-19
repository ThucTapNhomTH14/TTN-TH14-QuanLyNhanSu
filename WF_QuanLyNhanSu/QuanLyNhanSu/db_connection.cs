using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace WindowsFormsApplication1
{
     public class db_connection
    {
        //đổ data của nhân sự về DataGridView
        public static DataSet GetThongtincanhan()
        {
            DataSet data = new DataSet();
            string query = "exec getThongtincanhan";
            using (SqlConnection connection = new SqlConnection(connection_string.ConnectionString)) {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query,connection);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        //update thong tin nhan su
        public static void updateThongtincanhan(string manv,string tennv, string cmnd, string sdt, string diachi, string ngaysinh, string maphong, int tdhv)
        {
            using (SqlConnection connection = new SqlConnection(connection_string.ConnectionString))
            {
                SqlCommand query = new SqlCommand("exec updateThongtincanhan @manv, @tennv, @cmnd, @sdt, @diachi, @ngaysinh, @maphong, @tdhv");
                query.Parameters.Add("@manv", SqlDbType.VarChar, 10);
                query.Parameters.Add("@tennv", SqlDbType.NVarChar, 50);
                query.Parameters.Add("@cmnd", SqlDbType.VarChar, 10);
                query.Parameters.Add("@sdt", SqlDbType.VarChar, 11);
                query.Parameters.Add("@diachi", SqlDbType.NVarChar, 10);
                query.Parameters.Add("@ngaysinh", SqlDbType.Date, 10);
                query.Parameters.Add("@maphong", SqlDbType.VarChar, 10);
                query.Parameters.Add("@tdhv", SqlDbType.Int);

                connection.Open();
                query.ExecuteNonQuery();
                connection.Close();
            }         
        }
    }
}
