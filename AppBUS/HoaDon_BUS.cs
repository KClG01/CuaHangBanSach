using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDAO;
using AppDTO;

namespace AppBUS
{
    public class HoaDon_BUS
    {
        // Load all invoices
        HoaDon_DAO HoaDon = new HoaDon_DAO();
        public List<HoaDon_DTO> LoadHoaDon()
        {
            HoaDon_DAO hoaDonDAO = new HoaDon_DAO();
            return hoaDonDAO.LoadHoaDon();
        }
        public bool XoaHoaDon(HoaDon_DTO Info_HoaDon)
        {
            return HoaDon.XoaHoaDon(Info_HoaDon)>0;
        }
        public bool ThemHoaDon(HoaDon_DTO Info_HoaDon)
        {
            return HoaDon.ThemHoaDon(Info_HoaDon) > 0;
        }
        public bool KiemTraMaHD(string maHD)
        {
            return HoaDon.KiemTraMaHD(maHD);
        }
        public bool KiemTraMaKH(string maKH)
        {
            return HoaDon.KiemTraMaKH(maKH);
        }
        public bool KiemTraMaNV(string maNV)
        {
            return HoaDon.KiemTraMaNV(maNV);
        }
    }
}
