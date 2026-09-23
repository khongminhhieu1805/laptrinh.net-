namespace BaiTap4_5_ResponsiveForm
{
    partial class FrmQuanLySinhVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtMaSV = new TextBox();
            label2 = new Label();
            txtHoTen = new TextBox();
            label3 = new Label();
            txtLop = new TextBox();
            panel1 = new Panel();
            lstDanhSach = new ListBox();
            btnThem = new Button();
            btnXoa = new Button();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            //
            // tableLayoutPanel1
            //
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(700, 400);
            tableLayoutPanel1.TabIndex = 0;
            //
            // groupBox1
            //
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtLop);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 394);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(10, 30);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã SV";
            //
            // txtMaSV
            //
            txtMaSV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMaSV.Location = new Point(10, 50);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(184, 23);
            txtMaSV.TabIndex = 1;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(10, 85);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Họ tên";
            //
            // txtHoTen
            //
            txtHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtHoTen.Location = new Point(10, 105);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(184, 23);
            txtHoTen.TabIndex = 3;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(10, 140);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 4;
            label3.Text = "Lớp";
            //
            // txtLop
            //
            txtLop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLop.Location = new Point(10, 160);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(184, 23);
            txtLop.TabIndex = 5;
            //
            // panel1
            //
            panel1.Controls.Add(lstDanhSach);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnXoa);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(213, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 394);
            panel1.TabIndex = 1;
            //
            // lstDanhSach
            //
            lstDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.Location = new Point(10, 10);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.Size = new Size(464, 334);
            lstDanhSach.TabIndex = 0;
            //
            // btnThem
            //
            btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThem.Location = new Point(308, 355);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 30);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            //
            // btnXoa
            //
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoa.Location = new Point(394, 355);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 30);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            //
            // FrmQuanLySinhVien
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 400);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmQuanLySinhVien";
            Text = "Quản lý sinh viên";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtMaSV;
        private Label label2;
        private TextBox txtHoTen;
        private Label label3;
        private TextBox txtLop;
        private Panel panel1;
        private ListBox lstDanhSach;
        private Button btnThem;
        private Button btnXoa;
    }
}
