namespace BaiTap4_1_LoginForm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (txtUsername.Text == "")
            {
                errorProvider.SetError(txtUsername, "Vui lòng nhập tên đăng nhập");
                return;
            }

            if (txtPassword.Text == "")
            {
                errorProvider.SetError(txtPassword, "Vui lòng nhập mật khẩu");
                return;
            }

            MessageBox.Show("Đăng nhập thành công");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
