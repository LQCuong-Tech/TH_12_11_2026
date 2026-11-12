using System;
using System.Drawing;
using System.Windows.Forms;

namespace _5._1_ERRORPROVIDER
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox grpThongTinCaNhan;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Label lblXacNhanMatKhau;
        private TextBox txtXacNhanMatKhau;

        private GroupBox grpThongTinBoSung;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblGioiTinh;
        private RadioButton radNam;
        private RadioButton radNu;
        private CheckBox chkDieuKhoan;

        private Button btnDangKy;
        private Button btnLamMoi;
        private ErrorProvider epCheck;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpThongTinCaNhan = new GroupBox();
            this.lblTenDangNhap = new Label();
            this.txtTenDangNhap = new TextBox();
            this.lblMatKhau = new Label();
            this.txtMatKhau = new TextBox();
            this.lblXacNhanMatKhau = new Label();
            this.txtXacNhanMatKhau = new TextBox();

            this.grpThongTinBoSung = new GroupBox();
            this.lblNgaySinh = new Label();
            this.dtpNgaySinh = new DateTimePicker();
            this.lblGioiTinh = new Label();
            this.radNam = new RadioButton();
            this.radNu = new RadioButton();
            this.chkDieuKhoan = new CheckBox();

            this.btnDangKy = new Button();
            this.btnLamMoi = new Button();
            this.epCheck = new ErrorProvider(this.components);

            this.grpThongTinCaNhan.SuspendLayout();
            this.grpThongTinBoSung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();

            // 
            // grpThongTinCaNhan
            // 
            this.grpThongTinCaNhan.Controls.Add(this.lblTenDangNhap);
            this.grpThongTinCaNhan.Controls.Add(this.txtTenDangNhap);
            this.grpThongTinCaNhan.Controls.Add(this.lblMatKhau);
            this.grpThongTinCaNhan.Controls.Add(this.txtMatKhau);
            this.grpThongTinCaNhan.Controls.Add(this.lblXacNhanMatKhau);
            this.grpThongTinCaNhan.Controls.Add(this.txtXacNhanMatKhau);
            this.grpThongTinCaNhan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.grpThongTinCaNhan.Location = new Point(20, 15);
            this.grpThongTinCaNhan.Name = "grpThongTinCaNhan";
            this.grpThongTinCaNhan.Size = new Size(440, 165);
            this.grpThongTinCaNhan.TabIndex = 0;
            this.grpThongTinCaNhan.TabStop = false;
            this.grpThongTinCaNhan.Text = "Thông tin cá nhân";

            // lblTenDangNhap
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lblTenDangNhap.Location = new Point(18, 35);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new Size(102, 21);
            this.lblTenDangNhap.Text = "Tên đăng nhập:";

            // txtTenDangNhap
            this.txtTenDangNhap.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.txtTenDangNhap.Location = new Point(165, 32);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new Size(235, 29);
            this.txtTenDangNhap.TabIndex = 0;

            // lblMatKhau
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lblMatKhau.Location = new Point(18, 78);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new Size(71, 21);
            this.lblMatKhau.Text = "Mật khẩu:";

            // txtMatKhau
            this.txtMatKhau.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.txtMatKhau.Location = new Point(165, 75);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new Size(235, 29);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;

            // lblXacNhanMatKhau
            this.lblXacNhanMatKhau.AutoSize = true;
            this.lblXacNhanMatKhau.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lblXacNhanMatKhau.Location = new Point(18, 121);
            this.lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            this.lblXacNhanMatKhau.Size = new Size(131, 21);
            this.lblXacNhanMatKhau.Text = "Xác nhận mật khẩu:";

            // txtXacNhanMatKhau
            this.txtXacNhanMatKhau.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.txtXacNhanMatKhau.Location = new Point(165, 118);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Size = new Size(235, 29);
            this.txtXacNhanMatKhau.TabIndex = 2;
            this.txtXacNhanMatKhau.UseSystemPasswordChar = true;

            // 
            // grpThongTinBoSung
            // 
            this.grpThongTinBoSung.Controls.Add(this.lblNgaySinh);
            this.grpThongTinBoSung.Controls.Add(this.dtpNgaySinh);
            this.grpThongTinBoSung.Controls.Add(this.lblGioiTinh);
            this.grpThongTinBoSung.Controls.Add(this.radNam);
            this.grpThongTinBoSung.Controls.Add(this.radNu);
            this.grpThongTinBoSung.Controls.Add(this.chkDieuKhoan);
            this.grpThongTinBoSung.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.grpThongTinBoSung.Location = new Point(20, 195);
            this.grpThongTinBoSung.Name = "grpThongTinBoSung";
            this.grpThongTinBoSung.Size = new Size(440, 160);
            this.grpThongTinBoSung.TabIndex = 1;
            this.grpThongTinBoSung.TabStop = false;
            this.grpThongTinBoSung.Text = "Thông tin bổ sung";

            // lblNgaySinh
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lblNgaySinh.Location = new Point(18, 35);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new Size(76, 21);
            this.lblNgaySinh.Text = "Ngày sinh:";

            // dtpNgaySinh
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new Point(165, 31);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new Size(235, 29);
            this.dtpNgaySinh.TabIndex = 0;

            // lblGioiTinh
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lblGioiTinh.Location = new Point(18, 76);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new Size(67, 21);
            this.lblGioiTinh.Text = "Giới tính:";

            // radNam
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.radNam.Location = new Point(165, 74);
            this.radNam.Name = "radNam";
            this.radNam.Size = new Size(63, 25);
            this.radNam.TabIndex = 1;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";

            // radNu
            this.radNu.AutoSize = true;
            this.radNu.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.radNu.Location = new Point(255, 74);
            this.radNu.Name = "radNu";
            this.radNu.Size = new Size(51, 25);
            this.radNu.TabIndex = 2;
            this.radNu.Text = "Nữ";

            // chkDieuKhoan
            this.chkDieuKhoan.AutoSize = true;
            this.chkDieuKhoan.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.chkDieuKhoan.Location = new Point(165, 115);
            this.chkDieuKhoan.Name = "chkDieuKhoan";
            this.chkDieuKhoan.Size = new Size(232, 25);
            this.chkDieuKhoan.TabIndex = 3;
            this.chkDieuKhoan.Text = "Tôi đồng ý với Điều khoản dịch vụ";

            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = Color.FromArgb(0, 120, 215);
            this.btnDangKy.FlatStyle = FlatStyle.Flat;
            this.btnDangKy.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnDangKy.ForeColor = Color.White;
            this.btnDangKy.Location = new Point(125, 375);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new Size(110, 36);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new EventHandler(this.btnDangKy_Click);

            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.btnLamMoi.Location = new Point(255, 375);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new Size(110, 36);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new EventHandler(this.btnLamMoi_Click);

            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(480, 430);
            this.Controls.Add(this.grpThongTinCaNhan);
            this.Controls.Add(this.grpThongTinBoSung);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnLamMoi);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Bài 5.1 - Đăng Ký Tài Khoản";

            this.grpThongTinCaNhan.ResumeLayout(false);
            this.grpThongTinCaNhan.PerformLayout();
            this.grpThongTinBoSung.ResumeLayout(false);
            this.grpThongTinBoSung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.ResumeLayout(false);
        }
    }
}