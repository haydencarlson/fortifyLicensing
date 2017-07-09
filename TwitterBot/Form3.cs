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
            string hwid = getHWID();
            DBConnect db = new DBConnect();
            db.InsertUser(textBox1.Text, textBox2.Text, hwid);
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
    }
}
