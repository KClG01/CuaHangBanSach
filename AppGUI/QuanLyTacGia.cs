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
    public partial class FormQuanLyTacGia : Form
    {
        List<TacGia_DTO> dsTG = new List<TacGia_DTO>();
        TacGia_BUS tgia = new TacGia_BUS();
        public FormQuanLyTacGia()
        {
            InitializeComponent();
            
        }
        private void LoadData()
        {
            dtp_QLTG_NGSINH.Value = DateTime.Now.AddYears(-30);
            dsTG = tgia.dsTacGia();
            dgv_QLTG.DataSource = dsTG;
            dgv_QLTG.ClearSelection();
        }
        private void FormQuanLyTacGia_Load(object sender, EventArgs e)
        {
            dgv_QLTG.Font = new Font("Arial", 13);
            dgv_QLTG.AutoGenerateColumns = false;
            dgv_QLTG.ClearSelection();
            LoadData();
        }
        private void txt_QLTG_MATG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void txt_QLTG_TENTG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_QLTG_LIENHE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_QLTG_BUTDANH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_QLTG_DIACHI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void LayThongTin()
        {
            if (dgv_QLTG.SelectedRows.Count > 0)
            {
                int index = dgv_QLTG.CurrentCell.RowIndex;
                txt_QLTG_MATG.Text = dsTG[index].MaTacGia.ToString();
                txt_QLTG_TENTG.Text = dsTG[index].TenTacGia.ToString();
                dtp_QLTG_NGSINH.Value = dsTG[index].NgaySinh;
                txt_QLTG_LIENHE.Text = dsTG[index].LienHe.ToString();
                txt_QLTG_BUTDANH.Text = dsTG[index].ButDanh.ToString();
                txt_QLTG_DIACHI.Text = dsTG[index].DiaChi.ToString();
                txt_QLTG_MATG.Enabled = false;
            }
            else
            {
                txt_QLTG_MATG.Clear();
                txt_QLTG_TENTG.Clear();
                dtp_QLTG_NGSINH.Value = DateTime.Now.AddYears(-30);
                txt_QLTG_LIENHE.Clear();
                txt_QLTG_BUTDANH.Clear();
                txt_QLTG_DIACHI.Clear();
            }
        }
        private void btn_QLTG_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_QLTG_MATG.Text) || string.IsNullOrEmpty(txt_QLTG_TENTG.Text)
                || string.IsNullOrEmpty(txt_QLTG_LIENHE.Text) || string.IsNullOrEmpty(txt_QLTG_BUTDANH.Text)
                || string.IsNullOrEmpty(txt_QLTG_DIACHI.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maTG = txt_QLTG_MATG.Text.Trim();
            if (tgia.KiemTraTonTaiMaTG(maTG))
            {
                MessageBox.Show("Mã tác giả đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TacGia_DTO tgia_DTO = new TacGia_DTO
            {
                MaTacGia = txt_QLTG_MATG.Text,
                ButDanh = txt_QLTG_BUTDANH.Text,
                TenTacGia = txt_QLTG_TENTG.Text,
                LienHe = txt_QLTG_LIENHE.Text,
                DiaChi = txt_QLTG_DIACHI.Text,
                NgaySinh = dtp_QLTG_NGSINH.Value
            };

            if (tgia.ThemTacGia(tgia_DTO))
            {
                MessageBox.Show("Thêm tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refresh();
            }
            else
            {
                MessageBox.Show("Thêm tác giả thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void refresh()
        {
            LoadData();
            btn_QLTG_Add.Enabled = true;
            txt_QLTG_MATG.Enabled = true;
            btn_QLTG_Add.FillColor = Color.FromArgb(0, 120, 215);

            txt_QLTG_MATG.Clear();
            txt_QLTG_TENTG.Clear();
            dgv_QLTG.ClearSelection();
            dtp_QLTG_NGSINH.Value = DateTime.Now.AddYears(-30);
            txt_QLTG_LIENHE.Clear();
            txt_QLTG_BUTDANH.Clear();
            txt_QLTG_DIACHI.Clear();
            lbl_index.Text = "Chọn loại tìm!";
            txt_QLTG_NhapNoiDung.Enabled = false;

        }
        private void btn_QLTG_Edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_QLTG_MATG.Text) || string.IsNullOrEmpty(txt_QLTG_TENTG.Text)
                || string.IsNullOrEmpty(txt_QLTG_LIENHE.Text) || string.IsNullOrEmpty(txt_QLTG_BUTDANH.Text)
                || string.IsNullOrEmpty(txt_QLTG_DIACHI.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                TacGia_DTO tgia_DTO = new TacGia_DTO();
                tgia_DTO.MaTacGia = txt_QLTG_MATG.Text;
                tgia_DTO.ButDanh = txt_QLTG_BUTDANH.Text;
                tgia_DTO.TenTacGia = txt_QLTG_TENTG.Text;
                tgia_DTO.LienHe = txt_QLTG_LIENHE.Text;
                tgia_DTO.DiaChi = txt_QLTG_DIACHI.Text;
                tgia_DTO.NgaySinh = dtp_QLTG_NGSINH.Value;
                if (tgia.CapNhatTacGia(tgia_DTO))
                {
                    MessageBox.Show("Cập nhật tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật tác giả thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_QLTG_Del_Click(object sender, EventArgs e)
        {
            if (dgv_QLTG.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (tgia.XoaTacGia(txt_QLTG_MATG.Text))
                    {
                        MessageBox.Show("Xóa tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();

                    }
                    else
                    {
                        MessageBox.Show("Xóa tác giả thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tác giả để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_QLTG_Re_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void dgv_QLTG_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_QLTG.CurrentCell != null && dgv_QLTG.SelectedRows.Count > 0)
            {
                LayThongTin();
                btn_QLTG_Add.Enabled = false;
            }
            else
            {
                btn_QLTG_Add.Enabled = true;
            }
        }
        private void btn_QLTG_Search_Click(object sender, EventArgs e)
        {
            if(cb_QLTG_Selected.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string keyword = txt_QLTG_NhapNoiDung.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<TacGia_DTO> result = new List<TacGia_DTO>();
            if(cb_QLTG_Selected.SelectedIndex == 0)
            {
                result = dsTG.Where(tg => tg.MaTacGia.Contains(keyword)).ToList();
                dgv_QLTG.DataSource = result;
            }
            else if (cb_QLTG_Selected.SelectedIndex == 1)
            {
                result = dsTG.Where(tg => tg.TenTacGia.Contains(keyword)).ToList();
                dgv_QLTG.DataSource = result;
            }
            else if (cb_QLTG_Selected.SelectedIndex == 2)
            {
                result = dsTG.Where(tg => tg.ButDanh.Contains(keyword)).ToList();
                dgv_QLTG.DataSource = result;
            }
            if (result.Count == 0)
            {
                MessageBox.Show("Không tìm thấy tác giả nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgv_QLTG.DataSource = result;
                dgv_QLTG.ClearSelection();
            }
        }

        private void cb_QLTG_Selected_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_QLTG_Selected.SelectedIndex == 0)
            {
                txt_QLTG_NhapNoiDung.Enabled = true;
                lbl_index.Text = "Nhập mã:";
            }
            if (cb_QLTG_Selected.SelectedIndex == 1)
            {
                txt_QLTG_NhapNoiDung.Enabled = true;
                lbl_index.Text = "Nhập tên:";
            }
            if (cb_QLTG_Selected.SelectedIndex == 2)
            {
                txt_QLTG_NhapNoiDung.Enabled = true;
                lbl_index.Text = "Nhập bút danh:";
            }
        }
    }
}
