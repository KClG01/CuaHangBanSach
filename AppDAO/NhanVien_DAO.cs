using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDTO;

namespace AppDAO
{
    public class NhanVien_DAO
    {
        public List<NhanVien_DTO> dsNhanVien()
        {
            List<NhanVien_DTO> dsNV = new List<NhanVien_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string SELECT = "SELECT * FROM NHAN_VIEN";
            SqlDataReader dr = DataProvider.TruyVan(SELECT, conn);
            while (dr.Read())
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.MaNV = dr["MA_NV"].ToString();
                nv.TenNV = dr["TEN_NV"].ToString();
                nv.GioiTinh = Convert.ToBoolean(dr["GIOITINH"]);
                nv.SDT = int.Parse(dr["SDT"].ToString());
                nv.Email = dr["EMAIL"].ToString();
                nv.DiaChi = dr["DIACHI"].ToString();
                nv.Luong = Convert.ToDecimal(dr["LUONG"]);
                nv.NgayTao = DateTime.Parse(dr["NGAYTAO"].ToString());
                nv.Password = dr["PASSWORD"].ToString();
                dsNV.Add(nv);
            }
            dr.Close();
            conn.Close();
            return dsNV;
        }
        public bool KiemTraTonTaiMaNV(string maNV)
        {
            string query = "SELECT COUNT(*) FROM NHAN_VIEN WHERE MA_NV = @MaNV";
            using (SqlConnection conn = DataProvider.TaoKetNoi())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        public bool ThemNhanVien(NhanVien_DTO nv)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                conn.Open();
                string INSERT = "INSERT INTO NHAN_VIEN (MA_NV, TEN_NV, GIOITINH, SDT, EMAIL, DIACHI, LUONG, NGAYTAO, PASSWORD) VALUES (@MaNV, @TenNV, @GioiTinh, @SDT, @Email, @DiaChi, @Luong, @NgayTao, @Password)";
                using (SqlCommand cmd = new SqlCommand(INSERT, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                    cmd.Parameters.AddWithValue("@TenNV", nv.TenNV);
                    cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                    cmd.Parameters.AddWithValue("@SDT", nv.SDT);
                    cmd.Parameters.AddWithValue("@Email", nv.Email);
                    cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                    cmd.Parameters.AddWithValue("@Luong", nv.Luong);
                    cmd.Parameters.AddWithValue("@NgayTao", nv.NgayTao);
                    cmd.Parameters.AddWithValue("@Password", nv.Password);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool XoaNhanVien(string maNV)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                conn.Open();
                string DELETE = "DELETE FROM NHAN_VIEN WHERE MA_NV = @MaNV";
                using (SqlCommand cmd = new SqlCommand(DELETE, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool CapNhatNhanVien(NhanVien_DTO nv)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                conn.Open();
                string UPDATE = "UPDATE NHAN_VIEN SET TEN_NV = @TenNV, GIOITINH = @GioiTinh, SDT = @SDT, EMAIL = @Email, DIACHI = @DiaChi, LUONG = @Luong, NGAYTAO = @NgayTao, PASSWORD = @Password WHERE MA_NV = @MaNV";
                using (SqlCommand cmd = new SqlCommand(UPDATE, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                    cmd.Parameters.AddWithValue("@TenNV", nv.TenNV);
                    cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                    cmd.Parameters.AddWithValue("@SDT", nv.SDT);
                    cmd.Parameters.AddWithValue("@Email", nv.Email);
                    cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                    cmd.Parameters.AddWithValue("@Luong", nv.Luong);
                    cmd.Parameters.AddWithValue("@NgayTao", nv.NgayTao);
                    cmd.Parameters.AddWithValue("@Password", nv.Password);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
