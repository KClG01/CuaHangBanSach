namespace AppGUI
{
    partial class FormQuanLyTacGia
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
            this.dgv_QLTG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cln_QLTG_MATG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLTG_TENTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLTG_BUTDANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLTG_NGSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLTG_LIENHE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLTG_DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_QLLS_dgv = new System.Windows.Forms.Panel();
            this.txt_QLTG_TENTG = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_function = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_QLTG_Re = new Guna.UI2.WinForms.Guna2Button();
            this.txt_QLTG_NhapNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_QLTG_Selected = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_QLTG_Del = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLTG_Search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLTG_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLTG_Add = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_QLTG_NGSINH = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_QLTG_BUTDANH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLTG_DIACHI = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLTG_LIENHE = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLTG_MATG = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLTG)).BeginInit();
            this.pn_QLLS_dgv.SuspendLayout();
            this.panel_function.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_QLTG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgv_QLTG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_QLTG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_QLTG.ColumnHeadersHeight = 34;
            this.dgv_QLTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_QLTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_QLTG_MATG,
            this.cln_QLTG_TENTG,
            this.cln_QLTG_BUTDANH,
            this.cln_QLTG_NGSINH,
            this.cln_QLTG_LIENHE,
            this.cln_QLTG_DIACHI});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_QLTG.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_QLTG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_QLTG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_QLTG.Location = new System.Drawing.Point(0, 0);
            this.dgv_QLTG.MultiSelect = false;
            this.dgv_QLTG.Name = "dgv_QLTG";
            this.dgv_QLTG.RowHeadersVisible = false;
            this.dgv_QLTG.RowHeadersWidth = 51;
            this.dgv_QLTG.RowTemplate.Height = 24;
            this.dgv_QLTG.Size = new System.Drawing.Size(1601, 549);
            this.dgv_QLTG.TabIndex = 0;
            this.dgv_QLTG.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.dgv_QLTG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgv_QLTG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_QLTG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_QLTG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_QLTG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_QLTG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_QLTG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgv_QLTG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.dgv_QLTG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_QLTG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_QLTG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_QLTG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_QLTG.ThemeStyle.HeaderStyle.Height = 34;
            this.dgv_QLTG.ThemeStyle.ReadOnly = false;
            this.dgv_QLTG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.dgv_QLTG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_QLTG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_QLTG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_QLTG.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_QLTG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.dgv_QLTG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cln_QLTG_MATG
            // 
            this.cln_QLTG_MATG.DataPropertyName = "MA_TG";
            this.cln_QLTG_MATG.HeaderText = "Mã tác giả";
            this.cln_QLTG_MATG.MinimumWidth = 6;
            this.cln_QLTG_MATG.Name = "cln_QLTG_MATG";
            // 
            // cln_QLTG_TENTG
            // 
            this.cln_QLTG_TENTG.DataPropertyName = "TENTG";
            this.cln_QLTG_TENTG.HeaderText = "Tên tác giả";
            this.cln_QLTG_TENTG.MinimumWidth = 6;
            this.cln_QLTG_TENTG.Name = "cln_QLTG_TENTG";
            // 
            // cln_QLTG_BUTDANH
            // 
            this.cln_QLTG_BUTDANH.DataPropertyName = "BUTDANH";
            this.cln_QLTG_BUTDANH.HeaderText = "Bút danh";
            this.cln_QLTG_BUTDANH.MinimumWidth = 6;
            this.cln_QLTG_BUTDANH.Name = "cln_QLTG_BUTDANH";
            // 
            // cln_QLTG_NGSINH
            // 
            this.cln_QLTG_NGSINH.DataPropertyName = "NGSINH";
            this.cln_QLTG_NGSINH.HeaderText = "Ngày sinh";
            this.cln_QLTG_NGSINH.MinimumWidth = 6;
            this.cln_QLTG_NGSINH.Name = "cln_QLTG_NGSINH";
            // 
            // cln_QLTG_LIENHE
            // 
            this.cln_QLTG_LIENHE.DataPropertyName = "LIENHE";
            this.cln_QLTG_LIENHE.HeaderText = "Liên hệ";
            this.cln_QLTG_LIENHE.MinimumWidth = 6;
            this.cln_QLTG_LIENHE.Name = "cln_QLTG_LIENHE";
            // 
            // cln_QLTG_DIACHI
            // 
            this.cln_QLTG_DIACHI.DataPropertyName = "DIACHI";
            this.cln_QLTG_DIACHI.HeaderText = "Địa chỉ";
            this.cln_QLTG_DIACHI.MinimumWidth = 6;
            this.cln_QLTG_DIACHI.Name = "cln_QLTG_DIACHI";
            // 
            // pn_QLLS_dgv
            // 
            this.pn_QLLS_dgv.Controls.Add(this.dgv_QLTG);
            this.pn_QLLS_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_QLLS_dgv.Location = new System.Drawing.Point(0, 491);
            this.pn_QLLS_dgv.Name = "pn_QLLS_dgv";
            this.pn_QLLS_dgv.Size = new System.Drawing.Size(1601, 549);
            this.pn_QLLS_dgv.TabIndex = 9;
            // 
            // txt_QLTG_TENTG
            // 
            this.txt_QLTG_TENTG.Animated = true;
            this.txt_QLTG_TENTG.BorderRadius = 2;
            this.txt_QLTG_TENTG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLTG_TENTG.DefaultText = "";
            this.txt_QLTG_TENTG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLTG_TENTG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLTG_TENTG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLTG_TENTG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLTG_TENTG.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLTG_TENTG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLTG_TENTG.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLTG_TENTG.ForeColor = System.Drawing.Color.Black;
            this.txt_QLTG_TENTG.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLTG_TENTG.Location = new System.Drawing.Point(681, 95);
            this.txt_QLTG_TENTG.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLTG_TENTG.Name = "txt_QLTG_TENTG";
            this.txt_QLTG_TENTG.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLTG_TENTG.PlaceholderText = "Tên tác giả";
            this.txt_QLTG_TENTG.SelectedText = "";
            this.txt_QLTG_TENTG.Size = new System.Drawing.Size(255, 40);
            this.txt_QLTG_TENTG.TabIndex = 7;
            // 
            // panel_function
            // 
            this.panel_function.BackColor = System.Drawing.Color.White;
            this.panel_function.Controls.Add(this.label11);
            this.panel_function.Controls.Add(this.btn_QLTG_Re);
            this.panel_function.Controls.Add(this.txt_QLTG_NhapNoiDung);
            this.panel_function.Controls.Add(this.label9);
            this.panel_function.Controls.Add(this.cb_QLTG_Selected);
            this.panel_function.Controls.Add(this.label8);
            this.panel_function.Controls.Add(this.btn_QLTG_Del);
            this.panel_function.Controls.Add(this.btn_QLTG_Search);
            this.panel_function.Controls.Add(this.btn_QLTG_Edit);
            this.panel_function.Controls.Add(this.btn_QLTG_Add);
            this.panel_function.Controls.Add(this.label6);
            this.panel_function.Controls.Add(this.label4);
            this.panel_function.Controls.Add(this.label3);
            this.panel_function.Controls.Add(this.label2);
            this.panel_function.Controls.Add(this.label1);
            this.panel_function.Controls.Add(this.label5);
            this.panel_function.Controls.Add(this.dtp_QLTG_NGSINH);
            this.panel_function.Controls.Add(this.txt_QLTG_BUTDANH);
            this.panel_function.Controls.Add(this.txt_QLTG_DIACHI);
            this.panel_function.Controls.Add(this.txt_QLTG_LIENHE);
            this.panel_function.Controls.Add(this.txt_QLTG_TENTG);
            this.panel_function.Controls.Add(this.txt_QLTG_MATG);
            this.panel_function.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_function.Location = new System.Drawing.Point(0, 0);
            this.panel_function.Name = "panel_function";
            this.panel_function.Size = new System.Drawing.Size(1601, 491);
            this.panel_function.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(338, 59);
            this.label11.TabIndex = 68;
            this.label11.Text = "Quản lý tác giả";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_QLTG_Re
            // 
            this.btn_QLTG_Re.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Re.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Re.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLTG_Re.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLTG_Re.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLTG_Re.ForeColor = System.Drawing.Color.White;
            this.btn_QLTG_Re.Location = new System.Drawing.Point(716, 356);
            this.btn_QLTG_Re.Name = "btn_QLTG_Re";
            this.btn_QLTG_Re.Size = new System.Drawing.Size(150, 60);
            this.btn_QLTG_Re.TabIndex = 66;
            this.btn_QLTG_Re.Text = "Tạo mới";
            // 
            // txt_QLTG_NhapNoiDung
            // 
            this.txt_QLTG_NhapNoiDung.Animated = true;
            this.txt_QLTG_NhapNoiDung.BorderRadius = 2;
            this.txt_QLTG_NhapNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLTG_NhapNoiDung.DefaultText = "";
            this.txt_QLTG_NhapNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLTG_NhapNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLTG_NhapNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLTG_NhapNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLTG_NhapNoiDung.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLTG_NhapNoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLTG_NhapNoiDung.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLTG_NhapNoiDung.ForeColor = System.Drawing.Color.Black;
            this.txt_QLTG_NhapNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLTG_NhapNoiDung.Location = new System.Drawing.Point(1120, 430);
            this.txt_QLTG_NhapNoiDung.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLTG_NhapNoiDung.Name = "txt_QLTG_NhapNoiDung";
            this.txt_QLTG_NhapNoiDung.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLTG_NhapNoiDung.PlaceholderText = "";
            this.txt_QLTG_NhapNoiDung.SelectedText = "";
            this.txt_QLTG_NhapNoiDung.Size = new System.Drawing.Size(255, 40);
            this.txt_QLTG_NhapNoiDung.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(935, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 28);
            this.label9.TabIndex = 64;
            this.label9.Text = "Nhập nội dung:";
            // 
            // cb_QLTG_Selected
            // 
            this.cb_QLTG_Selected.BackColor = System.Drawing.Color.Transparent;
            this.cb_QLTG_Selected.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_QLTG_Selected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_QLTG_Selected.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_QLTG_Selected.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_QLTG_Selected.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_QLTG_Selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_QLTG_Selected.ItemHeight = 30;
            this.cb_QLTG_Selected.Location = new System.Drawing.Point(1120, 356);
            this.cb_QLTG_Selected.Name = "cb_QLTG_Selected";
            this.cb_QLTG_Selected.Size = new System.Drawing.Size(255, 36);
            this.cb_QLTG_Selected.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(935, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 28);
            this.label8.TabIndex = 62;
            this.label8.Text = "Tìm kiếm theo:";
            // 
            // btn_QLTG_Del
            // 
            this.btn_QLTG_Del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLTG_Del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLTG_Del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLTG_Del.ForeColor = System.Drawing.Color.White;
            this.btn_QLTG_Del.Location = new System.Drawing.Point(515, 356);
            this.btn_QLTG_Del.Name = "btn_QLTG_Del";
            this.btn_QLTG_Del.Size = new System.Drawing.Size(150, 60);
            this.btn_QLTG_Del.TabIndex = 61;
            this.btn_QLTG_Del.Text = "Xóa";
            // 
            // btn_QLTG_Search
            // 
            this.btn_QLTG_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLTG_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLTG_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLTG_Search.ForeColor = System.Drawing.Color.White;
            this.btn_QLTG_Search.Location = new System.Drawing.Point(1381, 430);
            this.btn_QLTG_Search.Name = "btn_QLTG_Search";
            this.btn_QLTG_Search.Size = new System.Drawing.Size(120, 40);
            this.btn_QLTG_Search.TabIndex = 58;
            this.btn_QLTG_Search.Text = "Tìm kiếm";
            // 
            // btn_QLTG_Edit
            // 
            this.btn_QLTG_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLTG_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLTG_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLTG_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_QLTG_Edit.Location = new System.Drawing.Point(313, 356);
            this.btn_QLTG_Edit.Name = "btn_QLTG_Edit";
            this.btn_QLTG_Edit.Size = new System.Drawing.Size(150, 60);
            this.btn_QLTG_Edit.TabIndex = 60;
            this.btn_QLTG_Edit.Text = "Sửa";
            // 
            // btn_QLTG_Add
            // 
            this.btn_QLTG_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLTG_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLTG_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLTG_Add.ForeColor = System.Drawing.Color.White;
            this.btn_QLTG_Add.Location = new System.Drawing.Point(113, 356);
            this.btn_QLTG_Add.Name = "btn_QLTG_Add";
            this.btn_QLTG_Add.Size = new System.Drawing.Size(150, 60);
            this.btn_QLTG_Add.TabIndex = 59;
            this.btn_QLTG_Add.Text = "Thêm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1003, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 28);
            this.label6.TabIndex = 40;
            this.label6.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(558, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 39;
            this.label4.Text = "Liên hệ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(75, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(983, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 37;
            this.label2.Text = "Bút danh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(523, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tên tác giả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(75, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 28);
            this.label5.TabIndex = 35;
            this.label5.Text = "Mã tác giả:";
            // 
            // dtp_QLTG_NGSINH
            // 
            this.dtp_QLTG_NGSINH.Animated = true;
            this.dtp_QLTG_NGSINH.Checked = true;
            this.dtp_QLTG_NGSINH.FillColor = System.Drawing.Color.White;
            this.dtp_QLTG_NGSINH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_QLTG_NGSINH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_QLTG_NGSINH.Location = new System.Drawing.Point(223, 198);
            this.dtp_QLTG_NGSINH.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_QLTG_NGSINH.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_QLTG_NGSINH.Name = "dtp_QLTG_NGSINH";
            this.dtp_QLTG_NGSINH.Size = new System.Drawing.Size(255, 40);
            this.dtp_QLTG_NGSINH.TabIndex = 11;
            this.dtp_QLTG_NGSINH.Value = new System.DateTime(2025, 4, 8, 8, 55, 25, 913);
            // 
            // txt_QLTG_BUTDANH
            // 
            this.txt_QLTG_BUTDANH.Animated = true;
            this.txt_QLTG_BUTDANH.BorderRadius = 2;
            this.txt_QLTG_BUTDANH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLTG_BUTDANH.DefaultText = "";
            this.txt_QLTG_BUTDANH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLTG_BUTDANH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLTG_BUTDANH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLTG_BUTDANH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLTG_BUTDANH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLTG_BUTDANH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLTG_BUTDANH.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLTG_BUTDANH.ForeColor = System.Drawing.Color.Black;
            this.txt_QLTG_BUTDANH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLTG_BUTDANH.Location = new System.Drawing.Point(1120, 95);
            this.txt_QLTG_BUTDANH.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLTG_BUTDANH.Name = "txt_QLTG_BUTDANH";
            this.txt_QLTG_BUTDANH.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLTG_BUTDANH.PlaceholderText = "Bút danh";
            this.txt_QLTG_BUTDANH.SelectedText = "";
            this.txt_QLTG_BUTDANH.Size = new System.Drawing.Size(255, 40);
            this.txt_QLTG_BUTDANH.TabIndex = 10;
            // 
            // txt_QLTG_DIACHI
            // 
            this.txt_QLTG_DIACHI.Animated = true;
            this.txt_QLTG_DIACHI.BorderRadius = 2;
            this.txt_QLTG_DIACHI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLTG_DIACHI.DefaultText = "";
            this.txt_QLTG_DIACHI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLTG_DIACHI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLTG_DIACHI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLTG_DIACHI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLTG_DIACHI.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLTG_DIACHI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLTG_DIACHI.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLTG_DIACHI.ForeColor = System.Drawing.Color.Black;
            this.txt_QLTG_DIACHI.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLTG_DIACHI.Location = new System.Drawing.Point(1120, 198);
            this.txt_QLTG_DIACHI.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLTG_DIACHI.Multiline = true;
            this.txt_QLTG_DIACHI.Name = "txt_QLTG_DIACHI";
            this.txt_QLTG_DIACHI.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLTG_DIACHI.PlaceholderText = "Địa chỉ";
            this.txt_QLTG_DIACHI.SelectedText = "";
            this.txt_QLTG_DIACHI.Size = new System.Drawing.Size(255, 80);
            this.txt_QLTG_DIACHI.TabIndex = 9;
            // 
            // txt_QLTG_LIENHE
            // 
            this.txt_QLTG_LIENHE.Animated = true;
            this.txt_QLTG_LIENHE.BorderRadius = 2;
            this.txt_QLTG_LIENHE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLTG_LIENHE.DefaultText = "";
            this.txt_QLTG_LIENHE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLTG_LIENHE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLTG_LIENHE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLTG_LIENHE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLTG_LIENHE.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLTG_LIENHE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLTG_LIENHE.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLTG_LIENHE.ForeColor = System.Drawing.Color.Black;
            this.txt_QLTG_LIENHE.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLTG_LIENHE.Location = new System.Drawing.Point(681, 198);
            this.txt_QLTG_LIENHE.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLTG_LIENHE.Name = "txt_QLTG_LIENHE";
            this.txt_QLTG_LIENHE.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLTG_LIENHE.PlaceholderText = "Liên hệ";
            this.txt_QLTG_LIENHE.SelectedText = "";
            this.txt_QLTG_LIENHE.Size = new System.Drawing.Size(255, 40);
            this.txt_QLTG_LIENHE.TabIndex = 8;
            // 
            // txt_QLTG_MATG
            // 
            this.txt_QLTG_MATG.Animated = true;
            this.txt_QLTG_MATG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(179)))), ((int)(((byte)(204)))));
            this.txt_QLTG_MATG.BorderRadius = 2;
            this.txt_QLTG_MATG.BorderThickness = 0;
            this.txt_QLTG_MATG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLTG_MATG.DefaultText = "";
            this.txt_QLTG_MATG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLTG_MATG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLTG_MATG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLTG_MATG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLTG_MATG.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLTG_MATG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLTG_MATG.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLTG_MATG.ForeColor = System.Drawing.Color.Black;
            this.txt_QLTG_MATG.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLTG_MATG.Location = new System.Drawing.Point(232, 95);
            this.txt_QLTG_MATG.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLTG_MATG.Name = "txt_QLTG_MATG";
            this.txt_QLTG_MATG.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLTG_MATG.PlaceholderText = "Mã tác giả";
            this.txt_QLTG_MATG.SelectedText = "";
            this.txt_QLTG_MATG.Size = new System.Drawing.Size(255, 40);
            this.txt_QLTG_MATG.TabIndex = 6;
            // 
            // FormQuanLyTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 1040);
            this.Controls.Add(this.pn_QLLS_dgv);
            this.Controls.Add(this.panel_function);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyTacGia";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLTG)).EndInit();
            this.pn_QLLS_dgv.ResumeLayout(false);
            this.panel_function.ResumeLayout(false);
            this.panel_function.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_QLTG;
        private System.Windows.Forms.Panel pn_QLLS_dgv;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLTG_TENTG;
        private System.Windows.Forms.Panel panel_function;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLTG_DIACHI;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLTG_LIENHE;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLTG_MATG;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLTG_MATG;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLTG_TENTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLTG_BUTDANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLTG_NGSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLTG_LIENHE;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLTG_DIACHI;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLTG_BUTDANH;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_QLTG_NGSINH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btn_QLTG_Re;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLTG_NhapNoiDung;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cb_QLTG_Selected;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btn_QLTG_Del;
        private Guna.UI2.WinForms.Guna2Button btn_QLTG_Search;
        private Guna.UI2.WinForms.Guna2Button btn_QLTG_Edit;
        private Guna.UI2.WinForms.Guna2Button btn_QLTG_Add;
        private System.Windows.Forms.Label label11;
    }
}