using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDAO;
using AppDTO;

namespace AppBUS
{
    public class KhachHang_BUS
    {
        private KhachHang_DAO KhachHang;
        public List<KhachHang_DTO> Lay_DS_KhachHang()
        {
            KhachHang_DAO dsKhachHang = new KhachHang_DAO();
            return dsKhachHang.Lay_DS_KhachHang();
        }
        public bool ViPham(string MaKH, string Ten, string diachi, string sdt, string email, DateTime NgaySinh)
        {
            if (string.IsNullOrWhiteSpace(MaKH) || string.IsNullOrWhiteSpace(Ten) || string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(NgaySinh.ToString()))
            {
                return true;
            }
            else { return false; }
        }
        public int Add_KhachHang(KhachHang_DTO Info_KhachHang)
        {
            return KhachHang.ThemKhachHang(Info_KhachHang);
        }
        public int Update_KhachHang(KhachHang_DTO Info_KhachHang)
        {
            return KhachHang.SuaThongTinKhachHang(Info_KhachHang);
        }
        public int Remove_KhachHang(KhachHang_DTO Info_KhachHang)
        {
            return KhachHang.XoaKhachHang(Info_KhachHang);
        }
    }
}
