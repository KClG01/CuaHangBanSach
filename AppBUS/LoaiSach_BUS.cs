using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDTO;
using AppDAO;

namespace AppBUS
{
    public class LoaiSach_BUS
    {
        private LoaiSach_DAO dsLS;

        public LoaiSach_BUS()
        {
            dsLS = new LoaiSach_DAO();
        }

        public List<LoaiSP_DTO> dsLoaiSach()
        {
            return dsLS.dsLoaiSach();
        }
        public bool ThemLoaiSach(LoaiSP_DTO loaiSach)
        {
            return dsLS.ThemLoaiSach(loaiSach);
        }
        public bool XoaLoaiSach(int maLoai)
        {
            return dsLS.XoaLoaiSach(maLoai);
        }
        public bool CapNhatLoaiSach(LoaiSP_DTO loaiSach)
        {
            return dsLS.CapNhatLoaiSach(loaiSach);
        }
        public bool KiemTraTonTaiMaLoai(int maLoai)
        {
            return dsLS.KiemTraTonTaiMaLoai(maLoai);
        }
    }
}
