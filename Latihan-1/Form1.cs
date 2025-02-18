namespace Latihan_1
{
    public partial class Form1 : Form
    {
        int a = 0;

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
            a++;
            labelStopwatch.Text = TimeSpan.FromSeconds(a).ToString();
            
        }
    }
}
