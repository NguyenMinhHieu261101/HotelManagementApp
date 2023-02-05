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
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {
           

        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDichVu QLDV = new frmQuanLyDichVu();
            QLDV.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe thongke = new frmThongKe();
            thongke.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmAccount tk = new frmAccount();
            tk.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmQLKH qlkh = new frmQLKH();
            qlkh.ShowDialog();
        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonForm hoaDon = new HoaDonForm();
            hoaDon.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFormChinh login = new frmFormChinh();
            login.ShowDialog();
        }
    } 
}
