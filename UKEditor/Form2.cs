using System;
using System.Windows.Forms;

namespace UKEditor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1のTextBox1.Textの値を取得
            string str = ((Form1)this.Owner).TextBoxText;
            
            string s = textBox1.Text;

            //探す文字列が見つかる位置を取得する
            int i = ((Form1)this.Owner).TextBoxText.IndexOf(s);

            if (i > -1)
            {
               this.label3.Text = i + "文字目 : " + "見つかりました。";
            }
            else
            {
                this.label3.Text = "最後まで検索しました。";
            }
        }
    }
}
