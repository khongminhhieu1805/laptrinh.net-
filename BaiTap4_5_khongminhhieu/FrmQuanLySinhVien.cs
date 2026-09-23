namespace BaiTap4_5_ResponsiveForm
{
    public partial class FrmQuanLySinhVien : Form
    {
        public FrmQuanLySinhVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.Add(txtMaSV.Text + " - " + txtHoTen.Text + " - " + txtLop.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedItem != null)
            {
                lstDanhSach.Items.Remove(lstDanhSach.SelectedItem);
            }
        }
    }
}
