using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Windows.Forms;

namespace UKEditor
{
    public partial class Form1 : Form
    {
        private string StrPrint;
        private PageSettings PageSetting = new PageSettings();
        private string FileName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void 閉じるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.閉じるToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
                MessageBox.Show("プログラムを終了します", "終了");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラーを捕捉しました");
            }
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.Title = "ファイルの選択";
                this.openFileDialog1.CheckFileExists = true;
                this.openFileDialog1.RestoreDirectory = true;
                this.openFileDialog1.Filter = "PowerShellファイル|*.ps1|テキストファイル|*.txt|すべてのファイル|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileName = openFileDialog1.FileName;
                    StreamReader reader = new StreamReader(FileName, Encoding.GetEncoding("UTF-8"));
                    textBox1.Text = reader.ReadToEnd();
                    reader.Close();
                    Text = Path.GetFileName(FileName) + " - UKEditor";
                    上書き保存ToolStripMenuItem.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラーを捕捉しました");
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
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
                    Text = Path.GetFileName(FileName) + " - UKEditor";
                    上書き保存ToolStripMenuItem.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラーを捕捉しました");
            }
        }

        private void 印刷ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.印刷ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            try
            {
                printDocument1.DefaultPageSettings = PageSetting;
                StrPrint = textBox1.Text;
                printDialog1.Document = printDocument1;

                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラーを捕捉しました");
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                Font Fontsize = new Font("MS UI Gothic", 11);
                int intNumberChars;
                int intNumberLines;
                string strPrintString;
                StringFormat strFormat = new StringFormat();

                Rectangle rectSquare = new Rectangle(
                    e.MarginBounds.Left, e.MarginBounds.Top,
                    e.MarginBounds.Width, e.MarginBounds.Height);

                SizeF SquareSize = new SizeF(
                    e.MarginBounds.Width,
                    e.MarginBounds.Height - Fontsize.GetHeight(e.Graphics));

                e.Graphics.MeasureString(
                    StrPrint, Fontsize, SquareSize, strFormat,
                    out intNumberChars, out intNumberLines);

                strPrintString = StrPrint.Substring(0, intNumberChars);

                e.Graphics.DrawString(
                    strPrintString, Fontsize, Brushes.Black, rectSquare, strFormat);

                if (intNumberChars < StrPrint.Length)
                {
                    StrPrint = StrPrint.Substring(intNumberChars);
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                    StrPrint = textBox1.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラーを捕捉しました");
            }
        }

        private void 印刷プレビューToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.印刷プレビューToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Space;
                printDocument1.DefaultPageSettings = PageSetting;
                StrPrint = textBox1.Text;
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラーを捕捉しました");
            }
        }

        private void 新規作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
                Text = "無題 - UKEditor";
                上書き保存ToolStripMenuItem.Enabled = false;
                this.新規作成ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラーを捕捉しました");
            }
        }

        private void コピーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.コピーToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            if (textBox1.SelectionLength > 0)
            {
                //選択されている文字列があるときはコピーする
                //（SelectionLengthで調べなくても問題はない）
                textBox1.Copy();
            }

        }

        private void 切り取りToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.切り取りToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            if (textBox1.SelectionLength > 0)
            {
                //選択されている文字列があるときは切り取る
                //（SelectionLengthで調べなくても問題はない）
                textBox1.Cut();
            }

        }

        private void 貼り付けToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.貼り付けToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            IDataObject data = Clipboard.GetDataObject();
            if (data != null && data.GetDataPresent(DataFormats.Text) == true)
            {
                //クリップボードにテキストデータがあるときは貼り付ける
                //（テキストデータの有無を調べなくても問題はない）
                textBox1.Paste();
            }

        }

        private void 元に戻すToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.元に戻すToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            //アンドゥができるか調べる
            if (textBox1.CanUndo)
            {
                //アンドゥする
                textBox1.Undo();
                //アンドゥバッファを削除する
                textBox1.ClearUndo();
            }
        }

        private void ヘルプToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ヘルプToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F2;
            try
            {
                System.Diagnostics.Process.Start("https://github.com/takkii/UKEditor");
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "エラーを捕捉しました。");
            }
        }

        private void 著作者情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.著作者情報ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
                AboutBox1 newAboutBox = new AboutBox1();
                newAboutBox.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラーを捕捉しました");
            }
        }

        //Form1オブジェクトを保持するためのフィールド
        private static Form1 _form1Instance;

        //Form1オブジェクトを取得、設定するためのプロパティ
        public static Form1 Form1Instance
        {
            get
            {
                return _form1Instance;
            }
            set
            {
                _form1Instance = value;
            }
        }
        //TextBox1.Textを取得、設定するためのプロパティ
        public string TextBoxText
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        private void 検索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.検索ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
                Form1 f = new Form1();
                Form1.Form1Instance = f;
                Form1.Form1Instance = this;
                Form2 d = new Form2();
                d.ShowDialog(this);
                d.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラーを捕捉しました");
            }
        }

        private void ストップウオッチToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.ストップウオッチToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Tab;
                Form3 d = new Form3();
                d.ShowDialog(this);
                d.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラーを捕捉しました");
            }
        }

        private void デジタルタイマーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.デジタルタイマーToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F1;
                Form d = new Form4();
                d.ShowDialog(this);
                d.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラーを捕捉しました");
            }
        }

        private void 上書き保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(FileName, textBox1.Text, Encoding.GetEncoding("UTF-8"));     
        }

        private void powerShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process cmd = new Process();
                cmd.StartInfo.WorkingDirectory = @"C:\";
                cmd.StartInfo.FileName = "C:/Program Files/PowerShell/7/pwsh.exe";
                cmd.Start();
            }
            catch (Exception shell)
            {
                MessageBox.Show(shell.Message, "エラーを捕捉しました");
                MessageBox.Show("https://github.com/PowerShell/PowerShell/releases");
                MessageBox.Show("PowerShellを手に入れて、デフォルトのPATHで設定してください。");
            }
        }

        private void powerShellを実行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form5 d = new Form5();
                d.ShowDialog(this);
                d.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラーを捕捉しました");
            }
        }

        private void powerShellを起動純正ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process cmd = new Process();
                cmd.StartInfo.WorkingDirectory = @"C:\";
                cmd.StartInfo.FileName = "C:/Windows/System32/WindowsPowerShell/v1.0/powershell.exe";
                cmd.Start();
            }
            catch (Exception shell)
            {
                MessageBox.Show(shell.Message, "エラーを捕捉しました");
            }
        }

        private void スクリプトを実行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
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
                    textBox1.AppendText(result_str.ToString());
                    textBox1.AppendText("\n");
                }
            }
            catch (Exception cept)
            {
                MessageBox.Show(cept.Message, "エラーを捕捉しました。");
            }
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingDialog dialog = new settingDialog(textBox1);
            dialog.ShowDialog(this);
        }

        private void 全範囲選択ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectAll();
        }

        private void powerShell実行保存ToolStripMenuItem_Click(object sender, EventArgs e)
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
                    textBox1.AppendText(result_str.ToString());
                    textBox1.AppendText("\n");
                }
            }
            catch (Exception cept)
            {
                MessageBox.Show(cept.Message, "エラーを捕捉しました。");
            }
        }

        private void ライセンスToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                String UK_li = @"
