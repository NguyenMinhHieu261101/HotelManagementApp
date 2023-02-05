using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Quản_lý_dịch_vụ_khấch_sạn
{
    public partial class frmlogin : Form
    {
        public static string sqlcon = ChuoiKetNoi.sqlcon;
        public static SqlConnection mycon;
        public static SqlCommand com;
        public static string full_name = "";
        public static int sate = 0, sai = 5;
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql1 = "Select count(*) from DangNhap where Taikhoan='" + txttk.Text.Trim() + "' and Matkhau='" + txtmk.Text.Trim() + "' and phanquyen = 1  ";
            string sql2 = "Select count(*) from DangNhap where Taikhoan ='" + txttk.Text + "'and Matkhau ='" + txtmk.Text + "' and phanquyen = 2  ";
            string sql3 = "Select count(*) from DangNhap where Taikhoan='" + txttk.Text + "' and Matkhau ='" + txtmk.Text + "' and phanquyen = 3  ";
            string chuoi4 = "Select FullName from DangNhap where Taikhoan ='" + txttk.Text.Trim() + "'";
            string chuoi5 = "Select trangthai from DangNhap where Taikhoan ='" + txttk.Text.Trim() + "'";

            if (txttk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản ", "Thông báo", MessageBoxButtons.OK);
            }
            else if (txtmk.Text == "")
                MessageBox.Show("Bạn chưa nhập Mật khẩu  ", "Thông báo", MessageBoxButtons.OK);
            else
            {
                if (sai > 0)
                {

                    int a = 0, b = 0, c = 0;
                    mycon = new SqlConnection(ChuoiKetNoi.sqlcon);
                    mycon.Open();


                    com = new SqlCommand(sql1, mycon);
                    a = (int)com.ExecuteScalar();

                    SqlCommand com1 = new SqlCommand(sql2, mycon);

                    b = (int)com1.ExecuteScalar();

                    SqlCommand com2 = new SqlCommand(sql3, mycon);
                    c = (int)com2.ExecuteScalar();


                    if (a > 0)
                    {
                        int trangthai = ChuoiKetNoi.check_key(chuoi5, sate);

                        if (trangthai == 0)
                        {
                            MessageBox.Show("Tài khoản của bạn đang bị khóa , hay liên lạc với Admin để được mở khóa ! Xin cảm ơn.", "Thông Báo ", MessageBoxButtons.OK);
                        }
                        else
                        {
                            string tendaydu = ChuoiKetNoi.load(chuoi4, full_name);
                            MessageBox.Show("Bạn đã đăng nhập vào tài khoản Admin", "Thông báo ", MessageBoxButtons.OK);
                            frmMainForm a1 = new frmMainForm();
                            this.Hide();
                            a1.ShowDialog();
                        }
                    }
                    else if (b > 0)
                    {
                        int trangthai = ChuoiKetNoi.check_key(chuoi5, sate);
                        if (trangthai == 0)
                        {
                            MessageBox.Show("Tài khoản của bạn đang bị khóa , hãy liên lạc với Admin để được mở khóa ! Xin cảm ơn.", "Thông Báo ", MessageBoxButtons.OK);
                        }
                        else
                        {
                            string tendaydu = ChuoiKetNoi.load(chuoi4, full_name);
                            MessageBox.Show("Ban đã đăng nhập vào tài khoản quản lý", "Thông báo ", MessageBoxButtons.OK);
                            frmMainForm a2 = new frmMainForm();
                            a2.tàiKhoảnToolStripMenuItem.Visible = false;
                            a2.ShowDialog();
                            this.Hide();
                        }
                    }

                    else if (c > 0)
                    {
                        int trangthai = ChuoiKetNoi.check_key(chuoi5, sate);
                        if (trangthai == 0)
                        {
                            MessageBox.Show("Tài khoản của bạn đang bị khóa , hay liên lạc với Admin để được mở khóa ! Xin cảm ơn.", "Thông Báo ", MessageBoxButtons.OK);
                        }
                        else
                        {
                            string tendaydu = ChuoiKetNoi.load(chuoi4, full_name);
                            MessageBox.Show("Bạn đã đăng nhập vào tài khoản người dùng ", "Thông báo ", MessageBoxButtons.OK);
                            frmMainForm a2 = new frmMainForm();
                            a2.tàiKhoảnToolStripMenuItem.Visible = false;
                            a2.kháchHàngToolStripMenuItem.Visible = false;
                            a2.ShowDialog();
                        }
                    }
                    if (a == 0 && b == 0 && c == 0)
                    {
                        sai--;
                        string t = ("Tên đăng nhập hoặc Mật khẩu sai! Bạn vui lòng kiểm tra lại, bạn còn " + sai + " lần đăng nhập");
                        MessageBox.Show((t), "Thông báo", MessageBoxButtons.OK);
                        txttk.Text = "";
                        txtmk.Text = "";
                        txttk.Focus();
                    }
                }

                else
                {

                    int trangthai = 0;
                    string sql = "Update DangNhap set trangthai='" + trangthai + "'  where Taikhoan = '" + txttk.Text + "'";
                    ChuoiKetNoi.Rekey(sql);
                    MessageBox.Show("do đăng nhập sai quá nhiều lần , tài khoản bạn đã bị khóa! vui lòng liên lạc với ADMIN để mở tài khoản ", "Thông báo", MessageBoxButtons.OK);
                    sai = 5;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmlogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
