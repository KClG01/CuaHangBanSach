using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDAO;
using AppDTO;

namespace AppBUS
{
    public class SanPham_BUS
    {
        SanPham_DAO SanPham= new SanPham_DAO();    
        public List<SanPham_DTO> Lay_DS_SanPham()
        {
            SanPham_DAO dsSanPham = new SanPham_DAO();
            return dsSanPham.Lay_DS_SanPham();
        }
        public List<LoaiSP_DTO> Load_Cob_Loai()
        {
            SanPham_DAO dsLoai = new SanPham_DAO();
            return dsLoai.Load_Cob_Loai();
        }
        public List<TacGia_DTO> Load_Cob_TacGia()
        {
            SanPham_DAO dsTacGia = new SanPham_DAO();
            return dsTacGia.Load_Cob_TacGia();
        }
        public List<NhaXuatBan_DTO> Load_Cob_NXB()
        {
            SanPham_DAO dsNXB = new SanPham_DAO();
            return dsNXB.Load_Cob_NXB();
        }
        public bool ViPham(string MaSp, string TenSp,string giaBan, string giaNhap)
        {
            if (string.IsNullOrWhiteSpace(MaSp) || string.IsNullOrWhiteSpace(TenSp) || string.IsNullOrWhiteSpace(giaBan) || string.IsNullOrWhiteSpace(giaNhap))
            {
                return true;
            }
            return false;
        }
        public bool Check_MaSP(string masp)
        {
            if (SanPham.KiemTraThongTinTrung_MaSP(masp))
            {
                return true;
            }
            return false;
        }
        public bool Check_TenSP(string tensp)
        {
            if (SanPham.KiemTraThongTinTrung_TenSp(tensp))
            {
                return true;
            }
            return false;
        }
        public bool Check_TenSP_Update(string tensp, string masp)
        {
            if (SanPham.KiemTraThongTin_Email_Update(tensp, masp))
            {
                return true;
            }
            return false;
        }
        public int Add_Book(SanPham_DTO Info_SanPham)
       {
            return SanPham.ThemSanPham(Info_SanPham);
        }
        public int Edit_Book(SanPham_DTO Info_SanPham)
        {
            return SanPham.SuaSanPham(Info_SanPham);
        }
        public int Delete_Book(SanPham_DTO Info_SanPham)
        {
            return SanPham.XoaSanPham(Info_SanPham);
        }
        public List<SanPham_DTO> TimKiemSanPham(int i, string str)
        {
            SanPham_DAO dsSanPham = new SanPham_DAO();
            switch (i)
            {
                case 0: { return dsSanPham.TimKiemSanPham_TenSP(str); }
                case 1: { return dsSanPham.TimKiemSanPham_NXB(str); }
                case 2: { return dsSanPham.TimKiemSanPham_TacGia(str); }
                case 3: { return dsSanPham.TimKiemSanPham_Loai(str); }
            }
            return null;

        }
        public void CapNhapSoLuong(int ma,int sl)
        {
            SanPham.CapNhapSoLuong(ma,sl);
        }
        public List<SanPham_DTO> Load_COB_TenSP()
        {
            SanPham_DAO dsSanPham = new SanPham_DAO();
            return dsSanPham.Load_COB_TenSP();
        }
        public void Update_SL_Edit_CTHD(int sl, int masp)
        {
            SanPham.CapNhapSoLuong(masp, sl);
        }
    }
}
