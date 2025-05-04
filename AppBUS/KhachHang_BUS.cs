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
        public KhachHang_DAO KhachHang = new KhachHang_DAO();

        public object MessageBox { get; private set; }

        public List<KhachHang_DTO> Lay_DS_KhachHang()
        {
            KhachHang_DAO dsKhachHang = new KhachHang_DAO();
            return dsKhachHang.Lay_DS_KhachHang();
        }
        public bool ViPham(string MaKH, string Ten, string diachi, string sdt, string email, DateTime NgayLap)
        {
            if (string.IsNullOrWhiteSpace(MaKH) || string.IsNullOrWhiteSpace(Ten) || string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(NgayLap.ToString()))
            {
                return true;
            }
            else { return false; }
        }
        public bool Check_SDT(string sdt)
        {
            if (KhachHang.KiemTraThongTinTrung_SDT(sdt))
            {
                return true;
            }
            return false;
        }
        public bool Check_SDT_Edit(string sdt, string makh)
        {
            if (KhachHang.KiemTraThongTin_SDT_Update(sdt,makh))
            {
                return true;
            }
            return false;
        }
        public bool Check_Email_Edit(string Email, string makh)
        {
            if (KhachHang.KiemTraThongTin_Email_Update(Email, makh))
            {
                return true;
            }
            return false;
        }
        public bool Check_Email(string email)
        {
            if (KhachHang.KiemTraThongTinTrung_Email(email))
            {
                return true;
            }
            return false;
        }
        public bool KiemTraDoDai_SDT(string SDT)
        {
            return SDT.Length != 10; // Trả về true nếu độ dài đúng 10, ngược lại false
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
        public List<KhachHang_DTO> TimKiemKhachHang(int i , string str)
        {
            KhachHang_DAO dsKhachHang = new KhachHang_DAO();
            switch(i)
            {
                case 0: { return dsKhachHang.TimKiemKhachHang_HoTen(str); }
                case 1: { return dsKhachHang.TimKiemKhachHang_SDT(str); }
                case 3: { return dsKhachHang.TimKiemKhachHang_Email(str); }
                case 2: { return dsKhachHang.TimKiemKhachHang_DiaChi(str); }
            }
            return null;

        }
    }
}
