using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDTO
{
    public class NhanVien_DTO
    {
        public string MaNV {  get; set; }
        public string TenNV {  get; set; }
        public string MaNQL {  get; set; }
        public int GioiTinh { get; set; }
        public string Email {  get; set; }
        public string DiaChi {  get; set; }
        public double Luong {  get; set; }
        public DateTime NgayTao { get; set; }
        public int TrangThai {  get; set; }
    }
}
