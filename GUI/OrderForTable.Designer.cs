namespace GUI
{
    partial class OrderForTable
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowFood = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 626);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 356);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.cbTable);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Location = new System.Drawing.Point(861, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 350);
            this.panel6.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Chuyển bàn";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbTable
            // 
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(3, 3);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(169, 21);
            this.cbTable.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView2);
            this.panel5.Location = new System.Drawing.Point(6, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(849, 350);
            this.panel5.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(843, 344);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.flowFood);
            this.panel3.Controls.Add(this.btnDeleteFood);
            this.panel3.Controls.Add(this.btnAddFood);
            this.panel3.Controls.Add(this.cbCategory);
            this.panel3.Location = new System.Drawing.Point(15, 377);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1042, 258);
            this.panel3.TabIndex = 1;
            // 
            // flowFood
            // 
            this.flowFood.AutoScroll = true;
            this.flowFood.Location = new System.Drawing.Point(3, 30);
            this.flowFood.Name = "flowFood";
            this.flowFood.Size = new System.Drawing.Size(1033, 228);
            this.flowFood.TabIndex = 4;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(880, 4);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFood.TabIndex = 3;
            this.btnDeleteFood.Text = "Xóa món";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(961, 4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(189, 21);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(198, 1);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // OrderForTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "OrderForTable";
            this.Text = "OrderForTable";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.FlowLayoutPanel flowFood;
        private System.Windows.Forms.Button btnReset;
    }
}