namespace BaiTap4_2_DangKyHocVien
{
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            List<KhoaHoc> ds = new List<KhoaHoc>();
            ds.Add(new KhoaHoc { MaKH = "KH01", TenKH = "Lập trình C#" });
            ds.Add(new KhoaHoc { MaKH = "KH02", TenKH = "Lập trình WinForms" });
            ds.Add(new KhoaHoc { MaKH = "KH03", TenKH = "Lập trình Web" });

            cboCourse.DataSource = ds;
            cboCourse.DisplayMember = "TenKH";
            cboCourse.ValueMember = "MaKH";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string gioiTinh = "";
            if (radNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }

            string online = "Không";
            if (chkOnline.Checked == true)
            {
                online = "Có";
            }

            string thongTin = "Họ tên: " + txtHoTen.Text + "\n"
                + "Giới tính: " + gioiTinh + "\n"
                + "Ngày sinh: " + dtpBirthDate.Text + "\n"
                + "SĐT: " + mtxtPhone.Text + "\n"
                + "Khóa học: " + cboCourse.Text + " (" + cboCourse.SelectedValue + ")" + "\n"
                + "Học online: " + online;

            MessageBox.Show(thongTin, "Thông tin đăng ký");
        }
    }
}
