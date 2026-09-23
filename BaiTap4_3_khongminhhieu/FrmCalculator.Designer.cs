namespace BaiTap4_3_Calculator
{
    partial class FrmCalculator
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
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnChia = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnNhan = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnTru = new Button();
            btnClear = new Button();
            btn0 = new Button();
            btnBang = new Button();
            btnCong = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(20, 20);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(230, 23);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.Location = new Point(20, 60);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 35);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberButton_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(80, 60);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 35);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberButton_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(140, 60);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 35);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberButton_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(200, 60);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(50, 35);
            btnChia.TabIndex = 4;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(20, 105);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 35);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberButton_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(80, 105);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 35);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberButton_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(140, 105);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 35);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberButton_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(200, 105);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(50, 35);
            btnNhan.TabIndex = 8;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(20, 150);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 35);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberButton_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(80, 150);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 35);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberButton_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(140, 150);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 35);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberButton_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(200, 150);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(50, 35);
            btnTru.TabIndex = 12;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(20, 195);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(50, 35);
            btnClear.TabIndex = 13;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(80, 195);
            btn0.Name = "btn0";
            btn0.Size = new Size(50, 35);
            btn0.TabIndex = 14;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += NumberButton_Click;
            // 
            // btnBang
            // 
            btnBang.Location = new Point(140, 195);
            btnBang.Name = "btnBang";
            btnBang.Size = new Size(50, 35);
            btnBang.TabIndex = 15;
            btnBang.Text = "=";
            btnBang.UseVisualStyleBackColor = true;
            btnBang.Click += btnBang_Click;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(200, 195);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(50, 35);
            btnCong.TabIndex = 16;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 250);
            Controls.Add(txtDisplay);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnChia);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btnNhan);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnTru);
            Controls.Add(btnClear);
            Controls.Add(btn0);
            Controls.Add(btnBang);
            Controls.Add(btnCong);
            Name = "FrmCalculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnChia;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnNhan;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnTru;
        private Button btnClear;
        private Button btn0;
        private Button btnBang;
        private Button btnCong;
    }
}
