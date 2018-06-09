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

namespace WindowsFormsApplication1
{
    public partial class update_form : Form
    {
        public update_form()
        {
            InitializeComponent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(db_connection.Instance.ConnectionString))
            {
                
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "exec updateThongtincanhan @manv, @tennv, @cmnd, @sdt, @diachi, @ngaysinh, @tenphong, @tentdhv";
                cmd.Parameters.Add("@manv", SqlDbType.VarChar, 10).Value = lb_id_string.Text;
                cmd.Parameters.Add("@tennv", SqlDbType.NVarChar, 50).Value = txtName.Text;
                cmd.Parameters.Add("@cmnd", SqlDbType.VarChar, 10).Value = txtCMND.Text;
                cmd.Parameters.Add("@sdt", SqlDbType.VarChar, 11).Value = txtSDT.Text;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 100).Value = txtAddress.Text;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = "1997-04-05";
                cmd.Parameters.Add("@tenphong", SqlDbType.NVarChar, 50).Value = cb_department.Text;
                cmd.Parameters.Add("@tentdhv", SqlDbType.NVarChar,10).Value = cbDiploma.Text;

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            this.Close();

        }
        
    }
}
