namespace GUI
{
    partial class Order
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.muaMangVềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1163, 604);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNhânViênToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinNhânViênToolStripMenuItem
            // 
            this.thôngTinNhânViênToolStripMenuItem.Name = "thôngTinNhânViênToolStripMenuItem";
            this.thôngTinNhânViênToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.thôngTinNhânViênToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.thôngTinNhânViênToolStripMenuItem.Text = "Thông tin nhân viên";
            this.thôngTinNhânViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinNhânViênToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Kết thúc ca làm việc";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.muaMangVềToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1188, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // muaMangVềToolStripMenuItem
            // 
            this.muaMangVềToolStripMenuItem.Name = "muaMangVềToolStripMenuItem";
            this.muaMangVềToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.muaMangVềToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.muaMangVềToolStripMenuItem.Text = "Mua mang về";
            this.muaMangVềToolStripMenuItem.Click += new System.EventHandler(this.muaMangVềToolStripMenuItem_Click);
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTime.Location = new System.Drawing.Point(1095, 0);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(66, 24);
            this.labelCurrentTime.TabIndex = 7;
            this.labelCurrentTime.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 644);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Order";
            this.Text = "Đặt món";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Order_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Order_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muaMangVềToolStripMenuItem;
    }
}