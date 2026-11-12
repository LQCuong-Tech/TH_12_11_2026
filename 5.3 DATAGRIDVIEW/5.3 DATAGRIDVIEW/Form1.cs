using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _5._3_DATAGRIDVIEW
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }

        public Product() { }

        public Product(string productId, string productName, decimal unitPrice, int quantity, string category)
        {
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Category = category;
        }
    }

    public partial class Form1 : Form
    {
        private List<Product> danhSachSanPham = new List<Product>();
        private BindingSource bsProducts = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            KhoiTaoDuLieu();
        }

        private void KhoiTaoDuLieu()
        {
            cboCategory.Items.AddRange(new string[]
            {
                "Điện thoại",
                "Laptop",
                "Phụ kiện",
                "Thiết bị mạng",
                "Gia dụng"
            });
            cboCategory.SelectedIndex = 0;
            HienThiLenDataGridView(danhSachSanPham);
        }

        private void HienThiLenDataGridView(List<Product> nguonDuLieu)
        {
            bsProducts.DataSource = null;
            bsProducts.DataSource = nguonDuLieu;
            dgvProducts.DataSource = bsProducts;

            if (dgvProducts.Columns.Count > 0)
            {
                dgvProducts.Columns["ProductId"].HeaderText = "Mã SP";
                dgvProducts.Columns["ProductName"].HeaderText = "Tên sản phẩm";
                dgvProducts.Columns["UnitPrice"].HeaderText = "Đơn giá";
                dgvProducts.Columns["UnitPrice"].DefaultCellStyle.Format = "N0";
                dgvProducts.Columns["Quantity"].HeaderText = "Số lượng";
                dgvProducts.Columns["Category"].HeaderText = "Danh mục";
            }
        }

        private bool KiemTraNhapLieu(out decimal donGia, out int soLuong)
        {
            donGia = 0;
            soLuong = 0;

            if (string.IsNullOrWhiteSpace(txtProductId.Text))
            {
                MessageBox.Show("Mã sản phẩm không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductId.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ và không âm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return false;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên không âm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieu(out decimal donGia, out int soLuong)) return;

            string maSP = txtProductId.Text.Trim();
            if (danhSachSanPham.Any(p => p.ProductId.Equals(maSP, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"Mã sản phẩm '{maSP}' đã tồn tại!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductId.Focus();
                return;
            }

            Product spMoi = new Product(
                maSP,
                txtProductName.Text.Trim(),
                donGia,
                soLuong,
                cboCategory.SelectedItem.ToString()
            );

            danhSachSanPham.Add(spMoi);
            HienThiLenDataGridView(danhSachSanPham);
            LamMoiOChon();
            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieu(out decimal donGia, out int soLuong)) return;

            string maSP = txtProductId.Text.Trim();
            Product spCanSua = danhSachSanPham.FirstOrDefault(p => p.ProductId.Equals(maSP, StringComparison.OrdinalIgnoreCase));

            if (spCanSua == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm có mã này để sửa! (Lưu ý: Không đổi Mã SP khi sửa)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            spCanSua.ProductName = txtProductName.Text.Trim();
            spCanSua.UnitPrice = donGia;
            spCanSua.Quantity = soLuong;
            spCanSua.Category = cboCategory.SelectedItem.ToString();

            HienThiLenDataGridView(danhSachSanPham);
            MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvProducts.Rows[e.RowIndex].DataBoundItem is Product spChon)
            {
                txtProductId.Text = spChon.ProductId;
                txtProductName.Text = spChon.ProductName;
                txtUnitPrice.Text = spChon.UnitPrice.ToString("0");
                txtQuantity.Text = spChon.Quantity.ToString();
                cboCategory.SelectedItem = spChon.Category;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null || !(dgvProducts.CurrentRow.DataBoundItem is Product spChon))
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult xacNhan = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sản phẩm '{spChon.ProductName}' (Mã: {spChon.ProductId}) không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (xacNhan == DialogResult.Yes)
            {
                danhSachSanPham.Remove(spChon);
                HienThiLenDataGridView(danhSachSanPham);
                LamMoiOChon();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                HienThiLenDataGridView(danhSachSanPham);
                return;
            }

            List<Product> ketQua = danhSachSanPham
                .Where(p => p.ProductName.IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            HienThiLenDataGridView(ketQua);

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào khớp với từ khóa!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LamMoiOChon();
            txtSearch.Clear();
            HienThiLenDataGridView(danhSachSanPham);
        }

        private void LamMoiOChon()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            txtProductId.Focus();
        }
    }
}