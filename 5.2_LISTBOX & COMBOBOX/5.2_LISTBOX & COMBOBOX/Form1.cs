using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _5._2_LISTBOX___COMBOBOX
{
    public class DichVu
    {
        public string LoaiDichVu { get; set; }
        public string TenDichVu { get; set; }
        public decimal DonGia { get; set; }

        public DichVu(string loaiDichVu, string tenDichVu, decimal donGia)
        {
            LoaiDichVu = loaiDichVu;
            TenDichVu = tenDichVu;
            DonGia = donGia;
        }

        public override string ToString()
        {
            return $"{TenDichVu} - {DonGia:N0} VNĐ";
        }
    }

    public partial class Form1 : Form
    {
        private Dictionary<string, List<DichVu>> duLieuDichVu;

        public Form1()
        {
            InitializeComponent();
            KhoiTaoDuLieu();
        }

        private void KhoiTaoDuLieu()
        {
            duLieuDichVu = new Dictionary<string, List<DichVu>>
            {
                ["Khám bệnh"] = new List<DichVu>
                {
                    new DichVu("Khám bệnh", "Khám nội tổng quát", 150000),
                    new DichVu("Khám bệnh", "Khám chuyên khoa Tai Mũi Họng", 200000),
                    new DichVu("Khám bệnh", "Khám răng hàm mặt", 180000),
                    new DichVu("Khám bệnh", "Khám tim mạch chuyên sâu", 300000)
                },
                ["Xét nghiệm"] = new List<DichVu>
                {
                    new DichVu("Xét nghiệm", "Tổng phân tích tế bào máu", 120000),
                    new DichVu("Xét nghiệm", "Xét nghiệm đường huyết", 80000),
                    new DichVu("Xét nghiệm", "Xét nghiệm chức năng gan - thận", 250000),
                    new DichVu("Xét nghiệm", "Xét nghiệm mỡ máu toàn phần", 220000)
                },
                ["Chụp X-Quang"] = new List<DichVu>
                {
                    new DichVu("Chụp X-Quang", "Chụp X-Quang tim phổi thẳng", 160000),
                    new DichVu("Chụp X-Quang", "Chụp X-Quang cột sống thắt lưng", 240000),
                    new DichVu("Chụp X-Quang", "Chụp X-Quang xương khớp chi", 150000)
                },
                ["Vắc-xin"] = new List<DichVu>
                {
                    new DichVu("Vắc-xin", "Vắc-xin Cúm mùa tứ giá", 350000),
                    new DichVu("Vắc-xin", "Vắc-xin Viêm gan B", 280000),
                    new DichVu("Vắc-xin", "Vắc-xin Uốn ván hấp phụ", 150000),
                    new DichVu("Vắc-xin", "Vắc-xin Phế cầu 13", 1290000)
                }
            };

            cboCategory.Items.AddRange(duLieuDichVu.Keys.ToArray());
            if (cboCategory.Items.Count > 0)
            {
                cboCategory.SelectedIndex = 0;
            }
        }

        // 1. Khi thay đổi ComboBox -> Load danh sách dịch vụ tương ứng (trừ các dịch vụ đã chọn)
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachDichVuKhaDung();
        }

        private void LoadDanhSachDichVuKhaDung()
        {
            lstAvailableServices.Items.Clear();
            if (cboCategory.SelectedItem == null) return;

            string loaiDuocChon = cboCategory.SelectedItem.ToString();
            if (duLieuDichVu.TryGetValue(loaiDuocChon, out List<DichVu> danhSach))
            {
                foreach (var dv in danhSach)
                {
                    // Chỉ hiển thị những dịch vụ chưa nằm trong danh sách đã chọn
                    if (!lstSelectedServices.Items.Contains(dv))
                    {
                        lstAvailableServices.Items.Add(dv);
                    }
                }
            }
        }

        // 2. Nhấn nút > hoặc Double Click vào lstAvailableServices -> Chuyển sang lstSelectedServices
        private void btnSelect_Click(object sender, EventArgs e)
        {
            ChuyenDichVuSangDaChon();
        }

        private void lstAvailableServices_DoubleClick(object sender, EventArgs e)
        {
            ChuyenDichVuSangDaChon();
        }

        private void ChuyenDichVuSangDaChon()
        {
            if (lstAvailableServices.SelectedItem is DichVu dv)
            {
                lstSelectedServices.Items.Add(dv);
                lstAvailableServices.Items.Remove(dv);
                TinhTongTien();
            }
        }

        // Nút < : Xóa 1 dịch vụ đang chọn khỏi lstSelectedServices
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem is DichVu dv)
            {
                lstSelectedServices.Items.Remove(dv);
                LoadDanhSachDichVuKhaDung();
                TinhTongTien();
            }
        }

        // Nút << : Xóa toàn bộ dịch vụ đã chọn
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.Items.Count == 0) return;

            lstSelectedServices.Items.Clear();
            LoadDanhSachDichVuKhaDung();
            TinhTongTien();
        }

        // Áp dụng mã giảm giá (GIAM10 -> 10%, GIAM20 -> 20%, VIP50 -> 50%)
        private void btnApDung_Click(object sender, EventArgs e)
        {
            string ma = txtMaGiamGia.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui lòng nhập mã giảm giá (VD: GIAM10, GIAM20, VIP50).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGiamGia.Focus();
                return;
            }

            switch (ma)
            {
                case "GIAM10":
                    txtChietKhau.Text = "10";
                    MessageBox.Show("Áp dụng thành công mã GIAM10 (Giảm 10%)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "GIAM20":
                    txtChietKhau.Text = "20";
                    MessageBox.Show("Áp dụng thành công mã GIAM20 (Giảm 20%)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "VIP50":
                    txtChietKhau.Text = "50";
                    MessageBox.Show("Áp dụng thành công mã VIP50 (Giảm 50%)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Mã giảm giá không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void txtChietKhau_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        // 3. Tự động tính lại tổng tiền, chiết khấu và thành tiền thanh toán
        private void TinhTongTien()
        {
            decimal tongTien = 0;
            foreach (var item in lstSelectedServices.Items)
            {
                if (item is DichVu dv)
                {
                    tongTien += dv.DonGia;
                }
            }

            if (!decimal.TryParse(txtChietKhau.Text, out decimal phanTramGiam) || phanTramGiam < 0)
            {
                phanTramGiam = 0;
            }
            else if (phanTramGiam > 100)
            {
                phanTramGiam = 100;
            }

            decimal tienGiam = tongTien * (phanTramGiam / 100m);
            decimal thanhTien = tongTien - tienGiam;

            txtTongTien.Text = $"{tongTien:N0} VNĐ";
            txtThanhTien.Text = $"{thanhTien:N0} VNĐ";
        }
    }
}