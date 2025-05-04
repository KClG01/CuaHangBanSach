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
    public partial class frm_ThemChiTietHoaDon : Form
    {
        public CT_HoaDon_BUS CT_HoaDon = new CT_HoaDon_BUS();
        public CTHoaDon_DTO cthd;
        public HoaDon_DTO HoaDon_Form { get; set; }
        public frm_ThemChiTietHoaDon()
        {
            InitializeComponent();
        }
        public void LoadChiTietHoaDon()
        {
            txt_CT_HOADON_MAHD.Text = HoaDon_Form.MaHD;
            txt_CT_HOADON_MANV.Text = HoaDon_Form.MaNV;
            txt_CT_HOADON_MAKH.Text = HoaDon_Form.MaKH;
            //Load danh sách sản phẩm vào combobox
            List<SanPham_DTO> dsSanPham = CT_HoaDon.Load_COB_SanPham();
            cb_CT_HOADON_TENSP.DataSource = dsSanPham;
            cb_CT_HOADON_TENSP.DisplayMember = "TenSp";
            cb_CT_HOADON_TENSP.ValueMember = "MaSp";
            
        }

        private void frm_ThemChiTietHoaDon_Load(object sender, EventArgs e)
        {
            LoadChiTietHoaDon();
            txt_CT_HOADON_KM.Controls[0].Visible = false;  // Ẩn mũi tên
        }
        private void txt_CT_HOADON_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Vui lòng nhập số nnguyên!","Cảnh báo");
                e.Handled = true;
            }
            if (txt_CT_HOADON_SL.Value > txt_CT_HOADON_SL.Maximum)
            {
                MessageBox.Show($"Số lượng sản phẩm chỉ còn {txt_CT_HOADON_SL.Maximum} cái!", "Cảnh báo");
                return;
            }

        }
        private void cb_CT_HOADON_TENSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            SanPham_DTO sp = CT_HoaDon.Lay_Gia_SL_SanPham(cb_CT_HOADON_TENSP.Text);
            txt_CT_HOADON_GIA.Text = sp.GiaBan.ToString();
            txt_CT_HOADON_SL.Maximum = sp.SLTon;
        }
        private void txt_CT_HOADON_SL_ValueChanged(object sender, EventArgs e)
        {
            double result = 0;
            double giaBan = 0;             
            int KhuyenMai = 0;
            int SL = (int)txt_CT_HOADON_SL.Value;            
            double.TryParse(txt_CT_HOADON_GIA.Text, out giaBan);            
            int.TryParse(txt_CT_HOADON_KM.Text, out KhuyenMai);
            result = (giaBan * SL) - ((giaBan * SL) * KhuyenMai / 100);
            txt_CT_HOADON_TT.Text = result.ToString();
        }
        private void txt_CT_HOADON_KM_ValueChanged(object sender, EventArgs e)
        {
            double result = 0;
            double giaBan = 0;
            int KhuyenMai = 0;
            int SL = (int)txt_CT_HOADON_SL.Value;
            double.TryParse(txt_CT_HOADON_GIA.Text, out giaBan);
            int.TryParse(txt_CT_HOADON_KM.Text, out KhuyenMai);
            result = (giaBan * SL) - ((giaBan * SL) * KhuyenMai / 100);
            txt_CT_HOADON_TT.Text = result.ToString();
        }
        public void LayChiTietHoaDon()
        {
            cthd = new CTHoaDon_DTO();
            cthd.MaHD = txt_CT_HOADON_MAHD.Text;
            cthd.MaSP = int.Parse(cb_CT_HOADON_TENSP.SelectedValue.ToString());
            cthd.SoLuong = int.Parse(txt_CT_HOADON_SL.Value.ToString());
            cthd.DonGia = double.Parse(txt_CT_HOADON_GIA.Text);
            cthd.ThanhTien = double.Parse(txt_CT_HOADON_TT.Text);
        }
        private void btn_QLS_Add_Click(object sender, EventArgs e)
        {
            if(txt_CT_HOADON_SL.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm!", "Cảnh báo");
                return;
            }
            if(CT_HoaDon.Check_MaSP(int.Parse(cb_CT_HOADON_TENSP.SelectedValue.ToString()), txt_CT_HOADON_MAHD.Text))
            {
                MessageBox.Show("Sản phẩm đã có trong hóa đơn!", "Cảnh báo");
                return;
            }
            else
            {
                LayChiTietHoaDon();
                if (CT_HoaDon.ThemChiTietHoaDon(cthd) > 0)
                {
                    MessageBox.Show("Thêm chi tiếc hóa đơn thành công!", "Thong bao");
                    SanPham_DTO sanpham = CT_HoaDon.Lay_Gia_SL_SanPham(cb_CT_HOADON_TENSP.Text);
                    int sl = sanpham.SLTon - cthd.SoLuong;
                    txt_CT_HOADON_SL.Maximum = sl;
                    SanPham_BUS sp = new SanPham_BUS();
                    sp.CapNhapSoLuong(cthd.MaSP,sl);
                    cb_CT_HOADON_TENSP.SelectedIndex = 0;
                    txt_CT_HOADON_SL.Value = 0;
                }
                else
                {
                    MessageBox.Show("Them chi tiết hóa đơn khong thanh cong!", "Thong bao");
                }
            }
        }

        private void btn_ADD_CTHD_OUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ADD_CTHD_HOANTAT_Click(object sender, EventArgs e)
        {
            if (txt_CT_HOADON_SL.Value != 0)
            {
                if (CT_HoaDon.Check_MaSP(int.Parse(cb_CT_HOADON_TENSP.SelectedValue.ToString()), txt_CT_HOADON_MAHD.Text))
                {
                    MessageBox.Show("Sản phẩm đã có trong hóa đơn!", "Cảnh báo");
                    return;
                }
                else
                {
                    LayChiTietHoaDon();
                    if (CT_HoaDon.ThemChiTietHoaDon(cthd) > 0)
                    {
                        MessageBox.Show("Thêm chi tiếc hóa đơn thành công!", "Thong bao");
                        SanPham_DTO sanpham = CT_HoaDon.Lay_Gia_SL_SanPham(cb_CT_HOADON_TENSP.Text);
                        int sl = sanpham.SLTon - cthd.SoLuong;
                        txt_CT_HOADON_SL.Maximum = sl;
                        SanPham_BUS sp = new SanPham_BUS();
                        sp.CapNhapSoLuong(cthd.MaSP, sl);
                        cb_CT_HOADON_TENSP.SelectedIndex = 0;
                        txt_CT_HOADON_SL.Value = 0;
                        this.Close();
                        XacNhan_CTHoaDon frm = new XacNhan_CTHoaDon();
                        frm.HoaDon_Form = HoaDon_Form;
                        frm.ShowDialog();
                        frm = null;
                    }
                    else
                    {
                        MessageBox.Show("Them chi tiết hóa đơn khong thanh cong!", "Thong bao");
                    }
                }
            }
            else
            {
                this.Close();
                XacNhan_CTHoaDon frm = new XacNhan_CTHoaDon();
                frm.HoaDon_Form=HoaDon_Form;
                frm.ShowDialog();
                frm = null;
            }
        }
    }
}
