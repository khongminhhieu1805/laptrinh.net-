namespace BaiTap4_4_FastFood
{
    partial class FrmFastFood
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
            groupBox1 = new GroupBox();
            lstMenu = new ListBox();
            groupBox2 = new GroupBox();
            lstSelected = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lblTotal = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            //
            // groupBox1
            //
            groupBox1.Controls.Add(lstMenu);
            groupBox1.Location = new Point(20, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(180, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            //
            // lstMenu
            //
            lstMenu.FormattingEnabled = true;
            lstMenu.Location = new Point(10, 22);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(160, 169);
            lstMenu.TabIndex = 0;
            //
            // groupBox2
            //
            groupBox2.Controls.Add(lstSelected);
            groupBox2.Location = new Point(280, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(180, 200);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Món đã chọn";
            //
            // lstSelected
            //
            lstSelected.FormattingEnabled = true;
            lstSelected.Location = new Point(10, 22);
            lstSelected.Name = "lstSelected";
            lstSelected.Size = new Size(160, 169);
            lstSelected.TabIndex = 0;
            //
            // btnAdd
            //
            btnAdd.Location = new Point(215, 80);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(50, 30);
            btnAdd.TabIndex = 2;
            btnAdd.Text = ">";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            //
            // btnRemove
            //
            btnRemove.Location = new Point(215, 125);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(50, 30);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            //
            // lblTotal
            //
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(280, 235);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(80, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Tổng tiền: 0đ";
            //
            // FrmFastFood
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 270);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(lblTotal);
            Name = "FrmFastFood";
            Text = "Đặt hàng Fast Food";
            Load += FrmFastFood_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstMenu;
        private GroupBox groupBox2;
        private ListBox lstSelected;
        private Button btnAdd;
        private Button btnRemove;
        private Label lblTotal;
    }
}
