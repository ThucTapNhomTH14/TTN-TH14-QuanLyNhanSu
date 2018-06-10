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
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
            btnCapnhat_Click(this,EventArgs.Empty);
            InitDiploma(cbDiploma);
            InitDepartment(cb_department);
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            //goi ham trong class: "db_connection"
            string query = "exec GetThongtincanhan";
            dgv_nhansu.DataSource = db_connection.Instance.ExecuteQuery(query);
            dgv_nhansu.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (dgv_nhansu.DataSource == null)
            {
                toolStripStatusUpdateLabel.Text = "Lỗi kết nối... Vui lòng kiểm tra kết nối mạng";
            }
            else
            {
                string time_to_display = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                toolStripStatusUpdateLabel.Text = "Dữ liệu được cập nhật lần cuối vào " + time_to_display;
            }
        }
        
        
        private void InitDiploma(ComboBox cb)
        {
            string query = "select tentdhv from trinhdohocvan";
            
            DataTable dt = db_connection.Instance.ExecuteQuery(query);
            
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                cb.Items.Add(dt.Rows[i]["tentdhv"].ToString());
            }
        }
        private void InitDepartment(ComboBox cb)
        {
            string query = "select tenphong from phongban";
            DataTable dt = db_connection.Instance.ExecuteQuery(query);
            for(int i=0; i < dt.Rows.Count; i++)
            {
                cb.Items.Add(dt.Rows[i]["tenphong"].ToString());
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            // dang le tao ra object roi truyen object vao instance cua form update =))
            // thoi lo ngu roi thi ngu cho het =)) // Trung
            update_form update = new update_form();
            
            int row_index = dgv_nhansu.SelectedCells[0].RowIndex;
            DataGridViewRow selected_row = dgv_nhansu.Rows[row_index];
            InitDiploma(update.cbDiploma);
            InitDepartment(update.cb_department);

            //hien thong tin nguoi dung duoc chon len form
            update.lb_id_string.Text = Convert.ToString(selected_row.Cells[0].Value);
            update.txtName.Text = selected_row.Cells[1].Value.ToString();
            update.txtCMND.Text = selected_row.Cells[2].Value.ToString();
            update.txtSDT.Text = selected_row.Cells[3].Value.ToString();
            update.txtAddress.Text = selected_row.Cells[4].Value.ToString();
            update.dateTimePicker1.Text = selected_row.Cells[5].Value.ToString();
            update.cb_department.Text = selected_row.Cells[6].Value.ToString();
            update.cbDiploma.Text = selected_row.Cells[7].Value.ToString();

            update.ShowDialog();

            btnCapnhat_Click(this, null);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int row_index = dgv_nhansu.SelectedCells[0].RowIndex;
            string nhanvien_id = dgv_nhansu.Rows[row_index].Cells[0].Value.ToString();
            string query = "exec deleteNhanSu"+" '"+nhanvien_id+"'";
            db_connection.Instance.ExecuteNonQuery(query);
            btnCapnhat_Click(this, null);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            create_form create = new create_form();

            InitDiploma(create.cbDiploma);
            InitDepartment(create.cb_department);

            create.ShowDialog();

            btnCapnhat_Click(this, null);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgv_nhansu.DataSource;

            string filter = "";


            // Check if text fields are not null before adding to filter. 
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                filter += "tennv" + " LIKE '%" + txtName.Text + "%' ";
            }
            if (!string.IsNullOrEmpty(txtCMND.Text))
            {
                if (filter.Length > 0) filter += "AND ";
                filter += "cmnd" + " LIKE '%" + txtCMND.Text + "%' ";
            }
            if (!string.IsNullOrEmpty(txtSDT.Text))
            {
                if (filter.Length > 0) filter += "AND ";
                filter += "sdt" + " LIKE '%" + txtSDT.Text + "%' ";
            }
            if (!string.IsNullOrEmpty(txtAddress.Text))
            {
                if (filter.Length > 0) filter += "AND ";
                filter += "diachi" + " LIKE '%" + txtAddress.Text + "%' ";
            }
            if (!string.IsNullOrEmpty(cb_department.Text))
            {
                if (filter.Length > 0) filter += "AND ";
                filter += "tenphong" + " LIKE '%" + cb_department.Text + "%' ";
            }
            if (!string.IsNullOrEmpty(cbDiploma.Text))
            {
                if (filter.Length > 0) filter += "AND ";
                filter += "tentdhv" + " LIKE '%" + cbDiploma.Text + "%' ";
            }
            
            bs.Filter = filter;
            dgv_nhansu.DataSource = bs;
        }
        
    }
}
