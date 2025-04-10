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
            this.dgvw_QLKH = new Guna.UI2.WinForms.Guna2DataGridView();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_QLHD_THANHTIEN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLHD_TIENTRA = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLHD_NGAYTAO = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_QLHD_MAKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLHD_TIENNHAN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLHD_MANV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLHD_MAHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.pn_fn = new System.Windows.Forms.Panel();
            this.btn_QLHD_Search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLHD_Del = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLHD_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLHD_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_QLKH)).BeginInit();
            this.pn_QLLS_dgv.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_function.SuspendLayout();
            this.pn_fn.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvw_QLKH
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvw_QLKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvw_QLKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvw_QLKH.ColumnHeadersHeight = 34;
            this.dgvw_QLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvw_QLKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_QLHD_MAHD,
            this.cln_QLHD_MANV,
            this.cln_QLHD_MAKH,
            this.cln_QLHD_NGAYBAN,
            this.cln_QLHD_TIENNHAN,
            this.cln_QLHD_TIENTRA,
            this.cln_QLHD_THANHTIEN});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvw_QLKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvw_QLKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvw_QLKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvw_QLKH.Location = new System.Drawing.Point(0, 0);
            this.dgvw_QLKH.MultiSelect = false;
            this.dgvw_QLKH.Name = "dgvw_QLKH";
            this.dgvw_QLKH.ReadOnly = true;
            this.dgvw_QLKH.RowHeadersVisible = false;
            this.dgvw_QLKH.RowHeadersWidth = 51;
            this.dgvw_QLKH.RowTemplate.Height = 24;
            this.dgvw_QLKH.Size = new System.Drawing.Size(1632, 1080);
            this.dgvw_QLKH.TabIndex = 0;
            this.dgvw_QLKH.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvw_QLKH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvw_QLKH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvw_QLKH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvw_QLKH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvw_QLKH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvw_QLKH.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvw_QLKH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvw_QLKH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvw_QLKH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvw_QLKH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvw_QLKH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvw_QLKH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvw_QLKH.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvw_QLKH.ThemeStyle.ReadOnly = true;
            this.dgvw_QLKH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvw_QLKH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvw_QLKH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvw_QLKH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvw_QLKH.ThemeStyle.RowsStyle.Height = 24;
            this.dgvw_QLKH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvw_QLKH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            this.pn_QLLS_dgv.Size = new System.Drawing.Size(1920, 1080);
            this.pn_QLLS_dgv.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvw_QLKH);
            this.panel1.Controls.Add(this.panel_function);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 1080);
            this.panel1.TabIndex = 11;
            // 
            // panel_function
            // 
            this.panel_function.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel_function.Controls.Add(this.label7);
            this.panel_function.Controls.Add(this.label6);
            this.panel_function.Controls.Add(this.label5);
            this.panel_function.Controls.Add(this.label4);
            this.panel_function.Controls.Add(this.label3);
            this.panel_function.Controls.Add(this.label2);
            this.panel_function.Controls.Add(this.label1);
            this.panel_function.Controls.Add(this.txt_QLHD_THANHTIEN);
            this.panel_function.Controls.Add(this.txt_QLHD_TIENTRA);
            this.panel_function.Controls.Add(this.txt_QLHD_NGAYTAO);
            this.panel_function.Controls.Add(this.txt_QLHD_MAKH);
            this.panel_function.Controls.Add(this.txt_QLHD_TIENNHAN);
            this.panel_function.Controls.Add(this.txt_QLHD_MANV);
            this.panel_function.Controls.Add(this.txt_QLHD_MAHD);
            this.panel_function.Controls.Add(this.pn_fn);
            this.panel_function.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_function.Location = new System.Drawing.Point(1632, 0);
            this.panel_function.Name = "panel_function";
            this.panel_function.Size = new System.Drawing.Size(288, 1080);
            this.panel_function.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tiền nhận của khách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ngày lập hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txt_QLHD_THANHTIEN
            // 
            this.txt_QLHD_THANHTIEN.Animated = true;
            this.txt_QLHD_THANHTIEN.BorderRadius = 2;
            this.txt_QLHD_THANHTIEN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLHD_THANHTIEN.DefaultText = "";
            this.txt_QLHD_THANHTIEN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLHD_THANHTIEN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLHD_THANHTIEN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLHD_THANHTIEN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLHD_THANHTIEN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLHD_THANHTIEN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLHD_THANHTIEN.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLHD_THANHTIEN.ForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_THANHTIEN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLHD_THANHTIEN.Location = new System.Drawing.Point(15, 477);
            this.txt_QLHD_THANHTIEN.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLHD_THANHTIEN.Name = "txt_QLHD_THANHTIEN";
            this.txt_QLHD_THANHTIEN.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_THANHTIEN.PlaceholderText = "Thành tiền";
            this.txt_QLHD_THANHTIEN.SelectedText = "";
            this.txt_QLHD_THANHTIEN.Size = new System.Drawing.Size(255, 41);
            this.txt_QLHD_THANHTIEN.TabIndex = 13;
            // 
            // txt_QLHD_TIENTRA
            // 
            this.txt_QLHD_TIENTRA.Animated = true;
            this.txt_QLHD_TIENTRA.BorderRadius = 2;
            this.txt_QLHD_TIENTRA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLHD_TIENTRA.DefaultText = "";
            this.txt_QLHD_TIENTRA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLHD_TIENTRA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLHD_TIENTRA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLHD_TIENTRA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLHD_TIENTRA.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLHD_TIENTRA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLHD_TIENTRA.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLHD_TIENTRA.ForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_TIENTRA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLHD_TIENTRA.Location = new System.Drawing.Point(15, 403);
            this.txt_QLHD_TIENTRA.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLHD_TIENTRA.Name = "txt_QLHD_TIENTRA";
            this.txt_QLHD_TIENTRA.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_TIENTRA.PlaceholderText = "Tiền thối";
            this.txt_QLHD_TIENTRA.SelectedText = "";
            this.txt_QLHD_TIENTRA.Size = new System.Drawing.Size(255, 41);
            this.txt_QLHD_TIENTRA.TabIndex = 12;
            // 
            // txt_QLHD_NGAYTAO
            // 
            this.txt_QLHD_NGAYTAO.Animated = true;
            this.txt_QLHD_NGAYTAO.Checked = true;
            this.txt_QLHD_NGAYTAO.FillColor = System.Drawing.Color.White;
            this.txt_QLHD_NGAYTAO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_QLHD_NGAYTAO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_QLHD_NGAYTAO.Location = new System.Drawing.Point(16, 257);
            this.txt_QLHD_NGAYTAO.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_QLHD_NGAYTAO.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_QLHD_NGAYTAO.Name = "txt_QLHD_NGAYTAO";
            this.txt_QLHD_NGAYTAO.Size = new System.Drawing.Size(254, 41);
            this.txt_QLHD_NGAYTAO.TabIndex = 11;
            this.txt_QLHD_NGAYTAO.Value = new System.DateTime(2025, 4, 8, 8, 55, 25, 913);
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
            this.txt_QLHD_MAKH.Location = new System.Drawing.Point(16, 185);
            this.txt_QLHD_MAKH.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLHD_MAKH.Name = "txt_QLHD_MAKH";
            this.txt_QLHD_MAKH.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_MAKH.PlaceholderText = "Mã khách hàng";
            this.txt_QLHD_MAKH.SelectedText = "";
            this.txt_QLHD_MAKH.Size = new System.Drawing.Size(255, 41);
            this.txt_QLHD_MAKH.TabIndex = 10;
            // 
            // txt_QLHD_TIENNHAN
            // 
            this.txt_QLHD_TIENNHAN.Animated = true;
            this.txt_QLHD_TIENNHAN.BorderRadius = 2;
            this.txt_QLHD_TIENNHAN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLHD_TIENNHAN.DefaultText = "";
            this.txt_QLHD_TIENNHAN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLHD_TIENNHAN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLHD_TIENNHAN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLHD_TIENNHAN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLHD_TIENNHAN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLHD_TIENNHAN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLHD_TIENNHAN.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLHD_TIENNHAN.ForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_TIENNHAN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLHD_TIENNHAN.Location = new System.Drawing.Point(15, 329);
            this.txt_QLHD_TIENNHAN.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLHD_TIENNHAN.Name = "txt_QLHD_TIENNHAN";
            this.txt_QLHD_TIENNHAN.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_TIENNHAN.PlaceholderText = "Tiền nhận";
            this.txt_QLHD_TIENNHAN.SelectedText = "";
            this.txt_QLHD_TIENNHAN.Size = new System.Drawing.Size(255, 41);
            this.txt_QLHD_TIENNHAN.TabIndex = 8;
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
            this.txt_QLHD_MANV.Location = new System.Drawing.Point(17, 111);
            this.txt_QLHD_MANV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLHD_MANV.Name = "txt_QLHD_MANV";
            this.txt_QLHD_MANV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_MANV.PlaceholderText = "Mã nhân viên";
            this.txt_QLHD_MANV.SelectedText = "";
            this.txt_QLHD_MANV.Size = new System.Drawing.Size(255, 41);
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
            this.txt_QLHD_MAHD.Location = new System.Drawing.Point(17, 37);
            this.txt_QLHD_MAHD.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLHD_MAHD.Name = "txt_QLHD_MAHD";
            this.txt_QLHD_MAHD.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLHD_MAHD.PlaceholderText = "Mã hóa đơn";
            this.txt_QLHD_MAHD.SelectedText = "";
            this.txt_QLHD_MAHD.Size = new System.Drawing.Size(255, 41);
            this.txt_QLHD_MAHD.TabIndex = 6;
            // 
            // pn_fn
            // 
            this.pn_fn.BackColor = System.Drawing.Color.Transparent;
            this.pn_fn.Controls.Add(this.btn_QLHD_Search);
            this.pn_fn.Controls.Add(this.btn_QLHD_Del);
            this.pn_fn.Controls.Add(this.btn_QLHD_Add);
            this.pn_fn.Controls.Add(this.btn_QLHD_Edit);
            this.pn_fn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_fn.Location = new System.Drawing.Point(0, 954);
            this.pn_fn.Name = "pn_fn";
            this.pn_fn.Size = new System.Drawing.Size(288, 126);
            this.pn_fn.TabIndex = 5;
            // 
            // btn_QLHD_Search
            // 
            this.btn_QLHD_Search.BorderRadius = 10;
            this.btn_QLHD_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLHD_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLHD_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLHD_Search.ForeColor = System.Drawing.Color.White;
            this.btn_QLHD_Search.Location = new System.Drawing.Point(17, 20);
            this.btn_QLHD_Search.Name = "btn_QLHD_Search";
            this.btn_QLHD_Search.Size = new System.Drawing.Size(117, 30);
            this.btn_QLHD_Search.TabIndex = 0;
            this.btn_QLHD_Search.Text = "Tìm kiếm";
            // 
            // btn_QLHD_Del
            // 
            this.btn_QLHD_Del.BorderRadius = 10;
            this.btn_QLHD_Del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLHD_Del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLHD_Del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLHD_Del.ForeColor = System.Drawing.Color.White;
            this.btn_QLHD_Del.Location = new System.Drawing.Point(154, 56);
            this.btn_QLHD_Del.Name = "btn_QLHD_Del";
            this.btn_QLHD_Del.Size = new System.Drawing.Size(117, 30);
            this.btn_QLHD_Del.TabIndex = 3;
            this.btn_QLHD_Del.Text = "Xóa";
            // 
            // btn_QLHD_Add
            // 
            this.btn_QLHD_Add.BorderRadius = 10;
            this.btn_QLHD_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLHD_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLHD_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLHD_Add.ForeColor = System.Drawing.Color.White;
            this.btn_QLHD_Add.Location = new System.Drawing.Point(154, 20);
            this.btn_QLHD_Add.Name = "btn_QLHD_Add";
            this.btn_QLHD_Add.Size = new System.Drawing.Size(117, 30);
            this.btn_QLHD_Add.TabIndex = 1;
            this.btn_QLHD_Add.Text = "Thêm";
            // 
            // btn_QLHD_Edit
            // 
            this.btn_QLHD_Edit.BorderRadius = 10;
            this.btn_QLHD_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLHD_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLHD_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLHD_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLHD_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_QLHD_Edit.Location = new System.Drawing.Point(17, 56);
            this.btn_QLHD_Edit.Name = "btn_QLHD_Edit";
            this.btn_QLHD_Edit.Size = new System.Drawing.Size(117, 30);
            this.btn_QLHD_Edit.TabIndex = 2;
            this.btn_QLHD_Edit.Text = "Sửa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tiền thối cho khách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "Thành tiền";
            // 
            // FormQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pn_QLLS_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_QLKH)).EndInit();
            this.pn_QLLS_dgv.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_function.ResumeLayout(false);
            this.panel_function.PerformLayout();
            this.pn_fn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvw_QLKH;
        private System.Windows.Forms.Panel pn_QLLS_dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_function;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_QLHD_NGAYTAO;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLHD_MAKH;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLHD_TIENNHAN;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLHD_MANV;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLHD_MAHD;
        private System.Windows.Forms.Panel pn_fn;
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
        private Guna.UI2.WinForms.Guna2TextBox txt_QLHD_THANHTIEN;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLHD_TIENTRA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}