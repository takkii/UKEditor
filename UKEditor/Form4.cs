using System;
using System.Windows.Forms;

namespace UKEditor
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void 今日の日付ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dat = DateTime.Now;
            label2.Text = dat.ToLongDateString();
        }

        private void 現在時刻ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dat = DateTime.Now;
            label2.Text = dat.ToShortTimeString();
        }

        private void 閉じるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dat = DateTime.Now;
            label1.Text = dat.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dat = DateTime.Now;
            label2.Text = dat.ToLongDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dat = DateTime.Now;
            label2.Text = dat.ToShortTimeString();
        }

        private void button3_Click(object sender, EventArgs e)
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
