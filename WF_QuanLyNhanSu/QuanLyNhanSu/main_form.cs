using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            //goi ham trong class: "db_connection"
            dgv_nhansu.DataSource = db_connection.GetThongtincanhan().Tables[0];
            string time_to_display = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            toolStripStatusUpdateLabel.Text = "Dữ liệu được cập nhật lần cuối vào " + time_to_display;
        }
    }
}
