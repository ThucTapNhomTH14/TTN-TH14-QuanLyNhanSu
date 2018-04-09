using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public class db_connection
    {
        //đổ data của nhân sự về DataGridView
        //đã sửa lại theo ông Tiến Chung về các hàm tương tác với DB

        //đú theo ông Chung :)
        private static db_connection instance;

        public static db_connection Instance
        {
            get { if (instance == null) instance = new db_connection(); return db_connection.instance; }
            private set { db_connection.instance = value; }
        }

        private db_connection() { }
        //

        public string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
        public DataTable ExecuteQuery(string query,object[] parameter =null)
        {
            try
            {
                DataTable data = new DataTable();
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    adapter.Fill(data);

                    connection.Close();
                }
                return data;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi kết nối!");
                return null;
            }
        }

        public void ExecuteNonQuery(string query)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối!");
                Debug.WriteLine(e.ToString());
            }
        }

        //update thong tin nhan su
        /*
        public void updateThongtincanhan(string manv,string tennv, string cmnd, string sdt, string diachi, string ngaysinh, string maphong, int tdhv)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
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
        }*/
    }
}
