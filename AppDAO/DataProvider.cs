using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDAO
{
    public static class DataProvider
    {
        static string strChuoiKetNoi = "Data Source =.;Initial Catalog = QLCuaHangBanSach;Integrated Security = True";
        public static SqlConnection TaoKetNoi()
        {
            return new SqlConnection(strChuoiKetNoi);
        }
        public static SqlDataReader TruyVan(string strChuoiKetNoi,SqlConnection conn)
        {
            SqlCommand com = new SqlCommand(strChuoiKetNoi,conn);
            return com.ExecuteReader();
        }
        public static int ThucThi(string strThucThi, SqlParameter[] sp, SqlConnection conn)
        {
            SqlCommand comm = new SqlCommand(strThucThi, conn);
            comm.Parameters.AddRange(sp);
            return comm.ExecuteNonQuery();
        }
        public static int Xoa(string strXoa, SqlConnection conn)
        {
            SqlCommand comm = new SqlCommand(strXoa, conn);

            return comm.ExecuteNonQuery();
        }


    }
}
