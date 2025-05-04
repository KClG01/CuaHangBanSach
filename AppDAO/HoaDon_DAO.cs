using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDTO;

namespace AppDAO
{
    public class HoaDon_DAO
    {
        public List<HoaDon_DTO> LoadHoaDon()
        {
            List<HoaDon_DTO> dsHoaDon = new List<HoaDon_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string SELECT = "SELECT * FROM HOA_DON WHERE TRANGTHAI = 1";
            SqlDataReader dr = DataProvider.TruyVan(SELECT, conn);
            while (dr.Read())
            {
                HoaDon_DTO hoaDon = new HoaDon_DTO();
                hoaDon.MaHD = dr["MAHD"].ToString();
                hoaDon.NgayBan = DateTime.Parse(dr["NGAYBAN"].ToString());
                hoaDon.MaNV = dr["MANV"].ToString();
                hoaDon.MaKH = dr["MAKH"].ToString();
                hoaDon.TienNhan = double.Parse(dr["TIENNHAN"].ToString());
                hoaDon.TienTra = double.Parse(dr["TIENTRA"].ToString());
                hoaDon.ThanhTien = double.Parse(dr["THANHTIEN"].ToString());
                dsHoaDon.Add(hoaDon);
            }
            dr.Close();
            conn.Close();
            return dsHoaDon;
        }
        public int XoaHoaDon(HoaDon_DTO hd)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strDelete = $"update HOA_DON set TrangThai = 0 where MAHD = '{hd.MaHD}'";
            int kq = DataProvider.Xoa(strDelete, conn);
            conn.Close();
            return kq;
        }
        public int ThemHoaDon(HoaDon_DTO hd)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strInsert = "INSERT INTO HOA_DON(MAHD, NGAYBAN, MANV, MAKH, TIENNHAN, TIENTRA, THANHTIEN,TRANGTHAI) VALUES (@MAHD, @NGAYBAN, @MANV, @MAKH, @TIENNHAN, @TIENTRA, @THANHTIEN,1)";
            SqlParameter[] sp = new SqlParameter[7];
            sp[0] = new SqlParameter("@MAHD", hd.MaHD);
            sp[1] = new SqlParameter("@NGAYBAN", hd.NgayBan);
            sp[2] = new SqlParameter("@MANV", hd.MaNV);
            sp[3] = new SqlParameter("@MAKH", hd.MaKH);
            sp[4] = new SqlParameter("@TIENNHAN", hd.TienNhan);
            sp[5] = new SqlParameter("@TIENTRA", hd.TienTra);
            sp[6] = new SqlParameter("@THANHTIEN", hd.ThanhTien);
            int kq = DataProvider.ThucThi(strInsert, sp, conn);
            conn.Close();
            return kq;
        }
        public bool KiemTraMaHD(string maHD)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = $"SELECT * FROM HOA_DON WHERE MAHD = '{maHD}' AND TRANGTHAI = 1";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            if (dr.HasRows)
            {
                dr.Close();
                conn.Close();
                return true;
            }
            else
            {
                dr.Close();
                conn.Close();
                return false;
            }
        }
        public bool KiemTraMaNV(string maNV)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = $"SELECT * FROM NHAN_VIEN WHERE MA_NV = '{maNV}' AND TRANGTHAI = 1";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            if (dr.HasRows)
            {
                dr.Close();
                conn.Close();
                return true;
            }
            else
            {
                dr.Close();
                conn.Close();
                return false;
            }
        }
        public bool KiemTraMaKH(string maKH)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = $"SELECT * FROM KHACH_HANG WHERE MAKH = '{maKH}' And TRANGTHAI = 1";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            if (dr.HasRows)
            {
                dr.Close();
                conn.Close();
                return true;
            }
            else
            {
                dr.Close();
                conn.Close();
                return false;
            }
        }
    }
}
