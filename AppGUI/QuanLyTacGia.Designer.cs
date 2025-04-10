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
            this.dgvw_QLTG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cln_QLTG_MATG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLTG_TENTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLTG_BUTDANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLTG_NGSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLTG_LIENHE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLTG_DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_QLLS_dgv = new System.Windows.Forms.Panel();
            this.pn_fn = new System.Windows.Forms.Panel();
            this.btn_QLTG_Search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLTG_Del = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLTG_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLTG_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.txt_QLTG_TENTG = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_function = new System.Windows.Forms.Panel();
            this.dtp_QLTG_NGSINH = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_QLTG_BUTDANH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLTG_DIACHI = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLTG_LIENHE = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLTG_MATG = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_QLTG)).BeginInit();
            this.pn_QLLS_dgv.SuspendLayout();
            this.pn_fn.SuspendLayout();
            this.panel_function.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvw_QLTG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvw_QLTG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvw_QLTG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvw_QLTG.ColumnHeadersHeight = 34;
            this.dgvw_QLTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvw_QLTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_QLTG_MATG,
            this.cln_QLTG_TENTG,
            this.cln_QLTG_BUTDANH,
            this.cln_QLTG_NGSINH,
            this.cln_QLTG_LIENHE,
            this.cln_QLTG_DIACHI});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvw_QLTG.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvw_QLTG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvw_QLTG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvw_QLTG.Location = new System.Drawing.Point(0, 0);
            this.dgvw_QLTG.MultiSelect = false;
            this.dgvw_QLTG.Name = "dgvw_QLTG";
            this.dgvw_QLTG.RowHeadersVisible = false;
            this.dgvw_QLTG.RowHeadersWidth = 51;
            this.dgvw_QLTG.RowTemplate.Height = 24;
            this.dgvw_QLTG.Size = new System.Drawing.Size(1632, 1080);
            this.dgvw_QLTG.TabIndex = 0;
            this.dgvw_QLTG.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvw_QLTG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvw_QLTG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvw_QLTG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvw_QLTG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvw_QLTG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvw_QLTG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvw_QLTG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvw_QLTG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvw_QLTG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvw_QLTG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvw_QLTG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvw_QLTG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvw_QLTG.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvw_QLTG.ThemeStyle.ReadOnly = false;
            this.dgvw_QLTG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvw_QLTG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvw_QLTG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvw_QLTG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvw_QLTG.ThemeStyle.RowsStyle.Height = 24;
            this.dgvw_QLTG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvw_QLTG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            this.pn_QLLS_dgv.Controls.Add(this.dgvw_QLTG);
            this.pn_QLLS_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_QLLS_dgv.Location = new System.Drawing.Point(0, 0);
            this.pn_QLLS_dgv.Name = "pn_QLLS_dgv";
            this.pn_QLLS_dgv.Size = new System.Drawing.Size(1632, 1080);
            this.pn_QLLS_dgv.TabIndex = 9;
            // 
            // pn_fn
            // 
            this.pn_fn.BackColor = System.Drawing.Color.Transparent;
            this.pn_fn.Controls.Add(this.btn_QLTG_Search);
            this.pn_fn.Controls.Add(this.btn_QLTG_Del);
            this.pn_fn.Controls.Add(this.btn_QLTG_Add);
            this.pn_fn.Controls.Add(this.btn_QLTG_Edit);
            this.pn_fn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_fn.Location = new System.Drawing.Point(0, 954);
            this.pn_fn.Name = "pn_fn";
            this.pn_fn.Size = new System.Drawing.Size(288, 126);
            this.pn_fn.TabIndex = 5;
            // 
            // btn_QLTG_Search
            // 
            this.btn_QLTG_Search.BorderRadius = 10;
            this.btn_QLTG_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLTG_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLTG_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLTG_Search.ForeColor = System.Drawing.Color.White;
            this.btn_QLTG_Search.Location = new System.Drawing.Point(17, 20);
            this.btn_QLTG_Search.Name = "btn_QLTG_Search";
            this.btn_QLTG_Search.Size = new System.Drawing.Size(117, 30);
            this.btn_QLTG_Search.TabIndex = 0;
            this.btn_QLTG_Search.Text = "Tìm kiếm";
            // 
            // btn_QLTG_Del
            // 
            this.btn_QLTG_Del.BorderRadius = 10;
            this.btn_QLTG_Del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLTG_Del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLTG_Del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLTG_Del.ForeColor = System.Drawing.Color.White;
            this.btn_QLTG_Del.Location = new System.Drawing.Point(154, 56);
            this.btn_QLTG_Del.Name = "btn_QLTG_Del";
            this.btn_QLTG_Del.Size = new System.Drawing.Size(117, 30);
            this.btn_QLTG_Del.TabIndex = 3;
            this.btn_QLTG_Del.Text = "Xóa";
            // 
            // btn_QLTG_Add
            // 
            this.btn_QLTG_Add.BorderRadius = 10;
            this.btn_QLTG_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLTG_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLTG_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLTG_Add.ForeColor = System.Drawing.Color.White;
            this.btn_QLTG_Add.Location = new System.Drawing.Point(154, 20);
            this.btn_QLTG_Add.Name = "btn_QLTG_Add";
            this.btn_QLTG_Add.Size = new System.Drawing.Size(117, 30);
            this.btn_QLTG_Add.TabIndex = 1;
            this.btn_QLTG_Add.Text = "Thêm";
            // 
            // btn_QLTG_Edit
            // 
            this.btn_QLTG_Edit.BorderRadius = 10;
            this.btn_QLTG_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTG_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLTG_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLTG_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLTG_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_QLTG_Edit.Location = new System.Drawing.Point(17, 56);
            this.btn_QLTG_Edit.Name = "btn_QLTG_Edit";
            this.btn_QLTG_Edit.Size = new System.Drawing.Size(117, 30);
            this.btn_QLTG_Edit.TabIndex = 2;
            this.btn_QLTG_Edit.Text = "Sửa";
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
            this.txt_QLTG_TENTG.Location = new System.Drawing.Point(16, 78);
            this.txt_QLTG_TENTG.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLTG_TENTG.Name = "txt_QLTG_TENTG";
            this.txt_QLTG_TENTG.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLTG_TENTG.PlaceholderText = "Tên tác giả";
            this.txt_QLTG_TENTG.SelectedText = "";
            this.txt_QLTG_TENTG.Size = new System.Drawing.Size(255, 41);
            this.txt_QLTG_TENTG.TabIndex = 7;
            // 
            // panel_function
            // 
            this.panel_function.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel_function.Controls.Add(this.dtp_QLTG_NGSINH);
            this.panel_function.Controls.Add(this.txt_QLTG_BUTDANH);
            this.panel_function.Controls.Add(this.txt_QLTG_DIACHI);
            this.panel_function.Controls.Add(this.txt_QLTG_LIENHE);
            this.panel_function.Controls.Add(this.txt_QLTG_TENTG);
            this.panel_function.Controls.Add(this.txt_QLTG_MATG);
            this.panel_function.Controls.Add(this.pn_fn);
            this.panel_function.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_function.Location = new System.Drawing.Point(1632, 0);
            this.panel_function.Name = "panel_function";
            this.panel_function.Size = new System.Drawing.Size(288, 1080);
            this.panel_function.TabIndex = 8;
            // 
            // dtp_QLTG_NGSINH
            // 
            this.dtp_QLTG_NGSINH.Animated = true;
            this.dtp_QLTG_NGSINH.Checked = true;
            this.dtp_QLTG_NGSINH.FillColor = System.Drawing.Color.White;
            this.dtp_QLTG_NGSINH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_QLTG_NGSINH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_QLTG_NGSINH.Location = new System.Drawing.Point(16, 202);
            this.dtp_QLTG_NGSINH.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_QLTG_NGSINH.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_QLTG_NGSINH.Name = "dtp_QLTG_NGSINH";
            this.dtp_QLTG_NGSINH.Size = new System.Drawing.Size(254, 41);
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
            this.txt_QLTG_BUTDANH.Location = new System.Drawing.Point(17, 141);
            this.txt_QLTG_BUTDANH.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLTG_BUTDANH.Name = "txt_QLTG_BUTDANH";
            this.txt_QLTG_BUTDANH.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLTG_BUTDANH.PlaceholderText = "Bút danh";
            this.txt_QLTG_BUTDANH.SelectedText = "";
            this.txt_QLTG_BUTDANH.Size = new System.Drawing.Size(255, 41);
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
            this.txt_QLTG_DIACHI.Location = new System.Drawing.Point(18, 326);
            this.txt_QLTG_DIACHI.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLTG_DIACHI.Name = "txt_QLTG_DIACHI";
            this.txt_QLTG_DIACHI.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLTG_DIACHI.PlaceholderText = "Địa chỉ";
            this.txt_QLTG_DIACHI.SelectedText = "";
            this.txt_QLTG_DIACHI.Size = new System.Drawing.Size(255, 253);
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
            this.txt_QLTG_LIENHE.Location = new System.Drawing.Point(17, 263);
            this.txt_QLTG_LIENHE.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLTG_LIENHE.Name = "txt_QLTG_LIENHE";
            this.txt_QLTG_LIENHE.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLTG_LIENHE.PlaceholderText = "Liên hệ";
            this.txt_QLTG_LIENHE.SelectedText = "";
            this.txt_QLTG_LIENHE.Size = new System.Drawing.Size(255, 41);
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
            this.txt_QLTG_MATG.Location = new System.Drawing.Point(16, 14);
            this.txt_QLTG_MATG.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLTG_MATG.Name = "txt_QLTG_MATG";
            this.txt_QLTG_MATG.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLTG_MATG.PlaceholderText = "Mã tác giả";
            this.txt_QLTG_MATG.SelectedText = "";
            this.txt_QLTG_MATG.Size = new System.Drawing.Size(255, 41);
            this.txt_QLTG_MATG.TabIndex = 6;
            // 
            // FormQuanLyTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pn_QLLS_dgv);
            this.Controls.Add(this.panel_function);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyTacGia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_QLTG)).EndInit();
            this.pn_QLLS_dgv.ResumeLayout(false);
            this.pn_fn.ResumeLayout(false);
            this.panel_function.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvw_QLTG;
        private System.Windows.Forms.Panel pn_QLLS_dgv;
        private System.Windows.Forms.Panel pn_fn;
        private Guna.UI2.WinForms.Guna2Button btn_QLTG_Search;
        private Guna.UI2.WinForms.Guna2Button btn_QLTG_Del;
        private Guna.UI2.WinForms.Guna2Button btn_QLTG_Add;
        private Guna.UI2.WinForms.Guna2Button btn_QLTG_Edit;
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
    }
}