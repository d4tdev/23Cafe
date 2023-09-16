namespace GUI.Staff
{
    partial class StaffInformationDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInformationDetail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnDelStaff = new System.Windows.Forms.Button();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditStaff);
            this.panel1.Controls.Add(this.btnDelStaff);
            this.panel1.Controls.Add(this.labelHour);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 362);
            this.panel1.TabIndex = 0;
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStaff.Location = new System.Drawing.Point(408, 336);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(110, 23);
            this.btnEditStaff.TabIndex = 3;
            this.btnEditStaff.Text = "Sửa thông tin";
            this.btnEditStaff.UseVisualStyleBackColor = true;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnDelStaff
            // 
            this.btnDelStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelStaff.Location = new System.Drawing.Point(327, 336);
            this.btnDelStaff.Name = "btnDelStaff";
            this.btnDelStaff.Size = new System.Drawing.Size(75, 23);
            this.btnDelStaff.TabIndex = 3;
            this.btnDelStaff.Text = "Xóa";
            this.btnDelStaff.UseVisualStyleBackColor = true;
            this.btnDelStaff.Click += new System.EventHandler(this.btnDelStaff_Click);
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour.Location = new System.Drawing.Point(299, 278);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(54, 20);
            this.labelHour.TabIndex = 2;
            this.labelHour.Text = "10000";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(299, 249);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(99, 20);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "0123456789";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(299, 218);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(118, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Chu Quang Hải";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số giờ làm việc:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(201, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // StaffInformationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 386);
            this.Controls.Add(this.panel1);
            this.Name = "StaffInformationDetail";
            this.Text = "Thông tin chi tiết nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffInformationDetail_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Button btnDelStaff;
    }
}