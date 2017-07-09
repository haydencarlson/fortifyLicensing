using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Net.Http;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;
using MaterialSkin.Controls;
using MaterialSkin;

namespace TwitterBot {
    public partial class Form1 : Form {
        static int accountsCount = 0;
        static int totalAccountsCount = 0;
        public Form1() {
            InitializeComponent();
        }

        private void accountCreatorTimer_Tick(Object sender, EventArgs e) {
            string randomEmail = Randomizer.RandomEmail(8);
            accountsList.Items.Add(randomEmail);
            // Create a background worker
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler((send, args) => makeRequest("a", randomEmail, "Joseph", "Bruno"));

            // run in another thread
            bw.RunWorkerAsync();
            Debug.WriteLine("Making request");
        }

        private string getRandomProxy() {
            string path = @"C:\twitterbot\proxies.txt";
            var lines = File.ReadAllLines(path);
            var r = new Random();
            var randomLineNumber = r.Next(0, lines.Length - 1);
            string line = lines[randomLineNumber];
            return line;
        }
        
        public async void makeRequest(string password, string email, string firstName, string lastName) {
            var cookieJar = new CookieContainer();
            CookieAwareWebClient client = new CookieAwareWebClient(cookieJar);
            string proxy = getRandomProxy();
            Debug.WriteLine(proxy);
            WebProxy wp = new WebProxy(proxy);
            Debug.WriteLine(wp);
            client.Proxy = wp;
            string response = client.DownloadString("https://twitter.com/signup");
            string token = Regex.Match(response, "authenticity_token.+?value=\"(.+?)\"").Groups[1].Value;
            string postData =
                string.Format("authenticity_token={0}&signup_ui_metrics=%7B%22rf%22%3A%7B%22a329c5b5bc6c102ef9c1d63f316f58ac8fb4532446a1e4c83a11d61dac0f0d88%22%3A128%2C%22ee55fdfa42bd4572ff3a3690c7d2e50796a0b4d842b51b2130eb6fa7818ca273%22%3A-1%2C%22a52e852b39ea535cd0dfdc5f0b421766719588a7600ffc992fc224f920e92a81%22%3A158%2C%22fdd9b9308177fabcd24ea3310770605522530c56e0c3884906198e2a81c793f7%22%3A170%7D%2C%22s%22%3A%22oVgQBK7u_ZBbokRa-9tVVDtYQIBFf5ndDt-8Juqa-0i4-X5KwVsPwEUYqDkfB24YH5hsr_tmqPm6769FZvg-eYDljhWCc3tvyTno6Ts_QeAFb8mMS-13wvcxJkrKTUNyb5ac_-kzalx_WKsR0BD-Q4gM9YQ52IYwu4X0Sj2qubjIpjygiZH-vZgMJTkwQZP4jK8q4LoC37liW1gbSM4kv9NNK5g-c-2VR79yDC92moRaEqS9XOpzP1zYEfDdGLZDLCNW0C8E8qaz_b-l1M5mV04ih7WHbRE5QjV1bZohkiFF5Xa2nteIoSCHnZjD41JA0M9wntp66gLjuZUrBJLX0QAAAV0WYV14%22%7D&m_metrics=thMqEh0A8SkAthM9EhMA9ykAthNZEhwA%2FSkAthNsEhMAByoAthOIEhwAGioAthObEhMALCoAwRObEgsAMCoAwRO4Eh0APCoAwRPLEhMARioAwRPnEhwATioAwRP6EhMAVioAwRMWExwAXCoAthMWEwsAXioAthMpExMAYioAthNGEx0AbioAwRNGEwsAmioAwRNZExMAsioA0BNZEw8AwCoA0BN1ExwAwSoA0BOIExMAzyoA%3AuQQJALkEtg0AXBQPDB4AUicA&d_metrics=&user%5Bname%5D=" + firstName + "+" + lastName + "&user%5Bemail%5D=" + email + "&user%5Buser_password%5D=" + password + "&user%5Buse_cookie_personalization%5D=1&asked_cookie_personalization_setting=1&ad_ref=&user%5Bdiscoverable_by_email%5D=1&asked_discoverable_by_email=1&user%5Bdiscoverable_by_mobile_phone%5D=1&asked_discoverable_by_mobile_phone=1", token);
            client.Method = "POST";
            Uri uri = new Uri("https://twitter.com/account/create");
            await client.UploadStringTaskAsync(uri, postData);
            saveAccountToFile(email);
            accountsCount++;
            totalAccountsCount++;
            this.Invoke(new MethodInvoker(delegate {
                accountsCreated.Text = accountsCount.ToString();
                totalAccounts.Text = totalAccountsCount.ToString();
                accountsList.Items.Add(account);
            }));
            

        }
  
        private void saveAccountToFile(string account) {
            string path = @"C:\twitterbot\accounts.txt";
            using (StreamWriter sw = File.AppendText(path)) {              
                sw.WriteLine(account);             
            }
        }
        private void Form1_Load(Object sender, EventArgs e) {
            var lineCount = File.ReadLines(@"C:\twitterbot\accounts.txt").Count();
            totalAccounts.Text = lineCount.ToString();
            totalAccountsCount = lineCount;
            InitializeComponent();
        }

        private void button1_Click(Object sender, EventArgs e) {
            accountCreatorTimer.Start();
        }

        private void button2_Click(Object sender, EventArgs e) {
            accountCreatorTimer.Stop();
        }
    }
}
