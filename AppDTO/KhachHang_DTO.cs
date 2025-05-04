using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace AppDTO
{
    public class KhachHang_DTO
    {
        public string MaKH {  get; set; }
        public string TenKH {  get; set; }  
        public string SDT{get; set; }
        public string Email {  get; set; }
        public string DiaChi {  get; set; }
        public DateTime NgayTao { get; set; }
    }
}
