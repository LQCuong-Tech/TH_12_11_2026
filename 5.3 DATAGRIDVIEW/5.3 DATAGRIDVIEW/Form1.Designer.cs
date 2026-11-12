using System;
using System.Drawing;
using System.Windows.Forms;

namespace _5._3_DATAGRIDVIEW
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox grpThongTin;
        private Label lblProductId;
        private TextBox txtProductId;
        private Label lblProductName;
        private TextBox txtProductName;
        private Label lblUnitPrice;
        private TextBox txtUnitPrice;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Label lblCategory;
        private ComboBox cboCategory;

        private GroupBox grpChucNang;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;

        private DataGridView dgvProducts;

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
            this.grpThongTin = new GroupBox();
            this.lblProductId = new Label();
            this.txtProductId = new TextBox();
            this.lblProductName = new Label();
            this.txtProductName = new TextBox();
            this.lblUnitPrice = new Label();
            this.txtUnitPrice = new TextBox();
            this.lblQuantity = new Label();
            this.txtQuantity = new TextBox();
            this.lblCategory = new Label();
            this.cboCategory = new ComboBox();

            this.grpChucNang = new GroupBox();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnClear = new Button();
            this.lblSearch = new Label();
            this.txtSearch = new TextBox();
            this.btnSearch = new Button();

            this.dgvProducts = new DataGridView();

            this.grpThongTin.SuspendLayout();
            this.grpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();

            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblProductId);
            this.grpThongTin.Controls.Add(this.txtProductId);
            this.grpThongTin.Controls.Add(this.lblProductName);
            this.grpThongTin.Controls.Add(this.txtProductName);
            this.grpThongTin.Controls.Add(this.lblUnitPrice);
            this.grpThongTin.Controls.Add(this.txtUnitPrice);
            this.grpThongTin.Controls.Add(this.lblQuantity);
            this.grpThongTin.Controls.Add(this.txtQuantity);
            this.grpThongTin.Controls.Add(this.lblCategory);
            this.grpThongTin.Controls.Add(this.cboCategory);
            this.grpThongTin.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.grpThongTin.Location = new Point(20, 15);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new Size(820, 155);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin sản phẩm";

            // lblProductId
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lblProductId.Location = new Point(20, 35);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new Size(63, 21);
            this.lblProductId.Text = "Mã SP:";

            // txtProductId
            this.txtProductId.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.txtProductId.Location = new Point(110, 32);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new Size(260, 29);
            this.txtProductId.TabIndex = 0;

            // lblProductName
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lblProductName.Location = new Point(20, 75);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new Size(66, 21);
            this.lblProductName.Text = "Tên SP:";

            // txtProductName
            this.txtProductName.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.txtProductName.Location = new Point(110, 72);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new Size(260, 29);
            this.txtProductName.TabIndex = 1;

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lblCategory.Location = new Point(20, 115);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new Size(84, 21);
            this.lblCategory.Text = "Danh mục:";

            // cboCategory
            this.cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.cboCategory.Location = new Point(110, 112);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new Size(260, 29);
            this.cboCategory.TabIndex = 2;

            // lblUnitPrice
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lblUnitPrice.Location = new Point(430, 35);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new Size(71, 21);
            this.lblUnitPrice.Text = "Đơn giá:";

            // txtUnitPrice
            this.txtUnitPrice.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.txtUnitPrice.Location = new Point(525, 32);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new Size(265, 29);
            this.txtUnitPrice.TabIndex = 3;

            // lblQuantity
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lblQuantity.Location = new Point(430, 75);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new Size(77, 21);
            this.lblQuantity.Text = "Số lượng:";

            // txtQuantity
            this.txtQuantity.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.txtQuantity.Location = new Point(525, 72);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new Size(265, 29);
            this.txtQuantity.TabIndex = 4;

            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnAdd);
            this.grpChucNang.Controls.Add(this.btnEdit);
            this.grpChucNang.Controls.Add(this.btnDelete);
            this.grpChucNang.Controls.Add(this.btnClear);
            this.grpChucNang.Controls.Add(this.lblSearch);
            this.grpChucNang.Controls.Add(this.txtSearch);
            this.grpChucNang.Controls.Add(this.btnSearch);
            this.grpChucNang.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.grpChucNang.Location = new Point(20, 180);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new Size(820, 75);
            this.grpChucNang.TabIndex = 1;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";

            // btnAdd
            this.btnAdd.BackColor = Color.FromArgb(0, 120, 215);
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnAdd.ForeColor = Color.White;
            this.btnAdd.Location = new Point(20, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(85, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            // btnEdit
            this.btnEdit.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.btnEdit.Location = new Point(115, 30);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new Size(85, 32);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new EventHandler(this.btnEdit_Click);

            // btnDelete
            this.btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.btnDelete.Location = new Point(210, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(85, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.btnClear.Location = new Point(305, 30);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(85, 32);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);

            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lblSearch.Location = new Point(425, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new Size(92, 21);
            this.lblSearch.Text = "Tìm tên SP:";

            // txtSearch
            this.txtSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.txtSearch.Location = new Point(525, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Nhập tên sản phẩm...";
            this.txtSearch.Size = new Size(170, 29);
            this.txtSearch.TabIndex = 4;

            // btnSearch
            this.btnSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.btnSearch.Location = new Point(705, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(85, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);

            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = Color.White;
            this.dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.dgvProducts.Location = new Point(20, 270);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new Size(820, 240);
            this.dgvProducts.TabIndex = 2;
            this.dgvProducts.CellClick += new DataGridViewCellEventHandler(this.dgvProducts_CellClick);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(860, 530);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.dgvProducts);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Bài 5.3 - Quản Lý Danh Sách Sản Phẩm";

            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpChucNang.ResumeLayout(false);
            this.grpChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
        }
    }
}