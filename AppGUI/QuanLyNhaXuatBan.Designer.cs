namespace AppGUI
{
    partial class FormQuanLyNhaXuatBan
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
            this.dgvw_QLNXB = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cln_QLNXB_MANXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLNXB_TENNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLNXB_LIENHE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLNXB_DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_QLLS_dgv = new System.Windows.Forms.Panel();
            this.txt_QLNXB_TENNXB = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_function = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_QLNXB_Re = new Guna.UI2.WinForms.Guna2Button();
            this.txt_QLNXB_NhapNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_QLNXB_Selected = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_QLNXB_Del = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLNXB_Search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLNXB_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLNXB_Add = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_QLNXB_DIACHI = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLNXB_LIENHE = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLNXB_MANXB = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_QLNXB)).BeginInit();
            this.pn_QLLS_dgv.SuspendLayout();
            this.panel_function.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvw_QLNXB
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgvw_QLNXB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvw_QLNXB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvw_QLNXB.ColumnHeadersHeight = 34;
            this.dgvw_QLNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvw_QLNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_QLNXB_MANXB,
            this.cln_QLNXB_TENNXB,
            this.cln_QLNXB_LIENHE,
            this.cln_QLNXB_DIACHI});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvw_QLNXB.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvw_QLNXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvw_QLNXB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgvw_QLNXB.Location = new System.Drawing.Point(0, 0);
            this.dgvw_QLNXB.MultiSelect = false;
            this.dgvw_QLNXB.Name = "dgvw_QLNXB";
            this.dgvw_QLNXB.RowHeadersVisible = false;
            this.dgvw_QLNXB.RowHeadersWidth = 51;
            this.dgvw_QLNXB.RowTemplate.Height = 24;
            this.dgvw_QLNXB.Size = new System.Drawing.Size(1601, 577);
            this.dgvw_QLNXB.TabIndex = 0;
            this.dgvw_QLNXB.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.dgvw_QLNXB.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgvw_QLNXB.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvw_QLNXB.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvw_QLNXB.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvw_QLNXB.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvw_QLNXB.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvw_QLNXB.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgvw_QLNXB.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.dgvw_QLNXB.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvw_QLNXB.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvw_QLNXB.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvw_QLNXB.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvw_QLNXB.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvw_QLNXB.ThemeStyle.ReadOnly = false;
            this.dgvw_QLNXB.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.dgvw_QLNXB.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvw_QLNXB.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvw_QLNXB.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvw_QLNXB.ThemeStyle.RowsStyle.Height = 24;
            this.dgvw_QLNXB.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.dgvw_QLNXB.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cln_QLNXB_MANXB
            // 
            this.cln_QLNXB_MANXB.DataPropertyName = "MA_NXB";
            this.cln_QLNXB_MANXB.HeaderText = "Mã nhà xuất bản";
            this.cln_QLNXB_MANXB.MinimumWidth = 6;
            this.cln_QLNXB_MANXB.Name = "cln_QLNXB_MANXB";
            // 
            // cln_QLNXB_TENNXB
            // 
            this.cln_QLNXB_TENNXB.DataPropertyName = "TEN_NXB";
            this.cln_QLNXB_TENNXB.HeaderText = "Tên nhà xuất bản";
            this.cln_QLNXB_TENNXB.MinimumWidth = 6;
            this.cln_QLNXB_TENNXB.Name = "cln_QLNXB_TENNXB";
            // 
            // cln_QLNXB_LIENHE
            // 
            this.cln_QLNXB_LIENHE.DataPropertyName = "LIENHE";
            this.cln_QLNXB_LIENHE.HeaderText = "Liên hệ";
            this.cln_QLNXB_LIENHE.MinimumWidth = 6;
            this.cln_QLNXB_LIENHE.Name = "cln_QLNXB_LIENHE";
            // 
            // cln_QLNXB_DIACHI
            // 
            this.cln_QLNXB_DIACHI.DataPropertyName = "DIACHI";
            this.cln_QLNXB_DIACHI.HeaderText = "Địa chỉ";
            this.cln_QLNXB_DIACHI.MinimumWidth = 6;
            this.cln_QLNXB_DIACHI.Name = "cln_QLNXB_DIACHI";
            // 
            // pn_QLLS_dgv
            // 
            this.pn_QLLS_dgv.Controls.Add(this.dgvw_QLNXB);
            this.pn_QLLS_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_QLLS_dgv.Location = new System.Drawing.Point(0, 463);
            this.pn_QLLS_dgv.Name = "pn_QLLS_dgv";
            this.pn_QLLS_dgv.Size = new System.Drawing.Size(1601, 577);
            this.pn_QLLS_dgv.TabIndex = 7;
            // 
            // txt_QLNXB_TENNXB
            // 
            this.txt_QLNXB_TENNXB.BorderRadius = 2;
            this.txt_QLNXB_TENNXB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLNXB_TENNXB.DefaultText = "";
            this.txt_QLNXB_TENNXB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLNXB_TENNXB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLNXB_TENNXB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNXB_TENNXB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNXB_TENNXB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLNXB_TENNXB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNXB_TENNXB.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLNXB_TENNXB.ForeColor = System.Drawing.Color.Black;
            this.txt_QLNXB_TENNXB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNXB_TENNXB.Location = new System.Drawing.Point(945, 99);
            this.txt_QLNXB_TENNXB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLNXB_TENNXB.Name = "txt_QLNXB_TENNXB";
            this.txt_QLNXB_TENNXB.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLNXB_TENNXB.PlaceholderText = "Tên nhà xuất bản";
            this.txt_QLNXB_TENNXB.SelectedText = "";
            this.txt_QLNXB_TENNXB.Size = new System.Drawing.Size(255, 40);
            this.txt_QLNXB_TENNXB.TabIndex = 7;
            // 
            // panel_function
            // 
            this.panel_function.BackColor = System.Drawing.Color.White;
            this.panel_function.Controls.Add(this.label10);
            this.panel_function.Controls.Add(this.btn_QLNXB_Re);
            this.panel_function.Controls.Add(this.txt_QLNXB_NhapNoiDung);
            this.panel_function.Controls.Add(this.label9);
            this.panel_function.Controls.Add(this.cb_QLNXB_Selected);
            this.panel_function.Controls.Add(this.label8);
            this.panel_function.Controls.Add(this.btn_QLNXB_Del);
            this.panel_function.Controls.Add(this.btn_QLNXB_Search);
            this.panel_function.Controls.Add(this.btn_QLNXB_Edit);
            this.panel_function.Controls.Add(this.btn_QLNXB_Add);
            this.panel_function.Controls.Add(this.label3);
            this.panel_function.Controls.Add(this.label2);
            this.panel_function.Controls.Add(this.label1);
            this.panel_function.Controls.Add(this.label5);
            this.panel_function.Controls.Add(this.txt_QLNXB_DIACHI);
            this.panel_function.Controls.Add(this.txt_QLNXB_LIENHE);
            this.panel_function.Controls.Add(this.txt_QLNXB_TENNXB);
            this.panel_function.Controls.Add(this.txt_QLNXB_MANXB);
            this.panel_function.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_function.Location = new System.Drawing.Point(0, 0);
            this.panel_function.Name = "panel_function";
            this.panel_function.Size = new System.Drawing.Size(1601, 463);
            this.panel_function.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(475, 59);
            this.label10.TabIndex = 59;
            this.label10.Text = "Quản lý nhà xuất bản";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_QLNXB_Re
            // 
            this.btn_QLNXB_Re.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNXB_Re.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNXB_Re.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLNXB_Re.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLNXB_Re.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNXB_Re.ForeColor = System.Drawing.Color.White;
            this.btn_QLNXB_Re.Location = new System.Drawing.Point(681, 319);
            this.btn_QLNXB_Re.Name = "btn_QLNXB_Re";
            this.btn_QLNXB_Re.Size = new System.Drawing.Size(150, 60);
            this.btn_QLNXB_Re.TabIndex = 57;
            this.btn_QLNXB_Re.Text = "Tạo mới";
            // 
            // txt_QLNXB_NhapNoiDung
            // 
            this.txt_QLNXB_NhapNoiDung.Animated = true;
            this.txt_QLNXB_NhapNoiDung.BorderRadius = 2;
            this.txt_QLNXB_NhapNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLNXB_NhapNoiDung.DefaultText = "";
            this.txt_QLNXB_NhapNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLNXB_NhapNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLNXB_NhapNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNXB_NhapNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNXB_NhapNoiDung.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLNXB_NhapNoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNXB_NhapNoiDung.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLNXB_NhapNoiDung.ForeColor = System.Drawing.Color.Black;
            this.txt_QLNXB_NhapNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNXB_NhapNoiDung.Location = new System.Drawing.Point(1107, 396);
            this.txt_QLNXB_NhapNoiDung.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLNXB_NhapNoiDung.Name = "txt_QLNXB_NhapNoiDung";
            this.txt_QLNXB_NhapNoiDung.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLNXB_NhapNoiDung.PlaceholderText = "";
            this.txt_QLNXB_NhapNoiDung.SelectedText = "";
            this.txt_QLNXB_NhapNoiDung.Size = new System.Drawing.Size(220, 40);
            this.txt_QLNXB_NhapNoiDung.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(922, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 28);
            this.label9.TabIndex = 55;
            this.label9.Text = "Nhập nội dung:";
            // 
            // cb_QLNXB_Selected
            // 
            this.cb_QLNXB_Selected.BackColor = System.Drawing.Color.Transparent;
            this.cb_QLNXB_Selected.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_QLNXB_Selected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_QLNXB_Selected.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_QLNXB_Selected.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_QLNXB_Selected.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_QLNXB_Selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_QLNXB_Selected.ItemHeight = 30;
            this.cb_QLNXB_Selected.Location = new System.Drawing.Point(1107, 322);
            this.cb_QLNXB_Selected.Name = "cb_QLNXB_Selected";
            this.cb_QLNXB_Selected.Size = new System.Drawing.Size(220, 36);
            this.cb_QLNXB_Selected.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(922, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 28);
            this.label8.TabIndex = 53;
            this.label8.Text = "Tìm kiếm theo:";
            // 
            // btn_QLNXB_Del
            // 
            this.btn_QLNXB_Del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNXB_Del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNXB_Del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLNXB_Del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLNXB_Del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNXB_Del.ForeColor = System.Drawing.Color.White;
            this.btn_QLNXB_Del.Location = new System.Drawing.Point(480, 319);
            this.btn_QLNXB_Del.Name = "btn_QLNXB_Del";
            this.btn_QLNXB_Del.Size = new System.Drawing.Size(150, 60);
            this.btn_QLNXB_Del.TabIndex = 52;
            this.btn_QLNXB_Del.Text = "Xóa";
            // 
            // btn_QLNXB_Search
            // 
            this.btn_QLNXB_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNXB_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNXB_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLNXB_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLNXB_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNXB_Search.ForeColor = System.Drawing.Color.White;
            this.btn_QLNXB_Search.Location = new System.Drawing.Point(1333, 396);
            this.btn_QLNXB_Search.Name = "btn_QLNXB_Search";
            this.btn_QLNXB_Search.Size = new System.Drawing.Size(120, 40);
            this.btn_QLNXB_Search.TabIndex = 49;
            this.btn_QLNXB_Search.Text = "Tìm kiếm";
            // 
            // btn_QLNXB_Edit
            // 
            this.btn_QLNXB_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNXB_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNXB_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLNXB_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLNXB_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNXB_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_QLNXB_Edit.Location = new System.Drawing.Point(278, 319);
            this.btn_QLNXB_Edit.Name = "btn_QLNXB_Edit";
            this.btn_QLNXB_Edit.Size = new System.Drawing.Size(150, 60);
            this.btn_QLNXB_Edit.TabIndex = 51;
            this.btn_QLNXB_Edit.Text = "Sửa";
            // 
            // btn_QLNXB_Add
            // 
            this.btn_QLNXB_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNXB_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNXB_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLNXB_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLNXB_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNXB_Add.ForeColor = System.Drawing.Color.White;
            this.btn_QLNXB_Add.Location = new System.Drawing.Point(78, 319);
            this.btn_QLNXB_Add.Name = "btn_QLNXB_Add";
            this.btn_QLNXB_Add.Size = new System.Drawing.Size(150, 60);
            this.btn_QLNXB_Add.TabIndex = 50;
            this.btn_QLNXB_Add.Text = "Thêm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(830, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 37;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(312, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "Liên hệ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(728, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên nhà xuất bản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(220, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 28);
            this.label5.TabIndex = 34;
            this.label5.Text = "Mã nhà xuất bản:";
            // 
            // txt_QLNXB_DIACHI
            // 
            this.txt_QLNXB_DIACHI.BorderRadius = 2;
            this.txt_QLNXB_DIACHI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLNXB_DIACHI.DefaultText = "";
            this.txt_QLNXB_DIACHI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLNXB_DIACHI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLNXB_DIACHI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNXB_DIACHI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNXB_DIACHI.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLNXB_DIACHI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNXB_DIACHI.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLNXB_DIACHI.ForeColor = System.Drawing.Color.Black;
            this.txt_QLNXB_DIACHI.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNXB_DIACHI.Location = new System.Drawing.Point(945, 191);
            this.txt_QLNXB_DIACHI.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLNXB_DIACHI.Multiline = true;
            this.txt_QLNXB_DIACHI.Name = "txt_QLNXB_DIACHI";
            this.txt_QLNXB_DIACHI.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLNXB_DIACHI.PlaceholderText = "Địa chỉ";
            this.txt_QLNXB_DIACHI.SelectedText = "";
            this.txt_QLNXB_DIACHI.Size = new System.Drawing.Size(255, 74);
            this.txt_QLNXB_DIACHI.TabIndex = 9;
            // 
            // txt_QLNXB_LIENHE
            // 
            this.txt_QLNXB_LIENHE.BorderRadius = 2;
            this.txt_QLNXB_LIENHE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLNXB_LIENHE.DefaultText = "";
            this.txt_QLNXB_LIENHE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLNXB_LIENHE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLNXB_LIENHE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNXB_LIENHE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNXB_LIENHE.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLNXB_LIENHE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNXB_LIENHE.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLNXB_LIENHE.ForeColor = System.Drawing.Color.Black;
            this.txt_QLNXB_LIENHE.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNXB_LIENHE.Location = new System.Drawing.Point(426, 191);
            this.txt_QLNXB_LIENHE.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLNXB_LIENHE.Name = "txt_QLNXB_LIENHE";
            this.txt_QLNXB_LIENHE.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLNXB_LIENHE.PlaceholderText = "Liên hệ";
            this.txt_QLNXB_LIENHE.SelectedText = "";
            this.txt_QLNXB_LIENHE.Size = new System.Drawing.Size(255, 40);
            this.txt_QLNXB_LIENHE.TabIndex = 8;
            // 
            // txt_QLNXB_MANXB
            // 
            this.txt_QLNXB_MANXB.BorderRadius = 2;
            this.txt_QLNXB_MANXB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLNXB_MANXB.DefaultText = "";
            this.txt_QLNXB_MANXB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLNXB_MANXB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLNXB_MANXB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNXB_MANXB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLNXB_MANXB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLNXB_MANXB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNXB_MANXB.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLNXB_MANXB.ForeColor = System.Drawing.Color.Black;
            this.txt_QLNXB_MANXB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLNXB_MANXB.Location = new System.Drawing.Point(426, 99);
            this.txt_QLNXB_MANXB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLNXB_MANXB.Name = "txt_QLNXB_MANXB";
            this.txt_QLNXB_MANXB.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLNXB_MANXB.PlaceholderText = "Mã nhà xuất bản";
            this.txt_QLNXB_MANXB.SelectedText = "";
            this.txt_QLNXB_MANXB.Size = new System.Drawing.Size(255, 40);
            this.txt_QLNXB_MANXB.TabIndex = 6;
            // 
            // FormQuanLyNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 1040);
            this.Controls.Add(this.pn_QLLS_dgv);
            this.Controls.Add(this.panel_function);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyNhaXuatBan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_QLNXB)).EndInit();
            this.pn_QLLS_dgv.ResumeLayout(false);
            this.panel_function.ResumeLayout(false);
            this.panel_function.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvw_QLNXB;
        private System.Windows.Forms.Panel pn_QLLS_dgv;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLNXB_TENNXB;
        private System.Windows.Forms.Panel panel_function;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLNXB_MANXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLNXB_MANXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLNXB_TENNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLNXB_LIENHE;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLNXB_DIACHI;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLNXB_LIENHE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLNXB_DIACHI;
        private Guna.UI2.WinForms.Guna2Button btn_QLNXB_Re;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLNXB_NhapNoiDung;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cb_QLNXB_Selected;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btn_QLNXB_Del;
        private Guna.UI2.WinForms.Guna2Button btn_QLNXB_Search;
        private Guna.UI2.WinForms.Guna2Button btn_QLNXB_Edit;
        private Guna.UI2.WinForms.Guna2Button btn_QLNXB_Add;
        private System.Windows.Forms.Label label10;
    }
}