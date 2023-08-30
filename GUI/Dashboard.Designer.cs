namespace GUI
{
    partial class Dashboard
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
            this.btnLogoutAdmin = new System.Windows.Forms.Button();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.txtUsernameAccount = new System.Windows.Forms.TextBox();
            this.labelUsernameAccount = new System.Windows.Forms.Label();
            this.txtPasswordAccount = new System.Windows.Forms.TextBox();
            this.labelPasswordAccount = new System.Windows.Forms.Label();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.txtSearchAccount = new System.Windows.Forms.TextBox();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBoxCategoryFood = new System.Windows.Forms.ComboBox();
            this.labelCategoryFood = new System.Windows.Forms.Label();
            this.txtPriceFood = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodeFood = new System.Windows.Forms.TextBox();
            this.labelCodeFood = new System.Windows.Forms.Label();
            this.txtNameFood = new System.Windows.Forms.TextBox();
            this.labelNameFood = new System.Windows.Forms.Label();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.btnViewFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnNaviOrder = new System.Windows.Forms.Button();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.labelTable = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.btnSearchTable = new System.Windows.Forms.Button();
            this.txtSearchTable = new System.Windows.Forms.TextBox();
            this.btnViewTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.dgrCategory = new System.Windows.Forms.DataGridView();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.btnViewCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.tabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogoutAdmin
            // 
            this.btnLogoutAdmin.Location = new System.Drawing.Point(927, 578);
            this.btnLogoutAdmin.Name = "btnLogoutAdmin";
            this.btnLogoutAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnLogoutAdmin.TabIndex = 0;
            this.btnLogoutAdmin.Text = "Đăng xuất";
            this.btnLogoutAdmin.UseVisualStyleBackColor = true;
            this.btnLogoutAdmin.Click += new System.EventHandler(this.btnLogoutAdmin_Click);
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabPage1);
            this.tabPage.Controls.Add(this.tabPage2);
            this.tabPage.Controls.Add(this.tabPage3);
            this.tabPage.Controls.Add(this.tabPage4);
            this.tabPage.Controls.Add(this.tabPage5);
            this.tabPage.Location = new System.Drawing.Point(13, 13);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(989, 559);
            this.tabPage.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnViewBill);
            this.tabPage1.Controls.Add(this.dgvBill);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(981, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý doanh thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSearchAccount);
            this.tabPage2.Controls.Add(this.txtUsernameAccount);
            this.tabPage2.Controls.Add(this.labelUsernameAccount);
            this.tabPage2.Controls.Add(this.txtPasswordAccount);
            this.tabPage2.Controls.Add(this.labelPasswordAccount);
            this.tabPage2.Controls.Add(this.dgvAccount);
            this.tabPage2.Controls.Add(this.txtSearchAccount);
            this.tabPage2.Controls.Add(this.btnViewAccount);
            this.tabPage2.Controls.Add(this.btnDeleteAccount);
            this.tabPage2.Controls.Add(this.btnEditAccount);
            this.tabPage2.Controls.Add(this.btnAddAccount);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(981, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý tài khoản";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.Location = new System.Drawing.Point(900, 5);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAccount.TabIndex = 22;
            this.btnSearchAccount.Text = "Tìm kiếm";
            this.btnSearchAccount.UseVisualStyleBackColor = true;
            // 
            // txtUsernameAccount
            // 
            this.txtUsernameAccount.Location = new System.Drawing.Point(608, 121);
            this.txtUsernameAccount.Name = "txtUsernameAccount";
            this.txtUsernameAccount.Size = new System.Drawing.Size(366, 20);
            this.txtUsernameAccount.TabIndex = 18;
            // 
            // labelUsernameAccount
            // 
            this.labelUsernameAccount.AutoSize = true;
            this.labelUsernameAccount.Location = new System.Drawing.Point(609, 105);
            this.labelUsernameAccount.Name = "labelUsernameAccount";
            this.labelUsernameAccount.Size = new System.Drawing.Size(73, 13);
            this.labelUsernameAccount.TabIndex = 15;
            this.labelUsernameAccount.Text = "Tên tài khoản";
            // 
            // txtPasswordAccount
            // 
            this.txtPasswordAccount.Location = new System.Drawing.Point(608, 175);
            this.txtPasswordAccount.Name = "txtPasswordAccount";
            this.txtPasswordAccount.Size = new System.Drawing.Size(366, 20);
            this.txtPasswordAccount.TabIndex = 19;
            // 
            // labelPasswordAccount
            // 
            this.labelPasswordAccount.AutoSize = true;
            this.labelPasswordAccount.Location = new System.Drawing.Point(609, 159);
            this.labelPasswordAccount.Name = "labelPasswordAccount";
            this.labelPasswordAccount.Size = new System.Drawing.Size(52, 13);
            this.labelPasswordAccount.TabIndex = 16;
            this.labelPasswordAccount.Text = "Mật khẩu";
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(6, 36);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(590, 490);
            this.dgvAccount.TabIndex = 13;
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.Location = new System.Drawing.Point(605, 8);
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.Size = new System.Drawing.Size(288, 20);
            this.txtSearchAccount.TabIndex = 12;
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Location = new System.Drawing.Point(249, 6);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(75, 23);
            this.btnViewAccount.TabIndex = 8;
            this.btnViewAccount.Text = "Xem";
            this.btnViewAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(168, 6);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAccount.TabIndex = 9;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(87, 6);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(75, 23);
            this.btnEditAccount.TabIndex = 10;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(6, 6);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(75, 23);
            this.btnAddAccount.TabIndex = 11;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtTable);
            this.tabPage3.Controls.Add(this.labelTable);
            this.tabPage3.Controls.Add(this.dgvTable);
            this.tabPage3.Controls.Add(this.btnSearchTable);
            this.tabPage3.Controls.Add(this.txtSearchTable);
            this.tabPage3.Controls.Add(this.btnViewTable);
            this.tabPage3.Controls.Add(this.btnDeleteTable);
            this.tabPage3.Controls.Add(this.btnEditTable);
            this.tabPage3.Controls.Add(this.btnAddTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(981, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản lý bàn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.comboBoxCategoryFood);
            this.tabPage4.Controls.Add(this.labelCategoryFood);
            this.tabPage4.Controls.Add(this.txtPriceFood);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.txtCodeFood);
            this.tabPage4.Controls.Add(this.labelCodeFood);
            this.tabPage4.Controls.Add(this.txtNameFood);
            this.tabPage4.Controls.Add(this.labelNameFood);
            this.tabPage4.Controls.Add(this.dgvFood);
            this.tabPage4.Controls.Add(this.btnSearchFood);
            this.tabPage4.Controls.Add(this.txtSearchFood);
            this.tabPage4.Controls.Add(this.btnViewFood);
            this.tabPage4.Controls.Add(this.btnDeleteFood);
            this.tabPage4.Controls.Add(this.btnEditFood);
            this.tabPage4.Controls.Add(this.btnAddFood);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(981, 533);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Quản lý món";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategoryFood
            // 
            this.comboBoxCategoryFood.FormattingEnabled = true;
            this.comboBoxCategoryFood.Location = new System.Drawing.Point(609, 299);
            this.comboBoxCategoryFood.Name = "comboBoxCategoryFood";
            this.comboBoxCategoryFood.Size = new System.Drawing.Size(366, 21);
            this.comboBoxCategoryFood.TabIndex = 7;
            // 
            // labelCategoryFood
            // 
            this.labelCategoryFood.AutoSize = true;
            this.labelCategoryFood.Location = new System.Drawing.Point(610, 282);
            this.labelCategoryFood.Name = "labelCategoryFood";
            this.labelCategoryFood.Size = new System.Drawing.Size(56, 13);
            this.labelCategoryFood.TabIndex = 6;
            this.labelCategoryFood.Text = "Danh mục";
            // 
            // txtPriceFood
            // 
            this.txtPriceFood.Location = new System.Drawing.Point(609, 236);
            this.txtPriceFood.Name = "txtPriceFood";
            this.txtPriceFood.Size = new System.Drawing.Size(366, 20);
            this.txtPriceFood.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá thành";
            // 
            // txtCodeFood
            // 
            this.txtCodeFood.Location = new System.Drawing.Point(609, 122);
            this.txtCodeFood.Name = "txtCodeFood";
            this.txtCodeFood.Size = new System.Drawing.Size(366, 20);
            this.txtCodeFood.TabIndex = 5;
            // 
            // labelCodeFood
            // 
            this.labelCodeFood.AutoSize = true;
            this.labelCodeFood.Location = new System.Drawing.Point(610, 106);
            this.labelCodeFood.Name = "labelCodeFood";
            this.labelCodeFood.Size = new System.Drawing.Size(45, 13);
            this.labelCodeFood.TabIndex = 4;
            this.labelCodeFood.Text = "Mã món";
            // 
            // txtNameFood
            // 
            this.txtNameFood.Location = new System.Drawing.Point(609, 176);
            this.txtNameFood.Name = "txtNameFood";
            this.txtNameFood.Size = new System.Drawing.Size(366, 20);
            this.txtNameFood.TabIndex = 5;
            // 
            // labelNameFood
            // 
            this.labelNameFood.AutoSize = true;
            this.labelNameFood.Location = new System.Drawing.Point(610, 160);
            this.labelNameFood.Name = "labelNameFood";
            this.labelNameFood.Size = new System.Drawing.Size(49, 13);
            this.labelNameFood.TabIndex = 4;
            this.labelNameFood.Text = "Tên món";
            // 
            // dgvFood
            // 
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(7, 37);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.Size = new System.Drawing.Size(590, 490);
            this.dgvFood.TabIndex = 3;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Location = new System.Drawing.Point(900, 7);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(75, 23);
            this.btnSearchFood.TabIndex = 2;
            this.btnSearchFood.Text = "Tìm kiếm";
            this.btnSearchFood.UseVisualStyleBackColor = true;
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Location = new System.Drawing.Point(606, 9);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(288, 20);
            this.txtSearchFood.TabIndex = 1;
            // 
            // btnViewFood
            // 
            this.btnViewFood.Location = new System.Drawing.Point(250, 7);
            this.btnViewFood.Name = "btnViewFood";
            this.btnViewFood.Size = new System.Drawing.Size(75, 23);
            this.btnViewFood.TabIndex = 0;
            this.btnViewFood.Text = "Xem";
            this.btnViewFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(169, 7);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFood.TabIndex = 0;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(88, 7);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(75, 23);
            this.btnEditFood.TabIndex = 0;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(7, 7);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtCategory);
            this.tabPage5.Controls.Add(this.labelCategory);
            this.tabPage5.Controls.Add(this.dgrCategory);
            this.tabPage5.Controls.Add(this.btnSearchCategory);
            this.tabPage5.Controls.Add(this.txtSearchCategory);
            this.tabPage5.Controls.Add(this.btnViewCategory);
            this.tabPage5.Controls.Add(this.btnDeleteCategory);
            this.tabPage5.Controls.Add(this.btnEditCategory);
            this.tabPage5.Controls.Add(this.btnAddCategory);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(981, 533);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Quản lý danh mục";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnNaviOrder
            // 
            this.btnNaviOrder.Location = new System.Drawing.Point(846, 578);
            this.btnNaviOrder.Name = "btnNaviOrder";
            this.btnNaviOrder.Size = new System.Drawing.Size(75, 23);
            this.btnNaviOrder.TabIndex = 2;
            this.btnNaviOrder.Text = "Đặt món";
            this.btnNaviOrder.UseVisualStyleBackColor = true;
            this.btnNaviOrder.Click += new System.EventHandler(this.btnNaviOrder_Click);
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(608, 121);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(366, 20);
            this.txtTable.TabIndex = 14;
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Location = new System.Drawing.Point(609, 105);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(26, 13);
            this.labelTable.TabIndex = 13;
            this.labelTable.Text = "Bàn";
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(6, 36);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(590, 490);
            this.dgvTable.TabIndex = 12;
            // 
            // btnSearchTable
            // 
            this.btnSearchTable.Location = new System.Drawing.Point(899, 6);
            this.btnSearchTable.Name = "btnSearchTable";
            this.btnSearchTable.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTable.TabIndex = 11;
            this.btnSearchTable.Text = "Tìm kiếm";
            this.btnSearchTable.UseVisualStyleBackColor = true;
            // 
            // txtSearchTable
            // 
            this.txtSearchTable.Location = new System.Drawing.Point(605, 8);
            this.txtSearchTable.Name = "txtSearchTable";
            this.txtSearchTable.Size = new System.Drawing.Size(288, 20);
            this.txtSearchTable.TabIndex = 10;
            // 
            // btnViewTable
            // 
            this.btnViewTable.Location = new System.Drawing.Point(249, 6);
            this.btnViewTable.Name = "btnViewTable";
            this.btnViewTable.Size = new System.Drawing.Size(75, 23);
            this.btnViewTable.TabIndex = 6;
            this.btnViewTable.Text = "Xem";
            this.btnViewTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(168, 6);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTable.TabIndex = 7;
            this.btnDeleteTable.Text = "Xóa";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnEditTable
            // 
            this.btnEditTable.Location = new System.Drawing.Point(87, 6);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(75, 23);
            this.btnEditTable.TabIndex = 8;
            this.btnEditTable.Text = "Sửa";
            this.btnEditTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(6, 6);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(75, 23);
            this.btnAddTable.TabIndex = 9;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = true;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(608, 121);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(366, 20);
            this.txtCategory.TabIndex = 23;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(609, 105);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(56, 13);
            this.labelCategory.TabIndex = 22;
            this.labelCategory.Text = "Danh mục";
            // 
            // dgrCategory
            // 
            this.dgrCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrCategory.Location = new System.Drawing.Point(6, 36);
            this.dgrCategory.Name = "dgrCategory";
            this.dgrCategory.Size = new System.Drawing.Size(590, 490);
            this.dgrCategory.TabIndex = 21;
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.Location = new System.Drawing.Point(899, 6);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCategory.TabIndex = 20;
            this.btnSearchCategory.Text = "Tìm kiếm";
            this.btnSearchCategory.UseVisualStyleBackColor = true;
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Location = new System.Drawing.Point(605, 8);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(288, 20);
            this.txtSearchCategory.TabIndex = 19;
            // 
            // btnViewCategory
            // 
            this.btnViewCategory.Location = new System.Drawing.Point(249, 6);
            this.btnViewCategory.Name = "btnViewCategory";
            this.btnViewCategory.Size = new System.Drawing.Size(75, 23);
            this.btnViewCategory.TabIndex = 15;
            this.btnViewCategory.Text = "Xem";
            this.btnViewCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(168, 6);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCategory.TabIndex = 16;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(87, 6);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(75, 23);
            this.btnEditCategory.TabIndex = 17;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(6, 6);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 23);
            this.btnAddCategory.TabIndex = 18;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(775, 6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(7, 33);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.Size = new System.Drawing.Size(968, 494);
            this.dgvBill.TabIndex = 2;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(455, 6);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(75, 23);
            this.btnViewBill.TabIndex = 3;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 613);
            this.Controls.Add(this.btnNaviOrder);
            this.Controls.Add(this.tabPage);
            this.Controls.Add(this.btnLogoutAdmin);
            this.Name = "Dashboard";
            this.Text = "Quản lý hệ thống";
            this.tabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogoutAdmin;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnNaviOrder;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.Button btnViewFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.TextBox txtPriceFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodeFood;
        private System.Windows.Forms.Label labelCodeFood;
        private System.Windows.Forms.TextBox txtNameFood;
        private System.Windows.Forms.Label labelNameFood;
        private System.Windows.Forms.Label labelCategoryFood;
        private System.Windows.Forms.ComboBox comboBoxCategoryFood;
        private System.Windows.Forms.Button btnSearchAccount;
        private System.Windows.Forms.TextBox txtUsernameAccount;
        private System.Windows.Forms.Label labelUsernameAccount;
        private System.Windows.Forms.TextBox txtPasswordAccount;
        private System.Windows.Forms.Label labelPasswordAccount;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.TextBox txtSearchAccount;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button btnSearchTable;
        private System.Windows.Forms.TextBox txtSearchTable;
        private System.Windows.Forms.Button btnViewTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.DataGridView dgrCategory;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.Button btnViewCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}