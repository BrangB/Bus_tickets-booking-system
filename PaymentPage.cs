using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bus_Ticket_Booking_System
{
    public partial class PaymentPage : Form
    {
        private int finalPayment;

        //the variables for connecting with Microsoft access db
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Desktop\Bus Ticket Booking System\Bus Ticket Booking System\bin\Debug\db_user.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();

        public PaymentPage()
        {
            InitializeComponent();

            string seats = File.ReadAllText(@"C:\Users\DELL\Desktop\Bus Ticket Booking System\Bus Ticket Booking System\bin\Debug\selectedSeats.txt");
            string seatsAmount = File.ReadAllText(@"C:\Users\DELL\Desktop\Bus Ticket Booking System\Bus Ticket Booking System\bin\Debug\selectedSeatsAmount.txt");

            selectedSeats.Text = seats;
            amountSeat.Text = $"{seatsAmount} x 35000 MMK";
            finalPayment = 35000 * Convert.ToInt32(seatsAmount);
            TotalAmount.Text = $"{finalPayment} MMK";
        }

        private void xMark_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void backPrevPage_Click(object sender, EventArgs e)
        {
            new BookingPage().Show();
            this.Hide();
        }

        private void Buy_Click(object sender, EventArgs e)
        {

            //get the current user from txt file
            string currentUser = File.ReadAllText(@"c:\users\dell\desktop\bus ticket booking system\bus ticket booking system\bin\debug\currentuserid.txt");

            con.Open();
            string selectUser = "SELECT * FROM tbl_user WHERE username='" + currentUser + "'";
            cmd = new OleDbCommand(selectUser, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {

                int balanceFromDB = Convert.ToInt32(reader.GetString(2));
                con.Close();

                if(finalPayment > balanceFromDB)
                {
                    MessageBox.Show("You don't have enough money");
                    new MainPage().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("!!! Thank You !!!");
                    con.Open();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "UPDATE tbl_user SET Balance='" + Convert.ToString(balanceFromDB - finalPayment) + "' WHERE username='" + currentUser + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    // update occupied seats by override new data as txt file
                    string occupedSeatsString = File.ReadAllText(@"C:\Users\DELL\Desktop\Bus Ticket Booking System\Bus Ticket Booking System\bin\Debug\occupiedSeats.txt");
                    string currentSelectedSeats = File.ReadAllText(@"C:\Users\DELL\Desktop\Bus Ticket Booking System\Bus Ticket Booking System\bin\Debug\currentSelectedSeatsNum.txt");
                    File.WriteAllText(@"C:\Users\DELL\Desktop\Bus Ticket Booking System\Bus Ticket Booking System\bin\Debug\occupiedSeats.txt", $"{occupedSeatsString}{currentSelectedSeats}");

                    new MainPage().Show();
                    this.Hide();
                }
            }
        }
    }
}
