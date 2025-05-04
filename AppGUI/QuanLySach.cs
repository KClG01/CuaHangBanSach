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
    public partial class FormQuanLySach : Form
    {
        public List<SanPham_DTO> dsSanPham;
        public SanPham_BUS SanPham = new SanPham_BUS();
        public SanPham_DTO sp;
        public FormQuanLySach()
        {
            InitializeComponent();
        }
      
        private void FormQuanLySach_Load(object sender, EventArgs e)
        {
            Load_Combobox();
            cob_QLS_Search.SelectedIndex = 0;
            LoadSanPham();
            dgv_QLS.AutoGenerateColumns = false;
        }
        public void LoadSanPham() 
        { 
            // Load Combobox DataGridView Loai San Pham
            List<LoaiSP_DTO> dsLoai = SanPham.Load_Cob_Loai();
            cln_QLS_LOAI.DataSource = dsLoai;
            cln_QLS_LOAI.DisplayMember = "TenLoai";
            cln_QLS_LOAI.ValueMember = "MaLoai";
            // Load Combobox DataGridView Loai San Pham
            List<TacGia_DTO> dsTacGia = SanPham.Load_Cob_TacGia();
            cln_QLS_TACGIA.DataSource = dsTacGia;
            cln_QLS_TACGIA.DisplayMember = "TenTacGia";
            cln_QLS_TACGIA.ValueMember = "MaTacGia";
            // Load Combobox DataGridView Nha xuat ban
            List<NhaXuatBan_DTO> dsNXB = SanPham.Load_Cob_NXB();
            cln_QLS_NXB.DataSource = dsNXB;
            cln_QLS_NXB.DisplayMember = "TenNXB";
            cln_QLS_NXB.ValueMember = "MaNXB";
            dsSanPham = SanPham.Lay_DS_SanPham();
            dgv_QLS.DataSource = dsSanPham;
            btn_QLS_Add.Enabled = true;
            txt_QLS_MASP.ReadOnly = false;
            txt_QLS_MASP.Clear();
            txt_QLS_TENSP.Clear();
            txt_QLS_GIABAN.Clear();
            txt_QLS_GIANHAP.Clear();
            cob_QLS_LOAISACH.SelectedIndex = 0;
            cob_QLS_TACGIA.SelectedIndex = 0;
            cob_QLS_NXB.SelectedIndex = 0;
            txt_QLS_SLTON.Value = 0;
        }
        public void Load_Combobox() 
        {
            // Load Combobox DataGridView Loai San Pham
            List<LoaiSP_DTO> dsLoai = SanPham.Load_Cob_Loai();
            cob_QLS_LOAISACH.DataSource = dsLoai;
            cob_QLS_LOAISACH.DisplayMember = "TenLoai";
            cob_QLS_LOAISACH.ValueMember = "MaLoai";
            // Load Combobox DataGridView Loai San Pham
            List<TacGia_DTO> dsTacGia = SanPham.Load_Cob_TacGia();
            cob_QLS_TACGIA.DataSource = dsTacGia;
            cob_QLS_TACGIA.DisplayMember = "TenTacGia";
            cob_QLS_TACGIA.ValueMember = "MaTacGia";
            // Load Combobox DataGridView Nha xuat ban
            List<NhaXuatBan_DTO> dsNXB = SanPham.Load_Cob_NXB();
            cob_QLS_NXB.DataSource = dsNXB;
            cob_QLS_NXB.DisplayMember = "TenNXB";
            cob_QLS_NXB.ValueMember = "MaNXB";
        }
        private void btn_QLS_Add_Click(object sender, EventArgs e)
        {
            if(SanPham.ViPham(txt_QLS_MASP.Text, txt_QLS_TENSP.Text, txt_QLS_GIANHAP.Text, txt_QLS_GIABAN.Text))
            {
                MessageBox.Show("Vui long nhap du thong tin!", "Canh bao!");
                return;
            }
            if (SanPham.Check_MaSP(txt_QLS_MASP.Text))
            {
                MessageBox.Show("Ma san pham da ton tai!", "Canh bao!");
                return;
            }
            if (SanPham.Check_TenSP(txt_QLS_TENSP.Text))
            {
                MessageBox.Show("Ten san pham da ton tai!", "Canh bao!");
                return;
            }
            else
            {
                LayThongTin();
                if (SanPham.Add_Book(sp) > 0)
                {
                    MessageBox.Show("Them san pham thanh cong!", "Thong bao");
                    LoadSanPham();
                    txt_QLS_MASP.Clear();
                    txt_QLS_TENSP.Clear();
                    txt_QLS_GIANHAP.Clear();
                    txt_QLS_GIABAN.Clear();
                    txt_QLS_SLTON.Value = 0;
                }
                else
                {
                    MessageBox.Show("Them san pham khong thanh cong!", "Thong bao");
                }
            }
        }
        public void LayThongTin()
        {
            sp = new SanPham_DTO();
            sp.MaSP = int.Parse(txt_QLS_MASP.Text);
            sp.TenSp = txt_QLS_TENSP.Text;
            sp.MaTacGia = cob_QLS_TACGIA.SelectedValue.ToString();
            sp.MaNXB = cob_QLS_NXB.SelectedValue.ToString();
            sp.MaLoai = cob_QLS_LOAISACH.SelectedValue.ToString();
            sp.GiaNhap = double.Parse(txt_QLS_GIANHAP.Text);
            sp.GiaBan = double.Parse(txt_QLS_GIABAN.Text);
            sp.SLTon = int.Parse(txt_QLS_SLTON.Text);
        }
        private void txt_QLS_GIANHAP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& e.KeyChar != (char)Keys.Back)  
            {
                MessageBox.Show("Khong nhap chu hoac ky tu dac biet!", "Canh bao!");
                e.Handled = true;
            }
            if (e.KeyChar == '0' && txt_QLS_GIANHAP.SelectionStart == 0)
            {
                e.Handled = true;
            }
        }

        private void txt_QLS_GIABAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Khong nhap chu hoac ky tu dac biet!", "Canh bao!");
                e.Handled = true;
            }
            if (e.KeyChar == '0' && txt_QLS_GIABAN.SelectionStart == 0)
            {
                e.Handled = true;
            }
        }

        private void dgv_QLS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_QLS.Rows.Count > 0)
            {
                sp = dgv_QLS.CurrentRow.DataBoundItem as SanPham_DTO;
                LoadThongTinSP();
                btn_QLS_Add.Enabled = false;
                txt_QLS_MASP.ReadOnly = true;
            }
            else
            {
                txt_QLS_MASP.Clear();
                txt_QLS_TENSP.Clear();
                txt_QLS_GIABAN.Clear();
                txt_QLS_GIANHAP.Clear();
                cob_QLS_LOAISACH.SelectedIndex =0;
                cob_QLS_TACGIA.SelectedIndex = 0;
                cob_QLS_NXB.SelectedIndex = 0;
            }
        }
        public void LoadThongTinSP()
        {
            if (sp != null)
            {
                txt_QLS_GIANHAP.Text = sp.GiaNhap.ToString();
                txt_QLS_GIABAN.Text = sp.GiaBan.ToString();
                txt_QLS_MASP.Text = sp.MaSP.ToString();
                txt_QLS_TENSP.Text = sp.TenSp;
                txt_QLS_SLTON.Text = sp.SLTon.ToString();
                cob_QLS_TACGIA.SelectedValue = sp.MaTacGia;
                cob_QLS_NXB.SelectedValue = sp.MaNXB;
                cob_QLS_LOAISACH.SelectedValue = sp.MaLoai;
            }
            else
            {
                sp = null;
            } 
        }

        private void btn_QLS_Re_Click(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        private void btn_QLS_Edit_Click(object sender, EventArgs e)
        {
            if (SanPham.ViPham(txt_QLS_MASP.Text, txt_QLS_TENSP.Text, txt_QLS_GIANHAP.Text, txt_QLS_GIABAN.Text))
            {
                MessageBox.Show("Vui long nhap du thong tin!", "Canh bao!");
                return;
            }
            if (SanPham.Check_TenSP_Update(txt_QLS_TENSP.Text,txt_QLS_MASP.Text))
            {
                MessageBox.Show("Ten san pham da ton tai!", "Canh bao!");
                return;
            }
            else
            {
                LayThongTin();
                if (SanPham.Edit_Book(sp) > 0)
                {
                    MessageBox.Show("Sua san pham thanh cong!", "Thong bao");
                    txt_QLS_MASP.Clear();
                    txt_QLS_TENSP.Clear();
                    txt_QLS_GIANHAP.Clear();
                    txt_QLS_GIABAN.Clear();
                    txt_QLS_SLTON.Value = 0;
                    LoadSanPham();
                }
                else
                {
                    MessageBox.Show("Sua san pham khong thanh cong!", "Thong bao");
                }
            }
        }
        public bool XoaSanPham(SanPham_DTO sp)
        {
            if (SanPham.Delete_Book(sp) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btn_QLS_Del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LayThongTin();
                if (XoaSanPham(sp))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadSanPham();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                    return;
                }
            }
        }

        private void btn_QLS_Search_Click(object sender, EventArgs e)
        {
            int chon = cob_QLS_Search.SelectedIndex;
            string noiDungNhap = txt_QLS_NhapNoiDung.Text.Trim();
            if (string.IsNullOrWhiteSpace(txt_QLS_NhapNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!", "Cảnh báo");
                return;
            }
            dsSanPham = SanPham.TimKiemSanPham(chon, txt_QLS_NhapNoiDung.Text);
            dgv_QLS.DataSource = dsSanPham;
        }
    }
}

