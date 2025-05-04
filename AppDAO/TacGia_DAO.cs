using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDTO;

namespace AppDAO
{
    public class TacGia_DAO
    {
        public List<TacGia_DTO> dsTacGia()
        {
            List<TacGia_DTO> dsTG = new List<TacGia_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            conn.Open();
            string SELECT = "SELECT * FROM TAC_GIA";
            SqlDataReader dr = DataProvider.TruyVan(SELECT, conn);
            while (dr.Read())
            {
                TacGia_DTO tg = new TacGia_DTO();
                tg.MaTacGia = dr["MA_TC"].ToString();
                tg.ButDanh = dr["BUTDANH"].ToString();
                tg.TenTacGia = dr["TEN_TC"].ToString();
                tg.LienHe = dr["LIENHE"].ToString();
                tg.DiaChi = dr["DIACHI"].ToString();
                tg.NgaySinh = DateTime.Parse(dr["NGSINH"].ToString());
                dsTG.Add(tg);
            }
            dr.Close();
            conn.Close();
            return dsTG;
        }
        public bool KiemTraTonTaiMaTG(string maTG)
        {
            string query = "SELECT COUNT(*) FROM TAC_GIA WHERE MA_TC = @MaTG";
            using (SqlConnection conn = DataProvider.TaoKetNoi())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTG", maTG);
                int count = cmd.ExecuteNonQuery();
                return count > 0;
            }
        }
        public bool ThemTacGia(TacGia_DTO tg)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                conn.Open();
                string INSERT = "INSERT INTO TAC_GIA (MA_TC, BUTDANH, TEN_TC, LIENHE, DIACHI, NGSINH) VALUES (@MaTG, @ButDanh, @TenTacGia, @LienHe, @DiaChi, @Ngsinh)";
                using (SqlCommand cmd = new SqlCommand(INSERT, conn))
                {
                    cmd.Parameters.AddWithValue("@MaTG", tg.MaTacGia);
                    cmd.Parameters.AddWithValue("@ButDanh", tg.ButDanh);
                    cmd.Parameters.AddWithValue("@TenTacGia", tg.TenTacGia);
                    cmd.Parameters.AddWithValue("@LienHe", tg.LienHe);
                    cmd.Parameters.AddWithValue("@DiaChi", tg.DiaChi);
                    cmd.Parameters.AddWithValue("@Ngsinh", tg.NgaySinh);
                    int kq = cmd.ExecuteNonQuery();
                    return kq > 0;
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
        public bool XoaTacGia(string maTG)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                conn.Open();
                string DELETE = "DELETE FROM TAC_GIA WHERE MA_TC = @MaTG";
                using (SqlCommand cmd = new SqlCommand(DELETE, conn))
                {
                    cmd.Parameters.AddWithValue("@MaTG", maTG);
                    int kq = cmd.ExecuteNonQuery();
                    return kq > 0;
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
        public bool CapNhatTacGia(TacGia_DTO tg)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                conn.Open();
                string UPDATE = "UPDATE TAC_GIA SET BUTDANH = @ButDanh, TEN_TC = @TenTacGia, LIENHE = @LienHe, DIACHI = @DiaChi, NGSINH = @Ngsinh WHERE MA_TC = @MaTG";
                using (SqlCommand cmd = new SqlCommand(UPDATE, conn))
                {
                    cmd.Parameters.AddWithValue("@MaTG", tg.MaTacGia);
                    cmd.Parameters.AddWithValue("@ButDanh", tg.ButDanh);
                    cmd.Parameters.AddWithValue("@TenTacGia", tg.TenTacGia);
                    cmd.Parameters.AddWithValue("@LienHe", tg.LienHe);
                    cmd.Parameters.AddWithValue("@DiaChi", tg.DiaChi);
                    cmd.Parameters.AddWithValue("@Ngsinh", tg.NgaySinh);
                    int kq = cmd.ExecuteNonQuery();
                    return kq > 0;
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
