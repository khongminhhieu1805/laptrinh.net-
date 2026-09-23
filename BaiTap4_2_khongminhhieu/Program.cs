namespace BaiTap4_2_DangKyHocVien
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmDangKy());
        }
    }
}
