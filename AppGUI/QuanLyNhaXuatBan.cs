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
    }
}
