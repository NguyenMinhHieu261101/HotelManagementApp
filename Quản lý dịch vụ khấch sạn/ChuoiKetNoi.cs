using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_dịch_vụ_khấch_sạn
{
    class ChuoiKetNoi
    {
        public static string sqlcon = @"Data Source=NMH;Initial Catalog=Hotel_Manager_HKTV; Integrated Security=True";
        private static SqlConnection mycon;

        public static SqlConnection Mycon
        {
            get { return ChuoiKetNoi.mycon; }
            set { ChuoiKetNoi.mycon = value; }
        }
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        // DataTable table;
        public static BindingSource code;
        public static SqlCommandBuilder bd;
        public static void Chuoiketnoi(string chuoi, DataGridView db1)
        {
            try
            {

                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(ad);
                ad.Fill(dt);
                db1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");

            }
        }

        public static void them(string select, String sql1, DataGridView dt)
        {
            int i;
            mycon = new SqlConnection(sqlcon);
            mycon.Open();
            string sql = select;
            com = new SqlCommand(sql, mycon);
            i = (int)com.ExecuteScalar();


            if (i != 0)
            {
                MessageBox.Show("Mã đã tồn tại, vui lòng nhập mã mới ! ", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    them_dl(sql1, dt);
                }
                catch
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
                }
            }
        }

        public static void Sua(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn sửa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    mycon.Close();
                    MessageBox.Show("Bạn sửa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }

        public static void Xoa(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn Xóa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Tài khoản bạn sửa trùng với tài khoản đã có ! Vui lòng ktra lại ");
                }
            }
        }

        public static void timkiem(string chuoi, DataGridView db2)
        {
            try
            {
                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(ad);
                ad.Fill(dt);
                db2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        public static void xulycbx(string chuoi, ComboBox cbx)
        {
            ad = new SqlDataAdapter(chuoi, sqlcon);
            dt = new DataTable();

            ad.Fill(dt);
            cbx.DataSource = dt;
        }

        public static void them_dl(string sql1, DataGridView dt)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(com);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                dt.DataSource = tb;
                MessageBox.Show("Thêm Thành công !", "Thông báo ");
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "" + ex);
            }

        }

        public static void Rekey(string sql)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql, mycon);
                com.ExecuteNonQuery();
                mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }
        }

        public static int check_key(string chuoi, int trangthai)
        {
            mycon = new SqlConnection(sqlcon);
            ad = new SqlDataAdapter(chuoi, sqlcon);

            dt = new DataTable("trang");
            ad.Fill(dt);
            code = new BindingSource();

            foreach (DataRow anh in dt.Rows)
            {
                code.Add(anh);
            }

            DataRow curent = (DataRow)code.Current;
            trangthai = Convert.ToInt32(curent["trangthai"].ToString());
            return trangthai;
        }

        public static string load(string chuoi, string hoten)
        {
            mycon = new SqlConnection(sqlcon);
            ad = new SqlDataAdapter(chuoi, sqlcon);

            dt = new DataTable("trang");
            ad.Fill(dt);
            code = new BindingSource();

            foreach (DataRow anh in dt.Rows)
            {
                code.Add(anh);
            }

            DataRow curent = (DataRow)code.Current;
            hoten = curent["FullName"].ToString();
            return hoten;
        }
    }
}
