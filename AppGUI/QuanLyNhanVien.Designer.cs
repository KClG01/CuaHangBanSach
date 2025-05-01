namespace AppGUI
{
    partial class FormQuanLyNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_QLLS_dgv = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_QLNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cln_QLNV_MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLNV_TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLNV_GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLNV_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLNV_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLNV_DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLNV_LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLNV_NGSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLNV_PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_function = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_QLNV_PASSWORD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_QLNV_SAF = new Guna.UI2.WinForms.Guna2TextBox();
            this.rad_QLNV_Female = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rad_QLNV_Male = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_QLNV_NhapNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_QLNV_Selected = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_QLNV_Re = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLNV_Del = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLNV_Search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLNV_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLNV_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_QLNV_SDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLNV_DIACHI = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLNV_TENNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLNV_MANV = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_QLNV_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.pn_QLLS_dgv.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLNV)).BeginInit();
            this.panel_function.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.dgv_QLNV);
            this.panel1.Controls.Add(this.panel_function);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1601, 1040);
            this.panel1.TabIndex = 11;
            // 
            // dgv_QLNV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgv_QLNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_QLNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_QLNV.ColumnHeadersHeight = 34;
            this.dgv_QLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_QLNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_QLNV_MANV,
            this.cln_QLNV_TENNV,
            this.cln_QLNV_GIOITINH,
            this.cln_QLNV_SDT,
            this.cln_QLNV_Email,
            this.cln_QLNV_DIACHI,
            this.cln_QLNV_LUONG,
            this.cln_QLNV_NGSINH,
            this.cln_QLNV_PASSWORD});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_QLNV.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_QLNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_QLNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_QLNV.Location = new System.Drawing.Point(0, 516);
            this.dgv_QLNV.MultiSelect = false;
            this.dgv_QLNV.Name = "dgv_QLNV";
            this.dgv_QLNV.ReadOnly = true;
            this.dgv_QLNV.RowHeadersVisible = false;
            this.dgv_QLNV.RowHeadersWidth = 51;
            this.dgv_QLNV.RowTemplate.Height = 24;
            this.dgv_QLNV.Size = new System.Drawing.Size(1601, 524);
            this.dgv_QLNV.TabIndex = 0;
            this.dgv_QLNV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.dgv_QLNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgv_QLNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_QLNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_QLNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_QLNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_QLNV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_QLNV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_QLNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.dgv_QLNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_QLNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_QLNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_QLNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_QLNV.ThemeStyle.HeaderStyle.Height = 34;
            this.dgv_QLNV.ThemeStyle.ReadOnly = true;
            this.dgv_QLNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.dgv_QLNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_QLNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_QLNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_QLNV.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_QLNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.dgv_QLNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_QLNV.SelectionChanged += new System.EventHandler(this.dgvw_QLNV_SelectionChanged);
            // 
            // cln_QLNV_MANV
            // 
            this.cln_QLNV_MANV.DataPropertyName = "MANV";
            this.cln_QLNV_MANV.HeaderText = "Mã nhân viên";
            this.cln_QLNV_MANV.MinimumWidth = 6;
            this.cln_QLNV_MANV.Name = "cln_QLNV_MANV";
            this.cln_QLNV_MANV.ReadOnly = true;
            // 
            // cln_QLNV_TENNV
            // 
            this.cln_QLNV_TENNV.DataPropertyName = "TENNV";
            this.cln_QLNV_TENNV.HeaderText = "Tên nhân viên";
            this.cln_QLNV_TENNV.MinimumWidth = 6;
            this.cln_QLNV_TENNV.Name = "cln_QLNV_TENNV";
            this.cln_QLNV_TENNV.ReadOnly = true;
            // 
            // cln_QLNV_GIOITINH
            // 
            this.cln_QLNV_GIOITINH.DataPropertyName = "GIOITINH";
            this.cln_QLNV_GIOITINH.HeaderText = "Giới tính";
            this.cln_QLNV_GIOITINH.MinimumWidth = 6;
            this.cln_QLNV_GIOITINH.Name = "cln_QLNV_GIOITINH";
            this.cln_QLNV_GIOITINH.ReadOnly = true;
            // 
            // cln_QLNV_SDT
            // 
            this.cln_QLNV_SDT.DataPropertyName = "SDT";
            this.cln_QLNV_SDT.HeaderText = "SĐT";
            this.cln_QLNV_SDT.MinimumWidth = 6;
            this.cln_QLNV_SDT.Name = "cln_QLNV_SDT";
            this.cln_QLNV_SDT.ReadOnly = true;
            // 
            // cln_QLNV_Email
            // 
            this.cln_QLNV_Email.DataPropertyName = "Email";
            this.cln_QLNV_Email.HeaderText = "Email";
            this.cln_QLNV_Email.MinimumWidth = 6;
            this.cln_QLNV_Email.Name = "cln_QLNV_Email";
            this.cln_QLNV_Email.ReadOnly = true;
            // 
            // cln_QLNV_DIACHI
            // 
            this.cln_QLNV_DIACHI.DataPropertyName = "DIACHI";
            this.cln_QLNV_DIACHI.HeaderText = "Địa chỉ";
            this.cln_QLNV_DIACHI.MinimumWidth = 6;
            this.cln_QLNV_DIACHI.Name = "cln_QLNV_DIACHI";
            this.cln_QLNV_DIACHI.ReadOnly = true;
            // 
            // cln_QLNV_LUONG
            // 
            this.cln_QLNV_LUONG.DataPropertyName = "LUONG";
            this.cln_QLNV_LUONG.HeaderText = "Lương";
            this.cln_QLNV_LUONG.MinimumWidth = 6;
            this.cln_QLNV_LUONG.Name = "cln_QLNV_LUONG";
            this.cln_QLNV_LUONG.ReadOnly = true;
            // 
            // cln_QLNV_NGSINH
            // 
            this.cln_QLNV_NGSINH.DataPropertyName = "NGAYTAO";
            this.cln_QLNV_NGSINH.HeaderText = "Ngày lập";
            this.cln_QLNV_NGSINH.MinimumWidth = 6;
            this.cln_QLNV_NGSINH.Name = "cln_QLNV_NGSINH";
            this.cln_QLNV_NGSINH.ReadOnly = true;
            // 
            // cln_QLNV_PASSWORD
            // 
            this.cln_QLNV_PASSWORD.DataPropertyName = "PASSWORD";
            this.cln_QLNV_PASSWORD.HeaderText = "Mật khẩu";
            this.cln_QLNV_PASSWORD.MinimumWidth = 6;
            this.cln_QLNV_PASSWORD.Name = "cln_QLNV_PASSWORD";
            this.cln_QLNV_PASSWORD.ReadOnly = true;
            // 
            // panel_function
            // 
            this.panel_function.BackColor = System.Drawing.Color.White;
            this.panel_function.Controls.Add(this.label4);
            this.panel_function.Controls.Add(this.btn_QLNV_Email);
            this.panel_function.Controls.Add(this.label12);
            this.panel_function.Controls.Add(this.txt_QLNV_PASSWORD);
            this.panel_function.Controls.Add(this.label11);
            this.panel_function.Controls.Add(this.txt_QLNV_SAF);
            this.panel_function.Controls.Add(this.rad_QLNV_Female);
            this.panel_function.Controls.Add(this.rad_QLNV_Male);
            this.panel_function.Controls.Add(this.label7);
            this.panel_function.Controls.Add(this.label10);
            this.panel_function.Controls.Add(this.txt_QLNV_NhapNoiDung);
            this.panel_function.Controls.Add(this.label9);
            this.panel_function.Controls.Add(this.cb_QLNV_Selected);
            this.panel_function.Controls.Add(this.label8);
            this.panel_function.Controls.Add(this.btn_QLNV_Re);
            this.panel_function.Controls.Add(this.btn_QLNV_Del);
            this.panel_function.Controls.Add(this.btn_QLNV_Search);
            this.panel_function.Controls.Add(this.btn_QLNV_Add);
            this.panel_function.Controls.Add(this.btn_QLNV_Edit);
            this.panel_function.Controls.Add(this.label5);
            this.panel_function.Controls.Add(this.label3);
            this.panel_function.Controls.Add(this.label1);
            this.panel_function.Controls.Add(this.label2);
            this.panel_function.Controls.Add(this.txt_QLNV_SDT);
            this.panel_function.Controls.Add(this.txt_QLNV_DIACHI);
            this.panel_function.Controls.Add(this.txt_QLNV_TENNV);
            this.panel_function.Controls.Add(this.txt_QLNV_MANV);
            this.panel_function.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_function.Location = new System.Drawing.Point(0, 0);
            this.panel_function.Name = "panel_function";
            this.panel_function.Size = new System.Drawing.Size(1601, 516);
            this.panel_function.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(129, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 28);
            this.label12.TabIndex = 51;
            this.label12.Text = "Mật khẩu:";
            // 
            // txt_QLNV_PASSWORD
            // 
            this.txt_QLNV_PASSWORD.Animated = true;
            this.txt_QLNV_PASSWORD.BorderRadius = 2;
            this.txt_QLNV_PASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLNV_PASSWORD.DefaultText = "";
            this.txt_QLNV_PASSWORD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLNV_PASSWORD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLNV_PASSWORD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNV_PASSWORD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNV_PASSWORD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLNV_PASSWORD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNV_PASSWORD.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLNV_PASSWORD.ForeColor = System.Drawing.Color.Black;
            this.txt_QLNV_PASSWORD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNV_PASSWORD.Location = new System.Drawing.Point(263, 299);
            this.txt_QLNV_PASSWORD.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLNV_PASSWORD.Name = "txt_QLNV_PASSWORD";
            this.txt_QLNV_PASSWORD.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLNV_PASSWORD.PlaceholderText = "";
            this.txt_QLNV_PASSWORD.SelectedText = "";
            this.txt_QLNV_PASSWORD.Size = new System.Drawing.Size(258, 40);
            this.txt_QLNV_PASSWORD.TabIndex = 50;
            this.txt_QLNV_PASSWORD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QLNV_PASSWORD_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(635, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 28);
            this.label11.TabIndex = 49;
            this.label11.Text = "Lương:";
            // 
            // txt_QLNV_SAF
            // 
            this.txt_QLNV_SAF.Animated = true;
            this.txt_QLNV_SAF.BorderRadius = 2;
            this.txt_QLNV_SAF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLNV_SAF.DefaultText = "";
            this.txt_QLNV_SAF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLNV_SAF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLNV_SAF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNV_SAF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNV_SAF.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLNV_SAF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNV_SAF.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLNV_SAF.ForeColor = System.Drawing.Color.Black;
            this.txt_QLNV_SAF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNV_SAF.Location = new System.Drawing.Point(735, 299);
            this.txt_QLNV_SAF.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLNV_SAF.Name = "txt_QLNV_SAF";
            this.txt_QLNV_SAF.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLNV_SAF.PlaceholderText = "";
            this.txt_QLNV_SAF.SelectedText = "";
            this.txt_QLNV_SAF.Size = new System.Drawing.Size(284, 40);
            this.txt_QLNV_SAF.TabIndex = 48;
            this.txt_QLNV_SAF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QLNV_SAF_KeyPress);
            // 
            // rad_QLNV_Female
            // 
            this.rad_QLNV_Female.AutoSize = true;
            this.rad_QLNV_Female.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rad_QLNV_Female.CheckedState.BorderThickness = 0;
            this.rad_QLNV_Female.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rad_QLNV_Female.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rad_QLNV_Female.CheckedState.InnerOffset = -4;
            this.rad_QLNV_Female.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_QLNV_Female.ForeColor = System.Drawing.Color.Black;
            this.rad_QLNV_Female.Location = new System.Drawing.Point(1403, 117);
            this.rad_QLNV_Female.Name = "rad_QLNV_Female";
            this.rad_QLNV_Female.Size = new System.Drawing.Size(62, 32);
            this.rad_QLNV_Female.TabIndex = 47;
            this.rad_QLNV_Female.Text = "Nữ";
            this.rad_QLNV_Female.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rad_QLNV_Female.UncheckedState.BorderThickness = 2;
            this.rad_QLNV_Female.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rad_QLNV_Female.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rad_QLNV_Male
            // 
            this.rad_QLNV_Male.AutoSize = true;
            this.rad_QLNV_Male.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rad_QLNV_Male.CheckedState.BorderThickness = 0;
            this.rad_QLNV_Male.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rad_QLNV_Male.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rad_QLNV_Male.CheckedState.InnerOffset = -4;
            this.rad_QLNV_Male.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_QLNV_Male.ForeColor = System.Drawing.Color.Black;
            this.rad_QLNV_Male.Location = new System.Drawing.Point(1261, 115);
            this.rad_QLNV_Male.Name = "rad_QLNV_Male";
            this.rad_QLNV_Male.Size = new System.Drawing.Size(78, 32);
            this.rad_QLNV_Male.TabIndex = 46;
            this.rad_QLNV_Male.Text = "Nam";
            this.rad_QLNV_Male.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rad_QLNV_Male.UncheckedState.BorderThickness = 2;
            this.rad_QLNV_Male.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rad_QLNV_Male.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1122, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 28);
            this.label7.TabIndex = 45;
            this.label7.Text = "Giới tính:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(404, 59);
            this.label10.TabIndex = 44;
            this.label10.Text = "Quản lý nhân viên";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_QLNV_NhapNoiDung
            // 
            this.txt_QLNV_NhapNoiDung.Animated = true;
            this.txt_QLNV_NhapNoiDung.BorderRadius = 2;
            this.txt_QLNV_NhapNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLNV_NhapNoiDung.DefaultText = "";
            this.txt_QLNV_NhapNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLNV_NhapNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLNV_NhapNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNV_NhapNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNV_NhapNoiDung.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLNV_NhapNoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNV_NhapNoiDung.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLNV_NhapNoiDung.ForeColor = System.Drawing.Color.Black;
            this.txt_QLNV_NhapNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNV_NhapNoiDung.Location = new System.Drawing.Point(1106, 454);
            this.txt_QLNV_NhapNoiDung.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLNV_NhapNoiDung.Name = "txt_QLNV_NhapNoiDung";
            this.txt_QLNV_NhapNoiDung.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLNV_NhapNoiDung.PlaceholderText = "";
            this.txt_QLNV_NhapNoiDung.SelectedText = "";
            this.txt_QLNV_NhapNoiDung.Size = new System.Drawing.Size(291, 40);
            this.txt_QLNV_NhapNoiDung.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(921, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 28);
            this.label9.TabIndex = 42;
            this.label9.Text = "Nhập nội dung:";
            // 
            // cb_QLNV_Selected
            // 
            this.cb_QLNV_Selected.BackColor = System.Drawing.Color.Transparent;
            this.cb_QLNV_Selected.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_QLNV_Selected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_QLNV_Selected.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_QLNV_Selected.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_QLNV_Selected.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_QLNV_Selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_QLNV_Selected.ItemHeight = 30;
            this.cb_QLNV_Selected.Location = new System.Drawing.Point(1106, 380);
            this.cb_QLNV_Selected.Name = "cb_QLNV_Selected";
            this.cb_QLNV_Selected.Size = new System.Drawing.Size(291, 36);
            this.cb_QLNV_Selected.TabIndex = 41;
            this.cb_QLNV_Selected.SelectedIndexChanged += new System.EventHandler(this.cb_QLNV_Selected_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(921, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 28);
            this.label8.TabIndex = 40;
            this.label8.Text = "Tìm kiếm theo:";
            // 
            // btn_QLNV_Re
            // 
            this.btn_QLNV_Re.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNV_Re.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNV_Re.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLNV_Re.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLNV_Re.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNV_Re.ForeColor = System.Drawing.Color.White;
            this.btn_QLNV_Re.Location = new System.Drawing.Point(702, 389);
            this.btn_QLNV_Re.Name = "btn_QLNV_Re";
            this.btn_QLNV_Re.Size = new System.Drawing.Size(150, 60);
            this.btn_QLNV_Re.TabIndex = 36;
            this.btn_QLNV_Re.Text = "Tạo mới";
            this.btn_QLNV_Re.Click += new System.EventHandler(this.btn_QLNV_Re_Click);
            // 
            // btn_QLNV_Del
            // 
            this.btn_QLNV_Del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNV_Del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNV_Del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLNV_Del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLNV_Del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNV_Del.ForeColor = System.Drawing.Color.White;
            this.btn_QLNV_Del.Location = new System.Drawing.Point(506, 389);
            this.btn_QLNV_Del.Name = "btn_QLNV_Del";
            this.btn_QLNV_Del.Size = new System.Drawing.Size(150, 60);
            this.btn_QLNV_Del.TabIndex = 3;
            this.btn_QLNV_Del.Text = "Xóa";
            this.btn_QLNV_Del.Click += new System.EventHandler(this.btn_QLNV_Del_Click);
            // 
            // btn_QLNV_Search
            // 
            this.btn_QLNV_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNV_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNV_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLNV_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLNV_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNV_Search.ForeColor = System.Drawing.Color.White;
            this.btn_QLNV_Search.Location = new System.Drawing.Point(1403, 454);
            this.btn_QLNV_Search.Name = "btn_QLNV_Search";
            this.btn_QLNV_Search.Size = new System.Drawing.Size(120, 40);
            this.btn_QLNV_Search.TabIndex = 0;
            this.btn_QLNV_Search.Text = "Tìm kiếm";
            this.btn_QLNV_Search.Click += new System.EventHandler(this.btn_QLNV_Search_Click);
            // 
            // btn_QLNV_Add
            // 
            this.btn_QLNV_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNV_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNV_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLNV_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLNV_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNV_Add.ForeColor = System.Drawing.Color.White;
            this.btn_QLNV_Add.Location = new System.Drawing.Point(118, 389);
            this.btn_QLNV_Add.Name = "btn_QLNV_Add";
            this.btn_QLNV_Add.Size = new System.Drawing.Size(150, 60);
            this.btn_QLNV_Add.TabIndex = 1;
            this.btn_QLNV_Add.Text = "Thêm";
            this.btn_QLNV_Add.Click += new System.EventHandler(this.btn_QLNV_Add_Click);
            // 
            // btn_QLNV_Edit
            // 
            this.btn_QLNV_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNV_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNV_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLNV_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLNV_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNV_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_QLNV_Edit.Location = new System.Drawing.Point(312, 389);
            this.btn_QLNV_Edit.Name = "btn_QLNV_Edit";
            this.btn_QLNV_Edit.Size = new System.Drawing.Size(150, 60);
            this.btn_QLNV_Edit.TabIndex = 2;
            this.btn_QLNV_Edit.Text = "Sửa";
            this.btn_QLNV_Edit.Click += new System.EventHandler(this.btn_QLNV_Edit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1139, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 28);
            this.label5.TabIndex = 32;
            this.label5.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(93, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 28);
            this.label3.TabIndex = 30;
            this.label3.Text = "Số điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(566, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(90, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã nhân viên:";
            // 
            // txt_QLNV_SDT
            // 
            this.txt_QLNV_SDT.Animated = true;
            this.txt_QLNV_SDT.BorderRadius = 2;
            this.txt_QLNV_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLNV_SDT.DefaultText = "";
            this.txt_QLNV_SDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLNV_SDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLNV_SDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNV_SDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNV_SDT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLNV_SDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNV_SDT.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLNV_SDT.ForeColor = System.Drawing.Color.Black;
            this.txt_QLNV_SDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNV_SDT.Location = new System.Drawing.Point(263, 205);
            this.txt_QLNV_SDT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLNV_SDT.Name = "txt_QLNV_SDT";
            this.txt_QLNV_SDT.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLNV_SDT.PlaceholderText = "SĐT";
            this.txt_QLNV_SDT.SelectedText = "";
            this.txt_QLNV_SDT.Size = new System.Drawing.Size(258, 40);
            this.txt_QLNV_SDT.TabIndex = 10;
            this.txt_QLNV_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QLNV_SDT_KeyPress);
            // 
            // txt_QLNV_DIACHI
            // 
            this.txt_QLNV_DIACHI.Animated = true;
            this.txt_QLNV_DIACHI.BorderRadius = 2;
            this.txt_QLNV_DIACHI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLNV_DIACHI.DefaultText = "";
            this.txt_QLNV_DIACHI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLNV_DIACHI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLNV_DIACHI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNV_DIACHI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNV_DIACHI.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLNV_DIACHI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNV_DIACHI.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLNV_DIACHI.ForeColor = System.Drawing.Color.Black;
            this.txt_QLNV_DIACHI.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNV_DIACHI.Location = new System.Drawing.Point(1245, 205);
            this.txt_QLNV_DIACHI.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLNV_DIACHI.Multiline = true;
            this.txt_QLNV_DIACHI.Name = "txt_QLNV_DIACHI";
            this.txt_QLNV_DIACHI.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLNV_DIACHI.PlaceholderText = "Địa chỉ";
            this.txt_QLNV_DIACHI.SelectedText = "";
            this.txt_QLNV_DIACHI.Size = new System.Drawing.Size(243, 92);
            this.txt_QLNV_DIACHI.TabIndex = 9;
            // 
            // txt_QLNV_TENNV
            // 
            this.txt_QLNV_TENNV.Animated = true;
            this.txt_QLNV_TENNV.BorderRadius = 2;
            this.txt_QLNV_TENNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLNV_TENNV.DefaultText = "";
            this.txt_QLNV_TENNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLNV_TENNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLNV_TENNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNV_TENNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNV_TENNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLNV_TENNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNV_TENNV.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLNV_TENNV.ForeColor = System.Drawing.Color.Black;
            this.txt_QLNV_TENNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNV_TENNV.Location = new System.Drawing.Point(735, 109);
            this.txt_QLNV_TENNV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLNV_TENNV.Name = "txt_QLNV_TENNV";
            this.txt_QLNV_TENNV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLNV_TENNV.PlaceholderText = "Tên nhân viên";
            this.txt_QLNV_TENNV.SelectedText = "";
            this.txt_QLNV_TENNV.Size = new System.Drawing.Size(284, 40);
            this.txt_QLNV_TENNV.TabIndex = 7;
            this.txt_QLNV_TENNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QLNV_TENKH_KeyPress);
            // 
            // txt_QLNV_MANV
            // 
            this.txt_QLNV_MANV.Animated = true;
            this.txt_QLNV_MANV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(179)))), ((int)(((byte)(204)))));
            this.txt_QLNV_MANV.BorderRadius = 2;
            this.txt_QLNV_MANV.BorderThickness = 0;
            this.txt_QLNV_MANV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLNV_MANV.DefaultText = "";
            this.txt_QLNV_MANV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLNV_MANV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLNV_MANV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNV_MANV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNV_MANV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLNV_MANV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNV_MANV.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLNV_MANV.ForeColor = System.Drawing.Color.Black;
            this.txt_QLNV_MANV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNV_MANV.Location = new System.Drawing.Point(263, 109);
            this.txt_QLNV_MANV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLNV_MANV.Name = "txt_QLNV_MANV";
            this.txt_QLNV_MANV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLNV_MANV.PlaceholderText = "Mã nhân viên";
            this.txt_QLNV_MANV.SelectedText = "";
            this.txt_QLNV_MANV.Size = new System.Drawing.Size(258, 40);
            this.txt_QLNV_MANV.TabIndex = 6;
            this.txt_QLNV_MANV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QLNV_MAKH_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(643, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 28);
            this.label4.TabIndex = 53;
            this.label4.Text = "Email:";
            // 
            // btn_QLNV_Email
            // 
            this.btn_QLNV_Email.Animated = true;
            this.btn_QLNV_Email.BorderRadius = 2;
            this.btn_QLNV_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_QLNV_Email.DefaultText = "";
            this.btn_QLNV_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btn_QLNV_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btn_QLNV_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btn_QLNV_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btn_QLNV_Email.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.btn_QLNV_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_QLNV_Email.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btn_QLNV_Email.ForeColor = System.Drawing.Color.Black;
            this.btn_QLNV_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_QLNV_Email.Location = new System.Drawing.Point(735, 205);
            this.btn_QLNV_Email.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_QLNV_Email.Name = "btn_QLNV_Email";
            this.btn_QLNV_Email.PlaceholderForeColor = System.Drawing.Color.Black;
            this.btn_QLNV_Email.PlaceholderText = "";
            this.btn_QLNV_Email.SelectedText = "";
            this.btn_QLNV_Email.Size = new System.Drawing.Size(284, 40);
            this.btn_QLNV_Email.TabIndex = 52;
            this.btn_QLNV_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_QLNV_Email_KeyPress);
            // 
            // FormQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 1040);
            this.Controls.Add(this.pn_QLLS_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyNhanVien";
            this.Load += new System.EventHandler(this.FormQuanLyNhanVien_Load);
            this.pn_QLLS_dgv.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLNV)).EndInit();
            this.panel_function.ResumeLayout(false);
            this.panel_function.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_QLLS_dgv;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_QLNV;
        private System.Windows.Forms.Panel panel_function;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLNV_NhapNoiDung;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cb_QLNV_Selected;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btn_QLNV_Re;
        private Guna.UI2.WinForms.Guna2Button btn_QLNV_Del;
        private Guna.UI2.WinForms.Guna2Button btn_QLNV_Search;
        private Guna.UI2.WinForms.Guna2Button btn_QLNV_Add;
        private Guna.UI2.WinForms.Guna2Button btn_QLNV_Edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLNV_SDT;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLNV_DIACHI;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLNV_TENNV;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLNV_MANV;
        private Guna.UI2.WinForms.Guna2RadioButton rad_QLNV_Male;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2RadioButton rad_QLNV_Female;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLNV_PASSWORD;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLNV_SAF;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLNV_MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLNV_TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLNV_GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLNV_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLNV_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLNV_DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLNV_LUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLNV_NGSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLNV_PASSWORD;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox btn_QLNV_Email;
    }
}