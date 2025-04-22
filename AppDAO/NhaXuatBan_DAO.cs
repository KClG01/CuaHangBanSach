using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDTO;

namespace AppDAO
{
    public class NhaXuatBan_DAO
    {
        public List<NhaXuatBan_DTO> dsNhaXuatBan()
        {
            List<NhaXuatBan_DTO> dsNXB = new List<NhaXuatBan_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string SELECT = "SELECT * FORM NHA_XUAT_BAN";
            SqlDataReader dr = DataProvider.TruyVan(SELECT, conn);
            while (dr.Read())
            {
                NhaXuatBan_DTO nxb = new NhaXuatBan_DTO();
                nxb.MaNXB = dr["MA_NXB"].ToString();
                nxb.TenNXB = dr["TEN_NXB"].ToString();
                nxb.LienHe = dr["LIENHE"].ToString();
                nxb.DiaChi = dr["DIACHI"].ToString();
                dsNXB.Add(nxb);
            }
            dr.Close();
            conn.Close();
            return dsNXB;
        }
        public bool KiemTraTonTaiMaNXB(int maNXB)
        {
            string query = "SELECT COUNT(*) FROM NHA_XUAT_BAN WHERE MA_NXB = @MaNXB";
            using (SqlConnection conn = DataProvider.TaoKetNoi())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNXB", maNXB);
                int kq = cmd.ExecuteNonQuery();
                return kq > 0;
            }
        }
        public bool ThemNhaXuatBan(NhaXuatBan_DTO nxb)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                conn.Open();
                string INSERT = "INSERT INTO NHA_XUAT_BAN (MA_LNXB, TEN_NXB, LIENHE, DIACHI) VALUES (@MaNXB, @TenNXB, @LienHe, @DiaChi)";
                using (SqlCommand cmd = new SqlCommand(INSERT, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNXB", nxb.MaNXB);
                    cmd.Parameters.AddWithValue("@TenNXB", nxb.TenNXB);
                    cmd.Parameters.AddWithValue("@LienHe", nxb.LienHe);
                    cmd.Parameters.AddWithValue("@DiaChi", nxb.DiaChi);
                    int kq = cmd.ExecuteNonQuery();
                    return kq > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }
        public bool XoaNhaXuatBan(int maNXB)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                conn.Open();
                string DELETE = "DELETE FROM NHA_XUAT_BAN WHERE MA_NXB = @MaNXB";
                using (SqlCommand cmd = new SqlCommand(DELETE, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNXB", maNXB);
                    int kq = cmd.ExecuteNonQuery();
                    return kq > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }
        public bool CapNhatNhaXuatBan(NhaXuatBan_DTO nxb)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                conn.Open();
                string UPDATE = "UPDATE NHA_XUAT_BAN SET TEN_NXB = @TenNXB, LIENHE = @LienHe, DIACHI = @DiaChi WHERE MA_NXB = @MaNXB";
                using (SqlCommand cmd = new SqlCommand(UPDATE, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNXB", nxb.MaNXB);
                    cmd.Parameters.AddWithValue("@TenNXB", nxb.TenNXB);
                    cmd.Parameters.AddWithValue("@LienHe", nxb.LienHe);
                    cmd.Parameters.AddWithValue("@DiaChi", nxb.DiaChi);
                    int kq = cmd.ExecuteNonQuery();
                    return kq > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }
    }
}
