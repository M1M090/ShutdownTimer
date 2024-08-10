using System.Diagnostics;
namespace ShutdownTimer
{
    public partial class Form : System.Windows.Forms.Form
    {

        TimeSpan timeLeft;

        public Form()
        {
            InitializeComponent();
        }

        private void lblHours_Click(object sender, EventArgs e)
        {

        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CheckTextBoxValues();
            bool isStartable = true;

            try
            {

                timeLeft = new TimeSpan(Convert.ToInt32(tbHours.Text), Convert.ToInt32(tbMinutes.Text), Convert.ToInt32(tbSeconds.Text));

            }
            catch (FormatException ex)
            {
                isStartable = false;
                MessageBox.Show(ex.Message);
            }

            if (isStartable == true)
            {

                Timer.Start();
                lblTimer.Text = timeLeft.ToString(@"hh\:mm\:ss");

            }
        }
        private void CheckTextBoxValues()
        {

            if (tbHours.Text.Count() == 0)
                tbHours.Text = "0";

            if (tbMinutes.Text.Count() == 0)
                tbMinutes.Text = "0";

            if (tbSeconds.Text.Count() == 0)
                tbSeconds.Text = "0";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft.Subtract(TimeSpan.FromSeconds(1));
            lblTimer.Text = timeLeft.ToString(@"hh\:mm\:ss");

            if (timeLeft.TotalSeconds <= 0)
            {
                Timer.Stop();
                PerformAction();
            }

        }

        private void PerformAction()
        {
            if (rbShutdown.Checked == true)
                Process.Start("shutdown", "/s");
            else if (rbRestart.Checked == true)
                Process.Start("shutdown", "/r");
            else if (rbSleep.Checked == true)
                Process.Start("rundll32.exe", "powrprof.dll,SetSuspendState");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            lblTimer.Text = "00:00:00";
        }

        private void gbTimer_Enter(object sender, EventArgs e)
        {

        }
    }
}
