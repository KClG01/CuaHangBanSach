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
                
            }
            else
            {
                
            }
        }
        private void dgvw_QLNV_SelectionChanged(object sender, EventArgs e)
        {
            btn_QLNV_Add.Enabled = false;
            btn_QLNV_Add.FillColor = Color.FromArgb(0, 120, 215);
        }

        private void btn_QLNV_Add_Click(object sender, EventArgs e)
        {

        }

        private void btn_QLNV_Edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_QLNV_Del_Click(object sender, EventArgs e)
        {

        }

        private void btn_QLNV_Re_Click(object sender, EventArgs e)
        {

        }

        private void cb_QLNV_Selected_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_QLNV_Search_Click(object sender, EventArgs e)
        {

        }

    }
}
