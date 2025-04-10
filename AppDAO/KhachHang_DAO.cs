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
                sv.MaKH = dr["MSSV"].ToString();
                sv.TenKH = dr["Ho"].ToString();
                sv.SDT = dr["SDT"].ToString();
                sv.DiaChi = dr["DiaChi"].ToString();
                sv.Email = dr["Email"].ToString();
                sv.NgayTao = DateTime.Parse(dr["NgayTao"].ToString());
                sv.TrangThai = 1;

                dsKhachHang.Add(sv);
            }
            conn.Close();
            return dsKhachHang;
        }
    }
}
