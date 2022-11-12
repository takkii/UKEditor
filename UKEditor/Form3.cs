using System;
using System.Windows.Forms;

namespace UKEditor
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        public DateTime datStart;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime dat1 = DateTime.Now;
            TimeSpan timespan = dat1 - datStart;
            label2.Text = timespan.Minutes.ToString("00") + ":"
                + timespan.Seconds.ToString("00") + ":"
                + timespan.Milliseconds.ToString("000");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 100;
            datStart = DateTime.Now;
            timer1.Enabled = true;
            this.button1.Enabled = false;
            this.button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "00:00:000";
            this.button1.Enabled = true;
        }

        private void 閉じるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 newAboutBox = new AboutBox1();
            newAboutBox.ShowDialog();
        }
    }
}