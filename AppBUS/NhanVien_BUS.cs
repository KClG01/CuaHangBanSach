using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDAO;
using AppDTO;

namespace AppBUS
{
    public class NhanVien_BUS
    {
        private NhanVien_DAO dsNV;
        public NhanVien_BUS()
        {
            dsNV = new NhanVien_DAO();
        }
        public List<NhanVien_DTO> dsNhanVien()
        {
            return dsNV.dsNhanVien();
        }
        public bool KiemTraTonTaiMaNV(string maNV)
        {
            return dsNV.KiemTraTonTaiMaNV(maNV);
        }
        public bool ThemNhanVien(NhanVien_DTO nv)
        {
            return dsNV.ThemNhanVien(nv);
        }
        public bool XoaNhanVien(string maNV)
        {
            return dsNV.XoaNhanVien(maNV);
        }
        public bool CapNhatNhanVien(NhanVien_DTO nv)
        {
            return dsNV.CapNhatNhanVien(nv);
        }
    }
}
