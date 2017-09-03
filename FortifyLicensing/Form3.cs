using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterBot {
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        private void button1_Click(Object sender, EventArgs e) {
            if (passwordField.Text.Length > 0) {
                if (IsValidEmail(emailField.Text)) {
                    string hwid = getHWID();
                    bool response = DBConnect.InsertUser(emailField.Text, passwordField.Text, hwid);
                    if (response) {
                        MessageBox.Show("User has been registered. Please wait for verification");
                    } else {
                        MessageBox.Show("User already exists");
                    }
                } else {
                    MessageBox.Show("Please enter a valid email address");
                }
            } else {
                MessageBox.Show("Your password must be atleast 1 character long");
            }
        }


        private string getHWID() {
            string HWID = string.Empty;//creating a empty string
            ManagementClass Management = new ManagementClass("win32_processor");//declaring the system management calss
            ManagementObjectCollection MObject = Management.GetInstances();//decalring the system management object collection 
            foreach (ManagementObject mob in MObject)//having a foreach loop
            {
                if (string.IsNullOrEmpty(HWID)) {
                    HWID = mob.GetPropertyValue("processorID").ToString();//converting the HWID to string
                    break;
                }
            }
            return HWID;
        }

        bool IsValidEmail(string email) {
            try {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            } catch {
                return false;
            }
        }

        private void textBox2_TextChanged(Object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(Object sender, EventArgs e) {
            registerAccount.Enabled = true;
        }
    }
}
