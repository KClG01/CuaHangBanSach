namespace AppGUI
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txt_DN_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_DN_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_DN_Login = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_DN_forgotPS = new System.Windows.Forms.LinkLabel();
            this.lblPsw = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lbl_Bar = new System.Windows.Forms.Label();
            this.btn_DN_Close = new System.Windows.Forms.Button();
            this.pnBar = new System.Windows.Forms.Panel();
            this.btn_DN_reg = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 690);
            this.panel2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(825, 63);
            this.label1.TabIndex = 17;
            this.label1.Text = "GROW UP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(0, 57);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(825, 461);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(825, 57);
            this.panel4.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_DN_reg);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txt_DN_password);
            this.panel1.Controls.Add(this.txt_DN_username);
            this.panel1.Controls.Add(this.btn_DN_Login);
            this.panel1.Controls.Add(this.lbl_DN_forgotPS);
            this.panel1.Controls.Add(this.lblPsw);
            this.panel1.Controls.Add(this.lblMaNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(825, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 690);
            this.panel1.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 60);
            this.panel3.TabIndex = 20;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(455, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ĐĂNG NHẬP";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txt_DN_password
            // 
            this.txt_DN_password.BackColor = System.Drawing.Color.Transparent;
            this.txt_DN_password.BorderRadius = 8;
            this.txt_DN_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DN_password.DefaultText = "";
            this.txt_DN_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DN_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DN_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DN_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DN_password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_DN_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DN_password.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DN_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DN_password.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_DN_password.IconLeft")));
            this.txt_DN_password.Location = new System.Drawing.Point(69, 223);
            this.txt_DN_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DN_password.Name = "txt_DN_password";
            this.txt_DN_password.PasswordChar = '*';
            this.txt_DN_password.PlaceholderText = "Password";
            this.txt_DN_password.SelectedText = "";
            this.txt_DN_password.Size = new System.Drawing.Size(320, 60);
            this.txt_DN_password.TabIndex = 19;
            // 
            // txt_DN_username
            // 
            this.txt_DN_username.BackColor = System.Drawing.Color.Transparent;
            this.txt_DN_username.BorderRadius = 8;
            this.txt_DN_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DN_username.DefaultText = "";
            this.txt_DN_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DN_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DN_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DN_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DN_username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_DN_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DN_username.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_DN_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DN_username.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_DN_username.IconLeft")));
            this.txt_DN_username.Location = new System.Drawing.Point(69, 119);
            this.txt_DN_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DN_username.Name = "txt_DN_username";
            this.txt_DN_username.PlaceholderText = "Username";
            this.txt_DN_username.SelectedText = "";
            this.txt_DN_username.Size = new System.Drawing.Size(320, 60);
            this.txt_DN_username.TabIndex = 18;
            // 
            // btn_DN_Login
            // 
            this.btn_DN_Login.BorderRadius = 10;
            this.btn_DN_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DN_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DN_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DN_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DN_Login.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DN_Login.ForeColor = System.Drawing.Color.White;
            this.btn_DN_Login.Location = new System.Drawing.Point(135, 350);
            this.btn_DN_Login.Name = "btn_DN_Login";
            this.btn_DN_Login.Size = new System.Drawing.Size(180, 50);
            this.btn_DN_Login.TabIndex = 17;
            this.btn_DN_Login.Text = "LOGIN";
            this.btn_DN_Login.Click += new System.EventHandler(this.btn_DN_Login_Click);
            // 
            // lbl_DN_forgotPS
            // 
            this.lbl_DN_forgotPS.AutoSize = true;
            this.lbl_DN_forgotPS.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DN_forgotPS.Location = new System.Drawing.Point(266, 287);
            this.lbl_DN_forgotPS.Name = "lbl_DN_forgotPS";
            this.lbl_DN_forgotPS.Size = new System.Drawing.Size(123, 20);
            this.lbl_DN_forgotPS.TabIndex = 14;
            this.lbl_DN_forgotPS.TabStop = true;
            this.lbl_DN_forgotPS.Text = "Quên mật khẩu?";
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPsw.Location = new System.Drawing.Point(78, 196);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(86, 23);
            this.lblPsw.TabIndex = 11;
            this.lblPsw.Text = "Mật khẩu";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaNV.Location = new System.Drawing.Point(78, 92);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(89, 23);
            this.lblMaNV.TabIndex = 4;
            this.lblMaNV.Text = "Username";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // lbl_Bar
            // 
            this.lbl_Bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Bar.AutoSize = true;
            this.lbl_Bar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bar.ForeColor = System.Drawing.Color.White;
            this.lbl_Bar.Location = new System.Drawing.Point(12, 15);
            this.lbl_Bar.Name = "lbl_Bar";
            this.lbl_Bar.Size = new System.Drawing.Size(0, 16);
            this.lbl_Bar.TabIndex = 14;
            this.lbl_Bar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_DN_Close
            // 
            this.btn_DN_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DN_Close.BackgroundImage")));
            this.btn_DN_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_DN_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_DN_Close.FlatAppearance.BorderSize = 0;
            this.btn_DN_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DN_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DN_Close.Location = new System.Drawing.Point(1240, 0);
            this.btn_DN_Close.Name = "btn_DN_Close";
            this.btn_DN_Close.Size = new System.Drawing.Size(40, 30);
            this.btn_DN_Close.TabIndex = 14;
            this.btn_DN_Close.UseVisualStyleBackColor = true;
            this.btn_DN_Close.Click += new System.EventHandler(this.btn_DN_Close_Click);
            // 
            // pnBar
            // 
            this.pnBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(5)))), ((int)(((byte)(50)))));
            this.pnBar.Controls.Add(this.lbl_Bar);
            this.pnBar.Controls.Add(this.btn_DN_Close);
            this.pnBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBar.Location = new System.Drawing.Point(0, 0);
            this.pnBar.Name = "pnBar";
            this.pnBar.Size = new System.Drawing.Size(1280, 30);
            this.pnBar.TabIndex = 19;
            // 
            // btn_DN_reg
            // 
            this.btn_DN_reg.BorderRadius = 10;
            this.btn_DN_reg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DN_reg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DN_reg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DN_reg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DN_reg.FillColor = System.Drawing.Color.Transparent;
            this.btn_DN_reg.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DN_reg.ForeColor = System.Drawing.Color.Gray;
            this.btn_DN_reg.Location = new System.Drawing.Point(135, 406);
            this.btn_DN_reg.Name = "btn_DN_reg";
            this.btn_DN_reg.Size = new System.Drawing.Size(180, 29);
            this.btn_DN_reg.TabIndex = 21;
            this.btn_DN_reg.Text = "Tạo tài khoản?";
            this.btn_DN_reg.Click += new System.EventHandler(this.btn_DN_reg_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnBar.ResumeLayout(false);
            this.pnBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txt_DN_password;
        private Guna.UI2.WinForms.Guna2TextBox txt_DN_username;
        private Guna.UI2.WinForms.Guna2Button btn_DN_Login;
        private System.Windows.Forms.LinkLabel lbl_DN_forgotPS;
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.Label lblMaNV;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel pnBar;
        private System.Windows.Forms.Label lbl_Bar;
        private System.Windows.Forms.Button btn_DN_Close;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btn_DN_reg;
    }
}

