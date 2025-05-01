using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBUS;
using AppDTO;

namespace AppGUI
{
    public partial class FormQuanLyNhanVien : Form
    {
        List<NhanVien_DTO> dsNV = new List<NhanVien_DTO>(); 
        NhanVien_BUS nv = new NhanVien_BUS();
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dsNV = nv.dsNhanVien();
            dgv_QLNV.DataSource = dsNV;
            dgv_QLNV.ClearSelection();
        }
        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dgv_QLNV.AutoGenerateColumns = false;
            dgv_QLNV.Font = new Font("Arial", 13);
            LoadData();
        }

        private void txt_QLNV_MAKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_QLNV_TENKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_QLNV_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_QLNV_PASSWORD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_QLNV_SAF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void btn_QLNV_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void LayThongTin()
        {
            if (dgv_QLNV.SelectedRows.Count > 0)
            {
                int index = dgv_QLNV.CurrentCell.RowIndex;
                txt_QLNV_MANV.Text = dsNV[index].MaNV.ToString();
                txt_QLNV_TENNV.Text = dsNV[index].TenNV.ToString();
                txt_QLNV_SDT.Text = dsNV[index].SDT.ToString();
                txt_QLNV_Email.Text = dsNV[index].Email.ToString();
                txt_QLNV_DIACHI.Text = dsNV[index].DiaChi.ToString();
                txt_QLNV_PASSWORD.Text = dsNV[index].Password.ToString();
                txt_QLNV_SAF.Text = dsNV[index].SDT.ToString();
                if (dsNV[index].GioiTinh == true)
                {
                    rad_QLNV_Male.Checked = true;
                }
                else
                {
                    rad_QLNV_Female.Checked = true;
                }
            }
            else
            {
                txt_QLNV_MANV.Clear();
                txt_QLNV_TENNV.Clear();
                txt_QLNV_SDT.Clear();
                txt_QLNV_Email.Clear();
                txt_QLNV_DIACHI.Clear();
                txt_QLNV_PASSWORD.Clear();
                txt_QLNV_SAF.Clear();
                rad_QLNV_Male.Checked = false;
                rad_QLNV_Female.Checked = false;
            }
        }
        private void dgvw_QLNV_SelectionChanged(object sender, EventArgs e)
        {
            btn_QLNV_Add.Enabled = false;
            btn_QLNV_Add.FillColor = Color.FromArgb(0, 120, 215);
            if(dgv_QLNV.SelectedRows.Count > 0)
            {
                LayThongTin();
            }
        }

        private void refresh()
        {
            btn_QLNV_Add.Enabled = true;
            txt_QLNV_MANV.Enabled = true;
            btn_QLNV_Add.FillColor = Color.FromArgb(0, 120, 215);
            cb_QLNV_Selected.SelectedIndex = -1;
            txt_QLNV_NhapNoiDung.Clear();
            txt_QLNV_MANV.Clear();
            txt_QLNV_TENNV.Clear();
            txt_QLNV_SDT.Clear();
            txt_QLNV_Email.Clear();
            txt_QLNV_DIACHI.Clear();
            txt_QLNV_PASSWORD.Clear();
            txt_QLNV_SAF.Clear();
            if (rad_QLNV_Male.Checked == true)
            {
                rad_QLNV_Male.Checked = false;
            }
            else
            {
                rad_QLNV_Female.Checked = false;
            }
            LoadData();
        }
        private void btn_QLNV_Add_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_QLNV_MANV.Text) || string.IsNullOrEmpty(txt_QLNV_DIACHI.Text) || string.IsNullOrEmpty(txt_QLNV_Email.Text) ||
                string.IsNullOrEmpty(txt_QLNV_PASSWORD.Text)|| string.IsNullOrEmpty(txt_QLNV_SAF.Text)|| string.IsNullOrEmpty(txt_QLNV_SDT.Text)||
                string.IsNullOrEmpty(txt_QLNV_TENNV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rad_QLNV_Female.Checked == true || rad_QLNV_Male.Checked == true)
            { 
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = txt_QLNV_MANV.Text.Trim();
            if (nv.KiemTraTonTaiMaNV(maNV))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NhanVien_DTO nhanVien = new NhanVien_DTO();
            {
                nhanVien.MaNV = txt_QLNV_MANV.Text.Trim();
                nhanVien.TenNV = txt_QLNV_TENNV.Text.Trim();
                nhanVien.SDT = int.Parse(txt_QLNV_SDT.Text.Trim());
                nhanVien.Email = txt_QLNV_Email.Text.Trim();
                nhanVien.DiaChi = txt_QLNV_DIACHI.Text.Trim();
                nhanVien.Password = txt_QLNV_PASSWORD.Text.Trim();
                nhanVien.GioiTinh = Convert.ToBoolean(rad_QLNV_Male.Checked == true ? true : false);
                nhanVien.NgayTao = DateTime.Now;
                nhanVien.Luong = decimal.Parse(txt_QLNV_SAF.Text.Trim());
            }
            if (nv.ThemNhanVien(nhanVien))
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                refresh();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_QLNV_Edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_QLNV_MANV.Text) || string.IsNullOrEmpty(txt_QLNV_DIACHI.Text) || string.IsNullOrEmpty(txt_QLNV_Email.Text) ||
                string.IsNullOrEmpty(txt_QLNV_PASSWORD.Text) || string.IsNullOrEmpty(txt_QLNV_SAF.Text) || string.IsNullOrEmpty(txt_QLNV_SDT.Text) ||
                string.IsNullOrEmpty(txt_QLNV_TENNV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                NhanVien_DTO nhanVien_DTO = new NhanVien_DTO();
                nhanVien_DTO.MaNV = txt_QLNV_MANV.Text.Trim();
                nhanVien_DTO.TenNV = txt_QLNV_TENNV.Text.Trim();
                nhanVien_DTO.SDT = int.Parse(txt_QLNV_SDT.Text.Trim());
                nhanVien_DTO.Email = txt_QLNV_Email.Text.Trim();
                nhanVien_DTO.DiaChi = txt_QLNV_DIACHI.Text.Trim();
                nhanVien_DTO.Password = txt_QLNV_PASSWORD.Text.Trim();
                nhanVien_DTO.Luong = decimal.Parse(txt_QLNV_SAF.Text.Trim());
                nhanVien_DTO.GioiTinh = Convert.ToBoolean(rad_QLNV_Male.Checked == true ? true : false);
                nhanVien_DTO.NgayTao = DateTime.Now;
                if (nv.CapNhatNhanVien(nhanVien_DTO))
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    refresh();
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_QLNV_Del_Click(object sender, EventArgs e)
        {
            if (dgv_QLNV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (nv.XoaNhanVien(txt_QLNV_MANV.Text))
                    {
                        MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_QLNV_Re_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void cb_QLNV_Selected_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_QLNV_Selected.SelectedIndex == 0)
            {
                lbl_index.Text = "Mã nhân viên";
                txt_QLNV_NhapNoiDung.Enabled = true;
            }
            if(cb_QLNV_Selected.SelectedIndex == 1)
            {
                lbl_index.Text = "Tên nhân viên";
                txt_QLNV_NhapNoiDung.Enabled = true;
            }
            if (cb_QLNV_Selected.SelectedIndex == 2)
            {
                lbl_index.Text = "Số điện thoại";
                txt_QLNV_NhapNoiDung.Enabled = true;
            }
            if (cb_QLNV_Selected.SelectedIndex == 3)
            {
                lbl_index.Text = "Email";
                txt_QLNV_NhapNoiDung.Enabled = true;
            }
        }

        private void btn_QLNV_Search_Click(object sender, EventArgs e)
        {
            if(cb_QLNV_Selected.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string keyword = txt_QLNV_NhapNoiDung.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<NhanVien_DTO> result = new List<NhanVien_DTO>();
            if (cb_QLNV_Selected.SelectedIndex == 0)
            {
                result = dsNV.Where(x => x.MaNV.Contains(keyword)).ToList();
                dgv_QLNV.DataSource = result;
            }
            else if (cb_QLNV_Selected.SelectedIndex == 1)
            {
                result = dsNV.Where(x => x.TenNV.Contains(keyword)).ToList();
                dgv_QLNV.DataSource = result;
            }
            else if (cb_QLNV_Selected.SelectedIndex == 2)
            {
                result = dsNV.Where(x => x.SDT.ToString().Contains(keyword)).ToList();
                dgv_QLNV.DataSource = result;
            }
            else if (cb_QLNV_Selected.SelectedIndex == 3)
            {
                result = dsNV.Where(x => x.Email.Contains(keyword)).ToList();
                dgv_QLNV.DataSource = result;
            }
            if (result.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgv_QLNV.DataSource = result;
            }
        }

    }
}
