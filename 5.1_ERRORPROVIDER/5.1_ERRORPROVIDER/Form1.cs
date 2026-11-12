using System;
using System.Windows.Forms;

namespace _5._1_ERRORPROVIDER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            epCheck.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            epCheck.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                epCheck.SetError(txtTenDangNhap, "Tên đăng nhập không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                epCheck.SetError(txtMatKhau, "Mật khẩu không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtXacNhanMatKhau.Text))
            {
                epCheck.SetError(txtXacNhanMatKhau, "Vui lòng xác nhận lại mật khẩu!");
                isValid = false;
            }
            else if (txtXacNhanMatKhau.Text != txtMatKhau.Text)
            {
                epCheck.SetError(txtXacNhanMatKhau, "Mật khẩu xác nhận không khớp với mật khẩu ban đầu!");
                isValid = false;
            }

            DateTime ngaySinh = dtpNgaySinh.Value.Date;
            DateTime homNay = DateTime.Today;
            int tuoi = homNay.Year - ngaySinh.Year;
            if (ngaySinh > homNay.AddYears(-tuoi))
            {
                tuoi--;
            }

            if (tuoi < 18)
            {
                epCheck.SetError(dtpNgaySinh, $"Bạn mới {tuoi} tuổi. Yêu cầu phải từ 18 tuổi trở lên!");
                isValid = false;
            }

            if (!chkDieuKhoan.Checked)
            {
                epCheck.SetError(chkDieuKhoan, "Bạn phải đồng ý với Điều khoản dịch vụ để tiếp tục!");
                isValid = false;
            }

            if (isValid)
            {
                string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
                string thongBao = $"Đăng ký tài khoản thành công!\n\n" +
                                  $"- Tên đăng nhập: {txtTenDangNhap.Text.Trim()}\n" +
                                  $"- Ngày sinh: {ngaySinh:dd/MM/yyyy} ({tuoi} tuổi)\n" +
                                  $"- Giới tính: {gioiTinh}";

                MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            epCheck.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtXacNhanMatKhau.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            radNam.Checked = true;
            chkDieuKhoan.Checked = false;
            txtTenDangNhap.Focus();
        }
    }
}