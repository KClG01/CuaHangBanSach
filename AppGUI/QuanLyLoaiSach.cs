using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using AppBUS;
using AppDTO;

namespace AppGUI
{
    public partial class FormQuanLyLoaiSach : Form
    {
        List<LoaiSP_DTO> dsLS = new List<LoaiSP_DTO>();
        LoaiSach_BUS ls = new LoaiSach_BUS();
        public FormQuanLyLoaiSach()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dsLS = ls.dsLoaiSach();
            dgv_QLLS.DataSource = dsLS;
        }
        private void txt_QLLS_MA_LOAI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_QLLS_TENLOAI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dgv_QLLS_SelectionChanged(object sender, EventArgs e)
        {
            btn_QLLS_Add.Enabled = false;
            btn_QLLS_Add.FillColor = Color.Gray;
            if(dgv_QLLS.CurrentCell != null && dgv_QLLS.CurrentRow.Index >= 0)
            {
                layThongTin();
            }
            else
            {
                ls = null;
            }

        }
        private void layThongTin()
        {
            if (ls != null)
            {
                txt_QLLS_MA_LOAI.Text = dsLS[dgv_QLLS.CurrentCell.RowIndex].MaLoai.ToString();
                txt_QLLS_TENLOAI.Text = dsLS[dgv_QLLS.CurrentCell.RowIndex].TenLoai.ToString();
                txt_QLLS_MA_LOAI.Enabled = false;
            }
            else
            {
                txt_QLLS_MA_LOAI.Clear();
                txt_QLLS_TENLOAI.Clear();
                cb_QLLS_Selected.SelectedIndex = -1;
            }
        }
        private void btn_QLLS_Re_Click(object sender, EventArgs e)
        {
            btn_QLLS_Add.Enabled = true;
            txt_QLLS_MA_LOAI.Enabled = true;
            btn_QLLS_Add.FillColor = Color.FromArgb(94, 148, 255);
            txt_QLLS_MA_LOAI.Clear();
            txt_QLLS_TENLOAI.Clear();
            txt_QLLS_NhapNoiDung.Clear();
            cb_QLLS_Selected.SelectedIndex = -1;
        }
        private void btn_QLLS_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_QLLS_TENLOAI.Text) || string.IsNullOrWhiteSpace(txt_QLLS_MA_LOAI.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                LoaiSP_DTO ls = new LoaiSP_DTO();
                ls.MaLoai = int.Parse(txt_QLLS_MA_LOAI.Text);
                ls.TenLoai = txt_QLLS_TENLOAI.Text;
                LoaiSach_BUS bus = new LoaiSach_BUS();
                if (bus.ThemLoaiSach(ls))
                {
                    MessageBox.Show("Thêm thành công");
                    txt_QLLS_MA_LOAI.Clear();
                    txt_QLLS_TENLOAI.Clear();
                    cb_QLLS_Selected.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void FormQuanLyLoaiSach_Load(object sender, EventArgs e)
        {
            LoadData();
            dgv_QLLS.Font = new Font("Arial", 13);
        }
    }
}
