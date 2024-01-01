using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Bus_Ticket_Booking_System
{

    public partial class Login : Form
    {
        //connect the microsoft access db
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Desktop\Bus Ticket Booking System\Bus Ticket Booking System\bin\Debug\db_user.accdb");
        OleDbCommand cmd = new OleDbCommand();

        public Login()
        {
            InitializeComponent();
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }



        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Empty input, Please enter your username or password");
            }
            else
            {
                con.Open();
                string login = "SELECT * FROM tbl_user WHERE username='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
                cmd = new OleDbCommand(login, con);
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    string currentUserName = reader.GetString(0);

                    File.WriteAllText(@"C:\Users\DELL\Desktop\Bus Ticket Booking System\Bus Ticket Booking System\bin\Debug\currentUserID.txt", $"{currentUserName}");
                    con.Close();
                    new MainPage().Show();
                    this.Hide();


                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                    MessageBox.Show("Invalid username or password, login failed");

                    con.Close();
                }
            }

        }
    }
}
