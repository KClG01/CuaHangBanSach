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
    public partial class FormQuanLyTacGia : Form
    {
        public FormQuanLyTacGia()
        {
            InitializeComponent();
            dtp_QLTG_NGSINH.Value = DateTime.Now.AddYears(-30);
        }
    }
}
