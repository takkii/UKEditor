using System;
using System.Windows.Forms;

namespace UKEditor
{
    class Weathertype
    {
        public string baseUrl;
        public string city;
        public string url;
        public string json;
        public string reiwa_kanji;
        public string OneYear;
        public string OneMonth;
        public string Onedays;
        public string OneHour;
        public string OneMinutes;
        public string Oneseconds;
    }
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
