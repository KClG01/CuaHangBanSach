namespace AppGUI
{
    partial class FormQuanLySach
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
            this.pn_QLS_dgv = new System.Windows.Forms.Panel();
            this.dgvw_QLS = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cln_QLS_MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLS_TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLS_NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLS_TACGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLS_LOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLS_GIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLS_GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLS_SLTON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_fn = new System.Windows.Forms.Panel();
            this.btn_QLS_Search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLS_Del = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLS_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLS_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.txt_QLS_TENSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLS_GIABAN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLS_GIANHAP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_QLS_LOAISACH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel_function = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_QLS_SLTON = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txt_QLS_TACGIA = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_QLS_NXB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_QLS_MASP = new Guna.UI2.WinForms.Guna2TextBox();
            this.pn_QLS_dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_QLS)).BeginInit();
            this.pn_fn.SuspendLayout();
            this.panel_function.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_QLS_SLTON)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_QLS_dgv
            // 
            this.pn_QLS_dgv.Controls.Add(this.dgvw_QLS);
            this.pn_QLS_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_QLS_dgv.Location = new System.Drawing.Point(0, 0);
            this.pn_QLS_dgv.Name = "pn_QLS_dgv";
            this.pn_QLS_dgv.Size = new System.Drawing.Size(1632, 1080);
            this.pn_QLS_dgv.TabIndex = 3;
            // 
            // dgvw_QLS
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvw_QLS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvw_QLS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvw_QLS.ColumnHeadersHeight = 34;
            this.dgvw_QLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvw_QLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_QLS_MASP,
            this.cln_QLS_TENSP,
            this.cln_QLS_NXB,
            this.cln_QLS_TACGIA,
            this.cln_QLS_LOAI,
            this.cln_QLS_GIANHAP,
            this.cln_QLS_GIABAN,
            this.cln_QLS_SLTON});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvw_QLS.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvw_QLS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvw_QLS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvw_QLS.Location = new System.Drawing.Point(0, 0);
            this.dgvw_QLS.MultiSelect = false;
            this.dgvw_QLS.Name = "dgvw_QLS";
            this.dgvw_QLS.RowHeadersVisible = false;
            this.dgvw_QLS.RowHeadersWidth = 51;
            this.dgvw_QLS.RowTemplate.Height = 24;
            this.dgvw_QLS.Size = new System.Drawing.Size(1632, 1080);
            this.dgvw_QLS.TabIndex = 0;
            this.dgvw_QLS.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvw_QLS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvw_QLS.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvw_QLS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvw_QLS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvw_QLS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvw_QLS.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvw_QLS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvw_QLS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvw_QLS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvw_QLS.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvw_QLS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvw_QLS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvw_QLS.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvw_QLS.ThemeStyle.ReadOnly = false;
            this.dgvw_QLS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvw_QLS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvw_QLS.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvw_QLS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvw_QLS.ThemeStyle.RowsStyle.Height = 24;
            this.dgvw_QLS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvw_QLS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cln_QLS_MASP
            // 
            this.cln_QLS_MASP.DataPropertyName = "MASP";
            this.cln_QLS_MASP.HeaderText = "Mã sách";
            this.cln_QLS_MASP.MinimumWidth = 6;
            this.cln_QLS_MASP.Name = "cln_QLS_MASP";
            // 
            // cln_QLS_TENSP
            // 
            this.cln_QLS_TENSP.DataPropertyName = "TENSP";
            this.cln_QLS_TENSP.HeaderText = "Tên sách";
            this.cln_QLS_TENSP.MinimumWidth = 6;
            this.cln_QLS_TENSP.Name = "cln_QLS_TENSP";
            // 
            // cln_QLS_NXB
            // 
            this.cln_QLS_NXB.DataPropertyName = "MA_NXB";
            this.cln_QLS_NXB.HeaderText = "Nhà xuất bản";
            this.cln_QLS_NXB.MinimumWidth = 6;
            this.cln_QLS_NXB.Name = "cln_QLS_NXB";
            // 
            // cln_QLS_TACGIA
            // 
            this.cln_QLS_TACGIA.DataPropertyName = "MA_TACGIA";
            this.cln_QLS_TACGIA.HeaderText = "Tác giả";
            this.cln_QLS_TACGIA.MinimumWidth = 6;
            this.cln_QLS_TACGIA.Name = "cln_QLS_TACGIA";
            // 
            // cln_QLS_LOAI
            // 
            this.cln_QLS_LOAI.DataPropertyName = "MA_LOAI";
            this.cln_QLS_LOAI.HeaderText = "Loại";
            this.cln_QLS_LOAI.MinimumWidth = 6;
            this.cln_QLS_LOAI.Name = "cln_QLS_LOAI";
            // 
            // cln_QLS_GIANHAP
            // 
            this.cln_QLS_GIANHAP.DataPropertyName = "GIANHAP";
            this.cln_QLS_GIANHAP.HeaderText = "Giá nhập";
            this.cln_QLS_GIANHAP.MinimumWidth = 6;
            this.cln_QLS_GIANHAP.Name = "cln_QLS_GIANHAP";
            // 
            // cln_QLS_GIABAN
            // 
            this.cln_QLS_GIABAN.DataPropertyName = "GIABAN";
            this.cln_QLS_GIABAN.HeaderText = "Giá bán";
            this.cln_QLS_GIABAN.MinimumWidth = 6;
            this.cln_QLS_GIABAN.Name = "cln_QLS_GIABAN";
            // 
            // cln_QLS_SLTON
            // 
            this.cln_QLS_SLTON.DataPropertyName = "SLTON";
            this.cln_QLS_SLTON.HeaderText = "Số lượng tồn";
            this.cln_QLS_SLTON.MinimumWidth = 6;
            this.cln_QLS_SLTON.Name = "cln_QLS_SLTON";
            // 
            // pn_fn
            // 
            this.pn_fn.BackColor = System.Drawing.Color.Transparent;
            this.pn_fn.Controls.Add(this.btn_QLS_Search);
            this.pn_fn.Controls.Add(this.btn_QLS_Del);
            this.pn_fn.Controls.Add(this.btn_QLS_Add);
            this.pn_fn.Controls.Add(this.btn_QLS_Edit);
            this.pn_fn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_fn.Location = new System.Drawing.Point(0, 954);
            this.pn_fn.Name = "pn_fn";
            this.pn_fn.Size = new System.Drawing.Size(288, 126);
            this.pn_fn.TabIndex = 5;
            // 
            // btn_QLS_Search
            // 
            this.btn_QLS_Search.BorderRadius = 10;
            this.btn_QLS_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLS_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLS_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLS_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLS_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLS_Search.ForeColor = System.Drawing.Color.White;
            this.btn_QLS_Search.Location = new System.Drawing.Point(17, 20);
            this.btn_QLS_Search.Name = "btn_QLS_Search";
            this.btn_QLS_Search.Size = new System.Drawing.Size(117, 30);
            this.btn_QLS_Search.TabIndex = 0;
            this.btn_QLS_Search.Text = "Tìm kiếm";
            // 
            // btn_QLS_Del
            // 
            this.btn_QLS_Del.BorderRadius = 10;
            this.btn_QLS_Del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLS_Del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLS_Del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLS_Del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLS_Del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLS_Del.ForeColor = System.Drawing.Color.White;
            this.btn_QLS_Del.Location = new System.Drawing.Point(154, 56);
            this.btn_QLS_Del.Name = "btn_QLS_Del";
            this.btn_QLS_Del.Size = new System.Drawing.Size(117, 30);
            this.btn_QLS_Del.TabIndex = 3;
            this.btn_QLS_Del.Text = "Xóa";
            // 
            // btn_QLS_Add
            // 
            this.btn_QLS_Add.BorderRadius = 10;
            this.btn_QLS_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLS_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLS_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLS_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLS_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLS_Add.ForeColor = System.Drawing.Color.White;
            this.btn_QLS_Add.Location = new System.Drawing.Point(154, 20);
            this.btn_QLS_Add.Name = "btn_QLS_Add";
            this.btn_QLS_Add.Size = new System.Drawing.Size(117, 30);
            this.btn_QLS_Add.TabIndex = 1;
            this.btn_QLS_Add.Text = "Thêm";
            // 
            // btn_QLS_Edit
            // 
            this.btn_QLS_Edit.BorderRadius = 10;
            this.btn_QLS_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLS_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLS_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLS_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLS_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLS_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_QLS_Edit.Location = new System.Drawing.Point(17, 56);
            this.btn_QLS_Edit.Name = "btn_QLS_Edit";
            this.btn_QLS_Edit.Size = new System.Drawing.Size(117, 30);
            this.btn_QLS_Edit.TabIndex = 2;
            this.btn_QLS_Edit.Text = "Sửa";
            // 
            // txt_QLS_TENSP
            // 
            this.txt_QLS_TENSP.BorderRadius = 2;
            this.txt_QLS_TENSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLS_TENSP.DefaultText = "";
            this.txt_QLS_TENSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLS_TENSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLS_TENSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLS_TENSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLS_TENSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLS_TENSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLS_TENSP.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLS_TENSP.ForeColor = System.Drawing.Color.Black;
            this.txt_QLS_TENSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLS_TENSP.Location = new System.Drawing.Point(16, 127);
            this.txt_QLS_TENSP.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLS_TENSP.Name = "txt_QLS_TENSP";
            this.txt_QLS_TENSP.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLS_TENSP.PlaceholderText = "Tên sách";
            this.txt_QLS_TENSP.SelectedText = "";
            this.txt_QLS_TENSP.Size = new System.Drawing.Size(255, 41);
            this.txt_QLS_TENSP.TabIndex = 7;
            // 
            // txt_QLS_GIABAN
            // 
            this.txt_QLS_GIABAN.BorderRadius = 2;
            this.txt_QLS_GIABAN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLS_GIABAN.DefaultText = "";
            this.txt_QLS_GIABAN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLS_GIABAN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLS_GIABAN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLS_GIABAN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLS_GIABAN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLS_GIABAN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLS_GIABAN.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLS_GIABAN.ForeColor = System.Drawing.Color.Black;
            this.txt_QLS_GIABAN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLS_GIABAN.Location = new System.Drawing.Point(16, 510);
            this.txt_QLS_GIABAN.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLS_GIABAN.Name = "txt_QLS_GIABAN";
            this.txt_QLS_GIABAN.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLS_GIABAN.PlaceholderText = "Giá bán";
            this.txt_QLS_GIABAN.SelectedText = "";
            this.txt_QLS_GIABAN.Size = new System.Drawing.Size(255, 41);
            this.txt_QLS_GIABAN.TabIndex = 12;
            // 
            // txt_QLS_GIANHAP
            // 
            this.txt_QLS_GIANHAP.BorderRadius = 2;
            this.txt_QLS_GIANHAP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLS_GIANHAP.DefaultText = "";
            this.txt_QLS_GIANHAP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLS_GIANHAP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLS_GIANHAP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLS_GIANHAP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLS_GIANHAP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLS_GIANHAP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLS_GIANHAP.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLS_GIANHAP.ForeColor = System.Drawing.Color.Black;
            this.txt_QLS_GIANHAP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLS_GIANHAP.Location = new System.Drawing.Point(16, 428);
            this.txt_QLS_GIANHAP.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLS_GIANHAP.Name = "txt_QLS_GIANHAP";
            this.txt_QLS_GIANHAP.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLS_GIANHAP.PlaceholderText = "Giá nhập";
            this.txt_QLS_GIANHAP.SelectedText = "";
            this.txt_QLS_GIANHAP.Size = new System.Drawing.Size(255, 41);
            this.txt_QLS_GIANHAP.TabIndex = 11;
            // 
            // txt_QLS_LOAISACH
            // 
            this.txt_QLS_LOAISACH.BackColor = System.Drawing.Color.Transparent;
            this.txt_QLS_LOAISACH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_QLS_LOAISACH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_QLS_LOAISACH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLS_LOAISACH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLS_LOAISACH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_QLS_LOAISACH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_QLS_LOAISACH.ItemHeight = 30;
            this.txt_QLS_LOAISACH.Location = new System.Drawing.Point(17, 353);
            this.txt_QLS_LOAISACH.Name = "txt_QLS_LOAISACH";
            this.txt_QLS_LOAISACH.Size = new System.Drawing.Size(255, 36);
            this.txt_QLS_LOAISACH.TabIndex = 10;
            // 
            // panel_function
            // 
            this.panel_function.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel_function.Controls.Add(this.label8);
            this.panel_function.Controls.Add(this.label7);
            this.panel_function.Controls.Add(this.label6);
            this.panel_function.Controls.Add(this.label5);
            this.panel_function.Controls.Add(this.label4);
            this.panel_function.Controls.Add(this.label3);
            this.panel_function.Controls.Add(this.label2);
            this.panel_function.Controls.Add(this.label1);
            this.panel_function.Controls.Add(this.txt_QLS_SLTON);
            this.panel_function.Controls.Add(this.txt_QLS_TACGIA);
            this.panel_function.Controls.Add(this.txt_QLS_NXB);
            this.panel_function.Controls.Add(this.txt_QLS_GIABAN);
            this.panel_function.Controls.Add(this.txt_QLS_GIANHAP);
            this.panel_function.Controls.Add(this.txt_QLS_LOAISACH);
            this.panel_function.Controls.Add(this.txt_QLS_TENSP);
            this.panel_function.Controls.Add(this.txt_QLS_MASP);
            this.panel_function.Controls.Add(this.pn_fn);
            this.panel_function.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_function.Location = new System.Drawing.Point(1632, 0);
            this.panel_function.Name = "panel_function";
            this.panel_function.Size = new System.Drawing.Size(288, 1080);
            this.panel_function.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(18, 564);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "Số lượng tồn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Giá nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Loại sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nhà xuất bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã sách";
            // 
            // txt_QLS_SLTON
            // 
            this.txt_QLS_SLTON.BackColor = System.Drawing.Color.Transparent;
            this.txt_QLS_SLTON.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLS_SLTON.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_QLS_SLTON.Location = new System.Drawing.Point(16, 591);
            this.txt_QLS_SLTON.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_QLS_SLTON.Name = "txt_QLS_SLTON";
            this.txt_QLS_SLTON.Size = new System.Drawing.Size(255, 41);
            this.txt_QLS_SLTON.TabIndex = 23;
            // 
            // txt_QLS_TACGIA
            // 
            this.txt_QLS_TACGIA.BackColor = System.Drawing.Color.Transparent;
            this.txt_QLS_TACGIA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_QLS_TACGIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_QLS_TACGIA.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLS_TACGIA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLS_TACGIA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_QLS_TACGIA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_QLS_TACGIA.ItemHeight = 30;
            this.txt_QLS_TACGIA.Location = new System.Drawing.Point(16, 280);
            this.txt_QLS_TACGIA.Name = "txt_QLS_TACGIA";
            this.txt_QLS_TACGIA.Size = new System.Drawing.Size(255, 36);
            this.txt_QLS_TACGIA.TabIndex = 16;
            // 
            // txt_QLS_NXB
            // 
            this.txt_QLS_NXB.BackColor = System.Drawing.Color.Transparent;
            this.txt_QLS_NXB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_QLS_NXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_QLS_NXB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLS_NXB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLS_NXB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_QLS_NXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_QLS_NXB.ItemHeight = 30;
            this.txt_QLS_NXB.Location = new System.Drawing.Point(16, 207);
            this.txt_QLS_NXB.Name = "txt_QLS_NXB";
            this.txt_QLS_NXB.Size = new System.Drawing.Size(255, 36);
            this.txt_QLS_NXB.TabIndex = 14;
            // 
            // txt_QLS_MASP
            // 
            this.txt_QLS_MASP.BorderRadius = 2;
            this.txt_QLS_MASP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QLS_MASP.DefaultText = "";
            this.txt_QLS_MASP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_QLS_MASP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_QLS_MASP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLS_MASP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_QLS_MASP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_QLS_MASP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLS_MASP.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_QLS_MASP.ForeColor = System.Drawing.Color.Black;
            this.txt_QLS_MASP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_QLS_MASP.Location = new System.Drawing.Point(16, 45);
            this.txt_QLS_MASP.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLS_MASP.Name = "txt_QLS_MASP";
            this.txt_QLS_MASP.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLS_MASP.PlaceholderText = "Mã sách";
            this.txt_QLS_MASP.SelectedText = "";
            this.txt_QLS_MASP.Size = new System.Drawing.Size(255, 41);
            this.txt_QLS_MASP.TabIndex = 6;
            // 
            // FormQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pn_QLS_dgv);
            this.Controls.Add(this.panel_function);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLySach";
            this.pn_QLS_dgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_QLS)).EndInit();
            this.pn_fn.ResumeLayout(false);
            this.panel_function.ResumeLayout(false);
            this.panel_function.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_QLS_SLTON)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_QLS_dgv;
        private Guna.UI2.WinForms.Guna2DataGridView dgvw_QLS;
        private System.Windows.Forms.Panel pn_fn;
        private Guna.UI2.WinForms.Guna2Button btn_QLS_Search;
        private Guna.UI2.WinForms.Guna2Button btn_QLS_Del;
        private Guna.UI2.WinForms.Guna2Button btn_QLS_Add;
        private Guna.UI2.WinForms.Guna2Button btn_QLS_Edit;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLS_TENSP;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLS_GIABAN;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLS_GIANHAP;
        private Guna.UI2.WinForms.Guna2ComboBox txt_QLS_LOAISACH;
        private System.Windows.Forms.Panel panel_function;
        private Guna.UI2.WinForms.Guna2TextBox txt_QLS_MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLS_MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLS_TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLS_NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLS_TACGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLS_LOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLS_GIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLS_GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLS_SLTON;
        private Guna.UI2.WinForms.Guna2ComboBox txt_QLS_TACGIA;
        private Guna.UI2.WinForms.Guna2ComboBox txt_QLS_NXB;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_QLS_SLTON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}