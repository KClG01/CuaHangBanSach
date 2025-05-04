using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDTO;

namespace AppDAO
{
    public class SanPham_DAO
    {
        public List<SanPham_DTO> Lay_DS_SanPham()
        {
            List<SanPham_DTO> dsSanPham = new List<SanPham_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = "Select * from SAN_PHAM where trangthai =1";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            while (dr.Read())
            {
                SanPham_DTO sp = new SanPham_DTO();
                sp.MaSP = int.Parse(dr["MASP"].ToString());
                sp.TenSp = dr["TENSP"].ToString();
                sp.GiaBan = double.Parse(dr["GIABAN"].ToString());
                sp.GiaNhap = double.Parse(dr["GIANHAP"].ToString());
                sp.SLTon = int.Parse(dr["SLTON"].ToString());
                sp.MaTacGia = dr["MA_TACGIA"].ToString();
                sp.MaNXB = dr["MA_NXB"].ToString();
                sp.MaLoai = dr["MA_LOAI"].ToString();
                dsSanPham.Add(sp);
            }
            conn.Close();
            return dsSanPham;
        }
        public List<LoaiSP_DTO> Load_Cob_Loai()
        {
            List<LoaiSP_DTO> dsLoai = new List<LoaiSP_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = "Select * from Loai_SP";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            while (dr.Read())
            {
                LoaiSP_DTO loai = new LoaiSP_DTO();
                loai.MaLoai = dr["MA_LOAI"].ToString();
                loai.TenLoai = dr["TENLOAI"].ToString();
                dsLoai.Add(loai);
            }
            conn.Close();
            return dsLoai;
        }
        public List<TacGia_DTO> Load_Cob_TacGia()
        {
            List<TacGia_DTO> dsLoai = new List<TacGia_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = "Select * from TAC_GIA";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            while (dr.Read())
            {
                TacGia_DTO tacgia = new TacGia_DTO();
                tacgia.MaTacGia = dr["MA_TC"].ToString();
                tacgia.TenTacGia = dr["TEN_TC"].ToString();
                tacgia.ButDanh = dr["BUTDANH"].ToString();
                tacgia.LienHe = dr["LIENHE"].ToString();
                tacgia.DiaChi = dr["DIACHI"].ToString();
                dsLoai.Add(tacgia);
            }
            conn.Close();
            return dsLoai;
        }
        public List<NhaXuatBan_DTO> Load_Cob_NXB()
        {
            List<NhaXuatBan_DTO> dsLoai = new List<NhaXuatBan_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = "Select * from NHA_XUAT_BAN";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            while (dr.Read())
            {
                NhaXuatBan_DTO nxb = new NhaXuatBan_DTO();
                nxb.MaNXB = dr["MA_NXB"].ToString();
                nxb.TenNXB = dr["TEN_NXB"].ToString();
                nxb.DiaChi = dr["DIACHI"].ToString();
                nxb.LienHe = dr["LIENHE"].ToString();
                dsLoai.Add(nxb);
            }
            conn.Close();
            return dsLoai;
        }
        public int ThemSanPham(SanPham_DTO SanPham)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strInsert = "INSERT INTO SAN_PHAM(MASP,TENSP,MA_TACGIA,MA_NXB,MA_LOAI,GIABAN,GIANHAP,SLTON,TRANGTHAI)" +
                "VALUES (@MASP,@TENSP,@MA_TG,@MA_NXB,@MA_LOAI,@GIABAN,@GIANHAP,@SL,1)";
            SqlParameter[] sp = new SqlParameter[8];
            sp[0] = new SqlParameter("@MASP", SanPham.MaSP);
            sp[1] = new SqlParameter("@TENSP",SanPham.TenSp);
            sp[2] = new SqlParameter("@MA_TG",SanPham.MaTacGia);
            sp[3] = new SqlParameter("@MA_NXB",SanPham.MaNXB);
            sp[4] = new SqlParameter("@MA_LOAI",SanPham.MaLoai); 
            sp[5] = new SqlParameter("@GIABAN",SanPham.GiaBan);
            sp[6] = new SqlParameter("@GIANHAP", SanPham.GiaNhap);
            sp[7] = new SqlParameter("@SL",SanPham.SLTon);
            int kq = DataProvider.ThucThi(strInsert, sp,conn);
            conn.Close();
            return kq;
        }
        public int SuaSanPham(SanPham_DTO SanPham)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strUpdate = "UPDATE SAN_PHAM SET TENSP=@TENSP,MA_TACGIA=@MA_TG,MA_NXB=@MA_NXB,MA_LOAI=@MA_LOAI,GIABAN=@GIABAN,GIANHAP=@GIANHAP,SLTON=@SLTON WHERE MASP=@MASP";
            SqlParameter[] sp = new SqlParameter[8];
            sp[0] = new SqlParameter("@MASP", SanPham.MaSP);
            sp[1] = new SqlParameter("@TENSP", SanPham.TenSp);
            sp[2] = new SqlParameter("@MA_TG", SanPham.MaTacGia);
            sp[3] = new SqlParameter("@MA_NXB", SanPham.MaNXB);
            sp[4] = new SqlParameter("@MA_LOAI", SanPham.MaLoai);
            sp[5] = new SqlParameter("@GIABAN", SanPham.GiaBan);
            sp[6] = new SqlParameter("@GIANHAP", SanPham.GiaNhap);
            sp[7] = new SqlParameter("@SLTON", SanPham.SLTon);
            int kq = DataProvider.ThucThi(strUpdate, sp, conn);
            conn.Close();
            return kq;
        }
        public bool KiemTraThongTinTrung_MaSP(string masp)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = $"Select * from SAN_PHAM where MASP = '{masp}' and trangthai = 1";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            bool result = false;
            if (dr.Read() == true)
                result = true;
            conn.Close();
            return result;
        }
        public bool KiemTraThongTinTrung_TenSp(string tensp)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = $"Select * from SAN_PHAM where TENSP = '{tensp}' and trangthai = 1";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            bool result = false;
            if (dr.Read() == true)
                result = true;
            conn.Close();
            return result;
        }
        public bool KiemTraThongTin_Email_Update(string tenSP, string maSp)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = $"Select * from SAN_PHAM where TenSP = '{tenSP}' and MASP != '{maSp}' and trangthai = 1";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            bool result = false;
            if (dr.Read() == true)
                result = true;
            conn.Close();
            return result;
        }
        public int XoaSanPham(SanPham_DTO sp)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strDelete = $"update SAN_PHAM set TrangThai = 0 where MaSP = '{sp.MaSP}'";
            int kq = DataProvider.Xoa(strDelete, conn);
            conn.Close();
            return kq;
        }
        public List<SanPham_DTO> TimKiemSanPham_TenSP(string strTen)
        {
            List<SanPham_DTO> dsSanPham = new List<SanPham_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = $"Select * from San_Pham where TENSP like N'%{strTen}%' and trangthai =1";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            while (dr.Read())
            {
                SanPham_DTO sp = new SanPham_DTO();
                sp.MaSP = int.Parse(dr["MASP"].ToString());
                sp.TenSp = dr["TENSP"].ToString();
                sp.GiaBan = double.Parse(dr["GIABAN"].ToString());
                sp.GiaNhap = double.Parse(dr["GIANHAP"].ToString());
                sp.SLTon = int.Parse(dr["SLTON"].ToString());
                sp.MaTacGia = dr["MA_TACGIA"].ToString();
                sp.MaNXB = dr["MA_NXB"].ToString();
                sp.MaLoai = dr["MA_LOAI"].ToString();
                dsSanPham.Add(sp);
            }
            conn.Close();
            return dsSanPham;
        }
        public List<SanPham_DTO> TimKiemSanPham_TacGia(string strTacGia)
        {
            List<SanPham_DTO> dsSanPham = new List<SanPham_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = $"select SAN_PHAM.* from SAN_PHAM join TAC_GIA on SAN_PHAM.MA_TACGIA= TAC_GIA.MA_TC" +
                $"where TEN_TC Like N'%{strTacGia}%' and trangthai =1 ";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            while (dr.Read())
            {
                SanPham_DTO sp = new SanPham_DTO();
                sp.MaSP = int.Parse(dr["MASP"].ToString());
                sp.TenSp = dr["TENSP"].ToString();
                sp.GiaBan = double.Parse(dr["GIABAN"].ToString());
                sp.GiaNhap = double.Parse(dr["GIANHAP"].ToString());
                sp.SLTon = int.Parse(dr["SLTON"].ToString());
                sp.MaTacGia = dr["MA_TACGIA"].ToString();
                sp.MaNXB = dr["MA_NXB"].ToString();
                sp.MaLoai = dr["MA_LOAI"].ToString();
                dsSanPham.Add(sp);
            }
            conn.Close();
            return dsSanPham;
        }
        public List<SanPham_DTO> TimKiemSanPham_NXB(string strNXB)
        {
            List<SanPham_DTO> dsSanPham = new List<SanPham_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = $" select SAN_PHAM.* from SAN_PHAM join NHA_XUAT_BAN on SAN_PHAM.MA_NXB= NHA_XUAT_BAN.MA_NXB" +
                $"where TEN_NXB Like N'%{strNXB}%' and trangthai =1";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            while (dr.Read())
            {
                SanPham_DTO sp = new SanPham_DTO();
                sp.MaSP = int.Parse(dr["MASP"].ToString());
                sp.TenSp = dr["TENSP"].ToString();
                sp.GiaBan = double.Parse(dr["GIABAN"].ToString());
                sp.GiaNhap = double.Parse(dr["GIANHAP"].ToString());
                sp.SLTon = int.Parse(dr["SLTON"].ToString());
                sp.MaTacGia = dr["MA_TACGIA"].ToString();
                sp.MaNXB = dr["MA_NXB"].ToString();
                sp.MaLoai = dr["MA_LOAI"].ToString();
                dsSanPham.Add(sp);
            }
            conn.Close();
            return dsSanPham;
        }
        public List<SanPham_DTO> TimKiemSanPham_Loai(string strLoai)
        {
            List<SanPham_DTO> dsSanPham = new List<SanPham_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = $"  select SAN_PHAM.* from SAN_PHAM join LOAI_SP on SAN_PHAM.MA_LOAI= LOAI_SP.MA_LOAI" +
                $" where TENLOAI Like N'%{strLoai}%' and trangthai =1";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            while (dr.Read())
            {
                SanPham_DTO sp = new SanPham_DTO();
                sp.MaSP = int.Parse(dr["MASP"].ToString());
                sp.TenSp = dr["TENSP"].ToString();
                sp.GiaBan = double.Parse(dr["GIABAN"].ToString());
                sp.GiaNhap = double.Parse(dr["GIANHAP"].ToString());
                sp.SLTon = int.Parse(dr["SLTON"].ToString());
                sp.MaTacGia = dr["MA_TACGIA"].ToString();
                sp.MaNXB = dr["MA_NXB"].ToString();
                sp.MaLoai = dr["MA_LOAI"].ToString();
                dsSanPham.Add(sp);
            }
            conn.Close();
            return dsSanPham;
        }
        public void CapNhapSoLuong(int MaSP, int SoLuong)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strUpdate = "UPDATE SAN_PHAM SET SLTON=SLTON-@SLTON WHERE MASP=@MASP";
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@SLTON", SoLuong);
            sp[1] = new SqlParameter("@MASP", MaSP);
            DataProvider.ThucThi(strUpdate, sp, conn);
            conn.Close();
        }
        public List<SanPham_DTO> Load_COB_TenSP()
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
        public void Update_SL_Edit_CTHD(int sl, int masp)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strUpdate = "UPDATE SAN_PHAM SET SLTON=SLTON+@SLTON WHERE MASP=@MASP";
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@SLTON", sl);
            sp[1] = new SqlParameter("@MASP", masp);
            DataProvider.ThucThi(strUpdate, sp, conn);
            conn.Close();
        }
    }
}
