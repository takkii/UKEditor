using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation;
using System.Text;
using System.Windows.Forms;

namespace UKEditor
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding("UTF-8"));
            String text_area = reader.ReadToEnd();
            string filepath = text_area;
            reader.Close();

            RunspaceInvoke runspaceInvoke = new RunspaceInvoke();

            Collection<PSObject> result = runspaceInvoke.Invoke(filepath);
            runspaceInvoke.Dispose();

            foreach (PSObject result_str in result)
            {
                richTextBox1.AppendText(result_str.ToString());
                richTextBox1.AppendText("\n");　　　　　　　　　　　　//改行する
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void 閉じるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 著作者情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.著作者情報ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            AboutBox1 newAboutBox = new AboutBox1();
            newAboutBox.ShowDialog();
        }
    }
}
