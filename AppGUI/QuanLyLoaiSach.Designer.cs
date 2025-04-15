namespace AppGUI
{
    partial class FormQuanLyLoaiSach
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
            this.dgvw_QLLS = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cln_QLLS_MA_LOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLLS_TENLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_QLLS_dgv = new System.Windows.Forms.Panel();
            this.btn_QLLS_Search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLLS_Del = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLLS_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLLS_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.txt_QLLS_TENLOAI = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_function = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_QLLS_Re = new Guna.UI2.WinForms.Guna2Button();
            this.txt_QLKH_NhapNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_QLKH_Selected = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_QLLS_MA_LOAI = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_QLLS)).BeginInit();
            this.pn_QLLS_dgv.SuspendLayout();
            this.panel_function.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvw_QLLS
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgvw_QLLS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvw_QLLS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvw_QLLS.ColumnHeadersHeight = 34;
            this.dgvw_QLLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvw_QLLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_QLLS_MA_LOAI,
            this.cln_QLLS_TENLOAI});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvw_QLLS.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvw_QLLS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvw_QLLS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgvw_QLLS.Location = new System.Drawing.Point(0, 0);
            this.dgvw_QLLS.MultiSelect = false;
            this.dgvw_QLLS.Name = "dgvw_QLLS";
            this.dgvw_QLLS.RowHeadersVisible = false;
            this.dgvw_QLLS.RowHeadersWidth = 51;
            this.dgvw_QLLS.RowTemplate.Height = 24;
            this.dgvw_QLLS.Size = new System.Drawing.Size(1601, 729);
            this.dgvw_QLLS.TabIndex = 0;
            this.dgvw_QLLS.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.dgvw_QLLS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgvw_QLLS.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvw_QLLS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvw_QLLS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvw_QLLS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvw_QLLS.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvw_QLLS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgvw_QLLS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.dgvw_QLLS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvw_QLLS.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvw_QLLS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvw_QLLS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvw_QLLS.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvw_QLLS.ThemeStyle.ReadOnly = false;
            this.dgvw_QLLS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.dgvw_QLLS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvw_QLLS.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvw_QLLS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvw_QLLS.ThemeStyle.RowsStyle.Height = 24;
            this.dgvw_QLLS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.dgvw_QLLS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cln_QLLS_MA_LOAI
            // 
            this.cln_QLLS_MA_LOAI.DataPropertyName = "MA_LOAI";
            this.cln_QLLS_MA_LOAI.HeaderText = "Mã loại sách";
            this.cln_QLLS_MA_LOAI.MinimumWidth = 6;
            this.cln_QLLS_MA_LOAI.Name = "cln_QLLS_MA_LOAI";
            // 
            // cln_QLLS_TENLOAI
            // 
            this.cln_QLLS_TENLOAI.DataPropertyName = "TENLOAI";
            this.cln_QLLS_TENLOAI.HeaderText = "Tên loại sách";
            this.cln_QLLS_TENLOAI.MinimumWidth = 6;
            this.cln_QLLS_TENLOAI.Name = "cln_QLLS_TENLOAI";
            // 
            // pn_QLLS_dgv
            // 
            this.pn_QLLS_dgv.Controls.Add(this.dgvw_QLLS);
            this.pn_QLLS_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_QLLS_dgv.Location = new System.Drawing.Point(0, 311);
            this.pn_QLLS_dgv.Name = "pn_QLLS_dgv";
            this.pn_QLLS_dgv.Size = new System.Drawing.Size(1601, 729);
            this.pn_QLLS_dgv.TabIndex = 5;
            // 
            // btn_QLLS_Search
            // 
            this.btn_QLLS_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLLS_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLLS_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLLS_Search.ForeColor = System.Drawing.Color.White;
            this.btn_QLLS_Search.Location = new System.Drawing.Point(1400, 196);
            this.btn_QLLS_Search.Name = "btn_QLLS_Search";
            this.btn_QLLS_Search.Size = new System.Drawing.Size(120, 40);
            this.btn_QLLS_Search.TabIndex = 0;
            this.btn_QLLS_Search.Text = "Tìm kiếm";
            // 
            // btn_QLLS_Del
            // 
            this.btn_QLLS_Del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLLS_Del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLLS_Del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLLS_Del.ForeColor = System.Drawing.Color.White;
            this.btn_QLLS_Del.Location = new System.Drawing.Point(482, 225);
            this.btn_QLLS_Del.Name = "btn_QLLS_Del";
            this.btn_QLLS_Del.Size = new System.Drawing.Size(150, 60);
            this.btn_QLLS_Del.TabIndex = 3;
            this.btn_QLLS_Del.Text = "Xóa";
            // 
            // btn_QLLS_Add
            // 
            this.btn_QLLS_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLLS_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLLS_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLLS_Add.ForeColor = System.Drawing.Color.White;
            this.btn_QLLS_Add.Location = new System.Drawing.Point(80, 225);
            this.btn_QLLS_Add.Name = "btn_QLLS_Add";
            this.btn_QLLS_Add.Size = new System.Drawing.Size(150, 60);
            this.btn_QLLS_Add.TabIndex = 1;
            this.btn_QLLS_Add.Text = "Thêm";
            // 
            // btn_QLLS_Edit
            // 
            this.btn_QLLS_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLLS_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLLS_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLLS_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_QLLS_Edit.Location = new System.Drawing.Point(280, 225);
            this.btn_QLLS_Edit.Name = "btn_QLLS_Edit";
            this.btn_QLLS_Edit.Size = new System.Drawing.Size(150, 60);
            this.btn_QLLS_Edit.TabIndex = 2;
            this.btn_QLLS_Edit.Text = "Sửa";
            // 
            // txt_QLLS_TENLOAI
            // 
            this.txt_QLLS_TENLOAI.BorderRadius = 2;
            this.txt_QLLS_TENLOAI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLLS_TENLOAI.DefaultText = "";
            this.txt_QLLS_TENLOAI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLLS_TENLOAI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLLS_TENLOAI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLLS_TENLOAI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLLS_TENLOAI.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLLS_TENLOAI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLLS_TENLOAI.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLLS_TENLOAI.ForeColor = System.Drawing.Color.Black;
            this.txt_QLLS_TENLOAI.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLLS_TENLOAI.Location = new System.Drawing.Point(711, 118);
            this.txt_QLLS_TENLOAI.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLLS_TENLOAI.Name = "txt_QLLS_TENLOAI";
            this.txt_QLLS_TENLOAI.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLLS_TENLOAI.PlaceholderText = "Tên loại sách";
            this.txt_QLLS_TENLOAI.SelectedText = "";
            this.txt_QLLS_TENLOAI.Size = new System.Drawing.Size(220, 40);
            this.txt_QLLS_TENLOAI.TabIndex = 7;
            // 
            // panel_function
            // 
            this.panel_function.BackColor = System.Drawing.Color.White;
            this.panel_function.Controls.Add(this.label10);
            this.panel_function.Controls.Add(this.btn_QLLS_Re);
            this.panel_function.Controls.Add(this.txt_QLKH_NhapNoiDung);
            this.panel_function.Controls.Add(this.label9);
            this.panel_function.Controls.Add(this.cb_QLKH_Selected);
            this.panel_function.Controls.Add(this.label8);
            this.panel_function.Controls.Add(this.btn_QLLS_Del);
            this.panel_function.Controls.Add(this.btn_QLLS_Search);
            this.panel_function.Controls.Add(this.btn_QLLS_Edit);
            this.panel_function.Controls.Add(this.btn_QLLS_Add);
            this.panel_function.Controls.Add(this.label1);
            this.panel_function.Controls.Add(this.label5);
            this.panel_function.Controls.Add(this.txt_QLLS_TENLOAI);
            this.panel_function.Controls.Add(this.txt_QLLS_MA_LOAI);
            this.panel_function.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_function.Location = new System.Drawing.Point(0, 0);
            this.panel_function.Name = "panel_function";
            this.panel_function.Size = new System.Drawing.Size(1601, 311);
            this.panel_function.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(380, 59);
            this.label10.TabIndex = 50;
            this.label10.Text = "Quản lý loại sách";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_QLLS_Re
            // 
            this.btn_QLLS_Re.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Re.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Re.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLLS_Re.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLLS_Re.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLLS_Re.ForeColor = System.Drawing.Color.White;
            this.btn_QLLS_Re.Location = new System.Drawing.Point(683, 225);
            this.btn_QLLS_Re.Name = "btn_QLLS_Re";
            this.btn_QLLS_Re.Size = new System.Drawing.Size(150, 60);
            this.btn_QLLS_Re.TabIndex = 48;
            this.btn_QLLS_Re.Text = "Tạo mới";
            // 
            // txt_QLKH_NhapNoiDung
            // 
            this.txt_QLKH_NhapNoiDung.Animated = true;
            this.txt_QLKH_NhapNoiDung.BorderRadius = 2;
            this.txt_QLKH_NhapNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLKH_NhapNoiDung.DefaultText = "";
            this.txt_QLKH_NhapNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLKH_NhapNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLKH_NhapNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLKH_NhapNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLKH_NhapNoiDung.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLKH_NhapNoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLKH_NhapNoiDung.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLKH_NhapNoiDung.ForeColor = System.Drawing.Color.Black;
            this.txt_QLKH_NhapNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLKH_NhapNoiDung.Location = new System.Drawing.Point(1174, 196);
            this.txt_QLKH_NhapNoiDung.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLKH_NhapNoiDung.Name = "txt_QLKH_NhapNoiDung";
            this.txt_QLKH_NhapNoiDung.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLKH_NhapNoiDung.PlaceholderText = "";
            this.txt_QLKH_NhapNoiDung.SelectedText = "";
            this.txt_QLKH_NhapNoiDung.Size = new System.Drawing.Size(220, 40);
            this.txt_QLKH_NhapNoiDung.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(989, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 28);
            this.label9.TabIndex = 46;
            this.label9.Text = "Nhập nội dung:";
            // 
            // cb_QLKH_Selected
            // 
            this.cb_QLKH_Selected.BackColor = System.Drawing.Color.Transparent;
            this.cb_QLKH_Selected.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_QLKH_Selected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_QLKH_Selected.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_QLKH_Selected.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_QLKH_Selected.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_QLKH_Selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_QLKH_Selected.ItemHeight = 30;
            this.cb_QLKH_Selected.Location = new System.Drawing.Point(1174, 122);
            this.cb_QLKH_Selected.Name = "cb_QLKH_Selected";
            this.cb_QLKH_Selected.Size = new System.Drawing.Size(220, 36);
            this.cb_QLKH_Selected.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(989, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 28);
            this.label8.TabIndex = 44;
            this.label8.Text = "Tìm kiếm theo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(534, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tên loại sách:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(75, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 28);
            this.label5.TabIndex = 33;
            this.label5.Text = "Mã loại sách:";
            // 
            // txt_QLLS_MA_LOAI
            // 
            this.txt_QLLS_MA_LOAI.BorderRadius = 2;
            this.txt_QLLS_MA_LOAI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLLS_MA_LOAI.DefaultText = "";
            this.txt_QLLS_MA_LOAI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLLS_MA_LOAI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLLS_MA_LOAI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLLS_MA_LOAI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLLS_MA_LOAI.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLLS_MA_LOAI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLLS_MA_LOAI.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLLS_MA_LOAI.ForeColor = System.Drawing.Color.Black;
            this.txt_QLLS_MA_LOAI.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLLS_MA_LOAI.Location = new System.Drawing.Point(263, 118);
            this.txt_QLLS_MA_LOAI.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLLS_MA_LOAI.Name = "txt_QLLS_MA_LOAI";
            this.txt_QLLS_MA_LOAI.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLLS_MA_LOAI.PlaceholderText = "Mã loại sách";
            this.txt_QLLS_MA_LOAI.SelectedText = "";
            this.txt_QLLS_MA_LOAI.Size = new System.Drawing.Size(220, 40);
            this.txt_QLLS_MA_LOAI.TabIndex = 6;
            // 
            // FormQuanLyLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 1040);
            this.Controls.Add(this.pn_QLLS_dgv);
            this.Controls.Add(this.panel_function);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyLoaiSach";
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_QLLS)).EndInit();
            this.pn_QLLS_dgv.ResumeLayout(false);
            this.panel_function.ResumeLayout(false);
            this.panel_function.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvw_QLLS;
        private System.Windows.Forms.Panel pn_QLLS_dgv;
        private Guna.UI2.WinForms.Guna2Button btn_QLLS_Search;
        private Guna.UI2.WinForms.Guna2Button btn_QLLS_Del;
        private Guna.UI2.WinForms.Guna2Button btn_QLLS_Add;
        private Guna.UI2.WinForms.Guna2Button btn_QLLS_Edit;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLLS_TENLOAI;
        private System.Windows.Forms.Panel panel_function;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLLS_MA_LOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLLS_MA_LOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLLS_TENLOAI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLKH_NhapNoiDung;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cb_QLKH_Selected;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btn_QLLS_Re;
        private System.Windows.Forms.Label label10;
    }
}