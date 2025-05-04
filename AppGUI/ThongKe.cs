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
using AppBUS;
using AppDTO;
namespace AppGUI
{
    public partial class FormThongKe : Form
    {
        public string strChuoiKetNoi = "Data Source =.;Initial Catalog = QLCuaHangBanSach;Integrated Security = True";
        public FormThongKe()
        {
            InitializeComponent();
        }
        private void FormThongKe_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            HienThiLenDGV();
        }
        public void Load_DS(string str, DataGridView dgv)
        {
            SqlConnection conn = new SqlConnection(strChuoiKetNoi);

            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(str, conn);
                DataSet lt = new DataSet();
                da.Fill(lt);

                dgv.DataSource = lt.Tables[0];
                conn.Close();
            }
                catch(Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị danh sách lên gird. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }
        }
        private void Load_Header(string str, DataGridView dgv)
        {
            SqlConnection conn = new SqlConnection(strChuoiKetNoi);
            try
            {
                conn.Open();

                SqlDataAdapter lst = new SqlDataAdapter(str, conn);
                DataSet lt = new DataSet();
                lst.Fill(lt);
                if (dgv.Columns.Contains("MASP"))
                    dgv.Columns["MASP"].HeaderText = "Mã";
                if (dgv.Columns.Contains("TENSP"))
                    dgv.Columns["TENSP"].HeaderText = "Tên sách";
                if (dgv.Columns.Contains("TongSoLuongBan"))
                    dgv.Columns["TongSoLuongBan"].HeaderText = "Số lượng bán";
                if (dgv.Columns.Contains("TongTienBan"))
                    dgv.Columns["TongTienBan"].HeaderText = "Tổng tiền bán";
                if (dgv.Columns.Contains("TonKho"))
                    dgv.Columns["TonKho"].HeaderText = "Số lượng tồn kho";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi tên cột phiếu nhập. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }
        }
        private void HienThiLenDGV()
        {
            string str = "SELECT " +
                         "SAN_PHAM.MASP, SAN_PHAM.TENSP, " +
                         "SUM(cthd.SOLUONG) AS TongSoLuongBan, " +
                         "SUM(cthd.THANHTIEN) AS TongTienBan, " +
                         "SAN_PHAM.SLTON AS TonKho " +
                         "FROM SAN_PHAM " +
                         "LEFT JOIN " +
                         "(SELECT CT_HOADON.MASP, CT_HOADON.SOLUONG, HOA_DON.THANHTIEN " +
                         "FROM CT_HOADON " +
                         "JOIN HOA_DON ON CT_HOADON.MAHD = HOA_DON.MAHD) AS cthd " +
                         "ON SAN_PHAM.MASP = cthd.MASP " +
                         "GROUP BY SAN_PHAM.MASP, SAN_PHAM.TENSP, SAN_PHAM.SLTON;";

            Load_DS(str, dgv_ThongKe);
            Load_Header(str, dgv_ThongKe);
        }
        public void HienThiDanhSach()
        {
            string strTongSoLuong = "SELECT SUM(CT_HOADON.SOLUONG) AS TongSoLuongBan " +
                                    "FROM CT_HOADON " +
                                    "JOIN HOA_DON ON CT_HOADON.MAHD = HOA_DON.MAHD";
            TongSoLuongBan(strTongSoLuong, txtSoLuongBan);

            string strTongTien = "SELECT SUM(hd.SOLUONG) AS TongSoLuongBan, SUM(hd.THANHTIEN) AS TongThanhTien " +
                                 "FROM (SELECT CT_HOADON.MASP, CT_HOADON.SOLUONG, HOA_DON.THANHTIEN " +
                                 "FROM CT_HOADON JOIN HOA_DON ON CT_HOADON.MAHD = HOA_DON.MAHD) AS hd";
            TongTienBan(strTongTien, txtTongTienBan);

            string strTongSoLuongTon = "SELECT SUM(SLTON) AS TonKho FROM SAN_PHAM";
            TongSoLuongTon(strTongSoLuongTon, txtTonKho);
        }

        public void TongSoLuongBan(string str, TextBox txt_SoLuongBan)
        {
            using (SqlConnection conn = new SqlConnection(strChuoiKetNoi))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(str, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if(dr.HasRows)
                    {
                        int tongSoLuong = 0;
                        while (dr.Read())
                        {
                            tongSoLuong = dr.IsDBNull(dr.GetOrdinal("TongSoLuongBan")) ? 0 : Convert.ToInt32(dr["TongSoLuongBan"]);
                        }

                        txt_SoLuongBan.Text = tongSoLuong.ToString();
                    }
                    else
                    {
                        txt_SoLuongBan.Text = "0";
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị tổng số lượng bán. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public void TongTienBan(string str, TextBox txt_TongTien)
        {
            using (SqlConnection conn = new SqlConnection(strChuoiKetNoi))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(str, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        decimal tongTien = 0;
                        if (dr.Read()) 
                        {
                            tongTien = dr.IsDBNull(dr.GetOrdinal("TongThanhTien")) ? 0 : dr.GetDecimal(dr.GetOrdinal("TongThanhTien"));
                        }
                        txt_TongTien.Text = tongTien.ToString("C");
                    }
                    else
                    {
                        txt_TongTien.Text = "0";
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị tổng tiền bán. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public void TongSoLuongTon(string str, TextBox txt_SoLuongTon)
        {
            using (SqlConnection conn = new SqlConnection(strChuoiKetNoi))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(str, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            int tongSoLuongTon = dr.IsDBNull(dr.GetOrdinal("TonKho")) ? 0 : Convert.ToInt32(dr["TonKho"]);
                            txt_SoLuongTon.Text = tongSoLuongTon.ToString();
                        }
                    }
                    else
                    {
                        txt_SoLuongTon.Text = "0";
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị tổng tồn kho. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        //public void HienThiTheoNgay(string ngaybd, string ngaykt)
        //{
        //    string str = "SELECT " +
        //                 "SAN_PHAM.MASP, SAN_PHAM.TENSP, " +
        //                 "SUM(cthd.SOLUONG) AS TongSoLuongBan, " +
        //                 "SUM(cthd.THANHTIEN) AS TongTienBan, " +
        //                 "SAN_PHAM.SLTON AS TonKho " +
        //                 "FROM SAN_PHAM " +
        //                 "LEFT JOIN " +
        //                 "(SELECT CT_HOADON.MASP, CT_HOADON.SOLUONG, HOA_DON.THANHTIEN " +
        //                 "FROM CT_HOADON " +
        //                 "JOIN HOA_DON ON CT_HOADON.MAHD = HOA_DON.MAHD " +
        //                 $"WHERE HOA_DON.NGAYBAN BETWEEN '{ngaybd}' AND '{ngaykt}') AS cthd " +
        //                 "ON SAN_PHAM.MASP = cthd.MASP " +
        //                 "GROUP BY SAN_PHAM.MASP, SAN_PHAM.TENSP, SAN_PHAM.SLTON;";

        //    Load_DS(str, dgv_ThongKe);
        //    Load_Header(str, dgv_ThongKe);
        //}

        //private void btn_fill_Click(object sender, EventArgs e)
        //{
        //    string ngaybd = dtp_NgayBatDau.Value.ToString("yyyy-MM-dd");
        //    string ngaykt = dtp_NgayKetThuc.Value.ToString("yyyy-MM-dd");
        //    if (dtp_NgayBatDau.Value > dtp_NgayKetThuc.Value)
        //    {
        //        MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    HienThiTheoNgay(ngaybd, ngaykt);
        //}

        //private void btn_Reset_Click(object sender, EventArgs e)
        //{
        //    dtp_NgayBatDau.Value = DateTime.Now;
        //    dtp_NgayKetThuc.Value = DateTime.Now;
        //    HienThiLenDGV();
        //}
    }
}
