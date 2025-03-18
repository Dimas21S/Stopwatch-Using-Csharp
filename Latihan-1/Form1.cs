namespace Latihan_1
{
    public partial class Form1 : Form
    {
        int seconds = 0;
        int minute = 0;
        int hour = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void ButtonStopwatch_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void TimerStopwatch(object sender, EventArgs e)
        {
            seconds++;

            if (seconds == 60)
            {
                seconds = 0;
                minute ++;

                if (minute == 60)
                {
                    minute = 0;
                    hour ++;
                }
            }

            labelSecond.Text = seconds.ToString("D2");
            labelMinute.Text = minute.ToString("D2");
            labelHour.Text = hour.ToString("D2");
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            seconds = 0;
            minute = 0;
            hour = 0;

            labelSecond.Text = seconds.ToString("D2");
            labelMinute.Text = minute.ToString("D2");
            labelHour.Text = hour.ToString("D2");
        }
    }
}