echo '「UKEditorのライセンス」

BSD-3-Clause

Copyright (c) 2023, Takayuki Kamiyama All rights reserved.

次の条件が満たされていれば、ソースおよびバイナリ形式での再配布および使用は、変更の有無にかかわらず許可されます。

ソースコードの再配布には、上記の著作権表示、この条件リスト、および以下の免責条項を保持する必要があります。
バイナリ形式の再配布は、上記の著作権表示、この条件一覧、および以下の免責条項を、
配布に付属のドキュメントおよび/またはその他の資料に複製する必要があります。
特定の書面による事前の許可なしに、このソフトウェアから派生した製品を推薦または宣伝するために、
組織の名前またはその貢献者の名前を使用することはできません。
本ソフトウェアは、著作権者および寄稿者によって「現状のまま」提供され、
商品性および特定の目的への適合性を含む黙示の保証を含むが、
明示または黙示の保証はされず 免責<COPYRIGHT HOLDER>は、
直接的、間接的、偶発的、特別、懲罰的、
派生的損害（代替商品やサービスの調達を含むが、これに限定されない。
使用、データ、または利益の喪失; （たとえこのような損害の可能性について知らされていたとしても）、
いかなる責任も負いません。また、本ソフトウェアの使用中に生じるいかなる損害についても責任を負わないものとします。

