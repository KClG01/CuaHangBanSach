using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDAO;
using AppDTO;

namespace AppBUS
{
    public class TacGia_BUS
    {
        private TacGia_DAO dsTG;
        public TacGia_BUS()
        {
            dsTG = new TacGia_DAO();
        }
        public List<TacGia_DTO> dsTacGia()
        {
            return dsTG.dsTacGia();
        }
        public bool KiemTraTonTaiMaTG(string maTG)
        {
            return dsTG.KiemTraTonTaiMaTG(maTG);
        }
        public bool ThemTacGia(TacGia_DTO tg)
        {
            return dsTG.ThemTacGia(tg);
        }
        public bool XoaTacGia(string maTG)
        {
            return dsTG.XoaTacGia(maTG);
        }
        public bool CapNhatTacGia(TacGia_DTO tg)
        {
            return dsTG.CapNhatTacGia(tg);
        }
    }
}
