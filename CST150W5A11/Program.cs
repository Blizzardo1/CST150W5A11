using System.Windows.Forms;

namespace CST150W5A11
{
    internal static class Program
    {
        public static readonly Random Random;

        static Program()
        {
            Random = new();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static async Task Main()
        { 
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            await Task.CompletedTask;
        }
    }
}
