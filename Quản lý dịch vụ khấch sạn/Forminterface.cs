using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_dịch_vụ_khấch_sạn
{
    public partial class frmFormChinh : Form
    {
        public frmFormChinh()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlogin login = new frmlogin();
            login.ShowDialog();
            this.Close();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmFormChinh_Load(object sender, EventArgs e)
        {

        }
    }
}
