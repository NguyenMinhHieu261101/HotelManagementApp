using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Quản_lý_dịch_vụ_khấch_sạn
{
    public partial class frmQuanLyDichVu : Form
    {
        int index = 0;
        public static string chuoi = "Select  * from QLDichVu";
        public frmQuanLyDichVu()
        {
            InitializeComponent();
            ChuoiKetNoi.Chuoiketnoi(chuoi, dgvQuanlyDV);
            Namecolumn();
        }

        private void Namecolumn()
        {
            dgvQuanlyDV.Columns[0].HeaderText = "Mã DV"; dgvQuanlyDV.Columns[0].Width = 130;
            dgvQuanlyDV.Columns[1].HeaderText = "Tên DV"; dgvQuanlyDV.Columns[1].Width = 130;
            dgvQuanlyDV.Columns[2].HeaderText = "Loại DV"; dgvQuanlyDV.Columns[2].Width = 100;
            dgvQuanlyDV.Columns[3].HeaderText = "Đơn vị tính"; dgvQuanlyDV.Columns[3].Width = 120;
            dgvQuanlyDV.Columns[4].HeaderText = "Đơn giá"; dgvQuanlyDV.Columns[4].Width = 120;
            dgvQuanlyDV.Columns[5].HeaderText = "Mô tả"; dgvQuanlyDV.Columns[5].Width = 120;
        }

        private void PopulateData(int curow)
        {
            txtIDDV.Text = dgvQuanlyDV.Rows[curow].Cells[0].Value.ToString();
            txtNameService.Text = dgvQuanlyDV.Rows[curow].Cells[1].Value.ToString();
            txtLoaiDV.Text = dgvQuanlyDV.Rows[curow].Cells[2].Value.ToString();
            txtDVTDV.Text = dgvQuanlyDV.Rows[curow].Cells[3].Value.ToString();
            nudDonGiaDV.Text = dgvQuanlyDV.Rows[curow].Cells[4].Value.ToString();
            rtbMota.Text = dgvQuanlyDV.Rows[curow].Cells[5].Value.ToString();
        }

        public void Clear()
        {
            txtIDDV.Text = "";
            txtNameService.Text = "";
            txtLoaiDV.Text = "";
            txtDVTDV.Text = "";
            nudDonGiaDV.Value = 0;
            rtbMota.Text = "";
            txtIDDV.Enabled = true;
        }

        private void frmQuanLyDichVu_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDV_Click(object sender, EventArgs e)
        {
            if (txtIDDV.Text == "" || txtNameService.Text == "" || txtLoaiDV.Text == "" || txtDVTDV.Text == "")
            {
                MessageBox.Show("Thông tin bạn nhập chưa đủ!", "Error", MessageBoxButtons.OK);
            }
            else
            if (nudDonGiaDV.Value < 5000)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 5000!!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string madv = txtIDDV.Text.Trim();
                string tendv = txtNameService.Text.Trim();
                string loaidv = txtLoaiDV.Text.Trim();
                string dvtinh = txtDVTDV.Text.Trim(); ;
                string dongia = nudDonGiaDV.Value.ToString();
                string mota = rtbMota.Text;

                string sql = "Select count(*) from QLDichVu where MaDV ='" + madv + "'";
                string sql1 = "Insert into QLDichVu values('" + madv + "',N'" + tendv + "',";
                sql1 += "N'" + loaidv + "',N'" + dvtinh + "','" + dongia + "',N'" + mota + "')";
                ChuoiKetNoi.them(sql, sql1, dgvQuanlyDV);
                ChuoiKetNoi.Chuoiketnoi(chuoi, dgvQuanlyDV);
                Namecolumn();
                Clear();
            }
        }

        private void btnEditDV_Click(object sender, EventArgs e)
        {
            string madv = txtIDDV.Text.Trim();
            string tendv = txtNameService.Text.Trim();
            string loaidv = txtLoaiDV.Text.Trim();
            string dvtinh = txtDVTDV.Text.Trim(); ;
            string dongia = nudDonGiaDV.Value.ToString();
            string mota = rtbMota.Text;
            string sql = "Update QLDichVu set TenDV = N'" + tendv + "',";
            sql += "LoaiDV = N'" + loaidv + "',DonGia = '" + dongia + "',";
            sql += "DVTinh = N'" + dvtinh + "', Mota=N'" + mota + "'  where MaDV = '" + madv + "'";
            ChuoiKetNoi.Sua(sql);
            ChuoiKetNoi.Chuoiketnoi(chuoi, dgvQuanlyDV);
            Namecolumn();
            Clear();
        }

        private void btnDeleteDV_Click(object sender, EventArgs e)
        {
            string sql = "Delete from QLDichVu where MaDV = N'" + txtIDDV.Text + "'";
            ChuoiKetNoi.Xoa(sql);
            ChuoiKetNoi.Chuoiketnoi(chuoi, dgvQuanlyDV);
            Namecolumn();
            Clear();
        }

        private void btnNhaplaiDV_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtSearchDV_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txtSearchDV.Text;
            String chuoi1 = "";
            chuoi1 = "Select * from QLDichVu where TenDV like N'%" + tukhoa + "%'";
            ChuoiKetNoi.timkiem(chuoi1, dgvQuanlyDV);
            Namecolumn();
        }

        private void dgvQuanlyDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDDV.Enabled = false;
            index = dgvQuanlyDV.CurrentRow.Index;
            PopulateData(index);
        }

        private void btnExitDV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
