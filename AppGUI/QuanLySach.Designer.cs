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
            this.btn_QLS_Xóa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLS_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLS_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_function = new System.Windows.Forms.Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pn_QLS_dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_QLS)).BeginInit();
            this.pn_fn.SuspendLayout();
            this.panel_function.SuspendLayout();
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
            this.pn_fn.Controls.Add(this.btn_QLS_Xóa);
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
            // btn_QLS_Xóa
            // 
            this.btn_QLS_Xóa.BorderRadius = 10;
            this.btn_QLS_Xóa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLS_Xóa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLS_Xóa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLS_Xóa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLS_Xóa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLS_Xóa.ForeColor = System.Drawing.Color.White;
            this.btn_QLS_Xóa.Location = new System.Drawing.Point(154, 56);
            this.btn_QLS_Xóa.Name = "btn_QLS_Xóa";
            this.btn_QLS_Xóa.Size = new System.Drawing.Size(117, 30);
            this.btn_QLS_Xóa.TabIndex = 3;
            this.btn_QLS_Xóa.Text = "Xóa";
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
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderRadius = 2;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(16, 78);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.PlaceholderText = "Tên sách";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(255, 41);
            this.guna2TextBox2.TabIndex = 7;
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.BorderRadius = 2;
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2TextBox6.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Location = new System.Drawing.Point(16, 418);
            this.guna2TextBox6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PlaceholderForeColor = System.Drawing.Color.Black;
            this.guna2TextBox6.PlaceholderText = "Giá bán";
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.Size = new System.Drawing.Size(255, 41);
            this.guna2TextBox6.TabIndex = 12;
            // 
            // guna2TextBox5
            // 
            this.guna2TextBox5.BorderRadius = 2;
            this.guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox5.DefaultText = "";
            this.guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2TextBox5.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.Location = new System.Drawing.Point(16, 346);
            this.guna2TextBox5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PlaceholderForeColor = System.Drawing.Color.Black;
            this.guna2TextBox5.PlaceholderText = "Giá nhập";
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.Size = new System.Drawing.Size(255, 41);
            this.guna2TextBox5.TabIndex = 11;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(16, 281);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(255, 36);
            this.guna2ComboBox1.TabIndex = 10;
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BorderRadius = 2;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2TextBox4.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Location = new System.Drawing.Point(16, 213);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PlaceholderForeColor = System.Drawing.Color.Black;
            this.guna2TextBox4.PlaceholderText = "Tác giả";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.Size = new System.Drawing.Size(255, 41);
            this.guna2TextBox4.TabIndex = 9;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.BorderRadius = 2;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2TextBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(16, 145);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.Black;
            this.guna2TextBox3.PlaceholderText = "Nhà xuất bản";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(255, 41);
            this.guna2TextBox3.TabIndex = 8;
            // 
            // panel_function
            // 
            this.panel_function.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel_function.Controls.Add(this.guna2TextBox6);
            this.panel_function.Controls.Add(this.guna2TextBox5);
            this.panel_function.Controls.Add(this.guna2ComboBox1);
            this.panel_function.Controls.Add(this.guna2TextBox4);
            this.panel_function.Controls.Add(this.guna2TextBox3);
            this.panel_function.Controls.Add(this.guna2TextBox2);
            this.panel_function.Controls.Add(this.guna2TextBox1);
            this.panel_function.Controls.Add(this.pn_fn);
            this.panel_function.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_function.Location = new System.Drawing.Point(1632, 0);
            this.panel_function.Name = "panel_function";
            this.panel_function.Size = new System.Drawing.Size(288, 1080);
            this.panel_function.TabIndex = 2;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 2;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(16, 14);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.PlaceholderText = "Mã sách";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(255, 41);
            this.guna2TextBox1.TabIndex = 6;
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_QLS_dgv;
        private Guna.UI2.WinForms.Guna2DataGridView dgvw_QLS;
        private System.Windows.Forms.Panel pn_fn;
        private Guna.UI2.WinForms.Guna2Button btn_QLS_Search;
        private Guna.UI2.WinForms.Guna2Button btn_QLS_Xóa;
        private Guna.UI2.WinForms.Guna2Button btn_QLS_Add;
        private Guna.UI2.WinForms.Guna2Button btn_QLS_Edit;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private System.Windows.Forms.Panel panel_function;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLS_MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLS_TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLS_NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLS_TACGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLS_LOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLS_GIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLS_GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_QLS_SLTON;
    }
}