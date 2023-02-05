
namespace Quản_lý_dịch_vụ_khấch_sạn
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.lblThongKe = new System.Windows.Forms.Label();
            this.lbltungay = new System.Windows.Forms.Label();
            this.lblDenngay = new System.Windows.Forms.Label();
            this.dtpTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongKe
            // 
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKe.ForeColor = System.Drawing.Color.Crimson;
            this.lblThongKe.Location = new System.Drawing.Point(309, 23);
            this.lblThongKe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(272, 26);
            this.lblThongKe.TabIndex = 0;
            this.lblThongKe.Text = "THỐNG KÊ THU NHẬP";
            // 
            // lbltungay
            // 
            this.lbltungay.AutoSize = true;
            this.lbltungay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltungay.Location = new System.Drawing.Point(132, 87);
            this.lbltungay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltungay.Name = "lbltungay";
            this.lbltungay.Size = new System.Drawing.Size(81, 21);
            this.lbltungay.TabIndex = 1;
            this.lbltungay.Text = "Từ ngày :";
            // 
            // lblDenngay
            // 
            this.lblDenngay.AutoSize = true;
            this.lblDenngay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenngay.Location = new System.Drawing.Point(459, 85);
            this.lblDenngay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDenngay.Name = "lblDenngay";
            this.lblDenngay.Size = new System.Drawing.Size(90, 21);
            this.lblDenngay.TabIndex = 1;
            this.lblDenngay.Text = "Đến ngày :";
            // 
            // dtpTimeStart
            // 
            this.dtpTimeStart.CustomFormat = "dd/MM/yyyy";
            this.dtpTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeStart.Location = new System.Drawing.Point(225, 81);
            this.dtpTimeStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTimeStart.Name = "dtpTimeStart";
            this.dtpTimeStart.Size = new System.Drawing.Size(193, 22);
            this.dtpTimeStart.TabIndex = 2;
            // 
            // dtpTimeEnd
            // 
            this.dtpTimeEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeEnd.Location = new System.Drawing.Point(563, 81);
            this.dtpTimeEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTimeEnd.Name = "dtpTimeEnd";
            this.dtpTimeEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpTimeEnd.TabIndex = 2;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Red;
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(413, 129);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(129, 34);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 180);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(963, 337);
            this.dataGridView1.TabIndex = 4;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(833, 534);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(147, 33);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xuat.Location = new System.Drawing.Point(644, 534);
            this.btn_Xuat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(160, 33);
            this.btn_Xuat.TabIndex = 8;
            this.btn_Xuat.Text = "Xuất ";
            this.btn_Xuat.UseVisualStyleBackColor = true;
            this.btn_Xuat.Click += new System.EventHandler(this.btn_Xuat_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(996, 582);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xuat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtpTimeEnd);
            this.Controls.Add(this.dtpTimeStart);
            this.Controls.Add(this.lblDenngay);
            this.Controls.Add(this.lbltungay);
            this.Controls.Add(this.lblThongKe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý dịch vụ khách sạn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.Label lbltungay;
        private System.Windows.Forms.Label lblDenngay;
        private System.Windows.Forms.DateTimePicker dtpTimeStart;
        private System.Windows.Forms.DateTimePicker dtpTimeEnd;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xuat;
    }
}