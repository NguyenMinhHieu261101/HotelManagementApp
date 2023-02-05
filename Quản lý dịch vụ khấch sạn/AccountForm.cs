using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Quản_lý_dịch_vụ_khấch_sạn
{
    public partial class frmAccount : Form
    {
        int index = 0;
        int last = 0;
        public static string chuoi = "Select  * From DangNhap";

        public frmAccount()
        {
            InitializeComponent();
            ChuoiKetNoi.Chuoiketnoi(chuoi, dgvAccount);
            Namecolumn();
        }

        private void Namecolumn()
        {

            dgvAccount.Columns[0].HeaderText = "Tài khoản"; dgvAccount.Columns[0].Width = 110;
            dgvAccount.Columns[1].HeaderText = "Mật khẩu"; dgvAccount.Columns[1].Width = 120;
            dgvAccount.Columns[2].HeaderText = "Họ và tên"; dgvAccount.Columns[2].Width = 100;
            dgvAccount.Columns[3].HeaderText = "Email"; dgvAccount.Columns[3].Width = 120;
            dgvAccount.Columns[4].HeaderText = "Phân Quyền"; dgvAccount.Columns[4].Width = 120;
            dgvAccount.Columns[5].HeaderText = "Trạng Thái"; dgvAccount.Columns[5].Width = 120;
            int sc = dgvAccount.Rows.Count;
            index = 0;
            last = sc - 1;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void PopulateData(int curow)
        {
            string quyen = "";
            string trangthai = "";
            txtTk.Text = dgvAccount.Rows[curow].Cells[0].Value.ToString();
            txtMk.Text = dgvAccount.Rows[curow].Cells[1].Value.ToString();
            txtHoTen.Text = dgvAccount.Rows[curow].Cells[2].Value.ToString();
            txtEmail.Text = dgvAccount.Rows[curow].Cells[3].Value.ToString();
            quyen = dgvAccount.Rows[curow].Cells[4].Value.ToString();
            trangthai = dgvAccount.Rows[curow].Cells[5].Value.ToString();
            if (quyen == "1") cbbPhanQuyen.Text = "Admin";
            if (quyen == "2") cbbPhanQuyen.Text = "Quan ly";
            if (quyen == "3") cbbPhanQuyen.Text = "Nguoi dung";
            if (trangthai == "1")
            {
                cbbTrangthai.Text = "Hoat dong";
                btnLockAccount.Enabled = true;
                btnOpenAccount.Enabled = false;
            }

            if (trangthai == "0")
            {
                cbbTrangthai.Text = "Khoa";

                btnLockAccount.Enabled = false;
                btnOpenAccount.Enabled = true;

            }
            txtTk.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvAccount.CurrentRow.Index;
            PopulateData(index);
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMk.Text == "" || txtTk.Text == "" || txtEmail.Text == "" || txtHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string username = txtTk.Text.Trim();
                string password = txtMk.Text.Trim();
                string fullname = txtHoTen.Text.Trim();
                string mail = txtEmail.Text.Trim(); ;
                string quyen = cbbPhanQuyen.Text;
                string trangthai = cbbTrangthai.Text;
                string q1 = check_quyen(quyen);
                string t1 = check_trangthai(trangthai);
                if (username.Length > 20)
                {
                    MessageBox.Show("Tên tài khoản quá dài ! Chỉ nhập nhiều nhất 15 ký tự", "Error", MessageBoxButtons.OK);
                    txtTk.Text = "";
                    txtTk.Focus();

                }
               
                else
                {
                    string sql = "Select count(*) from DangNhap where Taikhoan ='" + username + "'";
                    string sql1 = "Insert into DangNhap values(N'" + username + "',N'" + password + "',";
                    sql1 += "N'" + fullname + "','" + mail + "','" + q1 + "','" + t1 + "')";
                    ChuoiKetNoi.them(sql, sql1, dgvAccount);
                    ChuoiKetNoi.Chuoiketnoi(chuoi, dgvAccount);
                    Namecolumn();
                    Clear();
                }
            }
        }

        string check_quyen(string quyen)
        {
            string quyenq = "";
            if (quyen.ToString() == "Admin") quyenq = "1";
            if (quyen.ToString() == "Quản lý") quyenq = "2";
            if (quyen.ToString() == "Người dùng" || quyen.ToString() == "") quyenq = "3";
            return quyenq;
        }

        string check_trangthai(string quyen1)
        {
            string tt = "";
            if (quyen1.ToString() == "Hoạt động") tt = "1";
            if (quyen1.ToString() == "Khóa") tt = "0";
            return tt;
        }

        private void Clear()
        {
            txtTk.Enabled = true;
            txtMk.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtTk.Text = "";
            txtSearch.Text = "";
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = true;
            btnOpenAccount.Enabled = false;
            txtTk.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            
                string username = txtTk.Text.Trim();
                string password = txtMk.Text.Trim();
                string fullname = txtHoTen.Text.Trim();
                string mail = txtEmail.Text.Trim();
                string quyen = cbbPhanQuyen.Text;
                string trangthai = cbbTrangthai.Text;
                string q1 = "", t1 = "";
                q1 = check_quyen(quyen);
                t1 = check_trangthai(trangthai);
                string sql = "Update DangNhap set Matkhau = N'" + password + "',";
                sql += "FullName = N'" + fullname + "',Email = '" + mail + "',";
                sql += "phanquyen = '" + q1 + "', trangthai='" + t1 + "'  where Taikhoan = '" + username + "'";
                ChuoiKetNoi.Sua(sql);
                ChuoiKetNoi.Chuoiketnoi(chuoi, dgvAccount);
                Namecolumn();
                Clear();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "Delete from DangNhap where Taikhoan = N'" + txtTk.Text + "'";
            ChuoiKetNoi.Xoa(sql);
            ChuoiKetNoi.Chuoiketnoi(chuoi, dgvAccount);
            Namecolumn();
            Clear();
        }

        private void btnLockAccount_Click(object sender, EventArgs e)
        {
            int trangthai = 0;
            string sql = "Update DangNhap set trangthai='" + trangthai + "'  where Taikhoan = '" + txtTk.Text + "'";
            if (MessageBox.Show("Bạn có chắc chăn muốn khóa tài khoản này ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                ChuoiKetNoi.Rekey(sql);
                MessageBox.Show("Bạn khóa thành công ! Tài khoản sẽ không thế đăng nhập được ", "Thông báo", MessageBoxButtons.OK);
                ChuoiKetNoi.Chuoiketnoi(chuoi, dgvAccount);
                Namecolumn();
                Clear();
            }
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            int trangthai = 1;
            if (MessageBox.Show("Bạn có chắc chắn muốn mở khóa tài khoản này ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string sql = "Update DangNhap set trangthai='" + trangthai + "'  where Taikhoan = '" + txtTk.Text + "'";
                ChuoiKetNoi.Rekey(sql);
                MessageBox.Show("Bạn mở khóa thành công ! tài khoản hoạt động bình thường ", "Thông báo", MessageBoxButtons.OK);
                ChuoiKetNoi.Chuoiketnoi(chuoi, dgvAccount);
                Namecolumn();
                Clear();
            }
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txtSearch.Text;
            String chuoi1 = "";
            if (rbTK.Checked)
            {
                chuoi1 = "Select * from DangNhap where Taikhoan like '%" + tukhoa + "%'";
            }
            else if (rbT.Checked)
            {
                chuoi1 = "Select * from DangNhap where FullName like '%" + tukhoa + "%'";
            }
            else if (rdEmail.Checked)
            {
                chuoi1 = "Select * from DangNhap where Email like '%" + tukhoa + "%'";
            }
            ChuoiKetNoi.timkiem(chuoi1, dgvAccount);
            Namecolumn();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void auto()
        {
            txtMk.Text = "123456";
        }
        
    }
}
