using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace _5._4_TREEVIEW___LISTVIEW
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public string PhongBan { get; set; }
        public string Nhom { get; set; }
        public int IconIndex { get; set; }

        public NhanVien(string maNV, string hoTen, string chucVu, DateTime ngayVaoLam, string phongBan, string nhom, int iconIndex)
        {
            MaNV = maNV;
            HoTen = hoTen;
            ChucVu = chucVu;
            NgayVaoLam = ngayVaoLam;
            PhongBan = phongBan;
            Nhom = nhom;
            IconIndex = iconIndex;
        }
    }

    public partial class Form1 : Form
    {
        private List<NhanVien> danhSachNhanVien = new List<NhanVien>();

        public Form1()
        {
            InitializeComponent();
            KhoiTaoImageList();
            KhoiTaoComboBoxView();
            KhoiTaoDuLieuVaCay();
        }

        private void KhoiTaoImageList()
        {
            imgListTree.Images.Add(VeIconTree(Color.FromArgb(0, 102, 204), "CT"));
            imgListTree.Images.Add(VeIconTree(Color.FromArgb(230, 145, 0), "PB"));
            imgListTree.Images.Add(VeIconTree(Color.FromArgb(46, 139, 87), "NH"));

            imgListSmall.Images.Add(VeIconNhanVien(20, Color.FromArgb(30, 136, 229)));
            imgListSmall.Images.Add(VeIconNhanVien(20, Color.FromArgb(216, 27, 96)));

            imgListLarge.Images.Add(VeIconNhanVien(40, Color.FromArgb(30, 136, 229)));
            imgListLarge.Images.Add(VeIconNhanVien(40, Color.FromArgb(216, 27, 96)));
        }

        private Bitmap VeIconTree(Color mauNen, string kyHieu)
        {
            Bitmap bmp = new Bitmap(18, 18);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (Brush b = new SolidBrush(mauNen))
                {
                    g.FillRoundedRectangle(b, new Rectangle(1, 1, 16, 16), 3);
                }
                using (Font f = new Font("Segoe UI", 6.5F, FontStyle.Bold))
                using (Brush textBrush = new SolidBrush(Color.White))
                {
                    StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    g.DrawString(kyHieu, f, textBrush, new RectangleF(0, 0, 18, 18), sf);
                }
            }
            return bmp;
        }

        private Bitmap VeIconNhanVien(int size, Color mauAo)
        {
            Bitmap bmp = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (Brush bg = new SolidBrush(Color.FromArgb(235, 242, 250)))
                {
                    g.FillEllipse(bg, 1, 1, size - 2, size - 2);
                }
                using (Brush personBrush = new SolidBrush(mauAo))
                {
                    int headSize = size / 3;
                    g.FillEllipse(personBrush, (size - headSize) / 2, size / 5, headSize, headSize);
                    g.FillPie(personBrush, size / 5, size / 2, size * 3 / 5, size * 3 / 5, 180, 180);
                }
            }
            return bmp;
        }

        private void KhoiTaoComboBoxView()
        {
            cboViewMode.Items.AddRange(new string[]
            {
                "Details",
                "LargeIcon",
                "SmallIcon",
                "Tile",
                "List"
            });
            cboViewMode.SelectedIndex = 0;
        }

        private void KhoiTaoDuLieuVaCay()
        {
            danhSachNhanVien = new List<NhanVien>
            {
                new NhanVien("NV001", "Nguyễn Văn An", "Trưởng phòng Kỹ thuật", new DateTime(2021, 3, 15), "Phòng Kỹ Thuật", "Nhóm Phát triển Phần mềm", 0),
                new NhanVien("NV002", "Trần Thị Bình", "Lập trình viên C#", new DateTime(2022, 7, 10), "Phòng Kỹ Thuật", "Nhóm Phát triển Phần mềm", 1),
                new NhanVien("NV003", "Lê Hoàng Cường", "Lập trình viên Frontend", new DateTime(2023, 1, 20), "Phòng Kỹ Thuật", "Nhóm Phát triển Phần mềm", 0),
                new NhanVien("NV004", "Phạm Minh Đức", "Trưởng nhóm Hạ tầng", new DateTime(2021, 11, 5), "Phòng Kỹ Thuật", "Nhóm Hạ tầng & Mạng", 0),
                new NhanVien("NV005", "Vũ Thu Hà", "Chuyên viên An ninh mạng", new DateTime(2023, 5, 12), "Phòng Kỹ Thuật", "Nhóm Hạ tầng & Mạng", 1),

                new NhanVien("NV006", "Đặng Quốc Huy", "Trưởng phòng Kinh doanh", new DateTime(2020, 8, 1), "Phòng Kinh Doanh", "Nhóm Bán hàng Doanh nghiệp", 0),
                new NhanVien("NV007", "Hoàng Lan Anh", "Chuyên viên Tư vấn", new DateTime(2022, 9, 18), "Phòng Kinh Doanh", "Nhóm Bán hàng Doanh nghiệp", 1),
                new NhanVien("NV008", "Bùi Thanh Tùng", "Chuyên viên Chăm sóc KH", new DateTime(2024, 2, 14), "Phòng Kinh Doanh", "Nhóm Chăm sóc Khách hàng", 0),

                new NhanVien("NV009", "Ngô Mai Phương", "Trưởng phòng Nhân sự", new DateTime(2020, 4, 22), "Phòng Hành Chính - Nhân Sự", "Nhóm Tuyển dụng & Đào tạo", 1),
                new NhanVien("NV010", "Đỗ Văn Nam", "Chuyên viên Kế toán", new DateTime(2022, 12, 1), "Phòng Hành Chính - Nhân Sự", "Nhóm Kế toán Tổng hợp", 0)
            };

            tvDepartments.Nodes.Clear();

            TreeNode rootCongTy = new TreeNode("Công ty Công Nghệ ABC", 0, 0);

            TreeNode nodeKyThuat = new TreeNode("Phòng Kỹ Thuật", 1, 1);
            nodeKyThuat.Nodes.Add(new TreeNode("Nhóm Phát triển Phần mềm", 2, 2));
            nodeKyThuat.Nodes.Add(new TreeNode("Nhóm Hạ tầng & Mạng", 2, 2));

            TreeNode nodeKinhDoanh = new TreeNode("Phòng Kinh Doanh", 1, 1);
            nodeKinhDoanh.Nodes.Add(new TreeNode("Nhóm Bán hàng Doanh nghiệp", 2, 2));
            nodeKinhDoanh.Nodes.Add(new TreeNode("Nhóm Chăm sóc Khách hàng", 2, 2));

            TreeNode nodeNhanSu = new TreeNode("Phòng Hành Chính - Nhân Sự", 1, 1);
            nodeNhanSu.Nodes.Add(new TreeNode("Nhóm Tuyển dụng & Đào tạo", 2, 2));
            nodeNhanSu.Nodes.Add(new TreeNode("Nhóm Kế toán Tổng hợp", 2, 2));

            rootCongTy.Nodes.Add(nodeKyThuat);
            rootCongTy.Nodes.Add(nodeKinhDoanh);
            rootCongTy.Nodes.Add(nodeNhanSu);

            tvDepartments.Nodes.Add(rootCongTy);
            tvDepartments.ExpandAll();
            tvDepartments.SelectedNode = rootCongTy;
        }

        private void tvDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;

            IEnumerable<NhanVien> ketQuaLoc;

            switch (e.Node.Level)
            {
                case 0:
                    ketQuaLoc = danhSachNhanVien;
                    break;
                case 1:
                    ketQuaLoc = danhSachNhanVien.Where(nv => nv.PhongBan == e.Node.Text);
                    break;
                case 2:
                    ketQuaLoc = danhSachNhanVien.Where(nv => nv.Nhom == e.Node.Text);
                    break;
                default:
                    ketQuaLoc = Enumerable.Empty<NhanVien>();
                    break;
            }

            HienThiNhanVienLenListView(ketQuaLoc);
        }

        private void HienThiNhanVienLenListView(IEnumerable<NhanVien> dsNhanVien)
        {
            lsvEmployees.Items.Clear();

            foreach (var nv in dsNhanVien)
            {
                ListViewItem item = new ListViewItem(nv.MaNV, nv.IconIndex);
                item.SubItems.Add(nv.HoTen);
                item.SubItems.Add(nv.ChucVu);
                item.SubItems.Add(nv.NgayVaoLam.ToString("dd/MM/yyyy"));

                lsvEmployees.Items.Add(item);
            }
        }

        private void cboViewMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboViewMode.SelectedItem == null) return;

            string mode = cboViewMode.SelectedItem.ToString();
            if (Enum.TryParse(mode, out View selectedView))
            {
                lsvEmployees.View = selectedView;
            }
        }
    }

    internal static class GraphicsExtensions
    {
        public static void FillRoundedRectangle(this Graphics g, Brush brush, Rectangle bounds, int radius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int d = radius * 2;
                path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
                path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
                path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
                path.CloseFigure();
                g.FillPath(brush, path);
            }
        }
    }
}