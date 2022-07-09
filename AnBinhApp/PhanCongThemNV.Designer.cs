
namespace AnBinhApp
{
    partial class PhanCongThemNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanCongThemNV));
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.searchForm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel17 = new System.Windows.Forms.Panel();
            this.cbb_TrungTam = new System.Windows.Forms.ComboBox();
            this.btn_HoanTat = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.btn_TimKiem.FlatAppearance.BorderSize = 0;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(557, 127);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(122, 40);
            this.btn_TimKiem.TabIndex = 30;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel16
            // 
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.pictureBox11);
            this.panel16.Controls.Add(this.searchForm);
            this.panel16.Location = new System.Drawing.Point(33, 127);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(338, 40);
            this.panel16.TabIndex = 28;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(14, 8);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(24, 24);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 1;
            this.pictureBox11.TabStop = false;
            // 
            // searchForm
            // 
            this.searchForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.searchForm.Location = new System.Drawing.Point(50, 8);
            this.searchForm.Name = "searchForm";
            this.searchForm.Size = new System.Drawing.Size(265, 21);
            this.searchForm.TabIndex = 0;
            this.searchForm.TextChanged += new System.EventHandler(this.searchForm_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(29, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nháy đúp chuột vào một dòng để xem thông tin chi tiết một nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(21)))), ((int)(((byte)(92)))));
            this.label8.Location = new System.Drawing.Point(24, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(298, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "Thêm nhân viên vào ca";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(646, 316);
            this.dataGridView1.TabIndex = 25;
            // 
            // panel17
            // 
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Controls.Add(this.cbb_TrungTam);
            this.panel17.Location = new System.Drawing.Point(370, 127);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(188, 40);
            this.panel17.TabIndex = 29;
            // 
            // cbb_TrungTam
            // 
            this.cbb_TrungTam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_TrungTam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbb_TrungTam.FormattingEnabled = true;
            this.cbb_TrungTam.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbb_TrungTam.Location = new System.Drawing.Point(13, 6);
            this.cbb_TrungTam.Name = "cbb_TrungTam";
            this.cbb_TrungTam.Size = new System.Drawing.Size(167, 28);
            this.cbb_TrungTam.TabIndex = 10;
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(155)))), ((int)(((byte)(242)))));
            this.btn_HoanTat.FlatAppearance.BorderSize = 0;
            this.btn_HoanTat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoanTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoanTat.ForeColor = System.Drawing.Color.White;
            this.btn_HoanTat.Location = new System.Drawing.Point(557, 524);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Size = new System.Drawing.Size(122, 40);
            this.btn_HoanTat.TabIndex = 31;
            this.btn_HoanTat.Text = "Hoàn tất";
            this.btn_HoanTat.UseVisualStyleBackColor = false;
            this.btn_HoanTat.Click += new System.EventHandler(this.clickClose);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(422, 533);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(24, 29);
            this.pictureBox8.TabIndex = 65;
            this.pictureBox8.TabStop = false;
            // 
            // btn_Them
            // 
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Them.Location = new System.Drawing.Point(405, 524);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(127, 40);
            this.btn_Them.TabIndex = 64;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.button3_Click);
            // 
            // PhanCongThemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 588);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_HoanTat);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel17);
            this.Name = "PhanCongThemNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhanCongThemNV";
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.TextBox searchForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.ComboBox cbb_TrungTam;
        private System.Windows.Forms.Button btn_HoanTat;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btn_Them;
    }
}