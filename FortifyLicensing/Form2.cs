using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterBot {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void label1_Click(Object sender, EventArgs e) {

        }

        private void Form2_Load(Object sender, EventArgs e) {

        }

        private void button1_Click(Object sender, EventArgs e) {
            DBConnect db = new DBConnect();

            db.connection.Open();

            MySqlCommand command = db.connection.CreateCommand();
            command.CommandText = "SELECT * FROM users";

            IDataReader reader = command.ExecuteReader();

            if (reader.Read()) {
                Debug.WriteLine(reader);
            }
   
            db.connection.Close();

           
        }

        private void button2_Click(Object sender, EventArgs e) {
            Form3 registerForm = new Form3();
            registerForm.Show();
            this.Hide();
        }
    }
}
