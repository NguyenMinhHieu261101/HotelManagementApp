using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace Quản_lý_dịch_vụ_khấch_sạn
{
    public partial class HoaDonForm : Form
    {
        SaveFileDialog saveFile;
        public HoaDonForm()
        {
            InitializeComponent();
        }
        public void Connect()
        {
            string sql = "select * from HoaDon";
            ChuoiKetNoi.Chuoiketnoi(sql, dgvHoaDon);
        }
        public void Now()
        {
            string sql = "select * from HoaDon where NgayLapHD = '" + DateTime.Now + "'";
            ChuoiKetNoi.Chuoiketnoi(sql, dgvHoaDon);
        }
        private void Translate()
        {
            dgvHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dgvHoaDon.Columns[1].HeaderText = "Tên hóa đơn";
            dgvHoaDon.Columns[2].HeaderText = "Ngày lập";
            dgvHoaDon.Columns[3].HeaderText = "Phụ phí";
            dgvHoaDon.Columns[4].HeaderText = "Thành tiền";
            dgvHoaDon.Columns[5].HeaderText = "Trạng thái";
            dgvHoaDon.Columns[6].HeaderText = "Địa chỉ";
            dgvHoaDon.Columns[7].HeaderText = "Tên nhân viên";
            dgvHoaDon.Columns[0].Width = 90;
            dgvHoaDon.Columns[3].Width = 80;
            dgvHoaDon.Columns[4].Width = 90;
            dgvHoaDon.Columns[7].Width = 155;
        }

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            Now();
            //Connect();
            Translate();
            searchBills();
            loadStaff();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from HoaDon where ten_HD LIKE '%" + txtSearch.Text + "%'";
            ChuoiKetNoi.Chuoiketnoi(sql, dgvHoaDon);
        }

        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {
            string sql = "select * from HoaDon where NgayLapHD >='" + dtpTuNgayHD.Value.ToString() + "' and NgayLapHD <='" + dtpNgayKT.Value.ToString() + "'";
            ChuoiKetNoi.Chuoiketnoi(sql, dgvHoaDon);
        }

        private void dtpTuNgayHD_ValueChanged(object sender, EventArgs e)
        {
            string sql = "select * from HoaDon where NgayLapHD >='" + dtpTuNgayHD.Value.ToString() + "' and NgayLapHD <='" + dtpNgayKT.Value.ToString() + "'";
            ChuoiKetNoi.Chuoiketnoi(sql, dgvHoaDon);
        }

        private void btnLamMoiHD_Click(object sender, EventArgs e)
        {
            refresh();
            //Connect();
            Now();
        }

        private void refresh()
        {
            dtpTuNgayHD.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now;
            txtSearch.Text = "";
            txtID.Text = "";
            txtName.Text = "";
            dtpDateCreated.Value = DateTime.Now;
            nudSurcharge.Value = 0;
            nudTotal.Value = 0;
            rdPay.Checked = false;
            rdNonPay.Checked = true;
            txtAddress.Text = "";
            txtStaff.Text = "";
        }

        private void searchBills()
        {
            if (rdTenHD.Checked==true)
            {
                string sql = "select * from HoaDon where ten_HD like '%" + txtSearch.Text + "%'";
                ChuoiKetNoi.Chuoiketnoi(sql, dgvHoaDon);
            }
            else if (rdAddress.Checked == true)
            {
                string sql ="select * from Hoadon" +
                    "where diaChi like '%"+txtSearch.Text+"%'";
                ChuoiKetNoi.Chuoiketnoi(sql, dgvHoaDon);
            }
        }

        private void btnDeleteHD_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowAll.Checked == true)
            {
                Connect();
            }
            else
                Now();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSelectAll.Checked == true)
            {
            dgvHoaDon.SelectAll();
            }
            else
            {
                dgvHoaDon.ClearSelection();
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {

            int total = ((System.Data.DataTable)dgvHoaDon.DataSource).Rows.Count;
            lblTotal.Text = total.ToString();
        }

        private void loadControl()
        {
            txtID.Text = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            txtName.Text= dgvHoaDon.CurrentRow.Cells[1].Value.ToString();
            if (dgvHoaDon.CurrentRow.Cells[2].Value.ToString() == "")
            {
                return;
            }
            else
            dtpDateCreated.Value = DateTime.Parse(dgvHoaDon.CurrentRow.Cells[2].Value.ToString());
            nudSurcharge.Value = int.Parse(dgvHoaDon.CurrentRow.Cells[3].Value.ToString());
            nudTotal.Value = int.Parse(dgvHoaDon.CurrentRow.Cells[4].Value.ToString());
            if (dgvHoaDon.CurrentRow.Cells[5].Value == "Đã thanh toán")
                rdPay.Checked = true;
            else if(dgvHoaDon.CurrentRow.Cells[5].Value=="Chưa thanh toán"){
                    rdNonPay.Checked = true;
            }
            txtAddress.Text= dgvHoaDon.CurrentRow.Cells[6].Value.ToString();
            txtStaff.Text = dgvHoaDon.CurrentRow.Cells[7].Value.ToString();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadControl();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dgvHoaDon.Rows.Count.ToString()))
            {
                MessageBox.Show("Lỗi khi xóa hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (MessageBox.Show("Có muốn xóa dữ liệu?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from HoaDon where id_hoadon = '" + dgvHoaDon.CurrentRow.Cells[0].Value.ToString() + "'";
                ChuoiKetNoi.Chuoiketnoi(sql, dgvHoaDon);
                Now();
                Translate();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || nudTotal.ToString() == "")
            {
                MessageBox.Show("Hãy nhập thông tin bắt buộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string tt = "";
                if (rdPay.Checked == true)
                    tt = "Đã thanh toán";
                else
                    tt = "Chưa thanh toán";
                string sql = "INSERT INTO HoaDon VALUES(N'" + txtName.Text + "', N'" + dtpDateCreated.Value + "'," + nudSurcharge.Value + "," + nudTotal.Value + ",N'" + tt.Trim() + "',N'" + txtAddress.Text + "',N'" + txtStaff.Text + "')";
                ChuoiKetNoi.Chuoiketnoi(sql, dgvHoaDon);
                Now();
                Translate();
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tt = "";
            if (rdPay.Checked = true)
                tt = "Đã thanh toán";
            else
                tt = "Chưa thanh toán";
            string sql = "update HoaDon set ten_HD=N'" + txtName.Text + "',NgayLapHD=N'" + dtpDateCreated.Value + "',phiphuthu=" + nudSurcharge.Value + "," +
                "thanhtien=" + nudTotal.Value + ",trangthai=N'" + tt.Trim() + "',diaChi=N'" + txtAddress.Text + "',ten_nhanvien=N'" + txtStaff.Text + "' " +
                "where id_hoadon='"+txtID.Text+"'";
            ChuoiKetNoi.Sua(sql);
            Now();
            Translate();
            refresh();
        }

        private void loadStaff()
        {
           // string connS = @"Data Source=TRUNGVUONG303;Initial Catalog=Hotel_Manager; Integrated Security=True";
           // frmlogin frmlogin = new frmlogin();
           // string sql="select FullName from DangNhap where Taikhoan='"+frmlogin.txttk.Text+"'";
           // SqlConnection conn = new SqlConnection(connS);
           // SqlDataAdapter da = new SqlDataAdapter(sql, conn);
           // SqlCommandBuilder buider = new SqlCommandBuilder(da);
           // DataSet ds = new DataSet();
           // da.Fill(ds, "DangNhap");
           // BindingSource bs = new BindingSource(ds, "DangNhap");
           // txtStaff.DataBindings.Add("text",ds,"FullName");

        }

        private void txtStaff_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            Printed(dgvHoaDon, @"F:\", "Hóa đơn dịch vụ");
        }
        
        private void Printed(DataGridView data,string path, string fileName)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 30;
            for(int i = 1; i <= data.Columns.Count; i++)
            {
                obj.Cells[1, i] = data.Columns[i-1].HeaderText;
            }
            //Lấy nội dung
            for(int i = 0; i < data.Rows.Count; i++)
            {
                for(int j = 0; j < data.Columns.Count; j++)
                {
                    if (data.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(path+ fileName + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
    }
}
