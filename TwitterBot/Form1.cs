using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace TwitterBot {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void startBot_Click(Object sender, EventArgs e) {
            accountCreatorTimer.Start();
        }

        private void accountCreatorTimer_Tick(Object sender, EventArgs e) {

        }
        
        async static void makeRequest(string url) {
            using (HttpClient client = new HttpClient()) {
                HttpResponseMessage response = await client.PostAsync(url);
                using (HttpContent content = response.Content) {

                }
            }


        }

    }
}
