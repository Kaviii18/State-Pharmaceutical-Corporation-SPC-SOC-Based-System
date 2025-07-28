using System;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class SplashScreen : Form
    {
        Timer timer;
        int progressValue = 0;

        public SplashScreen()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 30;
            timer.Tick += Timer_Tick;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            progressBar1.Value = 0;
            progressValue = 0;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressValue < 100)
            {
                progressValue++;
                progressBar1.Value = progressValue;
            }
            else
            {
                timer.Stop();
                this.Close(); // Just close splash, let Program.cs handle the main form
            }
        }
    }
}
