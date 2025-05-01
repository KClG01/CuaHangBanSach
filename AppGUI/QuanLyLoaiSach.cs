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
        private ToolTip toolTip = new ToolTip();
        private void LoadData()
        {
            dsLS = ls.dsLoaiSach();
            dgv_QLLS.DataSource = dsLS;
        }
        private void FormQuanLyLoaiSach_Load(object sender, EventArgs e)
        {
            dgv_QLLS.Font = new Font("Arial", 13);
            LoadData();
        }
        private void txt_QLLS_MA_LOAI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void txt_QLLS_TENLOAI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void dgv_QLLS_SelectionChanged(object sender, EventArgs e)
        {
            btn_QLLS_Add.Enabled = false;
            btn_QLLS_Add.FillColor = Color.Gray;
            if (dgv_QLLS.CurrentCell != null && dgv_QLLS.CurrentRow.Index >= 0)
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
            if (dgv_QLLS.CurrentCell != null && dgv_QLLS.CurrentCell.RowIndex >= 0 && dgv_QLLS.CurrentCell.RowIndex < dsLS.Count)
            {
                txt_QLLS_MA_LOAI.Text = dsLS[dgv_QLLS.CurrentCell.RowIndex].MaLoai.ToString();
                txt_QLLS_TENLOAI.Text = dsLS[dgv_QLLS.CurrentCell.RowIndex].TenLoai.ToString();
                txt_QLLS_MA_LOAI.Enabled = false;
            }
            else
            {
                txt_QLLS_MA_LOAI.Clear();
                txt_QLLS_TENLOAI.Clear();
            }
        }
        private void refresh()
        {
            btn_QLLS_Add.Enabled = true;
            txt_QLLS_MA_LOAI.Enabled = true;
            btn_QLLS_Add.FillColor = Color.FromArgb(94, 148, 255);
            txt_QLLS_MA_LOAI.Clear();
            txt_QLLS_TENLOAI.Clear();
            txt_QLLS_NhapNoiDung.Clear();
            cb_QLLS_Selected.SelectedIndex = -1;
            lbl_index.Text = "Chọn kiểu:";
            toolTip.SetToolTip(btn_QLLS_Add, "Thêm loại sách mới.");
        }
        private void btn_QLLS_Re_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void btn_QLLS_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_QLLS_TENLOAI.Text) || string.IsNullOrWhiteSpace(txt_QLLS_MA_LOAI.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            {
                LoaiSach_BUS bus = new LoaiSach_BUS();
                if (bus.KiemTraTonTaiMaLoai(int.Parse(txt_QLLS_MA_LOAI.Text)))
                {
                    MessageBox.Show("Mã loại đã tồn tại. Vui lòng nhập mã loại khác.");
                    return;
                }
                LoaiSP_DTO ls = new LoaiSP_DTO
                {
                    MaLoai = int.Parse(txt_QLLS_MA_LOAI.Text),
                    TenLoai = txt_QLLS_TENLOAI.Text
                };

                if (bus.ThemLoaiSach(ls))
                {
                    MessageBox.Show("Thêm thành công");
                    txt_QLLS_MA_LOAI.Clear();
                    txt_QLLS_TENLOAI.Clear();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }
        private void btn_QLLS_Edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_QLLS_TENLOAI.Text) || string.IsNullOrWhiteSpace(txt_QLLS_MA_LOAI.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                LoaiSach_BUS bus = new LoaiSach_BUS();
                LoaiSP_DTO ls = new LoaiSP_DTO
                {
                    MaLoai = int.Parse(txt_QLLS_MA_LOAI.Text),
                    TenLoai = txt_QLLS_TENLOAI.Text
                };
                if (bus.CapNhatLoaiSach(ls))
                {
                    MessageBox.Show("Cập nhật thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }

        private void btn_QLLS_Del_Click(object sender, EventArgs e)
        {
            if (dgv_QLLS.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn loại sách để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa loại sách này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ls.XoaLoaiSach(int.Parse(txt_QLLS_MA_LOAI.Text)))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }
        private void cb_QLLS_Selected_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_QLLS_Selected.SelectedIndex == 0)
            {
                lbl_index.Text = "Nhập mã:";
            }
            if (cb_QLLS_Selected.SelectedIndex == 1)
            {
                lbl_index.Text = "Nhập tên:";
            }
        }
        private void btn_QLLS_Search_Click(object sender, EventArgs e)
        {
            if (cb_QLLS_Selected.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn kiểu tìm kiếm trước khi thực hiện tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string keyword = txt_QLLS_NhapNoiDung.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<LoaiSP_DTO> lS = ls.dsLoaiSach();
            List<LoaiSP_DTO> result = new List<LoaiSP_DTO>();

            if (cb_QLLS_Selected.SelectedIndex == 0)
            {
                result = lS
                    .Where(a => a.MaLoai.ToString().Contains(keyword))
                    .ToList();
            }
            else if (cb_QLLS_Selected.SelectedIndex == 1)
            {
                result = lS
                    .Where(a => a.TenLoai.ToLower().Contains(keyword.ToLower()))
                    .ToList();
            }

            if (result.Count > 0)
            {
                dgv_QLLS.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
