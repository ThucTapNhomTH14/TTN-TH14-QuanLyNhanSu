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
    public partial class create_form : Form
    {
        public create_form()
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
                cmd.CommandText = "exec addNhanvien @tennv, @cmnd, @sdt, @diachi, @ngaysinh, @tenphong, @tentdhv";
                cmd.Parameters.AddWithValue("@tennv", txtName.Text);
                cmd.Parameters.AddWithValue("@cmnd", txtCMND.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                cmd.Parameters.AddWithValue("@diachi", txtAddress.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@tenphong", cb_department.Text);
                cmd.Parameters.AddWithValue("@tentdhv", cbDiploma.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            this.Close();

        }
        
    }
}
