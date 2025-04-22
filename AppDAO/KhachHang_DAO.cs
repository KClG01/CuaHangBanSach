using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDTO;

namespace AppDAO
{
    public class KhachHang_DAO
    {
        public List<KhachHang_DTO> Lay_DS_KhachHang()
        {
            List<KhachHang_DTO> dsKhachHang = new List<KhachHang_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strSelect = "Select * from KHACH_HANG where trangthai =1";
            SqlDataReader dr = DataProvider.TruyVan(strSelect, conn);
            while (dr.Read())
            {
                KhachHang_DTO sv = new KhachHang_DTO();
                sv.MaKH = dr["MAKH"].ToString();
                sv.TenKH = dr["TENKH"].ToString();
                sv.SDT = dr["SDT"].ToString();
                sv.DiaChi = dr["DiaChi"].ToString();
                sv.Email = dr["Email"].ToString();
                sv.NgayTao = DateTime.Parse(dr["NgayTao"].ToString());
                dsKhachHang.Add(sv);
            }
            conn.Close();
            return dsKhachHang;
        }
        public int ThemKhachHang(KhachHang_DTO kh)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string Insert = "Insert into Khach_Hang(MaKH,TenKH,SDT,Email,DiaChi,NgayTao,TrangThai)" +
                "Values(@MaKH,@TenKH,@SDT,@Email,@DiaChi,@NgayTao,1)";
            SqlParameter[] sp = new SqlParameter[6];
            sp[0] = new SqlParameter("@MaKH", kh.MaKH);
            sp[1] = new SqlParameter("@TenKH", kh.TenKH);
            sp[2] = new SqlParameter("@SDT",kh.SDT);
            sp[3] = new SqlParameter("@Email", kh.Email);
            sp[4] = new SqlParameter("@DiaChi", kh.DiaChi);
            sp[5] = new SqlParameter("@NgayTao",kh.NgayTao);
            int kq = DataProvider.ThucThi(Insert, sp, conn);
            conn.Close();
            return kq;
        }
        public int SuaThongTinKhachHang(KhachHang_DTO kh)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            string Update = "Update Khach_Hang" +
                "Set MaKH =@MaKh, TenKH = @TenKH, SDT = @SDT, Email =@Email, DiaChi=@DiaChi, TrangThai = @TrangThai" +
                "Where MaKH = @MaKH";
            SqlParameter[] sp = new SqlParameter[6];
            sp[0] = new SqlParameter("@MaKH", kh.MaKH);
            sp[1] = new SqlParameter("@TenKH", kh.TenKH);
            sp[2] = new SqlParameter("@SDT", kh.SDT);
            sp[3] = new SqlParameter("@Email", kh.Email);
            sp[4] = new SqlParameter("@DiaChi", kh.DiaChi);
            sp[5] = new SqlParameter("@NgayTao", kh.NgayTao);
            int kq = DataProvider.ThucThi(Update, sp, conn);
            conn.Close();
            return kq;
        }
        public int XoaKhachHang(KhachHang_DTO kh)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string strDelete = $"update SinhVien set TrangThai = 0 whereMSSV ={kh.MaKH}";
            int kq = DataProvider.Xoa(strDelete, conn);
            conn.Close();
            return kq;
        }
        //public List<KhachHang_DTO> TimKiemKhachHang(KhachHang_DTO kh)
        //{
             
        //}
    }
}
