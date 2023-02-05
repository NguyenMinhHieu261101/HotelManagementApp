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
    public partial class frmQLKH : Form
    {
        int index = 0;
        int last = 0;
        public static string chuoi = "Select  * From Khachhang";
        public frmQLKH()
        {
            InitializeComponent();
            ChuoiKetNoi.Chuoiketnoi(chuoi, dgvKH);
            Namecolumn();
        }
        private void Namecolumn()
        {
            dgvKH.Columns[0].HeaderText = "Mã khách"; dgvKH.Columns[0].Width = 130;
            dgvKH.Columns[1].HeaderText = "Tên khách"; dgvKH.Columns[1].Width = 130;
            dgvKH.Columns[2].HeaderText = "Ngày sinh"; dgvKH.Columns[2].Width = 100;
            dgvKH.Columns[3].HeaderText = "Giới tính"; dgvKH.Columns[3].Width = 120;
            dgvKH.Columns[4].HeaderText = "Số điện thoại"; dgvKH.Columns[4].Width = 120;
            dgvKH.Columns[5].HeaderText = "Số CMTND"; dgvKH.Columns[5].Width = 120;
            dgvKH.Columns[6].HeaderText = "Email"; dgvKH.Columns[6].Width = 120;
            dgvKH.Columns[7].HeaderText = "Phòng"; dgvKH.Columns[7].Width = 120;
            int sc = dgvKH.Rows.Count;
            index = 0;
        }

        private void PopulateData(int curow)
        {
            string gt = "";

            txtIDKH.Text = dgvKH.Rows[curow].Cells[0].Value.ToString();
            txtNameKH.Text = dgvKH.Rows[curow].Cells[1].Value.ToString();
            dtpNgaySinhKH.Text = dgvKH.Rows[curow].Cells[2].Value.ToString();
            gt = dgvKH.Rows[curow].Cells[3].Value.ToString();
            if (String.Compare(gt, "Nam") == 0)
                rb_nam.Checked = true;
            else
                rb_nu.Checked = true;
            txtSĐTKH.Text = dgvKH.Rows[curow].Cells[4].Value.ToString();
            txtCMNDKH.Text = dgvKH.Rows[curow].Cells[5].Value.ToString();
            txtEmailKH.Text = dgvKH.Rows[curow].Cells[6].Value.ToString();
            txtPhong.Text = dgvKH.CurrentRow.Cells[7].Value.ToString();

        }
        public void Clear()
        {
            txtIDKH.Enabled = true;
            txtNameKH.Text = "";
            txtEmailKH.Text = "";
            txtCMNDKH.Text = "";
            txtSĐTKH.Text = "";
            txtIDKH.Text = "";
            txtIDKH.Focus();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                if (txtIDKH.Text == "" || txtNameKH.Text == "" || txtSĐTKH.Text == "" || txtEmailKH.Text == "" || txtCMNDKH.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string manv = txtIDKH.Text.Trim();
                if (manv.Length > 15)
                {
                    MessageBox.Show("Chỉ nhập nhiều nhất 15 kí tự", "Error", MessageBoxButtons.OK);
                    txtIDKH.Text = "";
                    txtIDKH.Focus();

                }
                else
                {

                    string gt = "";
                    if (rb_nam.Checked == true)
                        gt = "Nam";
                    else
                        gt = "Nữ";

                    string sql = "Select count(*) from Khachhang where MaKh ='" + manv + "'";
                    string sql1 = "Insert into Khachhang values(N'" + txtIDKH.Text + "',";
                    sql1 += "N'" + txtNameKH.Text + "','" + dtpNgaySinhKH.Value + "',N'" + gt.Trim() + "','" + txtSĐTKH.Text + "','" + txtCMNDKH.Text + "',";
                    sql1 += "'" + txtEmailKH.Text + "','"+txtPhong.Text+"' )";
                    ChuoiKetNoi.them(sql, sql1, dgvKH);
                    ChuoiKetNoi.Chuoiketnoi(chuoi, dgvKH);
                    Namecolumn();
                    Clear();



                }
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvKH.CurrentRow.Index;
            PopulateData(index);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (rb_nam.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";

            string sql = "Update Khachhang set Tenkh = N'" + txtNameKH.Text + "',";
            sql += "Ngaysinh = N'" + dtpNgaySinhKH.Value + "',";
            sql += "gioitinh = N'" + gt.Trim() + "',sdt = '" + txtSĐTKH.Text + "',Cmnd='" + txtCMNDKH.Text + "',Email='" + txtEmailKH.Text + "'";
            sql += "where MaKh = '" + txtIDKH.Text + "'";
            ChuoiKetNoi.Sua(sql);
            ChuoiKetNoi.Chuoiketnoi(chuoi, dgvKH);
            Namecolumn();
            Clear();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "Delete from Khachhang where Makh = N'" + txtIDKH.Text + "'";
            ChuoiKetNoi.Xoa(sql);
            ChuoiKetNoi.Chuoiketnoi(chuoi, dgvKH);
            Namecolumn();

            Clear();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txtSearch.Text;
            string chuoi1 = "";
           if(rdIDKH.Checked)
            {
                chuoi1 = "Select * from Khachhang where Makh like N'%" + tukhoa + "%'";
            }
           else if(rdHTKH.Checked)
            {
                chuoi1 = "Select * from Khachhang where Tenkh like N'%" + tukhoa + "%'";
            } 
           else if(rdSDT.Checked)
            {
                chuoi1 = "Select * from Khachhang where sdt like N'%" + tukhoa + "%'";
            }    
           else if(rdCMNDKH.Checked)
            {
                chuoi1 = "Select * from Khachhang where cmnd like N'%" + tukhoa + "%'";
            }    
            ChuoiKetNoi.timkiem(chuoi1, dgvKH);
            Namecolumn();

        }
    }
}


