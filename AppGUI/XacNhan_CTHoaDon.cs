using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDTO;
using AppBUS;

namespace AppGUI
{
    public partial class XacNhan_CTHoaDon : Form
    {
        public HoaDon_DTO HoaDon_Form { get; set; }
        public XacNhan_CTHoaDon()
        {
            InitializeComponent();
        }
        private void XacNhan_CTHoaDon_Load(object sender, EventArgs e)
        {
            txt_QLHD_MAHD.Text = HoaDon_Form.MaHD;
            txt_QLHD_MAKH.Text = HoaDon_Form.MaKH;
            txt_QLHD_MANV.Text = HoaDon_Form.MaNV;
            Load_TenSP();
            Load_CTHoaDon();
            dgv_CT_HOADON.AutoGenerateColumns = false;
            Load_TongTien();
            Load_SL_SanPham();
        }
        public void Load_CTHoaDon()
        {
            CT_HoaDon_BUS ctHoaDon = new CT_HoaDon_BUS();
            List<CTHoaDon_DTO> dsCTHD = ctHoaDon.Lay_DS_CTHD(HoaDon_Form.MaHD);
            dgv_CT_HOADON.DataSource = dsCTHD;
        }
        public void Load_TongTien()
        {
            double TongTien = 0;
            CT_HoaDon_BUS ctHoaDon = new CT_HoaDon_BUS();
            txt_CT_HOADON_TT.Text = ctHoaDon.ThanhTien_HoaDon(HoaDon_Form.MaHD).ToString();
         
        }
        public void Load_SL_SanPham()
        {
            CT_HoaDon_BUS ctHoaDon = new CT_HoaDon_BUS();
            int sl = ctHoaDon.Count_SanPham(HoaDon_Form.MaHD);
            txt_CT_HOADON_SL.Text = sl.ToString();
        }
        private void btn_CT_HOADON_XACNHAN_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_CT_HOADON_TIENNHAN.Text))
            {
                MessageBox.Show("Vui lòng nhập tiền nhận!", "Cảnh báo");
                return;
            }
            if (double.Parse(txt_CT_HOADON_TIENNHAN.Text) < double.Parse(txt_CT_HOADON_TT.Text))
            {
                MessageBox.Show("Tiền nhận không đủ!", "Cảnh báo");
                return;
            }
            CT_HoaDon_BUS ctHoaDon = new CT_HoaDon_BUS();
            if (ctHoaDon.Up_Date_HoaDon(txt_QLHD_MAHD.Text, txt_CT_HOADON_TT.Text, txt_CT_HOADON_TIENNHAN.Text, txt_CT_HOADON_TRA.Text))
            {
                
                MessageBox.Show("Xác nhận hóa đơn thành công!", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Xác nhận hóa đơn thất bại!", "Thông báo");
            }
        }
        public void Load_TenSP()
        {
            CT_HoaDon_BUS ctHoaDon = new CT_HoaDon_BUS();
            List<SanPham_DTO> dsSanPham = ctHoaDon.Load_COB_SanPham();
            cln_QL_CTHD_SANPHAM.DataSource = dsSanPham;
            cln_QL_CTHD_SANPHAM.DisplayMember = "TenSp";
            cln_QL_CTHD_SANPHAM.ValueMember = "MaSp";
        }

        private void txt_CT_HOADON_TIENNHAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) 
            {
                MessageBox.Show("Vui lòng nhập số tiền!", "Cảnh báo");
            }
        }

        private void txt_CT_HOADON_TIENNHAN_TextChanged(object sender, EventArgs e)
        {
            double result = 0;
            if (double.TryParse(txt_CT_HOADON_TIENNHAN.Text, out result))
            {
                double TongTien = double.Parse(txt_CT_HOADON_TT.Text);
                double TienThua = result - TongTien;
                txt_CT_HOADON_TRA.Text = TienThua.ToString();
            }
            else
            {
                txt_CT_HOADON_TRA.Text = "0";
            }
        }
    }
}
