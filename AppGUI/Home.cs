using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGUI
{
    public partial class FormHome : Form
    {
        FormLogin formLogin;
        FormQuanLySach formQLS;
        FormQuanLyLoaiSach formQLLS;
        FormQuanLyNhaXuatBan formQLNXB;
        FormQuanLyTacGia formQLTG;
        FormQuanLyKhachHang formQLKH;
        FormQuanLyHoaDon formQLHD;
        FormQuanLyNhanVien formQLNV;
        FormBanSach formSell;
        FormThongKe formtk;
        public FormHome()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        //Button khoát

        private void btn_Main_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Đăng xuất khỏi form home
        private void btn_Main_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            formLogin = new FormLogin();
            formLogin.Show();
        }
        //Sidebar Sách menu bằng timer
        bool menuExpand = false;
        private void menuTranstition_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                pn_bookContainer.Height += 135;
                if (pn_bookContainer.Height >= 135)
                {
                    menuTranstition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                pn_bookContainer.Height -= 15;
                if (pn_bookContainer.Height <= 40)
                {
                    menuTranstition.Stop();
                    menuExpand = false;
                }
            }
        }
        //Button sách 
        private void btn_Main_book_Click(object sender, EventArgs e)
        {
            menuTranstition.Start();
        }
        //Sidebar Menu bằng timer
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pn_MenuSide.Width -= 21;
                if (pn_MenuSide.Width <= 84)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = false;
                }
            }
            else
            {
                pn_MenuSide.Width += 168;
                if (pn_MenuSide.Width >= 168)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = true;
                }
            }
        }
        //Button Menu
        private void btn_Main_SideBar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
        //Xuất lên home form quản lý sách
        private void btn_Main_fnc_qlbook_Click(object sender, EventArgs e)
        {
            lbl_Main_formTitle.Text = "Quản lý sách";
            if (formQLS == null)
            {
                formQLS = new FormQuanLySach();
                formQLS.FormClosed += formQLS_FormClosed;
                formQLS.MdiParent = this;
                formQLS.Dock = DockStyle.Fill;
                formQLS.Show();
            }
            else
            {
                formQLS.Activate();
            }
        }
        private void formQLS_FormClosed(object sender, FormClosedEventArgs e)
        {
            formQLS = null;
        }
        //Xuất lên home form quản lý loại sách
        private void btn_Main_fnc_qlloaisach_Click(object sender, EventArgs e)
        {
            lbl_Main_formTitle.Text = "Quản lý loại sách";
            if (formQLLS == null)
            {
                formQLLS = new FormQuanLyLoaiSach();
                formQLLS.FormClosed += formQLLS_FormClosed;
                formQLLS.MdiParent = this;
                formQLLS.Dock = DockStyle.Fill;
                formQLLS.Show();
            }
            else
            {
                formQLLS.Activate();
            }
        }
        private void formQLLS_FormClosed(object sender, FormClosedEventArgs e)
        {
            formQLLS = null;
        }
        //Xuất lên home form quản lý nhà xuất bản
        private void btn_Main_fnc_qlnxb_Click(object sender, EventArgs e)
        {
            lbl_Main_formTitle.Text = "Quản lý nhà xuất bản";
            if (formQLNXB == null)
            {
                formQLNXB = new FormQuanLyNhaXuatBan();
                formQLNXB.FormClosed += formQLNXB_FormClosed;
                formQLNXB.MdiParent = this;
                formQLNXB.Dock = DockStyle.Fill;
                formQLNXB.Show();
            }
            else
            {
                formQLNXB.Activate();
            }
        }
        private void formQLNXB_FormClosed(object sender, FormClosedEventArgs e)
        {
            formQLNXB = null;
        }

        //Xuất lên home form quản lý tác giả
        private void btn_Main_fnc_qltacgia_Click(object sender, EventArgs e)
        {
            lbl_Main_formTitle.Text = "Quản lý tác giả";
            if (formQLTG == null)
            {
                formQLTG = new FormQuanLyTacGia();
                formQLTG.FormClosed += formQLTG_FormClosed;
                formQLTG.MdiParent = this;
                formQLTG.Dock = DockStyle.Fill;
                formQLTG.Show();
            }
            else
            {
                formQLTG.Activate();
            }
        }   
        private void formQLTG_FormClosed(object sender, FormClosedEventArgs e)
        {
            formQLTG = null;
        }
        //Xuất lên home form quản lý khách hàng
        private void btn_Main_fnc_customer_Click(object sender, EventArgs e)
        {
            lbl_Main_formTitle.Text = "Quản lý khách hàng";
            if (formQLKH == null)
            {
                formQLKH = new FormQuanLyKhachHang();
                formQLKH.FormClosed += formQLKH_FormClosed;
                formQLKH.MdiParent = this;
                formQLKH.Dock = DockStyle.Fill;
                formQLKH.Show();
            }
            else
            {
                formQLKH.Activate();
            }
        }

        private void formQLKH_FormClosed(object sender, FormClosedEventArgs e)
        {
            formQLKH = null;
        }
        //Xuất lên home form quản lý hóa đơn
        private void btn_Main_fnc_hoadon_Click(object sender, EventArgs e)
        {
            lbl_Main_formTitle.Text = "Quản lý hóa đơn";
            if(formQLHD == null)
            {
                formQLHD = new FormQuanLyHoaDon();
                formQLHD.FormClosed += formQLHD_FormClosed;
                formQLHD.MdiParent = this;
                formQLHD.Dock = DockStyle.Fill;
                formQLHD.Show();
            }
            else
            {
                formQLHD.Activate();
            }
        }

        private void formQLHD_FormClosed(object sender, FormClosedEventArgs e)
        {
            formQLHD = null;
        }

        //Xuất lên home form quản lý nhân viên
        private void btn_Main_fnc_nhanvien_Click(object sender, EventArgs e)
        {
            lbl_Main_formTitle.Text = "Quản lý nhân viên";
            if(formQLNV == null)
            {
                formQLNV = new FormQuanLyNhanVien();
                formQLNV.FormClosed += formQLNV_FormClosed;
                formQLNV.MdiParent = this;
                formQLNV.Dock = DockStyle.Fill;
                formQLNV.Show();
            }
            else
            {
                formQLNV.Activate();
            }
        }

        private void formQLNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            formQLNV = null;
        }

        //Xuất lên home form thống kê
        private void btn_Main_fnc_thongke_Click(object sender, EventArgs e)
        {
            lbl_Main_formTitle.Text = "Thống kê";
            if (formtk == null)
            {
                formtk = new FormThongKe();
                formtk.FormClosed += formtk_FormClosed;
                formtk.MdiParent = this;
                formtk.Dock = DockStyle.Fill;
                formtk.Show();
            }
            else
            {
                formtk.Activate();
            }
        }

        private void formtk_FormClosed(object sender, FormClosedEventArgs e)
        {
            formtk = null;
        }

        //Xuất lên home form bán sách
        //private void btn_Main_fnc_bansach_Click(object sender, EventArgs e)
        //{
        //    lbl_Main_formTitle.Text = "Thống kê";
        //    if(formSell == null)
        //    {
        //        formSell = new FormBanSach();
        //        formSell.FormClosed += formSell_FormClosed;
        //        formSell.MdiParent = this;
        //        formSell.Dock = DockStyle.Fill;
        //        formSell.Show();
        //    }
        //    else
        //    {
        //        formSell.Activate();
        //    }
        //}

        //private void formSell_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    formSell = null;
        //}
    }
}
