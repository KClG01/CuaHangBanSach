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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btn_DN_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_DN_Login_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome();
            home.Show();
            this.Hide();
        }

        private void btn_DN_reg_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
            this.Hide();
        }

        private void btn_ShowP_Click(object sender, EventArgs e)
        {
            if(txt_DN_password.UseSystemPasswordChar == true)
            {
                txt_DN_password.UseSystemPasswordChar = false;
                btn_ShowP.Image = Properties.Resources.Eye;
            }
            else
            {
                txt_DN_password.UseSystemPasswordChar = true;
                btn_ShowP.Image = Properties.Resources.Closed_Eye;
            }
        }
    }
}
