using System;
using System.Windows.Forms;

namespace ClientApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show SplashScreen as a dialog
            using (var splash = new SplashScreen())
            {
                splash.ShowDialog();
            }

            // After SplashScreen closes, open your main form
            Application.Run(new Form1());
        }
    }
}
