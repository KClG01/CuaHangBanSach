using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDAO;
using AppDTO;

namespace AppBUS
{
    public class CT_HoaDon_BUS
    {
        CT_HoaDon_DAO CTHD = new CT_HoaDon_DAO();
        public List<SanPham_DTO> Load_COB_SanPham()
        {
            CT_HoaDon_DAO ctHoaDonDAO = new CT_HoaDon_DAO();
            return ctHoaDonDAO.Load_COB_SanPham();
        }
        public SanPham_DTO Lay_Gia_SL_SanPham(string strTenSanPham)
        {
            CT_HoaDon_DAO ctHoaDonDAO = new CT_HoaDon_DAO();
            return ctHoaDonDAO.Lay_Gia_SL_SanPham(strTenSanPham);
        }
        public int ThemChiTietHoaDon(CTHoaDon_DTO cthd)
        {
            CT_HoaDon_DAO ctHoaDonDAO = new CT_HoaDon_DAO();
            return ctHoaDonDAO.ThemChiTietHoaDon(cthd);
        }
        public bool Check_MaSP(int masp,string mahd)
        {
            if (CTHD.KiemTraThongTinTrung_MaSP(masp,mahd))
            {
                return true;
            }
            return false;
        }
        public List<CTHoaDon_DTO> Lay_DS_CTHD(string mahd)
        {
            CT_HoaDon_DAO ctHoaDonDAO = new CT_HoaDon_DAO();
            return ctHoaDonDAO.Load_ChiTietHoaDon(mahd);
        }
        public double ThanhTien_HoaDon(string MaHD)
        {
            CT_HoaDon_DAO ctHoaDonDAO = new CT_HoaDon_DAO();
            return ctHoaDonDAO.ThanhTien_HoaDon(MaHD);
        }
        public int Count_SanPham(string MaHD)
        {
            CT_HoaDon_DAO ctHoaDonDAO = new CT_HoaDon_DAO();
            return ctHoaDonDAO.Count_SanPham(MaHD);
        }
        public bool Up_Date_HoaDon(string MaHD, string ThanhTien, string Nhan, string TienTra) 
        { 
            CT_HoaDon_DAO cthd = new CT_HoaDon_DAO();
            return CTHD.Up_Date_HoaDon(MaHD, ThanhTien, Nhan, TienTra)>0;
        }
        public bool Remove_CTHD(string MaHD, int MaSP)
        {
            CT_HoaDon_DAO cthd = new CT_HoaDon_DAO();
            return CTHD.XoaChiTietHoaDon(MaHD, MaSP) > 0;
        }
        public bool Update_CTHD(int sl, string mahd, string thanhtien,int masp)
        {
            CT_HoaDon_DAO cthd = new CT_HoaDon_DAO();
            return CTHD.Update_CTHD(sl, mahd, thanhtien,masp) > 0;
        }
    }
}
