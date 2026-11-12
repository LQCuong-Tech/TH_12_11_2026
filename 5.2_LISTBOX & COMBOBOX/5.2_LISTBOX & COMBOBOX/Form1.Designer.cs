using System;
using System.Drawing;
using System.Windows.Forms;

namespace _5._2_LISTBOX___COMBOBOX
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblAvailable;
        private ListBox lstAvailableServices;

        private Button btnSelect;
        private Button btnRemove;
        private Button btnClearAll;

        private Label lblSelected;
        private ListBox lstSelectedServices;

        private GroupBox grpThanhToan;
        private Label lblMaGiamGia;
        private TextBox txtMaGiamGia;
        private Button btnApDung;
        private Label lblChietKhau;
        private TextBox txtChietKhau;

        private Label lblTongTien;
        private TextBox txtTongTien;
        private Label lblThanhTien;
        private TextBox txtThanhTien;

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
            this.lblCategory = new Label();
            this.cboCategory = new ComboBox();
            this.lblAvailable = new Label();
            this.lstAvailableServices = new ListBox();

            this.btnSelect = new Button();
            this.btnRemove = new Button();
            this.btnClearAll = new Button();

            this.lblSelected = new Label();
            this.lstSelectedServices = new ListBox();

            this.grpThanhToan = new GroupBox();
            this.lblMaGiamGia = new Label();
            this.txtMaGiamGia = new TextBox();
            this.btnApDung = new Button();
            this.lblChietKhau = new Label();
            this.txtChietKhau = new TextBox();
            this.lblTongTien = new Label();
            this.txtTongTien = new TextBox();
            this.lblThanhTien = new Label();
            this.txtThanhTien = new TextBox();

            this.grpThanhToan.SuspendLayout();
            this.SuspendLayout();

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblCategory.Location = new Point(20, 15);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new Size(105, 21);
            this.lblCategory.Text = "Loại dịch vụ:";

            // cboCategory
            this.cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.cboCategory.Location = new Point(20, 40);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new Size(370, 29);
            this.cboCategory.TabIndex = 0;
            this.cboCategory.SelectedIndexChanged += new EventHandler(this.cboCategory_SelectedIndexChanged);

            // lblAvailable
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblAvailable.Location = new Point(20, 80);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new Size(165, 21);
            this.lblAvailable.Text = "Danh sách dịch vụ:";

            // lstAvailableServices
            this.lstAvailableServices.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lstAvailableServices.FormattingEnabled = true;
            this.lstAvailableServices.HorizontalScrollbar = true;
            this.lstAvailableServices.ItemHeight = 21;
            this.lstAvailableServices.Location = new Point(20, 105);
            this.lstAvailableServices.Name = "lstAvailableServices";
            this.lstAvailableServices.Size = new Size(370, 193);
            this.lstAvailableServices.TabIndex = 1;
            this.lstAvailableServices.DoubleClick += new EventHandler(this.lstAvailableServices_DoubleClick);

            // btnSelect (>)
            this.btnSelect.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSelect.Location = new Point(405, 125);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new Size(55, 36);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = ">";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new EventHandler(this.btnSelect_Click);

            // btnRemove (<)
            this.btnRemove.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnRemove.Location = new Point(405, 175);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new Size(55, 36);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new EventHandler(this.btnRemove_Click);

            // btnClearAll (<<)
            this.btnClearAll.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnClearAll.Location = new Point(405, 225);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new Size(55, 36);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "<<";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new EventHandler(this.btnClearAll_Click);

            // lblSelected
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblSelected.Location = new Point(475, 15);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new Size(140, 21);
            this.lblSelected.Text = "Dịch vụ đã chọn:";

            // lstSelectedServices
            this.lstSelectedServices.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lstSelectedServices.FormattingEnabled = true;
            this.lstSelectedServices.HorizontalScrollbar = true;
            this.lstSelectedServices.ItemHeight = 21;
            this.lstSelectedServices.Location = new Point(475, 40);
            this.lstSelectedServices.Name = "lstSelectedServices";
            this.lstSelectedServices.Size = new Size(385, 256);
            this.lstSelectedServices.TabIndex = 5;
            this.lstSelectedServices.DoubleClick += new EventHandler(this.btnRemove_Click);

            // 
            // grpThanhToan
            // 
            this.grpThanhToan.Controls.Add(this.lblMaGiamGia);
            this.grpThanhToan.Controls.Add(this.txtMaGiamGia);
            this.grpThanhToan.Controls.Add(this.btnApDung);
            this.grpThanhToan.Controls.Add(this.lblChietKhau);
            this.grpThanhToan.Controls.Add(this.txtChietKhau);
            this.grpThanhToan.Controls.Add(this.lblTongTien);
            this.grpThanhToan.Controls.Add(this.txtTongTien);
            this.grpThanhToan.Controls.Add(this.lblThanhTien);
            this.grpThanhToan.Controls.Add(this.txtThanhTien);
            this.grpThanhToan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.grpThanhToan.Location = new Point(20, 315);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new Size(840, 130);
            this.grpThanhToan.TabIndex = 6;
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "Thông tin thanh toán & Chiết khấu";

            // lblMaGiamGia
            this.lblMaGiamGia.AutoSize = true;
            this.lblMaGiamGia.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lblMaGiamGia.Location = new Point(20, 35);
            this.lblMaGiamGia.Name = "lblMaGiamGia";
            this.lblMaGiamGia.Size = new Size(99, 21);
            this.lblMaGiamGia.Text = "Mã giảm giá:";

            // txtMaGiamGia
            this.txtMaGiamGia.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.txtMaGiamGia.Location = new Point(165, 32);
            this.txtMaGiamGia.Name = "txtMaGiamGia";
            this.txtMaGiamGia.PlaceholderText = "VD: GIAM10, GIAM20";
            this.txtMaGiamGia.Size = new Size(155, 29);
            this.txtMaGiamGia.TabIndex = 0;

            // btnApDung
            this.btnApDung.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnApDung.Location = new Point(328, 31);
            this.btnApDung.Name = "btnApDung";
            this.btnApDung.Size = new Size(85, 30);
            this.btnApDung.TabIndex = 1;
            this.btnApDung.Text = "Áp dụng";
            this.btnApDung.UseVisualStyleBackColor = true;
            this.btnApDung.Click += new EventHandler(this.btnApDung_Click);

            // lblChietKhau
            this.lblChietKhau.AutoSize = true;
            this.lblChietKhau.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lblChietKhau.Location = new Point(20, 80);
            this.lblChietKhau.Name = "lblChietKhau";
            this.lblChietKhau.Size = new Size(134, 21);
            this.lblChietKhau.Text = "Tỷ lệ chiết khấu (%):";

            // txtChietKhau
            this.txtChietKhau.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.txtChietKhau.Location = new Point(165, 77);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.Size = new Size(248, 29);
            this.txtChietKhau.TabIndex = 2;
            this.txtChietKhau.Text = "0";
            this.txtChietKhau.TextAlign = HorizontalAlignment.Right;
            this.txtChietKhau.TextChanged += new EventHandler(this.txtChietKhau_TextChanged);

            // lblTongTien
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lblTongTien.Location = new Point(455, 35);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new Size(146, 21);
            this.lblTongTien.Text = "Tổng tiền chưa giảm:";

            // txtTongTien
            this.txtTongTien.BackColor = Color.WhiteSmoke;
            this.txtTongTien.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.txtTongTien.Location = new Point(630, 32);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new Size(185, 29);
            this.txtTongTien.TabIndex = 3;
            this.txtTongTien.Text = "0 VNĐ";
            this.txtTongTien.TextAlign = HorizontalAlignment.Right;

            // lblThanhTien
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblThanhTien.Location = new Point(455, 80);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new Size(148, 21);
            this.lblThanhTien.Text = "Thành tiền thanh toán:";

            // txtThanhTien
            this.txtThanhTien.BackColor = Color.FromArgb(255, 250, 240);
            this.txtThanhTien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.txtThanhTien.ForeColor = Color.Firebrick;
            this.txtThanhTien.Location = new Point(630, 76);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new Size(185, 30);
            this.txtThanhTien.TabIndex = 4;
            this.txtThanhTien.Text = "0 VNĐ";
            this.txtThanhTien.TextAlign = HorizontalAlignment.Right;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(880, 465);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lstAvailableServices);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lstSelectedServices);
            this.Controls.Add(this.grpThanhToan);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Bài 5.2 - Bảng Tính Tiền Dịch Vụ & Chiết Khấu";

            this.grpThanhToan.ResumeLayout(false);
            this.grpThanhToan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}