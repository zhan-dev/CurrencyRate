using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CurrencyRate
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // WebClient
            //string line;
            //string link = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange";
            //using (WebClient webClient = new WebClient())
            //    line = webClient.DownloadString(link);

            string line;
            string link = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange";
            using (HttpClient httpClient = new HttpClient())
                line = httpClient.GetStringAsync(link).Result;

            //удаление двойных, тройных и т.д.пробелов по шаблону(не путать с простым реплейсом)
            string singleLine = new Regex(@"\s+").Replace(line, " ");
            Match matchUSD = Regex.Match(singleLine, "<txt>Долар США</txt> <rate>(.*?)</rate> <cc>(.*?)</cc>");
            Match matchHKD = Regex.Match(singleLine, "<txt>Гонконгівський долар</txt> <rate>(.*?)</rate> <cc>(.*?)</cc>");
            Match matchCAD = Regex.Match(singleLine, "<txt>Канадський долар</txt> <rate>(.*?)</rate> <cc>(.*?)</cc>");
            Match matchCZK = Regex.Match(singleLine, "<txt>Чеська крона</txt> <rate>(.*?)</rate> <cc>(.*?)</cc>");
            USD_lbl.Text = $"{matchUSD.Groups[1].Value} {matchUSD.Groups[2].Value}";
            HKD_lbl.Text = $"{matchHKD.Groups[1].Value} {matchHKD.Groups[2].Value}";
            CAD_lbl.Text = $"{matchCAD.Groups[1].Value} {matchCAD.Groups[2].Value}";
            CZK_lbl.Text = $"{matchCZK.Groups[1].Value} {matchCZK.Groups[2].Value}";
            textBox1.Text = line;
            //textBox1.Text = singleLine;

            //System.IO.File.WriteAllText("C:\\Users\\slice\\Desktop\\New folder\\output.txt", 
            //    new System.Net.WebClient().DownloadString("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange"));

            // File.Create(@"C:\Users\slice\Desktop\New folder\1.txt").Dispose();
            //File.WriteAllText(@"C:\Users\slice\Desktop\New folder\1.txt", line);
            //using file.Create(@"C:\Users\slice\Desktop\New folder\1.txt");
        }
    }
}
