using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDAO;
using AppDTO;

namespace AppBUS
{
    public class NhaXuatBan_BUS
    {
        private NhaXuatBan_DAO dsNXB;

        public NhaXuatBan_BUS()
        {
            dsNXB = new NhaXuatBan_DAO();
        }
        public List<NhaXuatBan_DTO> dsNhaXuatBan()
        {
            return dsNXB.dsNhaXuatBan();
        }
        public bool KiemTraTonTaiMaNXB(int maNXB)
        {
            return dsNXB.KiemTraTonTaiMaNXB(maNXB);
        }
        public bool ThemNhaXuatBan(NhaXuatBan_DTO nxb)
        {
            return dsNXB.ThemNhaXuatBan(nxb);
        }
        public bool XoaNhaXuatBan(int maNXB)
        {
            return dsNXB.XoaNhaXuatBan(maNXB);
        }
        public bool CapNhatNhaXuatBan(NhaXuatBan_DTO nxb)
        {
            return dsNXB.CapNhatNhaXuatBan(nxb);
        }
    }
}
