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
        public List<KhachHang_DTO> dsKhachHang;
        public KhachHang_BUS Khachhang = new KhachHang_BUS();
        public KhachHang_DTO kh;
        public FormQuanLyKhachHang()
        {
            InitializeComponent();
        }
        public void LayThongTin()
        {
            kh = new KhachHang_DTO();
            kh.MaKH = txt_QLKH_MAKH.Text;
            kh.TenKH = txt_QLKH_TENKH.Text;
            kh.SDT = txt_QLKH_SDT.Text;
            kh.Email = txt_QLKH_EMAIL.Text;
            kh.DiaChi = txt_QLKH_DIACHI.Text;
            kh.NgayTao = dtp_QLKH_NGAYTAO.Value;        
        }
        public bool ThemMoiKhachHang(KhachHang_DTO kh)
        {
            if (Khachhang.Add_KhachHang(kh) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachKhang();
            dgv_QLKH.AutoGenerateColumns = false;
        }
        public void LoadKhachKhang()
        {
            dtp_QLKH_NGAYTAO.Enabled = true;
            txt_QLKH_MAKH.ReadOnly = false;
            btn_QLKH_Add.Enabled = true;
            cb_QLKH_Selected.SelectedIndex = 0;
            dsKhachHang = Khachhang.Lay_DS_KhachHang();
            dgv_QLKH.DataSource = dsKhachHang;
        }
        private void btn_QLKH_Add_Click(object sender, EventArgs e)
        {
            if (Khachhang.ViPham(txt_QLKH_MAKH.Text, txt_QLKH_TENKH.Text, txt_QLKH_DIACHI.Text, txt_QLKH_SDT.Text, txt_QLKH_EMAIL.Text, dtp_QLKH_NGAYTAO.Value))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo");
                return;
            }
            if (Khachhang.KiemTraDoDai_SDT(txt_QLKH_SDT.Text))
            {
                MessageBox.Show("Số điện thoại không đủ 10 số!", "Cảnh báo");
                return;
            }
            if (Khachhang.Check_SDT(txt_QLKH_SDT.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại!", "Cảnh báo");
                return;
            }
            if(Khachhang.Check_Email(txt_QLKH_EMAIL.Text))
            {
                MessageBox.Show("Số email đã tồn tại!", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTin();
                if (ThemMoiKhachHang(kh))
                {
                    MessageBox.Show("Thêm mới thành công");
                    LoadKhachKhang();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công");
                    return;
                }
            }
        }
        public bool XoaKhachHang(KhachHang_DTO kh)
        {
            if (Khachhang.Remove_KhachHang(kh) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btn_QLKH_Del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LayThongTin();
                if (XoaKhachHang(kh))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadKhachKhang();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                    return;
                }
            }
        }
        public void LoadThongTinKH()
        {
            if (kh != null)
            {
                txt_QLKH_DIACHI.Text = kh.DiaChi;
                txt_QLKH_EMAIL.Text = kh.Email;
                txt_QLKH_MAKH.Text = kh.MaKH;
                txt_QLKH_SDT.Text = kh.SDT;
                txt_QLKH_TENKH.Text = kh.TenKH;
                dtp_QLKH_NGAYTAO.Value = kh.NgayTao;
            }
            else
            {
                kh = null;
            }
            txt_QLKH_MAKH.ReadOnly = true;
            dtp_QLKH_NGAYTAO.Enabled = false;
            btn_QLKH_Add.Enabled = false;
        }
        private void dgv_QLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_QLKH.Rows.Count > 0)
            {
                kh = dgv_QLKH.CurrentRow.DataBoundItem as KhachHang_DTO;
                LoadThongTinKH();
            }
            else
            {
                txt_QLKH_MAKH.Clear();
                txt_QLKH_TENKH.Clear();
                txt_QLKH_SDT.Clear();
                txt_QLKH_EMAIL.Clear();
                txt_QLKH_DIACHI.Clear();
                dtp_QLKH_NGAYTAO.Value = DateTime.Now;
            }
          
        }
        private void btn_QLKH_Edit_Click(object sender, EventArgs e)
        {
            if (Khachhang.ViPham(txt_QLKH_MAKH.Text, txt_QLKH_TENKH.Text, txt_QLKH_DIACHI.Text, txt_QLKH_SDT.Text, txt_QLKH_EMAIL.Text, dtp_QLKH_NGAYTAO.Value))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo");
                return;
            }
            if(Khachhang.Check_SDT_Edit(txt_QLKH_SDT.Text,txt_QLKH_MAKH.Text))
            {
                MessageBox.Show($"Số điện thoại {txt_QLKH_SDT.Text} đã tồn tại!", "Cảnh báo");
                return;
            }
            if(Khachhang.Check_Email_Edit(txt_QLKH_EMAIL.Text, txt_QLKH_MAKH.Text))
            {
                MessageBox.Show($"Email {txt_QLKH_EMAIL.Text} đã tồn tại!", "Cảnh báo");
                return;
            }
            if (Khachhang.KiemTraDoDai_SDT(txt_QLKH_SDT.Text))
            {
                MessageBox.Show("Số điện thoại không đủ 10 số!", "Cảnh báo");
                return;
            }
            else
            {
                LayThongTin();
                if (SuaKhachHang(kh))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadKhachKhang();
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                    return;
                }
            }
        }
        public bool SuaKhachHang(KhachHang_DTO kh)
        {
            int kq = Khachhang.Update_KhachHang(kh);
            return kq > 0;
        }
        private void btn_QLKH_Re_Click(object sender, EventArgs e)
        {
            txt_QLKH_MAKH.Clear();
            txt_QLKH_TENKH.Clear();
            txt_QLKH_SDT.Clear();
            txt_QLKH_EMAIL.Clear();
            txt_QLKH_DIACHI.Clear();
            dtp_QLKH_NGAYTAO.Value = DateTime.Now;
            cb_QLKH_Selected.SelectedIndex = 0;
            dtp_QLKH_NGAYTAO.Enabled = true;
            LoadKhachKhang();
        }
        private void btn_QLKH_Search_Click(object sender, EventArgs e)
        {
            int chon = cb_QLKH_Selected.SelectedIndex;
            string noiDungNhap = txt_QLKH_NhapNoiDung.Text.Trim();
            if (string.IsNullOrWhiteSpace(txt_QLKH_NhapNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!", "Cảnh báo");
                return;
            }
            if (chon == 1) // Kiểm tra số điện thoại
            {
                if (noiDungNhap.Length != 10 || !noiDungNhap.All(char.IsDigit))
                {
                    MessageBox.Show("Số điện thoại phải có đúng 10 chữ số!", "Cảnh báo");
                    return;
                }
            }
            if(chon == 4)
            {
                if (!DateTime.TryParseExact(noiDungNhap, "dd-MM-yyyy",System.Globalization.CultureInfo.InvariantCulture,System.Globalization.DateTimeStyles.None, out DateTime ngayTimKiem))
                {
                    MessageBox.Show("Vui lòng nhập ngày hợp lệ theo định dạng Ngay-Thang-Nam(01-01-1900)!", "Cảnh báo");
                    return;
                }
            }
            dsKhachHang = Khachhang.TimKiemKhachHang(chon, txt_QLKH_NhapNoiDung.Text);
            dgv_QLKH.DataSource = dsKhachHang;
        }
        private void txt_QLKH_TENKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                MessageBox.Show("Vui long khong nhap so || ky tu dac biet!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
        private void txt_QLKH_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) || txt_QLKH_SDT.Text.Length >= 10) && e.KeyChar != (char)Keys.Back)
            {

                MessageBox.Show("Khong nhap chu va du 10 so!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}