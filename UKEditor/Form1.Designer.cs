namespace UKEditor
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.新規作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上書き保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.閉じるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.全範囲選択ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コピーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.切り取りToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼り付けToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.元に戻すToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.検索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.印刷プレビューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.印刷ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コードToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.今日は何月何日ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.その他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ストップウオッチToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.デジタルタイマーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerShellを起動純正ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerShellを実行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.スクリプトを実行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerShell実行保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.著作者情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ライセンスToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.編集ToolStripMenuItem1,
            this.編集ToolStripMenuItem,
            this.コードToolStripMenuItem,
            this.その他ToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(818, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.新規作成ToolStripMenuItem,
            this.開くToolStripMenuItem,
            this.上書き保存ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.toolStripSeparator1,
            this.閉じるToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(268, 6);
            // 
            // 新規作成ToolStripMenuItem
            // 
            this.新規作成ToolStripMenuItem.Name = "新規作成ToolStripMenuItem";
            this.新規作成ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新規作成ToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.新規作成ToolStripMenuItem.Text = "新規作成";
            this.新規作成ToolStripMenuItem.Click += new System.EventHandler(this.新規作成ToolStripMenuItem_Click);
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.開くToolStripMenuItem.Text = "開く";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // 上書き保存ToolStripMenuItem
            // 
            this.上書き保存ToolStripMenuItem.Enabled = false;
            this.上書き保存ToolStripMenuItem.Name = "上書き保存ToolStripMenuItem";
            this.上書き保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.上書き保存ToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.上書き保存ToolStripMenuItem.Text = "上書き保存";
            this.上書き保存ToolStripMenuItem.Click += new System.EventHandler(this.上書き保存ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.保存ToolStripMenuItem.Text = "名前を付けて保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(268, 6);
            // 
            // 閉じるToolStripMenuItem
            // 
            this.閉じるToolStripMenuItem.Name = "閉じるToolStripMenuItem";
            this.閉じるToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.閉じるToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.閉じるToolStripMenuItem.Text = "閉じる";
            this.閉じるToolStripMenuItem.Click += new System.EventHandler(this.閉じるToolStripMenuItem_Click);
            // 
            // 編集ToolStripMenuItem1
            // 
            this.編集ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全範囲選択ToolStripMenuItem,
            this.コピーToolStripMenuItem,
            this.切り取りToolStripMenuItem,
            this.貼り付けToolStripMenuItem,
            this.元に戻すToolStripMenuItem,
            this.検索ToolStripMenuItem});
            this.編集ToolStripMenuItem1.Name = "編集ToolStripMenuItem1";
            this.編集ToolStripMenuItem1.Size = new System.Drawing.Size(60, 29);
            this.編集ToolStripMenuItem1.Text = "編集";
            // 
            // 全範囲選択ToolStripMenuItem
            // 
            this.全範囲選択ToolStripMenuItem.Name = "全範囲選択ToolStripMenuItem";
            this.全範囲選択ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.全範囲選択ToolStripMenuItem.Size = new System.Drawing.Size(249, 30);
            this.全範囲選択ToolStripMenuItem.Text = "全範囲選択";
            this.全範囲選択ToolStripMenuItem.Click += new System.EventHandler(this.全範囲選択ToolStripMenuItem_Click);
            // 
            // コピーToolStripMenuItem
            // 
            this.コピーToolStripMenuItem.Name = "コピーToolStripMenuItem";
            this.コピーToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.コピーToolStripMenuItem.Size = new System.Drawing.Size(249, 30);
            this.コピーToolStripMenuItem.Text = "コピー";
            this.コピーToolStripMenuItem.Click += new System.EventHandler(this.コピーToolStripMenuItem_Click);
            // 
            // 切り取りToolStripMenuItem
            // 
            this.切り取りToolStripMenuItem.Name = "切り取りToolStripMenuItem";
            this.切り取りToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.切り取りToolStripMenuItem.Size = new System.Drawing.Size(249, 30);
            this.切り取りToolStripMenuItem.Text = "切り取り";
            this.切り取りToolStripMenuItem.Click += new System.EventHandler(this.切り取りToolStripMenuItem_Click);
            // 
            // 貼り付けToolStripMenuItem
            // 
            this.貼り付けToolStripMenuItem.Name = "貼り付けToolStripMenuItem";
            this.貼り付けToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.貼り付けToolStripMenuItem.Size = new System.Drawing.Size(249, 30);
            this.貼り付けToolStripMenuItem.Text = "貼り付け";
            this.貼り付けToolStripMenuItem.Click += new System.EventHandler(this.貼り付けToolStripMenuItem_Click);
            // 
            // 元に戻すToolStripMenuItem
            // 
            this.元に戻すToolStripMenuItem.Name = "元に戻すToolStripMenuItem";
            this.元に戻すToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.元に戻すToolStripMenuItem.Size = new System.Drawing.Size(249, 30);
            this.元に戻すToolStripMenuItem.Text = "元に戻す";
            this.元に戻すToolStripMenuItem.Click += new System.EventHandler(this.元に戻すToolStripMenuItem_Click);
            // 
            // 検索ToolStripMenuItem
            // 
            this.検索ToolStripMenuItem.Name = "検索ToolStripMenuItem";
            this.検索ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.検索ToolStripMenuItem.Size = new System.Drawing.Size(249, 30);
            this.検索ToolStripMenuItem.Text = "文字列の検索";
            this.検索ToolStripMenuItem.Click += new System.EventHandler(this.検索ToolStripMenuItem_Click);
            // 
            // 編集ToolStripMenuItem
            // 
            this.編集ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.印刷プレビューToolStripMenuItem,
            this.印刷ToolStripMenuItem});
            this.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            this.編集ToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.編集ToolStripMenuItem.Text = "印刷";
            // 
            // 印刷プレビューToolStripMenuItem
            // 
            this.印刷プレビューToolStripMenuItem.Name = "印刷プレビューToolStripMenuItem";
            this.印刷プレビューToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.印刷プレビューToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.印刷プレビューToolStripMenuItem.Text = "印刷プレビュー";
            this.印刷プレビューToolStripMenuItem.Click += new System.EventHandler(this.印刷プレビューToolStripMenuItem_Click);
            // 
            // 印刷ToolStripMenuItem
            // 
            this.印刷ToolStripMenuItem.Name = "印刷ToolStripMenuItem";
            this.印刷ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.印刷ToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.印刷ToolStripMenuItem.Text = "印刷";
            this.印刷ToolStripMenuItem.Click += new System.EventHandler(this.印刷ToolStripMenuItem_Click);
            // 
            // コードToolStripMenuItem
            // 
            this.コードToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.今日は何月何日ToolStripMenuItem});
            this.コードToolStripMenuItem.Name = "コードToolStripMenuItem";
            this.コードToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.コードToolStripMenuItem.Text = "コード";
            // 
            // 今日は何月何日ToolStripMenuItem
            // 
            this.今日は何月何日ToolStripMenuItem.Name = "今日は何月何日ToolStripMenuItem";
            this.今日は何月何日ToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.今日は何月何日ToolStripMenuItem.Text = "今日は何月何日";
            this.今日は何月何日ToolStripMenuItem.Click += new System.EventHandler(this.今日は何月何日ToolStripMenuItem_Click);
            // 
            // その他ToolStripMenuItem
            // 
            this.その他ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ストップウオッチToolStripMenuItem,
            this.デジタルタイマーToolStripMenuItem,
            this.powerShellを起動純正ToolStripMenuItem,
            this.powerShellToolStripMenuItem,
            this.powerShellを実行ToolStripMenuItem,
            this.スクリプトを実行ToolStripMenuItem,
            this.powerShell実行保存ToolStripMenuItem,
            this.設定ToolStripMenuItem});
            this.その他ToolStripMenuItem.Name = "その他ToolStripMenuItem";
            this.その他ToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.その他ToolStripMenuItem.Text = "その他";
            // 
            // ストップウオッチToolStripMenuItem
            // 
            this.ストップウオッチToolStripMenuItem.Name = "ストップウオッチToolStripMenuItem";
            this.ストップウオッチToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Tab)));
            this.ストップウオッチToolStripMenuItem.Size = new System.Drawing.Size(327, 30);
            this.ストップウオッチToolStripMenuItem.Text = "ストップウオッチ";
            this.ストップウオッチToolStripMenuItem.Click += new System.EventHandler(this.ストップウオッチToolStripMenuItem_Click);
            // 
            // デジタルタイマーToolStripMenuItem
            // 
            this.デジタルタイマーToolStripMenuItem.Name = "デジタルタイマーToolStripMenuItem";
            this.デジタルタイマーToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.デジタルタイマーToolStripMenuItem.Size = new System.Drawing.Size(327, 30);
            this.デジタルタイマーToolStripMenuItem.Text = "デジタルタイマー";
            this.デジタルタイマーToolStripMenuItem.Click += new System.EventHandler(this.デジタルタイマーToolStripMenuItem_Click);
            // 
            // powerShellを起動純正ToolStripMenuItem
            // 
            this.powerShellを起動純正ToolStripMenuItem.Name = "powerShellを起動純正ToolStripMenuItem";
            this.powerShellを起動純正ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F10)));
            this.powerShellを起動純正ToolStripMenuItem.Size = new System.Drawing.Size(327, 30);
            this.powerShellを起動純正ToolStripMenuItem.Text = "PowerShell起動(純正)";
            this.powerShellを起動純正ToolStripMenuItem.Click += new System.EventHandler(this.powerShellを起動純正ToolStripMenuItem_Click);
            // 
            // powerShellToolStripMenuItem
            // 
            this.powerShellToolStripMenuItem.Name = "powerShellToolStripMenuItem";
            this.powerShellToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F10)));
            this.powerShellToolStripMenuItem.Size = new System.Drawing.Size(327, 30);
            this.powerShellToolStripMenuItem.Text = "PowerShell起動";
            this.powerShellToolStripMenuItem.Click += new System.EventHandler(this.powerShellToolStripMenuItem_Click);
            // 
            // powerShellを実行ToolStripMenuItem
            // 
            this.powerShellを実行ToolStripMenuItem.Name = "powerShellを実行ToolStripMenuItem";
            this.powerShellを実行ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.powerShellを実行ToolStripMenuItem.Size = new System.Drawing.Size(327, 30);
            this.powerShellを実行ToolStripMenuItem.Text = "PowerShell環境";
            this.powerShellを実行ToolStripMenuItem.Click += new System.EventHandler(this.powerShellを実行ToolStripMenuItem_Click);
            // 
            // スクリプトを実行ToolStripMenuItem
            // 
            this.スクリプトを実行ToolStripMenuItem.Name = "スクリプトを実行ToolStripMenuItem";
            this.スクリプトを実行ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.スクリプトを実行ToolStripMenuItem.Size = new System.Drawing.Size(327, 30);
            this.スクリプトを実行ToolStripMenuItem.Text = "PowerShell実行";
            this.スクリプトを実行ToolStripMenuItem.Click += new System.EventHandler(this.スクリプトを実行ToolStripMenuItem_Click);
            // 
            // powerShell実行保存ToolStripMenuItem
            // 
            this.powerShell実行保存ToolStripMenuItem.Name = "powerShell実行保存ToolStripMenuItem";
            this.powerShell実行保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.powerShell実行保存ToolStripMenuItem.Size = new System.Drawing.Size(327, 30);
            this.powerShell実行保存ToolStripMenuItem.Text = "PowerShell実行(保存)";
            this.powerShell実行保存ToolStripMenuItem.Click += new System.EventHandler(this.powerShell実行保存ToolStripMenuItem_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(327, 30);
            this.設定ToolStripMenuItem.Text = "設定";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ヘルプToolStripMenuItem1,
            this.著作者情報ToolStripMenuItem,
            this.ライセンスToolStripMenuItem1});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // ヘルプToolStripMenuItem1
            // 
            this.ヘルプToolStripMenuItem1.Name = "ヘルプToolStripMenuItem1";
            this.ヘルプToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.ヘルプToolStripMenuItem1.Size = new System.Drawing.Size(294, 30);
            this.ヘルプToolStripMenuItem1.Text = "ヘルプ";
            this.ヘルプToolStripMenuItem1.Click += new System.EventHandler(this.ヘルプToolStripMenuItem1_Click);
            // 
            // 著作者情報ToolStripMenuItem
            // 
            this.著作者情報ToolStripMenuItem.Name = "著作者情報ToolStripMenuItem";
            this.著作者情報ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.著作者情報ToolStripMenuItem.Size = new System.Drawing.Size(294, 30);
            this.著作者情報ToolStripMenuItem.Text = "著作者情報";
            this.著作者情報ToolStripMenuItem.Click += new System.EventHandler(this.著作者情報ToolStripMenuItem_Click);
            // 
            // ライセンスToolStripMenuItem1
            // 
            this.ライセンスToolStripMenuItem1.Name = "ライセンスToolStripMenuItem1";
            this.ライセンスToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.ライセンスToolStripMenuItem1.Size = new System.Drawing.Size(294, 30);
            this.ライセンスToolStripMenuItem1.Text = "UKEditorのライセンス";
            this.ライセンスToolStripMenuItem1.Click += new System.EventHandler(this.ライセンスToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "(*.ps1)|[*.";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(0, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(818, 513);
            this.textBox1.TabIndex = 1;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "(*.txt)|*.txt";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(818, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 546);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("HackGen35 Console NFJ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "UKEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 閉じるToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 印刷ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 印刷プレビューToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem 新規作成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem コピーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 切り取りToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼り付けToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 元に戻すToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 著作者情報ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 検索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem その他ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ストップウオッチToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem デジタルタイマーToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 上書き保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerShellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerShellを実行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerShellを起動純正ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem スクリプトを実行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全範囲選択ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerShell実行保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ライセンスToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem コードToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 今日は何月何日ToolStripMenuItem;
    }
}

