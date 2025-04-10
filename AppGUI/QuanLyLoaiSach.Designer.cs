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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvw_QLLS = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cln_QLLS_MA_LOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_QLLS_TENLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_QLLS_dgv = new System.Windows.Forms.Panel();
            this.pn_fn = new System.Windows.Forms.Panel();
            this.btn_QLLS_Search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLLS_Del = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLLS_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLLS_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.txt_QLLS_TENLOAI = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_function = new System.Windows.Forms.Panel();
            this.txt_QLLS_MA_LOAI = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_QLLS)).BeginInit();
            this.pn_QLLS_dgv.SuspendLayout();
            this.pn_fn.SuspendLayout();
            this.panel_function.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvw_QLLS
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvw_QLLS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvw_QLLS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvw_QLLS.ColumnHeadersHeight = 34;
            this.dgvw_QLLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvw_QLLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_QLLS_MA_LOAI,
            this.cln_QLLS_TENLOAI});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvw_QLLS.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvw_QLLS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvw_QLLS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvw_QLLS.Location = new System.Drawing.Point(0, 0);
            this.dgvw_QLLS.MultiSelect = false;
            this.dgvw_QLLS.Name = "dgvw_QLLS";
            this.dgvw_QLLS.RowHeadersVisible = false;
            this.dgvw_QLLS.RowHeadersWidth = 51;
            this.dgvw_QLLS.RowTemplate.Height = 24;
            this.dgvw_QLLS.Size = new System.Drawing.Size(1632, 1080);
            this.dgvw_QLLS.TabIndex = 0;
            this.dgvw_QLLS.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvw_QLLS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvw_QLLS.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvw_QLLS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvw_QLLS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvw_QLLS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvw_QLLS.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvw_QLLS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvw_QLLS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvw_QLLS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvw_QLLS.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvw_QLLS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvw_QLLS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvw_QLLS.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvw_QLLS.ThemeStyle.ReadOnly = false;
            this.dgvw_QLLS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvw_QLLS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvw_QLLS.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvw_QLLS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvw_QLLS.ThemeStyle.RowsStyle.Height = 24;
            this.dgvw_QLLS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
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
            this.pn_QLLS_dgv.Location = new System.Drawing.Point(0, 0);
            this.pn_QLLS_dgv.Name = "pn_QLLS_dgv";
            this.pn_QLLS_dgv.Size = new System.Drawing.Size(1632, 1080);
            this.pn_QLLS_dgv.TabIndex = 5;
            // 
            // pn_fn
            // 
            this.pn_fn.BackColor = System.Drawing.Color.Transparent;
            this.pn_fn.Controls.Add(this.btn_QLLS_Search);
            this.pn_fn.Controls.Add(this.btn_QLLS_Del);
            this.pn_fn.Controls.Add(this.btn_QLLS_Add);
            this.pn_fn.Controls.Add(this.btn_QLLS_Edit);
            this.pn_fn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_fn.Location = new System.Drawing.Point(0, 954);
            this.pn_fn.Name = "pn_fn";
            this.pn_fn.Size = new System.Drawing.Size(288, 126);
            this.pn_fn.TabIndex = 5;
            // 
            // btn_QLLS_Search
            // 
            this.btn_QLLS_Search.BorderRadius = 10;
            this.btn_QLLS_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLLS_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLLS_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLLS_Search.ForeColor = System.Drawing.Color.White;
            this.btn_QLLS_Search.Location = new System.Drawing.Point(17, 20);
            this.btn_QLLS_Search.Name = "btn_QLLS_Search";
            this.btn_QLLS_Search.Size = new System.Drawing.Size(117, 30);
            this.btn_QLLS_Search.TabIndex = 0;
            this.btn_QLLS_Search.Text = "Tìm kiếm";
            // 
            // btn_QLLS_Del
            // 
            this.btn_QLLS_Del.BorderRadius = 10;
            this.btn_QLLS_Del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLLS_Del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLLS_Del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLLS_Del.ForeColor = System.Drawing.Color.White;
            this.btn_QLLS_Del.Location = new System.Drawing.Point(154, 56);
            this.btn_QLLS_Del.Name = "btn_QLLS_Del";
            this.btn_QLLS_Del.Size = new System.Drawing.Size(117, 30);
            this.btn_QLLS_Del.TabIndex = 3;
            this.btn_QLLS_Del.Text = "Xóa";
            // 
            // btn_QLLS_Add
            // 
            this.btn_QLLS_Add.BorderRadius = 10;
            this.btn_QLLS_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLLS_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLLS_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLLS_Add.ForeColor = System.Drawing.Color.White;
            this.btn_QLLS_Add.Location = new System.Drawing.Point(154, 20);
            this.btn_QLLS_Add.Name = "btn_QLLS_Add";
            this.btn_QLLS_Add.Size = new System.Drawing.Size(117, 30);
            this.btn_QLLS_Add.TabIndex = 1;
            this.btn_QLLS_Add.Text = "Thêm";
            // 
            // btn_QLLS_Edit
            // 
            this.btn_QLLS_Edit.BorderRadius = 10;
            this.btn_QLLS_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLLS_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLLS_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLLS_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLLS_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_QLLS_Edit.Location = new System.Drawing.Point(17, 56);
            this.btn_QLLS_Edit.Name = "btn_QLLS_Edit";
            this.btn_QLLS_Edit.Size = new System.Drawing.Size(117, 30);
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
            this.txt_QLLS_TENLOAI.Location = new System.Drawing.Point(17, 115);
            this.txt_QLLS_TENLOAI.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLLS_TENLOAI.Name = "txt_QLLS_TENLOAI";
            this.txt_QLLS_TENLOAI.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLLS_TENLOAI.PlaceholderText = "Tên loại sách";
            this.txt_QLLS_TENLOAI.SelectedText = "";
            this.txt_QLLS_TENLOAI.Size = new System.Drawing.Size(255, 41);
            this.txt_QLLS_TENLOAI.TabIndex = 7;
            // 
            // panel_function
            // 
            this.panel_function.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel_function.Controls.Add(this.label1);
            this.panel_function.Controls.Add(this.label5);
            this.panel_function.Controls.Add(this.txt_QLLS_TENLOAI);
            this.panel_function.Controls.Add(this.txt_QLLS_MA_LOAI);
            this.panel_function.Controls.Add(this.pn_fn);
            this.panel_function.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_function.Location = new System.Drawing.Point(1632, 0);
            this.panel_function.Name = "panel_function";
            this.panel_function.Size = new System.Drawing.Size(288, 1080);
            this.panel_function.TabIndex = 4;
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
            this.txt_QLLS_MA_LOAI.Location = new System.Drawing.Point(16, 39);
            this.txt_QLLS_MA_LOAI.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_QLLS_MA_LOAI.Name = "txt_QLLS_MA_LOAI";
            this.txt_QLLS_MA_LOAI.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_QLLS_MA_LOAI.PlaceholderText = "Mã loại sách";
            this.txt_QLLS_MA_LOAI.SelectedText = "";
            this.txt_QLLS_MA_LOAI.Size = new System.Drawing.Size(255, 41);
            this.txt_QLLS_MA_LOAI.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Mã loại sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tên loại sách";
            // 
            // FormQuanLyLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pn_QLLS_dgv);
            this.Controls.Add(this.panel_function);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyLoaiSach";
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_QLLS)).EndInit();
            this.pn_QLLS_dgv.ResumeLayout(false);
            this.pn_fn.ResumeLayout(false);
            this.panel_function.ResumeLayout(false);
            this.panel_function.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvw_QLLS;
        private System.Windows.Forms.Panel pn_QLLS_dgv;
        private System.Windows.Forms.Panel pn_fn;
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
    }
}