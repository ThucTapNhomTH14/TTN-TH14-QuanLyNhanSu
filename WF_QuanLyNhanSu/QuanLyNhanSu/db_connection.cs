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
    }
}
