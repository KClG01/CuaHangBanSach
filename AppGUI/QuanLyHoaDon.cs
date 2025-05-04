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
    public partial class FormQuanLyHoaDon : Form
    {

        frm_ThemChiTietHoaDon form_Add_CT_HoaDon;
        frm_Edit_HoaDon form_Edit_CT_HoaDon;
        public List<HoaDon_DTO> dsHoaDon;
        public HoaDon_BUS HoaDon = new HoaDon_BUS();
        public HoaDon_DTO hd;
        public FormQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void btn_QLHD_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_QLHD_MAHD.Text) || string.IsNullOrWhiteSpace(txt_QLHD_MAKH.Text) || string.IsNullOrWhiteSpace(txt_QLHD_MANV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (HoaDon.KiemTraMaHD(txt_QLHD_MAHD.Text))
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại");
                return;
            }
            else if (HoaDon.KiemTraMaNV(txt_QLHD_MANV.Text) == false)
            {
                MessageBox.Show("Mã nhân viên không tồn tại");
                return;
            }
            else if (HoaDon.KiemTraMaKH(txt_QLHD_MAKH.Text) == false)
            {
                MessageBox.Show("Mã khách hàng không tồn tại");
                return;
            }
            else
            {
                LayThongTinHoaDon();
                if (HoaDon.ThemHoaDon(hd))
                {
                    LoadHoaDon();
                    if (form_Add_CT_HoaDon == null)
                    {           
                        form_Add_CT_HoaDon = new frm_ThemChiTietHoaDon();
                        form_Add_CT_HoaDon.HoaDon_Form = hd;
                        form_Add_CT_HoaDon.Show();
                        form_Add_CT_HoaDon = null;
                    }
                    else
                    {
                        if (form_Add_CT_HoaDon.IsDisposed)
                        {
                            form_Add_CT_HoaDon = new frm_ThemChiTietHoaDon();
                            form_Add_CT_HoaDon.Show();
                            form_Add_CT_HoaDon = null;
                        }
                        else
                        {
                            form_Add_CT_HoaDon.Activate();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn không thành công");
                    return;
                }

            }

        }
        private void FormQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            dgv_QLHD.AutoGenerateColumns = false;
        }
        public void LoadHoaDon()
        {
            dsHoaDon = HoaDon.LoadHoaDon();
            dgv_QLHD.DataSource = dsHoaDon;
            btn_QLHD_Add.Enabled = true;
            txt_QLHD_MAKH.ReadOnly = false;
            txt_QLHD_MANV.ReadOnly = false;
            txt_QLHD_MAHD.ReadOnly = false;
            dtp_QLHD_NGAYTAO.Enabled = true;
            txt_QLHD_MANV.Clear();
            txt_QLHD_MAKH.Clear();
            txt_QLHD_MAHD.Clear();
            dtp_QLHD_NGAYTAO.Value= DateTime.Now;
        }

        private void dgv_QLHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_QLHD.Rows.Count > 0)
            {
                hd = dgv_QLHD.CurrentRow.DataBoundItem as HoaDon_DTO;
                LoadThongTinHoaDon();
                btn_QLHD_Add.Enabled = false;
                txt_QLHD_MAKH.ReadOnly = true;
                txt_QLHD_MANV.ReadOnly = true;
                txt_QLHD_MAHD.ReadOnly = true;
                dtp_QLHD_NGAYTAO.Enabled = false;
            }
            else
            {
                txt_QLHD_MANV.Clear();
                txt_QLHD_MAKH.Clear();
                txt_QLHD_MAHD.Clear();
            }
        }
        public void LoadThongTinHoaDon()
        {
            if (hd != null)
            {
                txt_QLHD_MAHD.Text = hd.MaHD.ToString();
                txt_QLHD_MAKH.Text = hd.MaKH.ToString();
                txt_QLHD_MANV.Text = hd.MaNV.ToString();
                dtp_QLHD_NGAYTAO.Value = hd.NgayBan;
            }
            else
            {
                hd = null;
            }
        }

        private void btn_QLHD_Re_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void btn_QLHD_Del_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_QLHD_MAHD.Text) || string.IsNullOrWhiteSpace(txt_QLHD_MAKH.Text) || string.IsNullOrWhiteSpace(txt_QLHD_MANV.Text))
            {
                MessageBox.Show("Chọn hóa đơn cần xóa!");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoadThongTinHoaDon();
                if (XoaSanPham(hd))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadHoaDon();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                    return;
                }
            }
        }
        public bool XoaSanPham(HoaDon_DTO hd)
        {
            if (HoaDon.XoaHoaDon(hd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btn_QLHD_Edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_QLHD_MAHD.Text) || string.IsNullOrWhiteSpace(txt_QLHD_MAKH.Text) || string.IsNullOrWhiteSpace(txt_QLHD_MANV.Text))
            {
                MessageBox.Show("Chọn hóa đơn cập nhật!");
                return;
            }
            else
            {
                LayThongTinHoaDon();
                if (form_Edit_CT_HoaDon == null)
                {
                    form_Edit_CT_HoaDon = new frm_Edit_HoaDon();
                    form_Edit_CT_HoaDon.HoaDon = hd;
                    form_Edit_CT_HoaDon.Show();
                    form_Edit_CT_HoaDon = null;
                }
                else
                {
                    if (form_Edit_CT_HoaDon.IsDisposed)
                    {
                        form_Edit_CT_HoaDon = new frm_Edit_HoaDon();
                        form_Edit_CT_HoaDon.Show();
                        form_Edit_CT_HoaDon = null;
                    }
                    else
                    {
                        form_Edit_CT_HoaDon.Activate();
                    }
                }
            }
        }
        private void btn_QLHD_Search_Click(object sender, EventArgs e)
        {

        }
        public void LayThongTinHoaDon()
        {
            hd = new HoaDon_DTO();
            hd.MaHD = txt_QLHD_MAHD.Text;
            hd.MaNV = txt_QLHD_MANV.Text;
            hd.MaKH = txt_QLHD_MAKH.Text;
            hd.NgayBan = dtp_QLHD_NGAYTAO.Value;
        }

    }
}
