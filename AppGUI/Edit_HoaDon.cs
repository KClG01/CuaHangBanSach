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
    public partial class frm_Edit_HoaDon : Form
    {
        public HoaDon_DTO HoaDon { get; set; }
        CTHoaDon_DTO ct;
        public frm_Edit_HoaDon()
        {
            InitializeComponent();
        }
        private void frm_Edit_HoaDon_Load(object sender, EventArgs e)
        {
            // Trong constructor của Form hoặc sự kiện Load
            this.WindowState = FormWindowState.Maximized; // Mở rộng cửa sổ toàn màn hình
            txt_QLHD_MAHD.Text = HoaDon.MaHD;
            txt_QLHD_MAKH.Text = HoaDon.MaKH;
            txt_QLHD_MANV.Text = HoaDon.MaNV;
            Load_TenSP();
            Load_DS_CTHD();
            dgv_CT_HOADON.AutoGenerateColumns = false;
            txt_CTHD_KM.Controls[0].Visible = false;
        }
        private void btn_QLHD_Re_Click(object sender, EventArgs e)
        {
            Load_DS_CTHD();
        }
        public void Load_DS_CTHD()
        {
            CT_HoaDon_BUS ctHoaDon = new CT_HoaDon_BUS();
            List<CTHoaDon_DTO> dsCTHD = ctHoaDon.Lay_DS_CTHD(HoaDon.MaHD);
            dgv_CT_HOADON.DataSource = dsCTHD;
        }
        private void btn_CN_CTHD_OUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadThongTin()
        {
            if (ct != null)
            {
                cob_CTHD_TENSP.SelectedValue = ct.MaSP;
                txt_CT_HOADON_SL.Value = int.Parse(ct.SoLuong.ToString());
                txt_CT_HOADON_GIA.Text = ct.DonGia.ToString();
                txt_CTHD_KM.Text = ct.KhuyenMai.ToString();
                txt_CT_HOADON_TT.Text = ct.ThanhTien.ToString();
                txt_CTHD_KM.Text = ct.KhuyenMai.ToString();
            }
            else
            {
                ct = null;
            }

        }
        public void Load_TenSP()
        {
            CT_HoaDon_BUS ctHoaDon = new CT_HoaDon_BUS();
            List<SanPham_DTO> dsSanPham = ctHoaDon.Load_COB_SanPham();
            cln_QL_CTHD_SANPHAM.DataSource = dsSanPham;
            cln_QL_CTHD_SANPHAM.DisplayMember = "TenSp";
            cln_QL_CTHD_SANPHAM.ValueMember = "MaSp";
            cob_CTHD_TENSP.DataSource = dsSanPham;
            cob_CTHD_TENSP.DisplayMember = "TenSp";
            cob_CTHD_TENSP.ValueMember = "MaSp";
        }
        private void dgv_CT_HOADON_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_CT_HOADON.Rows.Count > 0)
            {
                ct = dgv_CT_HOADON.CurrentRow.DataBoundItem as CTHoaDon_DTO;
                LoadThongTin();
            }
            else
            {
                ct = null;
            }
        }

        private void btn_QLHD_Del_Click(object sender, EventArgs e)
        {
            CT_HoaDon_BUS cT_HoaDon_BUS = new CT_HoaDon_BUS();
            if (cT_HoaDon_BUS.Remove_CTHD(txt_QLHD_MAHD.Text, (int)cob_CTHD_TENSP.SelectedValue))
            {
                MessageBox.Show("Xóa chi tiết hóa đơn thành công!", "Thông báo!");
                SanPham_BUS sp = new SanPham_BUS();
                sp.CapNhapSoLuong((int)cob_CTHD_TENSP.SelectedValue, (-1) * (int)ct.SoLuong);
                Load_DS_CTHD();
            }
            else
            {
                MessageBox.Show("Xóa chi tiết hóa đơn không thành công!", "Thông báo!");
            }
        }

        private void cob_CTHD_TENSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            CT_HoaDon_BUS cT_HoaDon = new CT_HoaDon_BUS();
            SanPham_DTO sp = cT_HoaDon.Lay_Gia_SL_SanPham(cob_CTHD_TENSP.Text);
            txt_CT_HOADON_GIA.Text = sp.GiaBan.ToString();
            txt_CT_HOADON_SL.Maximum = 100;
        }

        private void txt_CT_HOADON_SL_ValueChanged(object sender, EventArgs e)
        {
            double result = 0;
            double giaBan = 0;
            int KhuyenMai = 0;
            int SL = (int)txt_CT_HOADON_SL.Value;
            double.TryParse(txt_CT_HOADON_GIA.Text, out giaBan);
            int.TryParse(txt_CTHD_KM.Text, out KhuyenMai);
            result = (giaBan * SL) - ((giaBan * SL) * KhuyenMai / 100);
            txt_CT_HOADON_TT.Text = result.ToString();
        }

        private void txt_CT_HOADON_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Vui lòng nhập số nnguyên!", "Cảnh báo");
                e.Handled = true;
            }
            if (txt_CT_HOADON_SL.Value > txt_CT_HOADON_SL.Maximum)
            {
                MessageBox.Show($"Số lượng sản phẩm chỉ còn {txt_CT_HOADON_SL.Maximum} cái!", "Cảnh báo");
                return;
            }
        }

        private void btn_QLHD_Add_Click(object sender, EventArgs e)
        {
            int sl;
            int masp = (int)cob_CTHD_TENSP.SelectedValue;
            CT_HoaDon_BUS cT_HoaDon = new CT_HoaDon_BUS();
            if (txt_CT_HOADON_SL.Value > ct.SoLuong)
            {
                sl = (int)txt_CT_HOADON_SL.Value - (int)ct.SoLuong;
                SanPham_BUS sp = new SanPham_BUS();
                sp.Update_SL_Edit_CTHD(sl,(int)cob_CTHD_TENSP.SelectedValue);
                Load_DS_CTHD();
            }
            else
            {
                sl = (int)ct.SoLuong - (int)txt_CT_HOADON_SL.Value;
                SanPham_BUS sp = new SanPham_BUS();
                sp.Update_SL_Edit_CTHD((-1)*sl, (int)cob_CTHD_TENSP.SelectedValue);
                Load_DS_CTHD();
            }
            if (cT_HoaDon.Update_CTHD((int)txt_CT_HOADON_SL.Value, txt_QLHD_MAHD.Text, txt_CT_HOADON_TT.Text,masp))
            {
               
                MessageBox.Show("Cập nhật chi tiết hóa đơn thành công!", "Thông báo!");
                Load_DS_CTHD();
            }
            else
            {
                MessageBox.Show("Cập nhật chi tiết hóa đơn không thành công!", "Thông báo!");
            }
        }
        private void txt_CTHD_KM_ValueChanged(object sender, EventArgs e)
        {
            double result = 0;
            double giaBan = 0;
            int KhuyenMai = 0;
            int SL = (int)txt_CT_HOADON_SL.Value;
            double.TryParse(txt_CT_HOADON_GIA.Text, out giaBan);
            int.TryParse(txt_CTHD_KM.Text, out KhuyenMai);
            result = (giaBan * SL) - ((giaBan * SL) * KhuyenMai / 100);
            txt_CT_HOADON_TT.Text = result.ToString();
        }
    }
}
