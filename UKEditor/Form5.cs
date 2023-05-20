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
        private string FileName = "";

        public Form5()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
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

        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.saveFileDialog1.Title = "ファイルの選択";
                this.saveFileDialog1.RestoreDirectory = true;
                this.saveFileDialog1.Filter = "PowerShellファイル|*.ps1|テキストファイル|*.txt|すべてのファイル|*.*";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog1.FileName;
                    StreamWriter writer = new StreamWriter(FileName, false, Encoding.GetEncoding("UTF-8"));
                    writer.Write(textBox1.Text);
                    writer.Close();
                    Text = Path.GetFileName(FileName) + " - PowerShellBox";
                    上書き保存ToolStripMenuItem.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラーを捕捉しました");
            }
        }

        private void 上書き保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(FileName, richTextBox1.Text, Encoding.GetEncoding("UTF-8")); 
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Title = "ファイルの選択";
            this.openFileDialog1.CheckFileExists = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Filter = "PowerShellファイル|*.ps1|テキストファイル|*.txt|すべてのファイル|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                StreamReader reader = new StreamReader(FileName, Encoding.GetEncoding("UTF-8"));
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
                Text = Path.GetFileName(FileName) + " - PowerShellBox";
                上書き保存ToolStripMenuItem.Enabled = true;
            }
        }

        private void 新規作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Text = "無題 - PowerShellBox";
            上書き保存ToolStripMenuItem.Enabled = false;
            this.新規作成ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = AutoCompleteSource.AllSystemSources;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader = new StreamReader(textBox1.Text, Encoding.GetEncoding("UTF-8"));
                String text_area = reader.ReadToEnd();
                string filepath = text_area;
                reader.Close();

                RunspaceInvoke runspaceInvoke = new RunspaceInvoke();

                Collection<PSObject> result = runspaceInvoke.Invoke(filepath);
                runspaceInvoke.Dispose();

                foreach (PSObject result_str in result)
                {
                    richTextBox1.AppendText(result_str.ToString());
                    richTextBox1.AppendText("\n");
                }
            }
            catch (Exception cept)
            {
                MessageBox.Show(cept.Message, "エラーを捕捉しました。");
            }
        }

        private void 実行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                上書き保存ToolStripMenuItem.Enabled = false;
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
                    richTextBox1.AppendText("\n");
                }
            }
            catch (Exception cept)
            {
                MessageBox.Show(cept.Message, "エラーを捕捉しました。");
            }
        }

        private void 実行保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader save_reader = new StreamReader(saveFileDialog1.FileName, Encoding.GetEncoding("UTF-8"));
                String save_text_area = save_reader.ReadToEnd();
                string save_filepath = save_text_area;
                save_reader.Close();

                RunspaceInvoke runspaceInvoke = new RunspaceInvoke();

                Collection<PSObject> save_result = runspaceInvoke.Invoke(save_filepath);
                runspaceInvoke.Dispose();

                foreach (PSObject result_str in save_result)
                {
                    richTextBox1.AppendText(result_str.ToString());
                    richTextBox1.AppendText("\r\n");
                }
            }
            catch (Exception cept)
            {
                MessageBox.Show(cept.Message, "エラーを捕捉しました。");
            }
        }
    }
}
