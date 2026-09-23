namespace BaiTap4_3_Calculator
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmCalculator());
        }
    }
}
