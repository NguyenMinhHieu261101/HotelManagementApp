
namespace Quản_lý_dịch_vụ_khấch_sạn
{
    partial class frmQuanLyDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyDichVu));
            this.lb_Tile = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExitDV = new System.Windows.Forms.Button();
            this.dgvQuanlyDV = new System.Windows.Forms.DataGridView();
            this.txtSearchDV = new System.Windows.Forms.TextBox();
            this.btnNhaplaiDV = new System.Windows.Forms.Button();
            this.btnDeleteDV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudDonGiaDV = new System.Windows.Forms.NumericUpDown();
            this.rtbMota = new System.Windows.Forms.RichTextBox();
            this.txtDVTDV = new System.Windows.Forms.TextBox();
            this.txtLoaiDV = new System.Windows.Forms.TextBox();
            this.txtNameService = new System.Windows.Forms.TextBox();
            this.txtIDDV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditDV = new System.Windows.Forms.Button();
            this.btnAddDV = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlyDV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaDV)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Tile
            // 
            this.lb_Tile.AutoSize = true;
            this.lb_Tile.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tile.ForeColor = System.Drawing.Color.Red;
            this.lb_Tile.Location = new System.Drawing.Point(286, 7);
            this.lb_Tile.Name = "lb_Tile";
            this.lb_Tile.Size = new System.Drawing.Size(196, 29);
            this.lb_Tile.TabIndex = 69;
            this.lb_Tile.Text = "Quản lý dịch vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnExitDV);
            this.groupBox2.Controls.Add(this.dgvQuanlyDV);
            this.groupBox2.Controls.Add(this.txtSearchDV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 352);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin dữ liệu dịch vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 72;
            this.label7.Text = "Tìm kiếm theo tên:";
            // 
            // btnExitDV
            // 
            this.btnExitDV.BackColor = System.Drawing.Color.Tomato;
            this.btnExitDV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitDV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExitDV.Image = ((System.Drawing.Image)(resources.GetObject("btnExitDV.Image")));
            this.btnExitDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitDV.Location = new System.Drawing.Point(649, 307);
            this.btnExitDV.Name = "btnExitDV";
            this.btnExitDV.Size = new System.Drawing.Size(110, 40);
            this.btnExitDV.TabIndex = 71;
            this.btnExitDV.Text = "Thoát";
            this.btnExitDV.UseVisualStyleBackColor = false;
            this.btnExitDV.Click += new System.EventHandler(this.btnExitDV_Click);
            // 
            // dgvQuanlyDV
            // 
            this.dgvQuanlyDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlyDV.Location = new System.Drawing.Point(7, 65);
            this.dgvQuanlyDV.Name = "dgvQuanlyDV";
            this.dgvQuanlyDV.RowHeadersWidth = 51;
            this.dgvQuanlyDV.Size = new System.Drawing.Size(752, 212);
            this.dgvQuanlyDV.TabIndex = 2;
            this.dgvQuanlyDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanlyDV_CellClick);
            // 
            // txtSearchDV
            // 
            this.txtSearchDV.Location = new System.Drawing.Point(578, 28);
            this.txtSearchDV.Name = "txtSearchDV";
            this.txtSearchDV.Size = new System.Drawing.Size(181, 26);
            this.txtSearchDV.TabIndex = 0;
            this.txtSearchDV.TextChanged += new System.EventHandler(this.txtSearchDV_TextChanged);
            // 
            // btnNhaplaiDV
            // 
            this.btnNhaplaiDV.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnNhaplaiDV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaplaiDV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNhaplaiDV.Image = ((System.Drawing.Image)(resources.GetObject("btnNhaplaiDV.Image")));
            this.btnNhaplaiDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaplaiDV.Location = new System.Drawing.Point(678, 233);
            this.btnNhaplaiDV.Name = "btnNhaplaiDV";
            this.btnNhaplaiDV.Size = new System.Drawing.Size(110, 40);
            this.btnNhaplaiDV.TabIndex = 82;
            this.btnNhaplaiDV.Text = "Nhập lại";
            this.btnNhaplaiDV.UseVisualStyleBackColor = false;
            this.btnNhaplaiDV.Click += new System.EventHandler(this.btnNhaplaiDV_Click);
            // 
            // btnDeleteDV
            // 
            this.btnDeleteDV.BackColor = System.Drawing.SystemColors.Info;
            this.btnDeleteDV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteDV.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDV.Image")));
            this.btnDeleteDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDV.Location = new System.Drawing.Point(678, 166);
            this.btnDeleteDV.Name = "btnDeleteDV";
            this.btnDeleteDV.Size = new System.Drawing.Size(110, 40);
            this.btnDeleteDV.TabIndex = 81;
            this.btnDeleteDV.Text = "Xóa";
            this.btnDeleteDV.UseVisualStyleBackColor = false;
            this.btnDeleteDV.Click += new System.EventHandler(this.btnDeleteDV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.nudDonGiaDV);
            this.groupBox1.Controls.Add(this.rtbMota);
            this.groupBox1.Controls.Add(this.txtDVTDV);
            this.groupBox1.Controls.Add(this.txtLoaiDV);
            this.groupBox1.Controls.Add(this.txtNameService);
            this.groupBox1.Controls.Add(this.txtIDDV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 229);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // nudDonGiaDV
            // 
            this.nudDonGiaDV.Location = new System.Drawing.Point(434, 67);
            this.nudDonGiaDV.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudDonGiaDV.Name = "nudDonGiaDV";
            this.nudDonGiaDV.Size = new System.Drawing.Size(192, 26);
            this.nudDonGiaDV.TabIndex = 4;
            // 
            // rtbMota
            // 
            this.rtbMota.Location = new System.Drawing.Point(131, 154);
            this.rtbMota.Name = "rtbMota";
            this.rtbMota.Size = new System.Drawing.Size(495, 64);
            this.rtbMota.TabIndex = 5;
            this.rtbMota.Text = "";
            // 
            // txtDVTDV
            // 
            this.txtDVTDV.Location = new System.Drawing.Point(434, 28);
            this.txtDVTDV.Name = "txtDVTDV";
            this.txtDVTDV.Size = new System.Drawing.Size(192, 26);
            this.txtDVTDV.TabIndex = 3;
            // 
            // txtLoaiDV
            // 
            this.txtLoaiDV.Location = new System.Drawing.Point(131, 110);
            this.txtLoaiDV.Name = "txtLoaiDV";
            this.txtLoaiDV.Size = new System.Drawing.Size(153, 26);
            this.txtLoaiDV.TabIndex = 2;
            // 
            // txtNameService
            // 
            this.txtNameService.Location = new System.Drawing.Point(131, 67);
            this.txtNameService.Name = "txtNameService";
            this.txtNameService.Size = new System.Drawing.Size(153, 26);
            this.txtNameService.TabIndex = 1;
            // 
            // txtIDDV
            // 
            this.txtIDDV.BackColor = System.Drawing.Color.White;
            this.txtIDDV.Location = new System.Drawing.Point(131, 25);
            this.txtIDDV.Name = "txtIDDV";
            this.txtIDDV.Size = new System.Drawing.Size(71, 26);
            this.txtIDDV.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mô tả :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn giá :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn vị tính :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại dịch vụ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên dịch vụ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã dịch vụ :";
            // 
            // btnEditDV
            // 
            this.btnEditDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditDV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditDV.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDV.Image")));
            this.btnEditDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDV.Location = new System.Drawing.Point(678, 103);
            this.btnEditDV.Name = "btnEditDV";
            this.btnEditDV.Size = new System.Drawing.Size(110, 40);
            this.btnEditDV.TabIndex = 80;
            this.btnEditDV.Text = "Sửa";
            this.btnEditDV.UseVisualStyleBackColor = false;
            this.btnEditDV.Click += new System.EventHandler(this.btnEditDV_Click);
            // 
            // btnAddDV
            // 
            this.btnAddDV.BackColor = System.Drawing.Color.Turquoise;
            this.btnAddDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddDV.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDV.Image")));
            this.btnAddDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDV.Location = new System.Drawing.Point(678, 44);
            this.btnAddDV.Name = "btnAddDV";
            this.btnAddDV.Size = new System.Drawing.Size(110, 40);
            this.btnAddDV.TabIndex = 79;
            this.btnAddDV.Text = "Thêm";
            this.btnAddDV.UseVisualStyleBackColor = false;
            this.btnAddDV.Click += new System.EventHandler(this.btnAddDV_Click);
            // 
            // frmQuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNhaplaiDV);
            this.Controls.Add(this.btnDeleteDV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEditDV);
            this.Controls.Add(this.btnAddDV);
            this.Controls.Add(this.lb_Tile);
            this.Name = "frmQuanLyDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý dịch vụ";
            this.Load += new System.EventHandler(this.frmQuanLyDichVu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlyDV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Tile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExitDV;
        private System.Windows.Forms.DataGridView dgvQuanlyDV;
        private System.Windows.Forms.TextBox txtSearchDV;
        private System.Windows.Forms.Button btnNhaplaiDV;
        private System.Windows.Forms.Button btnDeleteDV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudDonGiaDV;
        private System.Windows.Forms.RichTextBox rtbMota;
        private System.Windows.Forms.TextBox txtDVTDV;
        private System.Windows.Forms.TextBox txtLoaiDV;
        private System.Windows.Forms.TextBox txtNameService;
        private System.Windows.Forms.TextBox txtIDDV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditDV;
        private System.Windows.Forms.Button btnAddDV;
    }
}