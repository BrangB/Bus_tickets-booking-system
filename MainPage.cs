using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Bus_Ticket_Booking_System
{
    public partial class MainPage : Form
    {

        //the variables for connecting with Microsoft access db
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Desktop\Bus Ticket Booking System\Bus Ticket Booking System\bin\Debug\db_user.accdb");
        OleDbCommand cmd = new OleDbCommand();

        public MainPage()
        {
            InitializeComponent();
        }


        private void MainPage_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            con.Open();
            string currentUser = File.ReadAllText(@"c:\users\dell\desktop\bus ticket booking system\bus ticket booking system\bin\debug\currentuserid.txt");

            string getUserData = "SELECT * FROM tbl_user WHERE username='" + currentUser + "'";
            cmd = new OleDbCommand(getUserData, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                userName.Text = $"{reader.GetString(0)}";
                balanceLabel.Text = $"{reader.GetString(2)} MMK";
                typeOfUser.Text = $"{reader.GetString(3)}";

            }
            con.Close();
        }

        private void xmark_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void makeBookingBtn_Click(object sender, EventArgs e)
        {
            new BookingPage().Show();
            this.Hide();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void ExpenseTBtn_Click(object sender, EventArgs e)
        {
            new Expense_Tracker().Show();
            this.Hide();
        }


    }
}
