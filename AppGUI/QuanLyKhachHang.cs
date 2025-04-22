using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBUS;
using AppDTO;

namespace AppGUI
{
    public partial class FormQuanLyKhachHang : Form
    {
        List<KhachHang_DTO> dsKhachHang;
        KhachHang_BUS Khachhang = new KhachHang_BUS();
        KhachHang_DTO kh;
        public FormQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachKhang();
            dgv_QLKH.AutoGenerateColumns = false;
        }
        public void LoadKhachKhang()
        {
            dsKhachHang = Khachhang.Lay_DS_KhachHang();
            dgv_QLKH.DataSource = dsKhachHang;
        }
    }
}
