namespace AppGUI
{
    partial class FormQuanLyHoaDon
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
            this.dgv_QLHD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cln_QLHD_MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLHD_MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLHD_MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLHD_NGAYBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLHD_TIENNHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLHD_TIENTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLHD_THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_QLLS_dgv = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_function = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_QLHD_NhapNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_QLHD_Selected = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_QLHD_Re = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLHD_Search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLHD_Del = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLHD_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLHD_Add = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_QLHD_NGAYTAO = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_QLHD_MAKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLHD_MANV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLHD_MAHD = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLHD)).BeginInit();
            this.pn_QLLS_dgv.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_function.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_QLHD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgv_QLHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_QLHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_QLHD.ColumnHeadersHeight = 34;
            this.dgv_QLHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_QLHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_QLHD_MAHD,
            this.cln_QLHD_MANV,
            this.cln_QLHD_MAKH,
            this.cln_QLHD_NGAYBAN,
            this.cln_QLHD_TIENNHAN,
            this.cln_QLHD_TIENTRA,
            this.cln_QLHD_THANHTIEN});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_QLHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_QLHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_QLHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_QLHD.Location = new System.Drawing.Point(0, 467);
            this.dgv_QLHD.MultiSelect = false;
            this.dgv_QLHD.Name = "dgv_QLHD";
            this.dgv_QLHD.ReadOnly = true;
            this.dgv_QLHD.RowHeadersVisible = false;
            this.dgv_QLHD.RowHeadersWidth = 51;
            this.dgv_QLHD.RowTemplate.Height = 24;
            this.dgv_QLHD.Size = new System.Drawing.Size(1601, 573);
            this.dgv_QLHD.TabIndex = 0;
            this.dgv_QLHD.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.dgv_QLHD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgv_QLHD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_QLHD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_QLHD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_QLHD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_QLHD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_QLHD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_QLHD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.dgv_QLHD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_QLHD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_QLHD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_QLHD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_QLHD.ThemeStyle.HeaderStyle.Height = 34;
            this.dgv_QLHD.ThemeStyle.ReadOnly = true;
            this.dgv_QLHD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.dgv_QLHD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_QLHD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_QLHD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_QLHD.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_QLHD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.dgv_QLHD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_QLHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLHD_CellClick);
            // 
            // cln_QLHD_MAHD
            // 
            this.cln_QLHD_MAHD.DataPropertyName = "MAHD";
            this.cln_QLHD_MAHD.HeaderText = "Mã Hóa Đơn";
            this.cln_QLHD_MAHD.MinimumWidth = 6;
            this.cln_QLHD_MAHD.Name = "cln_QLHD_MAHD";
            this.cln_QLHD_MAHD.ReadOnly = true;
            // 
            // cln_QLHD_MANV
            // 
            this.cln_QLHD_MANV.DataPropertyName = "MANV";
            this.cln_QLHD_MANV.HeaderText = "Mã Nhân Viên";
            this.cln_QLHD_MANV.MinimumWidth = 6;
            this.cln_QLHD_MANV.Name = "cln_QLHD_MANV";
            this.cln_QLHD_MANV.ReadOnly = true;
            // 
            // cln_QLHD_MAKH
            // 
            this.cln_QLHD_MAKH.DataPropertyName = "MAKH";
            this.cln_QLHD_MAKH.HeaderText = "Mã Khách Hàng";
            this.cln_QLHD_MAKH.MinimumWidth = 6;
            this.cln_QLHD_MAKH.Name = "cln_QLHD_MAKH";
            this.cln_QLHD_MAKH.ReadOnly = true;
            // 
            // cln_QLHD_NGAYBAN
            // 
            this.cln_QLHD_NGAYBAN.DataPropertyName = "NGAYBAN";
            this.cln_QLHD_NGAYBAN.HeaderText = "Ngày Lập Hóa Đơn";
            this.cln_QLHD_NGAYBAN.MinimumWidth = 6;
            this.cln_QLHD_NGAYBAN.Name = "cln_QLHD_NGAYBAN";
            this.cln_QLHD_NGAYBAN.ReadOnly = true;
            // 
            // cln_QLHD_TIENNHAN
            // 
            this.cln_QLHD_TIENNHAN.DataPropertyName = "TIENNHAN";
            this.cln_QLHD_TIENNHAN.HeaderText = "Tiền Nhận";
            this.cln_QLHD_TIENNHAN.MinimumWidth = 6;
            this.cln_QLHD_TIENNHAN.Name = "cln_QLHD_TIENNHAN";
            this.cln_QLHD_TIENNHAN.ReadOnly = true;
            // 
            // cln_QLHD_TIENTRA
            // 
            this.cln_QLHD_TIENTRA.DataPropertyName = "TIENTRA";
            this.cln_QLHD_TIENTRA.HeaderText = "Tiền Thối";
            this.cln_QLHD_TIENTRA.MinimumWidth = 6;
            this.cln_QLHD_TIENTRA.Name = "cln_QLHD_TIENTRA";
            this.cln_QLHD_TIENTRA.ReadOnly = true;
            // 
            // cln_QLHD_THANHTIEN
            // 
            this.cln_QLHD_THANHTIEN.DataPropertyName = "THANHTIEN";
            this.cln_QLHD_THANHTIEN.HeaderText = "Thành Tiền";
            this.cln_QLHD_THANHTIEN.MinimumWidth = 6;
            this.cln_QLHD_THANHTIEN.Name = "cln_QLHD_THANHTIEN";
            this.cln_QLHD_THANHTIEN.ReadOnly = true;
            // 
            // pn_QLLS_dgv
            // 
            this.pn_QLLS_dgv.Controls.Add(this.panel1);
            this.pn_QLLS_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_QLLS_dgv.Location = new System.Drawing.Point(0, 0);
            this.pn_QLLS_dgv.Name = "pn_QLLS_dgv";
            this.pn_QLLS_dgv.Size = new System.Drawing.Size(1601, 1040);
            this.pn_QLLS_dgv.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_QLHD);
            this.panel1.Controls.Add(this.panel_function);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1601, 1040);
            this.panel1.TabIndex = 11;
            // 
            // panel_function
            // 
            this.panel_function.BackColor = System.Drawing.Color.White;
            this.panel_function.Controls.Add(this.label10);
            this.panel_function.Controls.Add(this.txt_QLHD_NhapNoiDung);
            this.panel_function.Controls.Add(this.label9);
            this.panel_function.Controls.Add(this.cb_QLHD_Selected);
            this.panel_function.Controls.Add(this.label8);
            this.panel_function.Controls.Add(this.btn_QLHD_Re);
            this.panel_function.Controls.Add(this.btn_QLHD_Search);
            this.panel_function.Controls.Add(this.btn_QLHD_Del);
            this.panel_function.Controls.Add(this.btn_QLHD_Edit);
            this.panel_function.Controls.Add(this.btn_QLHD_Add);
            this.panel_function.Controls.Add(this.label4);
            this.panel_function.Controls.Add(this.label3);
            this.panel_function.Controls.Add(this.label2);
            this.panel_function.Controls.Add(this.label1);
            this.panel_function.Controls.Add(this.dtp_QLHD_NGAYTAO);
            this.panel_function.Controls.Add(this.txt_QLHD_MAKH);
            this.panel_function.Controls.Add(this.txt_QLHD_MANV);
            this.panel_function.Controls.Add(this.txt_QLHD_MAHD);
            this.panel_function.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_function.Location = new System.Drawing.Point(0, 0);
            this.panel_function.Name = "panel_function";
            this.panel_function.Size = new System.Drawing.Size(1601, 467);
            this.panel_function.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(370, 59);
            this.label10.TabIndex = 41;
            this.label10.Text = "Quản lý hóa đơn";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_QLHD_NhapNoiDung
            // 
            this.txt_QLHD_NhapNoiDung.Animated = true;
            this.txt_QLHD_NhapNoiDung.BorderRadius = 2;
            this.txt_QLHD_NhapNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLHD_NhapNoiDung.DefaultText = "";
            this.txt_QLHD_NhapNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLHD_NhapNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLHD_NhapNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLHD_NhapNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLHD_NhapNoiDung.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLHD_NhapNoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLHD_NhapNoiDung.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLHD_NhapNoiDung.ForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_NhapNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLHD_NhapNoiDung.Location = new System.Drawing.Point(1082, 314);
            this.txt_QLHD_NhapNoiDung.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLHD_NhapNoiDung.Name = "txt_QLHD_NhapNoiDung";
            this.txt_QLHD_NhapNoiDung.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_NhapNoiDung.PlaceholderText = "";
            this.txt_QLHD_NhapNoiDung.SelectedText = "";
            this.txt_QLHD_NhapNoiDung.Size = new System.Drawing.Size(294, 40);
            this.txt_QLHD_NhapNoiDung.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(897, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 28);
            this.label9.TabIndex = 38;
            this.label9.Text = "Nhập nội dung:";
            // 
            // cb_QLHD_Selected
            // 
            this.cb_QLHD_Selected.BackColor = System.Drawing.Color.Transparent;
            this.cb_QLHD_Selected.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_QLHD_Selected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_QLHD_Selected.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_QLHD_Selected.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_QLHD_Selected.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_QLHD_Selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_QLHD_Selected.ItemHeight = 30;
            this.cb_QLHD_Selected.Items.AddRange(new object[] {
            "Mã Hóa Đơn",
            "Mã Nhân Viên",
            "Mã Khách Hàng"});
            this.cb_QLHD_Selected.Location = new System.Drawing.Point(1082, 243);
            this.cb_QLHD_Selected.Name = "cb_QLHD_Selected";
            this.cb_QLHD_Selected.Size = new System.Drawing.Size(294, 36);
            this.cb_QLHD_Selected.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(897, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 28);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tìm kiếm theo:";
            // 
            // btn_QLHD_Re
            // 
            this.btn_QLHD_Re.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Re.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Re.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLHD_Re.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLHD_Re.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLHD_Re.ForeColor = System.Drawing.Color.White;
            this.btn_QLHD_Re.Location = new System.Drawing.Point(713, 285);
            this.btn_QLHD_Re.Name = "btn_QLHD_Re";
            this.btn_QLHD_Re.Size = new System.Drawing.Size(150, 60);
            this.btn_QLHD_Re.TabIndex = 35;
            this.btn_QLHD_Re.Text = "Reset";
            this.btn_QLHD_Re.Click += new System.EventHandler(this.btn_QLHD_Re_Click);
            // 
            // btn_QLHD_Search
            // 
            this.btn_QLHD_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLHD_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLHD_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLHD_Search.ForeColor = System.Drawing.Color.White;
            this.btn_QLHD_Search.Location = new System.Drawing.Point(0, 0);
            this.btn_QLHD_Search.Name = "btn_QLHD_Search";
            this.btn_QLHD_Search.Size = new System.Drawing.Size(120, 40);
            this.btn_QLHD_Search.TabIndex = 0;
            this.btn_QLHD_Search.Text = "Tìm kiếm";
            // 
            // btn_QLHD_Del
            // 
            this.btn_QLHD_Del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLHD_Del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLHD_Del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLHD_Del.ForeColor = System.Drawing.Color.White;
            this.btn_QLHD_Del.Location = new System.Drawing.Point(492, 285);
            this.btn_QLHD_Del.Name = "btn_QLHD_Del";
            this.btn_QLHD_Del.Size = new System.Drawing.Size(150, 60);
            this.btn_QLHD_Del.TabIndex = 3;
            this.btn_QLHD_Del.Text = "Xóa";
            // 
            // btn_QLHD_Edit
            // 
            this.btn_QLHD_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLHD_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLHD_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLHD_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_QLHD_Edit.Location = new System.Drawing.Point(280, 285);
            this.btn_QLHD_Edit.Name = "btn_QLHD_Edit";
            this.btn_QLHD_Edit.Size = new System.Drawing.Size(150, 60);
            this.btn_QLHD_Edit.TabIndex = 2;
            this.btn_QLHD_Edit.Text = "Cập nhật";
            this.btn_QLHD_Edit.Click += new System.EventHandler(this.btn_QLHD_Edit_Click);
            // 
            // btn_QLHD_Add
            // 
            this.btn_QLHD_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLHD_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLHD_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLHD_Add.ForeColor = System.Drawing.Color.White;
            this.btn_QLHD_Add.Location = new System.Drawing.Point(72, 285);
            this.btn_QLHD_Add.Name = "btn_QLHD_Add";
            this.btn_QLHD_Add.Size = new System.Drawing.Size(150, 60);
            this.btn_QLHD_Add.TabIndex = 1;
            this.btn_QLHD_Add.Text = "Thêm";
            this.btn_QLHD_Add.Click += new System.EventHandler(this.btn_QLHD_Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 203);
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
            this.label3.Location = new System.Drawing.Point(1050, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(568, 127);
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
            this.label1.Location = new System.Drawing.Point(75, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // dtp_QLHD_NGAYTAO
            // 
            this.dtp_QLHD_NGAYTAO.Animated = true;
            this.dtp_QLHD_NGAYTAO.Checked = true;
            this.dtp_QLHD_NGAYTAO.FillColor = System.Drawing.Color.White;
            this.dtp_QLHD_NGAYTAO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_QLHD_NGAYTAO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_QLHD_NGAYTAO.Location = new System.Drawing.Point(228, 200);
            this.dtp_QLHD_NGAYTAO.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_QLHD_NGAYTAO.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_QLHD_NGAYTAO.Name = "dtp_QLHD_NGAYTAO";
            this.dtp_QLHD_NGAYTAO.Size = new System.Drawing.Size(283, 40);
            this.dtp_QLHD_NGAYTAO.TabIndex = 11;
            this.dtp_QLHD_NGAYTAO.Value = new System.DateTime(2025, 4, 8, 8, 55, 25, 913);
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
            this.txt_QLHD_MAKH.Location = new System.Drawing.Point(1243, 121);
            this.txt_QLHD_MAKH.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLHD_MAKH.Name = "txt_QLHD_MAKH";
            this.txt_QLHD_MAKH.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_MAKH.PlaceholderText = "Mã khách hàng";
            this.txt_QLHD_MAKH.SelectedText = "";
            this.txt_QLHD_MAKH.Size = new System.Drawing.Size(266, 40);
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
            this.txt_QLHD_MANV.Location = new System.Drawing.Point(736, 121);
            this.txt_QLHD_MANV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLHD_MANV.Name = "txt_QLHD_MANV";
            this.txt_QLHD_MANV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_MANV.PlaceholderText = "Mã nhân viên";
            this.txt_QLHD_MANV.SelectedText = "";
            this.txt_QLHD_MANV.Size = new System.Drawing.Size(277, 40);
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
            this.txt_QLHD_MAHD.Location = new System.Drawing.Point(232, 121);
            this.txt_QLHD_MAHD.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLHD_MAHD.Name = "txt_QLHD_MAHD";
            this.txt_QLHD_MAHD.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_MAHD.PlaceholderText = "Mã hóa đơn";
            this.txt_QLHD_MAHD.SelectedText = "";
            this.txt_QLHD_MAHD.Size = new System.Drawing.Size(283, 40);
            this.txt_QLHD_MAHD.TabIndex = 6;
            // 
            // FormQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 1040);
            this.Controls.Add(this.pn_QLLS_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyHoaDon";
            this.Load += new System.EventHandler(this.FormQuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLHD)).EndInit();
            this.pn_QLLS_dgv.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_function.ResumeLayout(false);
            this.panel_function.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_QLHD;
        private System.Windows.Forms.Panel pn_QLLS_dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_function;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_QLHD_NGAYTAO;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLHD_MAKH;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLHD_MANV;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLHD_MAHD;
        private Guna.UI2.WinForms.Guna2Button btn_QLHD_Search;
        private Guna.UI2.WinForms.Guna2Button btn_QLHD_Del;
        private Guna.UI2.WinForms.Guna2Button btn_QLHD_Add;
        private Guna.UI2.WinForms.Guna2Button btn_QLHD_Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLHD_MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLHD_MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLHD_MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLHD_NGAYBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLHD_TIENNHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLHD_TIENTRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLHD_THANHTIEN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_QLHD_Re;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cb_QLHD_Selected;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLHD_NhapNoiDung;
        private System.Windows.Forms.Label label10;
    }
}