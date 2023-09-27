namespace GUI.TableMana
{
    partial class TableManager
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
            this.flowTable = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelTable = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowTable);
            this.panel1.Controls.Add(this.txtTable);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelTable);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 467);
            this.panel1.TabIndex = 0;
            // 
            // flowTable
            // 
            this.flowTable.Location = new System.Drawing.Point(3, 32);
            this.flowTable.Name = "flowTable";
            this.flowTable.Size = new System.Drawing.Size(814, 432);
            this.flowTable.TabIndex = 3;
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(3, 3);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(158, 20);
            this.txtTable.TabIndex = 2;
            this.txtTable.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(167, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelTable
            // 
            this.btnDelTable.Location = new System.Drawing.Point(742, 3);
            this.btnDelTable.Name = "btnDelTable";
            this.btnDelTable.Size = new System.Drawing.Size(75, 23);
            this.btnDelTable.TabIndex = 0;
            this.btnDelTable.Text = "Xóa";
            this.btnDelTable.UseVisualStyleBackColor = true;
            this.btnDelTable.Click += new System.EventHandler(this.btnDelTable_Click);
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 491);
            this.Controls.Add(this.panel1);
            this.Name = "TableManager";
            this.Text = "Quản lý bàn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelTable;
        private System.Windows.Forms.FlowLayoutPanel flowTable;
    }
}