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
    public partial class FormQuanLyNhaXuatBan : Form
    {
        List<NhaXuatBan_DTO> dsNXB = new List<NhaXuatBan_DTO>();
        NhaXuatBan_BUS nxb = new NhaXuatBan_BUS();
        public FormQuanLyNhaXuatBan()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dsNXB = nxb.dsNhaXuatBan();
            dgv_QLNXB.DataSource = dsNXB;
            dgv_QLNXB.ClearSelection();
        }
        private void FormQuanLyNhaXuatBan_Load(object sender, EventArgs e)
        {
            dgv_QLNXB.Font = new Font("Arial", 13);
            LoadData();
            dgv_QLNXB.AutoGenerateColumns = false;
            dgv_QLNXB.ClearSelection();
        }

        private void txt_QLNXB_MANXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_QLNXB_LIENHE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_QLNXB_TENNXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_QLNXB_DIACHI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void layThongTin()
        {
            if(dgv_QLNXB.CurrentCell != null && dgv_QLNXB.CurrentRow.Index >= 0)
            {
                int rowIndex = dgv_QLNXB.CurrentCell.RowIndex;
                txt_QLNXB_MANXB.Text = dsNXB[rowIndex].MaNXB.ToString();
                txt_QLNXB_TENNXB.Text = dsNXB[rowIndex].TenNXB.ToString();
                txt_QLNXB_DIACHI.Text = dsNXB[rowIndex].DiaChi.ToString();
                txt_QLNXB_LIENHE.Text = dsNXB[rowIndex].LienHe.ToString();
                txt_QLNXB_MANXB.Enabled = false;
            }
            else
            {
                txt_QLNXB_MANXB.Clear();
                txt_QLNXB_TENNXB.Clear();
                txt_QLNXB_DIACHI.Clear();
                txt_QLNXB_LIENHE.Clear();
            }
        }
        private void dgv_QLNXB_SelectionChanged(object sender, EventArgs e)
        {
            btn_QLNXB_Add.Enabled = false;
            btn_QLNXB_Add.FillColor = Color.Gray;
            if (dgv_QLNXB.CurrentCell != null && dgv_QLNXB.CurrentRow.Index >= 0)
            {
                layThongTin();
            }
        }
        private void refresh()
        {
            LoadData();
            btn_QLNXB_Add.Enabled = true;
            txt_QLNXB_MANXB.Enabled = true;
            btn_QLNXB_Add.FillColor = Color.FromArgb(0, 120, 215);
            cb_QLNXB_Selected.SelectedIndex = -1;
            txt_QLNXB_MANXB.Clear();
            txt_QLNXB_TENNXB.Clear();
            txt_QLNXB_DIACHI.Clear();
            txt_QLNXB_LIENHE.Clear();
            txt_QLNXB_NhapNoiDung.Clear();
            lbl_ccs.Text = "Chọn loại tìm!";
            txt_QLNXB_NhapNoiDung.Enabled = false;
        }

        private void btn_QLNXB_Re_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_QLNXB_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_QLNXB_MANXB.Text) || string.IsNullOrWhiteSpace(txt_QLNXB_TENNXB.Text)
                || string.IsNullOrWhiteSpace(txt_QLNXB_DIACHI.Text) || string.IsNullOrWhiteSpace(txt_QLNXB_LIENHE.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (nxb.KiemTraTonTaiMaNXB(txt_QLNXB_MANXB.Text))
                {
                    MessageBox.Show("Mã nhà xuất bản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    NhaXuatBan_DTO nhaXuatBan_DTO = new NhaXuatBan_DTO();
                    {
                        nhaXuatBan_DTO.MaNXB = txt_QLNXB_MANXB.Text;
                        nhaXuatBan_DTO.TenNXB = txt_QLNXB_TENNXB.Text;
                        nhaXuatBan_DTO.DiaChi = txt_QLNXB_DIACHI.Text;
                        nhaXuatBan_DTO.LienHe = txt_QLNXB_LIENHE.Text;
                    }
                    if (nxb.ThemNhaXuatBan(nhaXuatBan_DTO))
                    {
                        MessageBox.Show("Thêm nhà xuất bản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhà xuất bản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_QLNXB_Edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_QLNXB_MANXB.Text) || string.IsNullOrWhiteSpace(txt_QLNXB_TENNXB.Text)
                || string.IsNullOrWhiteSpace(txt_QLNXB_DIACHI.Text) || string.IsNullOrWhiteSpace(txt_QLNXB_LIENHE.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                NhaXuatBan_DTO nhaXuatBan_DTO = new NhaXuatBan_DTO();
                {
                    nhaXuatBan_DTO.MaNXB = txt_QLNXB_MANXB.Text;
                    nhaXuatBan_DTO.TenNXB = txt_QLNXB_TENNXB.Text;
                    nhaXuatBan_DTO.DiaChi = txt_QLNXB_DIACHI.Text;
                    nhaXuatBan_DTO.LienHe = txt_QLNXB_LIENHE.Text;
                }
                if (nxb.CapNhatNhaXuatBan(nhaXuatBan_DTO))
                {
                    MessageBox.Show("Cập nhật nhà xuất bản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh();
                }
                else
                {
                    MessageBox.Show("Cập nhật nhà xuất bản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_QLNXB_Del_Click(object sender, EventArgs e)
        {
            if (dgv_QLNXB.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn loại sách để xóa");
                return;
            }
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa nhà xuất bản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                if (nxb.XoaNhaXuatBan(txt_QLNXB_MANXB.Text))
                {
                    MessageBox.Show("Xóa nhà xuất bản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh();
                }
                else
                {
                    MessageBox.Show("Xóa nhà xuất bản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_QLNXB_Search_Click(object sender, EventArgs e)
        {
            if(cb_QLNXB_Selected.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại cần tìm!");
                return;
            }
            string keyword = txt_QLNXB_NhapNoiDung.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<NhaXuatBan_DTO> result = new List<NhaXuatBan_DTO>();
            if (cb_QLNXB_Selected.SelectedIndex == 0)
            {
                result = dsNXB.Where(x => x.MaNXB.ToString().Contains(keyword)).ToList();
            }
            else if (cb_QLNXB_Selected.SelectedIndex == 1)
            {
                result = dsNXB.Where(x => x.TenNXB.ToString().Contains(keyword)).ToList();
            }
            if (result.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhà xuất bản nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_QLNXB.DataSource = null;
            }
            else
            {
                dsNXB = result;
                dgv_QLNXB.DataSource = dsNXB;

                dgv_QLNXB.Rows[0].Selected = true;
                layThongTin();
            }
        }

        private void cb_QLNXB_Selected_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_QLNXB_Selected.SelectedIndex == 0)
            {
                txt_QLNXB_NhapNoiDung.Enabled = true;
                lbl_ccs.Text = "Nhập mã:";
            }
            if (cb_QLNXB_Selected.SelectedIndex == 1)
            {
                txt_QLNXB_NhapNoiDung.Enabled = true;
                lbl_ccs.Text = "Nhập tên:";
            }
        }
    }
}