Copyright (c) 2023, Takayuki Kamiyama All rights reserved.

Redistribution and use in source and binary forms, 
with or without modification, 
are permitted provided that the following conditions are met:

Redistributions of source code must retain the above copyright notice,
this list of conditions and the following disclaimer.

Redistributions in binary form must reproduce the above copyright notice,
this list of conditions and the following disclaimer
in the documentation and/or other materials provided with the distribution.

Neither the name of the organization nor the names of its contributors
may be used to endorse or promote products derived 
from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 'AS IS' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
'
";
                RunspaceInvoke runspaceInvoke = new RunspaceInvoke();

                Collection<PSObject> result = runspaceInvoke.Invoke(UK_li);
                runspaceInvoke.Dispose();

                foreach (PSObject result_str in result)
                {
                    textBox1.AppendText(result_str.ToString());
                    textBox1.AppendText("\n");
                }
            }
            catch (Exception cept)
            {
                MessageBox.Show(cept.Message, "エラーを捕捉しました。");
            }
        }

        private void ライセンスToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String UK_li = @"
echo '
「コード内機能のライセンス」

※ 移植先一覧(引用先)
https://github.com/takkii/himekuri_shaper
https://github.com/takkii/himekuri2

The MIT License
Copyright (c) 2023, Takayuki Kamiyama All rights reserved.

以下に定める条件に従い、本ソフトウェアおよび関連文書のファイル（以下「ソフトウェア」）の複製を取得するすべての人に対し、ソフトウェアを無制限に扱うことを無償で許可します。これには、ソフトウェアの複製を使用、複写、変更、結合、掲載、頒布、サブライセンス、および/または販売する権利、およびソフトウェアを提供する相手に同じことを許可する権利も無制限に含まれます。

上記の著作権表示および本許諾表示を、ソフトウェアのすべての複製または重要な部分に記載するものとします。

