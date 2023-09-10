namespace GUI
{
    partial class ProductManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReloadProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.textCategoryProduct = new System.Windows.Forms.Label();
            this.textPriceCategory = new System.Windows.Forms.Label();
            this.textNameProduct = new System.Windows.Forms.Label();
            this.textCodeProduct = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 537);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 534);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin sản phẩm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtSearchProduct);
            this.panel2.Controls.Add(this.btnReloadProduct);
            this.panel2.Controls.Add(this.btnDeleteProduct);
            this.panel2.Controls.Add(this.btnEditProduct);
            this.panel2.Controls.Add(this.btnAddProduct);
            this.panel2.Controls.Add(this.textCategoryProduct);
            this.panel2.Controls.Add(this.textPriceCategory);
            this.panel2.Controls.Add(this.textNameProduct);
            this.panel2.Controls.Add(this.textCodeProduct);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(641, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 534);
            this.panel2.TabIndex = 2;
            // 
            // btnReloadProduct
            // 
            this.btnReloadProduct.Location = new System.Drawing.Point(249, 320);
            this.btnReloadProduct.Name = "btnReloadProduct";
            this.btnReloadProduct.Size = new System.Drawing.Size(75, 23);
            this.btnReloadProduct.TabIndex = 2;
            this.btnReloadProduct.Text = "Xem";
            this.btnReloadProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(168, 320);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Xóa";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(87, 320);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(75, 23);
            this.btnEditProduct.TabIndex = 2;
            this.btnEditProduct.Text = "Sửa";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(6, 320);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // textCategoryProduct
            // 
            this.textCategoryProduct.AutoSize = true;
            this.textCategoryProduct.Location = new System.Drawing.Point(3, 270);
            this.textCategoryProduct.Name = "textCategoryProduct";
            this.textCategoryProduct.Size = new System.Drawing.Size(41, 13);
            this.textCategoryProduct.TabIndex = 1;
            this.textCategoryProduct.Text = "Cà phê";
            // 
            // textPriceCategory
            // 
            this.textPriceCategory.AutoSize = true;
            this.textPriceCategory.Location = new System.Drawing.Point(3, 218);
            this.textPriceCategory.Name = "textPriceCategory";
            this.textPriceCategory.Size = new System.Drawing.Size(37, 13);
            this.textPriceCategory.TabIndex = 1;
            this.textPriceCategory.Text = "20000";
            // 
            // textNameProduct
            // 
            this.textNameProduct.AutoSize = true;
            this.textNameProduct.Location = new System.Drawing.Point(3, 168);
            this.textNameProduct.Name = "textNameProduct";
            this.textNameProduct.Size = new System.Drawing.Size(42, 13);
            this.textNameProduct.TabIndex = 1;
            this.textNameProduct.Text = "Bạc xỉu";
            // 
            // textCodeProduct
            // 
            this.textCodeProduct.AutoSize = true;
            this.textCodeProduct.Location = new System.Drawing.Point(3, 120);
            this.textCodeProduct.Name = "textCodeProduct";
            this.textCodeProduct.Size = new System.Drawing.Size(52, 13);
            this.textCodeProduct.TabIndex = 1;
            this.textCodeProduct.Text = "Test_001";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(48, 0);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(195, 20);
            this.txtSearchProduct.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 604);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ProductManager";
            this.Text = "ProductManager";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textCategoryProduct;
        private System.Windows.Forms.Label textPriceCategory;
        private System.Windows.Forms.Label textNameProduct;
        private System.Windows.Forms.Label textCodeProduct;
        private System.Windows.Forms.Button btnReloadProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearchProduct;
    }
}