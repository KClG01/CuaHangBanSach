using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDTO;

namespace AppDAO
{
    public class CT_HoaDon_DAO
    {
        public List<SanPham_DTO> Load_COB_SanPham()
        {
            List<SanPham_DTO> dsSanPham = new List<SanPham_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = "SELECT MASP, TENSP FROM SAN_PHAM";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            while (dr.Read())
            {
                SanPham_DTO sp = new SanPham_DTO();
                sp.MaSP = int.Parse(dr["MASP"].ToString());
                sp.TenSp = dr["TENSP"].ToString();
                dsSanPham.Add(sp);
            }
            return dsSanPham;
        }
        public SanPham_DTO Lay_Gia_SL_SanPham(string strTenSanPham)
        {
            SanPham_DTO sp = new SanPham_DTO();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = $"SELECT GIABAN, SLTON FROM SAN_PHAM Where TENSP =N'{strTenSanPham}'";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            while (dr.Read())
            {
                sp.GiaBan = double.Parse(dr["GIABAN"].ToString());
                sp.SLTon = int.Parse(dr["SLTON"].ToString());
            }
            return sp;
        }
        public int ThemChiTietHoaDon(CTHoaDon_DTO cthd)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strInsert = "INSERT INTO CT_HOADON(MAHD, MASP, SOLUONG, DONGIA, THANHTIEN) VALUES (@MAHD, @MASP, @SOLUONG, @GIABAN, @THANHTIEN)";
            SqlParameter[] sp = new SqlParameter[5];
            sp[0] = new SqlParameter("@MAHD", cthd.MaHD);
            sp[1] = new SqlParameter("@MASP", cthd.MaSP);
            sp[2] = new SqlParameter("@SOLUONG", cthd.SoLuong);
            sp[3] = new SqlParameter("@GIABAN", cthd.DonGia);
            sp[4] = new SqlParameter("@THANHTIEN", cthd.ThanhTien);
            int kq = DataProvider.ThucThi(strInsert, sp, conn);
            conn.Close();
            return kq;
        }
        public bool KiemTraThongTinTrung_MaSP(int masp,string mahd)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = $"SELECT * " +
                                $"FROM CT_HOADON " +
                                $"WHERE MASP = {masp} AND MAHD = '{mahd}'";

            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            bool result = false;
            if (dr.Read() == true)
                result = true;
            conn.Close();
            return result;
        }
        public List<CTHoaDon_DTO> Load_ChiTietHoaDon(string strMaHD)
        {
            List<CTHoaDon_DTO> dsCTHD = new List<CTHoaDon_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = $"SELECT MASP,SOLUONG,DONGIA,THANHTIEN FROM CT_HOADON WHERE MAHD = '{strMaHD}'";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            while (dr.Read())
            {
                CTHoaDon_DTO cthd = new CTHoaDon_DTO();
                cthd.MaSP = int.Parse(dr["MASP"].ToString());
                cthd.SoLuong = int.Parse(dr["SOLUONG"].ToString());
                cthd.DonGia = double.Parse(dr["DONGIA"].ToString());
                cthd.ThanhTien = double.Parse(dr["THANHTIEN"].ToString());
                dsCTHD.Add(cthd);
            }
            return dsCTHD;
        }
        public double ThanhTien_HoaDon(string MaHD)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = $"SELECT SUM(THANHTIEN) FROM CT_HOADON where MaHD = '{MaHD}'";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            double result = 0;
            if (dr.Read() == true && dr[0] != DBNull.Value)
                result = double.TryParse(dr[0].ToString(), out double parsedValue) ? parsedValue : 0;
            conn.Close();
            return result;
        }
        public int Count_SanPham(string MaHD)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = $"SELECT COUNT(MASP) FROM CT_HOADON WHERE MAHD = '{MaHD}'";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            int result = 0;
            if (dr.Read() == true && dr[0] != DBNull.Value)
                result = int.TryParse(dr[0].ToString(), out int parsedValue) ? parsedValue : 0;
            conn.Close();
            return result;
        }
        //Xac nhan hoa don thi thanh tien, tien nhan, tien tra insert vao hoa don
        public int Up_Date_HoaDon(string MaHD, string ThanhTien, string Nhan, string TienTra)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strUpdate = $"UPDATE HOA_DON SET THANHTIEN = @THANHTIEN, TIENNHAN = @TIENNHAN, TIENTRA = @TIENTRA WHERE MAHD = @MAHD";
            SqlParameter[] sp = new SqlParameter[4];
            sp[0] = new SqlParameter("@THANHTIEN", ThanhTien);
            sp[1] = new SqlParameter("@TIENNHAN", Nhan);
            sp[2] = new SqlParameter("@TIENTRA", TienTra);
            sp[3] = new SqlParameter("@MAHD", MaHD);
            int kq = DataProvider.ThucThi(strUpdate, sp, conn);
            conn.Close();
            return kq;
        }
        public int XoaChiTietHoaDon(string strMaHD, int masp)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strDelete = $"DELETE FROM CT_HOADON WHERE MAHD = '{strMaHD}' AND MASP = {masp}";
            int kq = DataProvider.Xoa(strDelete, conn);
            conn.Close();
            return kq;
        }
        public int Update_CTHD(int sl, string mahd,string thanhtien,int masp)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strUpdate = $"UPDATE CT_HOADON SET SOLUONG = @SOLUONG, THANHTIEN = @THANHTIEN WHERE MAHD = @MAHD AND MASP = @MASP";
            SqlParameter[] sp = new SqlParameter[4];
            sp[0] = new SqlParameter("@SOLUONG", sl);
            sp[1] = new SqlParameter("@THANHTIEN", thanhtien);
            sp[2] = new SqlParameter("@MAHD", mahd);
            sp[3] = new SqlParameter("@MASP", masp);
            int kq = DataProvider.ThucThi(strUpdate, sp, conn);
            conn.Close();
            return kq;
        }
    }
}