ソフトウェアは「現状のまま」で、明示であるか暗黙であるかを問わず、何らの保証もなく提供されます。ここでいう保証とは、商品性、特定の目的への適合性、および権利非侵害についての保証も含みますが、それに限定されるものではありません。 作者または著作権者は、契約行為、不法行為、またはそれ以外であろうと、ソフトウェアに起因または関連し、あるいはソフトウェアの使用またはその他の扱いによって生じる一切の請求、損害、その他の義務について何らの責任も負わないものとします。
'
";
                RunspaceInvoke runspaceInvoke = new RunspaceInvoke();

                Collection<PSObject> result = runspaceInvoke.Invoke(UK_li);
                runspaceInvoke.Dispose();

                foreach (PSObject result_str in result)
                {
                    textBox1.AppendText(result_str.ToString());
                    textBox1.AppendText("\n");
                }
            }
            catch (Exception cept)
            {
                MessageBox.Show(cept.Message, "エラーを捕捉しました。");
            }
        }

        private void 日めくり2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String koyomi = "himekuri";
                RunspaceInvoke runspaceInvoke = new RunspaceInvoke();

                Collection<PSObject> result = runspaceInvoke.Invoke(koyomi);
                runspaceInvoke.Dispose();

                foreach (PSObject result_str in result)
                {
                    MessageBox.Show(result_str.ToString());
                }
            }
            catch (Exception cept)
            {
                MessageBox.Show(cept.Message, "gem install himekuri2 ... 実行してください！");
            }
        }

        private void 日めくりSharpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 宣言
                var dt = DateTime.Now;
                const string reiwa_kanji = "令和";
                const string reiwa_alpha = "R0";
                const string OneYear = "年";
                const string OneMonth = "月";
                const string Onedays = "日";
                const string OneHour = "時";
                const string OneMinutes = "分";
                // const string Oneseconds = "秒";
                const string comma = ".";
                const string koron = " : ";
                const string next_year = "来年の1月1日まであと：";
                const string message = "日です";

                // 計算
                var reiwa = (reiwa_kanji + (dt.Year - 2018) + OneYear + dt.Month + OneMonth + dt.Day + Onedays);
                var reiwa2 = (reiwa_alpha + (dt.Year - 2018) + comma + dt.Month + comma + dt.Day);

                // 入れ子
                var count = new DateTime(dt.Year, dt.Month, dt.Day);
                var count2 = new DateTime(dt.Year + 1, 1, 1);
                var gantan = (count2 - count).TotalDays;

                // 参照先
                var nengo = (dt.Year + OneYear + dt.Month + OneMonth + dt.Day + Onedays + koron + dt.Hour + OneHour + dt.Minute + OneMinutes +
                             dt.Second + OneMinutes + " : " + dt.ToString("dddd"));
                var hagoita = reiwa + " : " + reiwa2;
                var oshogatsu = next_year + (gantan - 1) + message;

                // 安定ソート
                var takoage = new[]
                {
                    oshogatsu,
                    hagoita,
                    nengo
                };

                var orderByList = takoage.OrderBy(x => x);
                foreach (var x in orderByList)
                {
                    MessageBox.Show(x);
                }
            }

            catch (Exception exe)
            {
                // 出力
                MessageBox.Show(exe.Message, "エラーを捕捉しました。");
            }
            finally
            {
                try
                {
                    // 宣言
                    const string himekuriversion = "1.1.0";
                    const string himekuriSharper = "日めくりの数え番号：";
                    const string vesion = himekuriSharper + himekuriversion;

                    // 安定ソート
                    var versioner = new[]
                    {
                        vesion
                    };

                    var orderList = versioner.OrderBy(y => y);

                    foreach (var y in orderList)
                    {
                        MessageBox.Show(y);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "エラーを捕捉しました。");
                }
            }
        }

        private void 足し算12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String one_two = "ruby -e 'puts 1+2'";
                RunspaceInvoke runspaceInvoke = new RunspaceInvoke();

                Collection<PSObject> result = runspaceInvoke.Invoke(one_two);
                runspaceInvoke.Dispose();

                foreach (PSObject result_str in result)
                {
                    MessageBox.Show(result_str.ToString());
                }
            }
            catch (Exception cept)
            {
                MessageBox.Show(cept.Message, "RubyにPATHを通してください。");
            }
        }

        private void ハローワールドToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 宣言
                const string world = "こんにちは、世界";

                // 計算
                var hello = world;

                // 安定ソート
                var helloworld = new[]
                {
                    hello
                };

                var orderByList = helloworld.OrderBy(x => x);
                foreach (var x in orderByList)
                {
                    MessageBox.Show(x);
                }
            }

            catch (Exception exe)
            {
                // 出力
                MessageBox.Show(exe.Message, "エラーを捕捉しました。");
            }
            finally
            {
                try
                {
                    // 宣言
                    const string out_exit = "メッセージを終了します";

                    // 安定ソート
                    var in_out = new[]
                    {
                        out_exit
                    };

                    var orderList = in_out.OrderBy(y => y);

                    foreach (var y in orderList)
                    {
                        MessageBox.Show(y);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "エラーを捕捉しました。");
                }
            }
        }
    }
}
