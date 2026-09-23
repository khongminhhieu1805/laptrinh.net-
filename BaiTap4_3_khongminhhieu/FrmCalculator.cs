namespace BaiTap4_3_Calculator
{
    public partial class FrmCalculator : Form
    {
        double so1 = 0;
        string pheptoan = "";

        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text = txtDisplay.Text + btn.Text;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtDisplay.Text);
            pheptoan = "+";
            txtDisplay.Text = "";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtDisplay.Text);
            pheptoan = "-";
            txtDisplay.Text = "";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtDisplay.Text);
            pheptoan = "*";
            txtDisplay.Text = "";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtDisplay.Text);
            pheptoan = "/";
            txtDisplay.Text = "";
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            double so2 = double.Parse(txtDisplay.Text);
            double ketqua = 0;

            if (pheptoan == "+") ketqua = so1 + so2;
            if (pheptoan == "-") ketqua = so1 - so2;
            if (pheptoan == "*") ketqua = so1 * so2;
            if (pheptoan == "/") ketqua = so1 / so2;

            txtDisplay.Text = ketqua.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            so1 = 0;
            pheptoan = "";
        }
    }
}
