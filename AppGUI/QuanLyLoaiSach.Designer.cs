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
            this.pn_QLLS_dgv = new System.Windows.Forms.Panel();
            this.dgv_QLLS = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cln_QLLS_MA_LOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLLS_TENLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_QLLS_Search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLLS_Del = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLLS_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLLS_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.txt_QLLS_TENLOAI = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_function = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_QLLS_Re = new Guna.UI2.WinForms.Guna2Button();
            this.txt_QLLS_NhapNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_index = new System.Windows.Forms.Label();
            this.cb_QLLS_Selected = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_QLLS_MA_LOAI = new Guna.UI2.WinForms.Guna2TextBox();
            this.pn_QLLS_dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLLS)).BeginInit();
            this.panel_function.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_QLLS_dgv
            // 
            this.pn_QLLS_dgv.Controls.Add(this.dgv_QLLS);
            this.pn_QLLS_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_QLLS_dgv.Location = new System.Drawing.Point(0, 311);
            this.pn_QLLS_dgv.Name = "pn_QLLS_dgv";
            this.pn_QLLS_dgv.Size = new System.Drawing.Size(1601, 729);
            this.pn_QLLS_dgv.TabIndex = 5;
            // 
            // dgv_QLLS
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgv_QLLS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_QLLS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_QLLS.ColumnHeadersHeight = 40;
            this.dgv_QLLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_QLLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_QLLS_MA_LOAI,
            this.cln_QLLS_TENLOAI});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_QLLS.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_QLLS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_QLLS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgv_QLLS.Location = new System.Drawing.Point(0, 0);
            this.dgv_QLLS.Name = "dgv_QLLS";
            this.dgv_QLLS.ReadOnly = true;
            this.dgv_QLLS.RowHeadersVisible = false;
            this.dgv_QLLS.RowHeadersWidth = 50;
            this.dgv_QLLS.RowTemplate.Height = 24;
            this.dgv_QLLS.Size = new System.Drawing.Size(1601, 729);
            this.dgv_QLLS.TabIndex = 0;
            this.dgv_QLLS.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgv_QLLS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgv_QLLS.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_QLLS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_QLLS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_QLLS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_QLLS.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_QLLS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgv_QLLS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgv_QLLS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_QLLS.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_QLLS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_QLLS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_QLLS.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_QLLS.ThemeStyle.ReadOnly = true;
            this.dgv_QLLS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgv_QLLS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_QLLS.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_QLLS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_QLLS.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_QLLS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgv_QLLS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_QLLS.SelectionChanged += new System.EventHandler(this.dgv_QLLS_SelectionChanged);
            // 
            // cln_QLLS_MA_LOAI
            // 
            this.cln_QLLS_MA_LOAI.DataPropertyName = "MALOAI";
            this.cln_QLLS_MA_LOAI.HeaderText = "Mã loại sách";
            this.cln_QLLS_MA_LOAI.MinimumWidth = 6;
            this.cln_QLLS_MA_LOAI.Name = "cln_QLLS_MA_LOAI";
            this.cln_QLLS_MA_LOAI.ReadOnly = true;
            // 
            // cln_QLLS_TENLOAI
            // 
            this.cln_QLLS_TENLOAI.DataPropertyName = "TENLOAI";
            this.cln_QLLS_TENLOAI.HeaderText = "Tên loại sách";
            this.cln_QLLS_TENLOAI.MinimumWidth = 6;
            this.cln_QLLS_TENLOAI.Name = "cln_QLLS_TENLOAI";
            this.cln_QLLS_TENLOAI.ReadOnly = true;
            // 
            // btn_QLLS_Search
            // 
            this.btn_QLLS_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLLS_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLLS_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLLS_Search.ForeColor = System.Drawing.Color.White;
            this.btn_QLLS_Search.Location = new System.Drawing.Point(1447, 245);
            this.btn_QLLS_Search.Name = "btn_QLLS_Search";
            this.btn_QLLS_Search.Size = new System.Drawing.Size(120, 40);
            this.btn_QLLS_Search.TabIndex = 0;
            this.btn_QLLS_Search.Text = "Tìm kiếm";
            this.btn_QLLS_Search.Click += new System.EventHandler(this.btn_QLLS_Search_Click);
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
            this.btn_QLLS_Del.Click += new System.EventHandler(this.btn_QLLS_Del_Click);
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
            this.btn_QLLS_Add.Click += new System.EventHandler(this.btn_QLLS_Add_Click);
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
            this.btn_QLLS_Edit.Click += new System.EventHandler(this.btn_QLLS_Edit_Click);
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
            this.txt_QLLS_TENLOAI.Location = new System.Drawing.Point(777, 118);
            this.txt_QLLS_TENLOAI.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLLS_TENLOAI.Name = "txt_QLLS_TENLOAI";
            this.txt_QLLS_TENLOAI.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLLS_TENLOAI.PlaceholderText = "Tên loại sách";
            this.txt_QLLS_TENLOAI.SelectedText = "";
            this.txt_QLLS_TENLOAI.Size = new System.Drawing.Size(299, 40);
            this.txt_QLLS_TENLOAI.TabIndex = 7;
            this.txt_QLLS_TENLOAI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QLLS_TENLOAI_KeyPress);
            // 
            // panel_function
            // 
            this.panel_function.BackColor = System.Drawing.Color.White;
            this.panel_function.Controls.Add(this.label10);
            this.panel_function.Controls.Add(this.btn_QLLS_Re);
            this.panel_function.Controls.Add(this.txt_QLLS_NhapNoiDung);
            this.panel_function.Controls.Add(this.lbl_index);
            this.panel_function.Controls.Add(this.cb_QLLS_Selected);
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
            this.btn_QLLS_Re.Click += new System.EventHandler(this.btn_QLLS_Re_Click);
            // 
            // txt_QLLS_NhapNoiDung
            // 
            this.txt_QLLS_NhapNoiDung.Animated = true;
            this.txt_QLLS_NhapNoiDung.BorderRadius = 2;
            this.txt_QLLS_NhapNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLLS_NhapNoiDung.DefaultText = "";
            this.txt_QLLS_NhapNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLLS_NhapNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLLS_NhapNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLLS_NhapNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLLS_NhapNoiDung.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLLS_NhapNoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLLS_NhapNoiDung.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLLS_NhapNoiDung.ForeColor = System.Drawing.Color.Black;
            this.txt_QLLS_NhapNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLLS_NhapNoiDung.Location = new System.Drawing.Point(1132, 245);
            this.txt_QLLS_NhapNoiDung.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLLS_NhapNoiDung.Name = "txt_QLLS_NhapNoiDung";
            this.txt_QLLS_NhapNoiDung.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLLS_NhapNoiDung.PlaceholderText = "";
            this.txt_QLLS_NhapNoiDung.SelectedText = "";
            this.txt_QLLS_NhapNoiDung.Size = new System.Drawing.Size(309, 40);
            this.txt_QLLS_NhapNoiDung.TabIndex = 47;
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_index.ForeColor = System.Drawing.Color.Red;
            this.lbl_index.Location = new System.Drawing.Point(947, 248);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(158, 28);
            this.lbl_index.TabIndex = 46;
            this.lbl_index.Text = "Nhập nội dung:";
            // 
            // cb_QLLS_Selected
            // 
            this.cb_QLLS_Selected.BackColor = System.Drawing.Color.Transparent;
            this.cb_QLLS_Selected.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_QLLS_Selected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_QLLS_Selected.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_QLLS_Selected.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_QLLS_Selected.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_QLLS_Selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_QLLS_Selected.ItemHeight = 30;
            this.cb_QLLS_Selected.Items.AddRange(new object[] {
            "Mã loại sách",
            "Tên loại sách"});
            this.cb_QLLS_Selected.Location = new System.Drawing.Point(1132, 185);
            this.cb_QLLS_Selected.Name = "cb_QLLS_Selected";
            this.cb_QLLS_Selected.Size = new System.Drawing.Size(309, 36);
            this.cb_QLLS_Selected.TabIndex = 45;
            this.cb_QLLS_Selected.SelectedIndexChanged += new System.EventHandler(this.cb_QLLS_Selected_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(947, 185);
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
            this.label1.Location = new System.Drawing.Point(600, 123);
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
            this.txt_QLLS_MA_LOAI.Size = new System.Drawing.Size(265, 40);
            this.txt_QLLS_MA_LOAI.TabIndex = 6;
            this.txt_QLLS_MA_LOAI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QLLS_MA_LOAI_KeyPress);
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
            this.Load += new System.EventHandler(this.FormQuanLyLoaiSach_Load);
            this.pn_QLLS_dgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLLS)).EndInit();
            this.panel_function.ResumeLayout(false);
            this.panel_function.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_QLLS_dgv;
        private Guna.UI2.WinForms.Guna2Button btn_QLLS_Search;
        private Guna.UI2.WinForms.Guna2Button btn_QLLS_Del;
        private Guna.UI2.WinForms.Guna2Button btn_QLLS_Add;
        private Guna.UI2.WinForms.Guna2Button btn_QLLS_Edit;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLLS_TENLOAI;
        private System.Windows.Forms.Panel panel_function;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLLS_MA_LOAI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLLS_NhapNoiDung;
        private System.Windows.Forms.Label lbl_index;
        private Guna.UI2.WinForms.Guna2ComboBox cb_QLLS_Selected;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btn_QLLS_Re;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_QLLS;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLLS_MA_LOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLLS_TENLOAI;
    }
}