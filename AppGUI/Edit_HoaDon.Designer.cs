namespace AppGUI
{
    partial class frm_Edit_HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_QLLS_dgv = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_CT_HOADON = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cln_QL_CTHD_SANPHAM = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cln_QLHD_MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLHD_NGAYBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLHD_TIENNHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLHD_TIENTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_function = new System.Windows.Forms.Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txt_CTHD_KM = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cob_CTHD_TENSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_CT_HOADON_TT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CT_HOADON_GIA = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CT_HOADON_SL = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_QLHD_Re = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_QLHD_Del = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CN_CTHD_OUT = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLHD_Add = new Guna.UI2.WinForms.Guna2Button();
            this.dtp_QLHD_NGAYLAP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_QLHD_MAKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLHD_MANV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLHD_MAHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.pn_QLLS_dgv.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CT_HOADON)).BeginInit();
            this.panel_function.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CTHD_KM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CT_HOADON_SL)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_QLLS_dgv
            // 
            this.pn_QLLS_dgv.Controls.Add(this.panel1);
            this.pn_QLLS_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_QLLS_dgv.Location = new System.Drawing.Point(0, 0);
            this.pn_QLLS_dgv.Name = "pn_QLLS_dgv";
            this.pn_QLLS_dgv.Size = new System.Drawing.Size(1730, 672);
            this.pn_QLLS_dgv.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_CT_HOADON);
            this.panel1.Controls.Add(this.panel_function);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1730, 672);
            this.panel1.TabIndex = 11;
            // 
            // dgv_CT_HOADON
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgv_CT_HOADON.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CT_HOADON.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CT_HOADON.ColumnHeadersHeight = 34;
            this.dgv_CT_HOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_CT_HOADON.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_QL_CTHD_SANPHAM,
            this.cln_QLHD_MAKH,
            this.cln_QLHD_NGAYBAN,
            this.cln_QLHD_TIENNHAN,
            this.cln_QLHD_TIENTRA});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CT_HOADON.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_CT_HOADON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CT_HOADON.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_CT_HOADON.Location = new System.Drawing.Point(0, 433);
            this.dgv_CT_HOADON.MultiSelect = false;
            this.dgv_CT_HOADON.Name = "dgv_CT_HOADON";
            this.dgv_CT_HOADON.ReadOnly = true;
            this.dgv_CT_HOADON.RowHeadersVisible = false;
            this.dgv_CT_HOADON.RowHeadersWidth = 51;
            this.dgv_CT_HOADON.RowTemplate.Height = 24;
            this.dgv_CT_HOADON.Size = new System.Drawing.Size(1730, 239);
            this.dgv_CT_HOADON.TabIndex = 58;
            this.dgv_CT_HOADON.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.dgv_CT_HOADON.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgv_CT_HOADON.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_CT_HOADON.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_CT_HOADON.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_CT_HOADON.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_CT_HOADON.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_CT_HOADON.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_CT_HOADON.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.dgv_CT_HOADON.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_CT_HOADON.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_CT_HOADON.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_CT_HOADON.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_CT_HOADON.ThemeStyle.HeaderStyle.Height = 34;
            this.dgv_CT_HOADON.ThemeStyle.ReadOnly = true;
            this.dgv_CT_HOADON.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.dgv_CT_HOADON.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_CT_HOADON.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_CT_HOADON.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_CT_HOADON.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_CT_HOADON.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.dgv_CT_HOADON.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_CT_HOADON.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CT_HOADON_CellClick);
            // 
            // cln_QL_CTHD_SANPHAM
            // 
            this.cln_QL_CTHD_SANPHAM.DataPropertyName = "MASP";
            this.cln_QL_CTHD_SANPHAM.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cln_QL_CTHD_SANPHAM.HeaderText = "Tên Sản Phẩm";
            this.cln_QL_CTHD_SANPHAM.MinimumWidth = 6;
            this.cln_QL_CTHD_SANPHAM.Name = "cln_QL_CTHD_SANPHAM";
            this.cln_QL_CTHD_SANPHAM.ReadOnly = true;
            this.cln_QL_CTHD_SANPHAM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cln_QL_CTHD_SANPHAM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cln_QLHD_MAKH
            // 
            this.cln_QLHD_MAKH.DataPropertyName = "SOLUONG";
            this.cln_QLHD_MAKH.HeaderText = "Số lượng";
            this.cln_QLHD_MAKH.MinimumWidth = 6;
            this.cln_QLHD_MAKH.Name = "cln_QLHD_MAKH";
            this.cln_QLHD_MAKH.ReadOnly = true;
            // 
            // cln_QLHD_NGAYBAN
            // 
            this.cln_QLHD_NGAYBAN.DataPropertyName = "DONGIA";
            this.cln_QLHD_NGAYBAN.HeaderText = "Giá";
            this.cln_QLHD_NGAYBAN.MinimumWidth = 6;
            this.cln_QLHD_NGAYBAN.Name = "cln_QLHD_NGAYBAN";
            this.cln_QLHD_NGAYBAN.ReadOnly = true;
            // 
            // cln_QLHD_TIENNHAN
            // 
            this.cln_QLHD_TIENNHAN.DataPropertyName = "KHUYENMAI";
            this.cln_QLHD_TIENNHAN.HeaderText = "Khuyến mãi";
            this.cln_QLHD_TIENNHAN.MinimumWidth = 6;
            this.cln_QLHD_TIENNHAN.Name = "cln_QLHD_TIENNHAN";
            this.cln_QLHD_TIENNHAN.ReadOnly = true;
            // 
            // cln_QLHD_TIENTRA
            // 
            this.cln_QLHD_TIENTRA.DataPropertyName = "THANHTIEN";
            this.cln_QLHD_TIENTRA.HeaderText = "Thành tiền";
            this.cln_QLHD_TIENTRA.MinimumWidth = 6;
            this.cln_QLHD_TIENTRA.Name = "cln_QLHD_TIENTRA";
            this.cln_QLHD_TIENTRA.ReadOnly = true;
            // 
            // panel_function
            // 
            this.panel_function.BackColor = System.Drawing.Color.White;
            this.panel_function.Controls.Add(this.guna2GroupBox1);
            this.panel_function.Controls.Add(this.label10);
            this.panel_function.Controls.Add(this.btn_QLHD_Re);
            this.panel_function.Controls.Add(this.label4);
            this.panel_function.Controls.Add(this.label3);
            this.panel_function.Controls.Add(this.btn_QLHD_Del);
            this.panel_function.Controls.Add(this.label2);
            this.panel_function.Controls.Add(this.label1);
            this.panel_function.Controls.Add(this.btn_CN_CTHD_OUT);
            this.panel_function.Controls.Add(this.btn_QLHD_Add);
            this.panel_function.Controls.Add(this.dtp_QLHD_NGAYLAP);
            this.panel_function.Controls.Add(this.txt_QLHD_MAKH);
            this.panel_function.Controls.Add(this.txt_QLHD_MANV);
            this.panel_function.Controls.Add(this.txt_QLHD_MAHD);
            this.panel_function.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_function.Location = new System.Drawing.Point(0, 0);
            this.panel_function.Name = "panel_function";
            this.panel_function.Size = new System.Drawing.Size(1730, 433);
            this.panel_function.TabIndex = 10;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.txt_CTHD_KM);
            this.guna2GroupBox1.Controls.Add(this.cob_CTHD_TENSP);
            this.guna2GroupBox1.Controls.Add(this.txt_CT_HOADON_TT);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.txt_CT_HOADON_GIA);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.txt_CT_HOADON_SL);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(14, 155);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1704, 157);
            this.guna2GroupBox1.TabIndex = 50;
            this.guna2GroupBox1.Text = "Thông tin sản phấm";
            // 
            // txt_CTHD_KM
            // 
            this.txt_CTHD_KM.BackColor = System.Drawing.Color.Transparent;
            this.txt_CTHD_KM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CTHD_KM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CTHD_KM.Location = new System.Drawing.Point(1448, 60);
            this.txt_CTHD_KM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CTHD_KM.Name = "txt_CTHD_KM";
            this.txt_CTHD_KM.Size = new System.Drawing.Size(220, 40);
            this.txt_CTHD_KM.TabIndex = 61;
            this.txt_CTHD_KM.ValueChanged += new System.EventHandler(this.txt_CTHD_KM_ValueChanged);
            // 
            // cob_CTHD_TENSP
            // 
            this.cob_CTHD_TENSP.BackColor = System.Drawing.Color.Transparent;
            this.cob_CTHD_TENSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cob_CTHD_TENSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_CTHD_TENSP.Enabled = false;
            this.cob_CTHD_TENSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cob_CTHD_TENSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cob_CTHD_TENSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cob_CTHD_TENSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cob_CTHD_TENSP.ItemHeight = 30;
            this.cob_CTHD_TENSP.Items.AddRange(new object[] {
            "Mã Hóa Đơn",
            "Mã Nhân Viên",
            "Mã Khách Hàng"});
            this.cob_CTHD_TENSP.Location = new System.Drawing.Point(183, 60);
            this.cob_CTHD_TENSP.Name = "cob_CTHD_TENSP";
            this.cob_CTHD_TENSP.Size = new System.Drawing.Size(455, 36);
            this.cob_CTHD_TENSP.TabIndex = 60;
            this.cob_CTHD_TENSP.SelectedIndexChanged += new System.EventHandler(this.cob_CTHD_TENSP_SelectedIndexChanged);
            // 
            // txt_CT_HOADON_TT
            // 
            this.txt_CT_HOADON_TT.Animated = true;
            this.txt_CT_HOADON_TT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(179)))), ((int)(((byte)(204)))));
            this.txt_CT_HOADON_TT.BorderRadius = 2;
            this.txt_CT_HOADON_TT.BorderThickness = 0;
            this.txt_CT_HOADON_TT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CT_HOADON_TT.DefaultText = "";
            this.txt_CT_HOADON_TT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CT_HOADON_TT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CT_HOADON_TT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CT_HOADON_TT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CT_HOADON_TT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_CT_HOADON_TT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CT_HOADON_TT.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_CT_HOADON_TT.ForeColor = System.Drawing.Color.Black;
            this.txt_CT_HOADON_TT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CT_HOADON_TT.Location = new System.Drawing.Point(183, 110);
            this.txt_CT_HOADON_TT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_CT_HOADON_TT.Name = "txt_CT_HOADON_TT";
            this.txt_CT_HOADON_TT.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_CT_HOADON_TT.PlaceholderText = "Thành Tiền ";
            this.txt_CT_HOADON_TT.ReadOnly = true;
            this.txt_CT_HOADON_TT.SelectedText = "";
            this.txt_CT_HOADON_TT.Size = new System.Drawing.Size(220, 38);
            this.txt_CT_HOADON_TT.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(58, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 28);
            this.label7.TabIndex = 58;
            this.label7.Text = "Thành tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1313, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 28);
            this.label6.TabIndex = 56;
            this.label6.Text = "Khuyến mãi:";
            // 
            // txt_CT_HOADON_GIA
            // 
            this.txt_CT_HOADON_GIA.Animated = true;
            this.txt_CT_HOADON_GIA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(179)))), ((int)(((byte)(204)))));
            this.txt_CT_HOADON_GIA.BorderRadius = 2;
            this.txt_CT_HOADON_GIA.BorderThickness = 0;
            this.txt_CT_HOADON_GIA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CT_HOADON_GIA.DefaultText = "";
            this.txt_CT_HOADON_GIA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CT_HOADON_GIA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CT_HOADON_GIA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CT_HOADON_GIA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CT_HOADON_GIA.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_CT_HOADON_GIA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CT_HOADON_GIA.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_CT_HOADON_GIA.ForeColor = System.Drawing.Color.Black;
            this.txt_CT_HOADON_GIA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CT_HOADON_GIA.Location = new System.Drawing.Point(1067, 60);
            this.txt_CT_HOADON_GIA.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_CT_HOADON_GIA.Name = "txt_CT_HOADON_GIA";
            this.txt_CT_HOADON_GIA.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_CT_HOADON_GIA.PlaceholderText = "Giá";
            this.txt_CT_HOADON_GIA.ReadOnly = true;
            this.txt_CT_HOADON_GIA.SelectedText = "";
            this.txt_CT_HOADON_GIA.Size = new System.Drawing.Size(220, 40);
            this.txt_CT_HOADON_GIA.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1013, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 28);
            this.label5.TabIndex = 54;
            this.label5.Text = "Giá:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(660, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 28);
            this.label8.TabIndex = 53;
            this.label8.Text = "Số lượng:";
            // 
            // txt_CT_HOADON_SL
            // 
            this.txt_CT_HOADON_SL.BackColor = System.Drawing.Color.Transparent;
            this.txt_CT_HOADON_SL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CT_HOADON_SL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CT_HOADON_SL.Location = new System.Drawing.Point(768, 60);
            this.txt_CT_HOADON_SL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CT_HOADON_SL.Name = "txt_CT_HOADON_SL";
            this.txt_CT_HOADON_SL.Size = new System.Drawing.Size(220, 40);
            this.txt_CT_HOADON_SL.TabIndex = 52;
            this.txt_CT_HOADON_SL.ValueChanged += new System.EventHandler(this.txt_CT_HOADON_SL_ValueChanged);
            this.txt_CT_HOADON_SL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CT_HOADON_SL_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(10, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 28);
            this.label9.TabIndex = 50;
            this.label9.Text = "Tên Sản Phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(396, 59);
            this.label10.TabIndex = 41;
            this.label10.Text = "Cập nhật hóa đơn";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_QLHD_Re
            // 
            this.btn_QLHD_Re.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Re.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Re.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLHD_Re.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLHD_Re.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLHD_Re.ForeColor = System.Drawing.Color.White;
            this.btn_QLHD_Re.Location = new System.Drawing.Point(1567, 318);
            this.btn_QLHD_Re.Name = "btn_QLHD_Re";
            this.btn_QLHD_Re.Size = new System.Drawing.Size(150, 60);
            this.btn_QLHD_Re.TabIndex = 35;
            this.btn_QLHD_Re.Text = "Reset";
            this.btn_QLHD_Re.Click += new System.EventHandler(this.btn_QLHD_Re_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1275, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ngày lập hóa đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(829, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã khách hàng:";
            // 
            // btn_QLHD_Del
            // 
            this.btn_QLHD_Del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLHD_Del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLHD_Del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLHD_Del.ForeColor = System.Drawing.Color.White;
            this.btn_QLHD_Del.Location = new System.Drawing.Point(1167, 318);
            this.btn_QLHD_Del.Name = "btn_QLHD_Del";
            this.btn_QLHD_Del.Size = new System.Drawing.Size(150, 60);
            this.btn_QLHD_Del.TabIndex = 3;
            this.btn_QLHD_Del.Text = "Xóa";
            this.btn_QLHD_Del.Click += new System.EventHandler(this.btn_QLHD_Del_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(408, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // btn_CN_CTHD_OUT
            // 
            this.btn_CN_CTHD_OUT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CN_CTHD_OUT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CN_CTHD_OUT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CN_CTHD_OUT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CN_CTHD_OUT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CN_CTHD_OUT.ForeColor = System.Drawing.Color.White;
            this.btn_CN_CTHD_OUT.Location = new System.Drawing.Point(1369, 318);
            this.btn_CN_CTHD_OUT.Name = "btn_CN_CTHD_OUT";
            this.btn_CN_CTHD_OUT.Size = new System.Drawing.Size(150, 60);
            this.btn_CN_CTHD_OUT.TabIndex = 2;
            this.btn_CN_CTHD_OUT.Text = "Thoát";
            this.btn_CN_CTHD_OUT.Click += new System.EventHandler(this.btn_CN_CTHD_OUT_Click);
            // 
            // btn_QLHD_Add
            // 
            this.btn_QLHD_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLHD_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLHD_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLHD_Add.ForeColor = System.Drawing.Color.White;
            this.btn_QLHD_Add.Location = new System.Drawing.Point(966, 318);
            this.btn_QLHD_Add.Name = "btn_QLHD_Add";
            this.btn_QLHD_Add.Size = new System.Drawing.Size(150, 60);
            this.btn_QLHD_Add.TabIndex = 1;
            this.btn_QLHD_Add.Text = "Cập nhật";
            this.btn_QLHD_Add.Click += new System.EventHandler(this.btn_QLHD_Add_Click);
            // 
            // dtp_QLHD_NGAYLAP
            // 
            this.dtp_QLHD_NGAYLAP.Animated = true;
            this.dtp_QLHD_NGAYLAP.Checked = true;
            this.dtp_QLHD_NGAYLAP.Enabled = false;
            this.dtp_QLHD_NGAYLAP.FillColor = System.Drawing.Color.White;
            this.dtp_QLHD_NGAYLAP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_QLHD_NGAYLAP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_QLHD_NGAYLAP.Location = new System.Drawing.Point(1497, 105);
            this.dtp_QLHD_NGAYLAP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_QLHD_NGAYLAP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_QLHD_NGAYLAP.Name = "dtp_QLHD_NGAYLAP";
            this.dtp_QLHD_NGAYLAP.Size = new System.Drawing.Size(220, 40);
            this.dtp_QLHD_NGAYLAP.TabIndex = 11;
            this.dtp_QLHD_NGAYLAP.Value = new System.DateTime(2025, 5, 3, 0, 0, 0, 0);
            // 
            // txt_QLHD_MAKH
            // 
            this.txt_QLHD_MAKH.Animated = true;
            this.txt_QLHD_MAKH.BorderRadius = 2;
            this.txt_QLHD_MAKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLHD_MAKH.DefaultText = "";
            this.txt_QLHD_MAKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLHD_MAKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLHD_MAKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLHD_MAKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLHD_MAKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLHD_MAKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLHD_MAKH.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLHD_MAKH.ForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_MAKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLHD_MAKH.Location = new System.Drawing.Point(1022, 99);
            this.txt_QLHD_MAKH.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLHD_MAKH.Name = "txt_QLHD_MAKH";
            this.txt_QLHD_MAKH.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_MAKH.PlaceholderText = "Mã khách hàng";
            this.txt_QLHD_MAKH.ReadOnly = true;
            this.txt_QLHD_MAKH.SelectedText = "";
            this.txt_QLHD_MAKH.Size = new System.Drawing.Size(220, 40);
            this.txt_QLHD_MAKH.TabIndex = 10;
            // 
            // txt_QLHD_MANV
            // 
            this.txt_QLHD_MANV.Animated = true;
            this.txt_QLHD_MANV.BorderRadius = 2;
            this.txt_QLHD_MANV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLHD_MANV.DefaultText = "";
            this.txt_QLHD_MANV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLHD_MANV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLHD_MANV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLHD_MANV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLHD_MANV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLHD_MANV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLHD_MANV.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLHD_MANV.ForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_MANV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLHD_MANV.Location = new System.Drawing.Point(576, 99);
            this.txt_QLHD_MANV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLHD_MANV.Name = "txt_QLHD_MANV";
            this.txt_QLHD_MANV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_MANV.PlaceholderText = "Mã nhân viên";
            this.txt_QLHD_MANV.ReadOnly = true;
            this.txt_QLHD_MANV.SelectedText = "";
            this.txt_QLHD_MANV.Size = new System.Drawing.Size(220, 40);
            this.txt_QLHD_MANV.TabIndex = 7;
            // 
            // txt_QLHD_MAHD
            // 
            this.txt_QLHD_MAHD.Animated = true;
            this.txt_QLHD_MAHD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(179)))), ((int)(((byte)(204)))));
            this.txt_QLHD_MAHD.BorderRadius = 2;
            this.txt_QLHD_MAHD.BorderThickness = 0;
            this.txt_QLHD_MAHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLHD_MAHD.DefaultText = "";
            this.txt_QLHD_MAHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLHD_MAHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLHD_MAHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLHD_MAHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLHD_MAHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLHD_MAHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLHD_MAHD.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLHD_MAHD.ForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_MAHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLHD_MAHD.Location = new System.Drawing.Point(165, 99);
            this.txt_QLHD_MAHD.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLHD_MAHD.Name = "txt_QLHD_MAHD";
            this.txt_QLHD_MAHD.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_MAHD.PlaceholderText = "Mã hóa đơn";
            this.txt_QLHD_MAHD.ReadOnly = true;
            this.txt_QLHD_MAHD.SelectedText = "";
            this.txt_QLHD_MAHD.Size = new System.Drawing.Size(220, 40);
            this.txt_QLHD_MAHD.TabIndex = 6;
            // 
            // frm_Edit_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 672);
            this.Controls.Add(this.pn_QLLS_dgv);
            this.Name = "frm_Edit_HoaDon";
            this.Text = "Edit_HoaDon";
            this.Load += new System.EventHandler(this.frm_Edit_HoaDon_Load);
            this.pn_QLLS_dgv.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CT_HOADON)).EndInit();
            this.panel_function.ResumeLayout(false);
            this.panel_function.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CTHD_KM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CT_HOADON_SL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_QLLS_dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_function;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_CT_HOADON_TT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_CT_HOADON_GIA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_CT_HOADON_SL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btn_QLHD_Re;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_QLHD_Del;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_CN_CTHD_OUT;
        private Guna.UI2.WinForms.Guna2Button btn_QLHD_Add;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_QLHD_NGAYLAP;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLHD_MAKH;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLHD_MANV;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLHD_MAHD;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_CT_HOADON;
        private System.Windows.Forms.DataGridViewComboBoxColumn cln_QL_CTHD_SANPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLHD_MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLHD_NGAYBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLHD_TIENNHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLHD_TIENTRA;
        private Guna.UI2.WinForms.Guna2ComboBox cob_CTHD_TENSP;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_CTHD_KM;
    }
}