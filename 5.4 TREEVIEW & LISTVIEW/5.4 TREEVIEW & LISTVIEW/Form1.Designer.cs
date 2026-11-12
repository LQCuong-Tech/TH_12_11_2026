using System;
using System.Drawing;
using System.Windows.Forms;

namespace _5._4_TREEVIEW___LISTVIEW
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlTop;
        private Label lblTitle;
        private Label lblViewMode;
        private ComboBox cboViewMode;

        private SplitContainer splitContainer1;
        private TreeView tvDepartments;
        private ListView lsvEmployees;

        private ColumnHeader colMaNV;
        private ColumnHeader colHoTen;
        private ColumnHeader colChucVu;
        private ColumnHeader colNgayVaoLam;

        private ImageList imgListTree;
        private ImageList imgListSmall;
        private ImageList imgListLarge;

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
            this.pnlTop = new Panel();
            this.lblTitle = new Label();
            this.lblViewMode = new Label();
            this.cboViewMode = new ComboBox();

            this.splitContainer1 = new SplitContainer();
            this.tvDepartments = new TreeView();
            this.lsvEmployees = new ListView();

            this.colMaNV = new ColumnHeader();
            this.colHoTen = new ColumnHeader();
            this.colChucVu = new ColumnHeader();
            this.colNgayVaoLam = new ColumnHeader();

            this.imgListTree = new ImageList(this.components);
            this.imgListSmall = new ImageList(this.components);
            this.imgListLarge = new ImageList(this.components);

            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = Color.FromArgb(240, 244, 248);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.lblViewMode);
            this.pnlTop.Controls.Add(this.cboViewMode);
            this.pnlTop.Dock = DockStyle.Top;
            this.pnlTop.Location = new Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new Size(920, 50);
            this.pnlTop.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(0, 90, 158);
            this.lblTitle.Location = new Point(15, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(265, 25);
            this.lblTitle.Text = "SƠ ĐỒ TỔ CHỨC & NHÂN SỰ";

            // lblViewMode
            this.lblViewMode.AutoSize = true;
            this.lblViewMode.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lblViewMode.Location = new Point(635, 15);
            this.lblViewMode.Name = "lblViewMode";
            this.lblViewMode.Size = new Size(103, 21);
            this.lblViewMode.Text = "Chế độ xem:";

            // cboViewMode
            this.cboViewMode.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboViewMode.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.cboViewMode.Location = new Point(745, 11);
            this.cboViewMode.Name = "cboViewMode";
            this.cboViewMode.Size = new Size(155, 29);
            this.cboViewMode.TabIndex = 0;
            this.cboViewMode.SelectedIndexChanged += new EventHandler(this.cboViewMode_SelectedIndexChanged);

            // 
            // imgListTree
            // 
            this.imgListTree.ColorDepth = ColorDepth.Depth32Bit;
            this.imgListTree.ImageSize = new Size(18, 18);
            this.imgListTree.TransparentColor = Color.Transparent;

            // 
            // imgListSmall
            // 
            this.imgListSmall.ColorDepth = ColorDepth.Depth32Bit;
            this.imgListSmall.ImageSize = new Size(20, 20);
            this.imgListSmall.TransparentColor = Color.Transparent;

            // 
            // imgListLarge
            // 
            this.imgListLarge.ColorDepth = ColorDepth.Depth32Bit;
            this.imgListLarge.ImageSize = new Size(40, 40);
            this.imgListLarge.TransparentColor = Color.Transparent;

            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.Location = new Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.Size = new Size(920, 470);
            this.splitContainer1.TabIndex = 1;

            // 
            // splitContainer1.Panel1 (TreeView bên trái)
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvDepartments);
            this.splitContainer1.Panel1.Padding = new Padding(10, 10, 0, 10);

            // tvDepartments
            this.tvDepartments.Dock = DockStyle.Fill;
            this.tvDepartments.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.tvDepartments.HideSelection = false;
            this.tvDepartments.ImageList = this.imgListTree;
            this.tvDepartments.ItemHeight = 26;
            this.tvDepartments.Location = new Point(10, 10);
            this.tvDepartments.Name = "tvDepartments";
            this.tvDepartments.Size = new Size(275, 450);
            this.tvDepartments.TabIndex = 0;
            this.tvDepartments.AfterSelect += new TreeViewEventHandler(this.tvDepartments_AfterSelect);

            // 
            // splitContainer1.Panel2 (ListView bên phải)
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lsvEmployees);
            this.splitContainer1.Panel2.Padding = new Padding(0, 10, 10, 10);

            // lsvEmployees
            this.lsvEmployees.Columns.AddRange(new ColumnHeader[] {
                this.colMaNV,
                this.colHoTen,
                this.colChucVu,
                this.colNgayVaoLam
            });
            this.lsvEmployees.Dock = DockStyle.Fill;
            this.lsvEmployees.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lsvEmployees.FullRowSelect = true;
            this.lsvEmployees.GridLines = true;
            this.lsvEmployees.LargeImageList = this.imgListLarge;
            this.lsvEmployees.Location = new Point(0, 10);
            this.lsvEmployees.Name = "lsvEmployees";
            this.lsvEmployees.Size = new Size(620, 450);
            this.lsvEmployees.SmallImageList = this.imgListSmall;
            this.lsvEmployees.TabIndex = 0;
            this.lsvEmployees.UseCompatibleStateImageBehavior = false;
            this.lsvEmployees.View = View.Details;

            // Columns
            this.colMaNV.Text = "Mã NV";
            this.colMaNV.Width = 100;

            this.colHoTen.Text = "Họ Tên";
            this.colHoTen.Width = 200;

            this.colChucVu.Text = "Chức vụ";
            this.colChucVu.Width = 175;

            this.colNgayVaoLam.Text = "Ngày vào làm";
            this.colNgayVaoLam.Width = 130;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(920, 520);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlTop);
            this.MinimumSize = new Size(800, 450);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Bài 5.4 - Quản Lý Tổ Chức & Nhân Sự (TreeView & ListView)";

            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}