using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDTO;

namespace AppDAO
{
    public class LoaiSach_DAO
    {
        public List<LoaiSP_DTO> dsLoaiSach()
        {
            List<LoaiSP_DTO> dsLS = new List<LoaiSP_DTO>();

            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string SELECT = "SELECT * FROM LOAI_SP";
            SqlDataReader dr = DataProvider.TruyVan(SELECT, conn);
            while (dr.Read())
            {
                LoaiSP_DTO loaiSach = new LoaiSP_DTO();
                loaiSach.MaLoai = dr["MA_LOAI"].ToString();
                loaiSach.TenLoai = dr["TENLOAI"].ToString();
                dsLS.Add(loaiSach);
            }
            dr.Close();
            conn.Close();
            return dsLS;
        }
        public bool KiemTraTonTaiMaLoai(int maLoai)
        {
            string query = "SELECT COUNT(*) FROM LOAI_SP WHERE MA_LOAI = @MaLoai";
            using (SqlConnection conn = DataProvider.TaoKetNoi())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLoai", maLoai);   
                int kq = cmd.ExecuteNonQuery();
                return kq > 0;
            }
        }
        public bool ThemLoaiSach(LoaiSP_DTO loaiSach)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                conn.Open();
                string INSERT = "INSERT INTO LOAI_SP (MA_LOAI, TENLOAI) VALUES (@MaLoai, @TenLoai)";
                using(SqlCommand cmd = new SqlCommand(INSERT, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLoai", loaiSach.MaLoai);
                    cmd.Parameters.AddWithValue("@TenLoai", loaiSach.TenLoai);
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
        public bool XoaLoaiSach(int maLoai)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                conn.Open();
                string DELETE = "DELETE FROM LOAI_SP WHERE MA_LOAI = @MaLoai";
                using (SqlCommand cmd = new SqlCommand(DELETE, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLoai", maLoai);
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
        public bool CapNhatLoaiSach(LoaiSP_DTO loaiSach)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                conn.Open();
                string UPDATE = "UPDATE LOAI_SP SET TENLOAI = @TenLoai WHERE MA_LOAI = @MaLoai";
                using (SqlCommand cmd = new SqlCommand(UPDATE, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLoai", loaiSach.MaLoai);
                    cmd.Parameters.AddWithValue("@TenLoai", loaiSach.TenLoai);
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
