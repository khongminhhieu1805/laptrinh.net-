namespace BaiTap4_5_ResponsiveForm
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmQuanLySinhVien());
        }
    }
}
