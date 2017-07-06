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

namespace TwitterBot {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private string getEmail() {
            if (webBrowser1.ReadyState == WebBrowserReadyState.Complete) {
                string emailAddress = webBrowser1.Document.GetElementById("mail").GetAttribute("value");
                return emailAddress;
            }
            return "";
        }
        
        private void startBot_Click(Object sender, EventArgs e) {
            string email = getEmail();
            if (email != String.Empty) {

            }
        }

        private void accountCreatorTimer_Tick(Object sender, EventArgs e) {

        }
        
        public void makeRequest() {
            
            var cookieJar = new CookieContainer();
            CookieAwareWebClient client = new CookieAwareWebClient(cookieJar);
        }

    }
}
