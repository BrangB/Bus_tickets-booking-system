using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bus_Ticket_Booking_System
{
    public partial class SignUp : Form
    {

        //the variables for connecting with Microsoft access db
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Desktop\Bus Ticket Booking System\Bus Ticket Booking System\bin\Debug\db_user.accdb");
        OleDbCommand cmd = new OleDbCommand();


        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Please fill the username and password, Registeration Fail");
            }
            else if(textBox2.Text == textBox3.Text)
            {
                con.Open();

                //geting random number to set ID
                Random random = new Random();
                string typeOfUser = "Customer";

                int randomNumber = random.Next(60000, 90001); // generates a number between 60000 (inclusive) and 90001 (exclusive)

                string register = "INSERT INTO tbl_user VALUES ('"+textBox1.Text+"', '"+textBox2.Text+"','"+randomNumber+"', '"+typeOfUser+"')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Your account has been successfully created");
                new Login().Show();
                this.Hide();
            }
            else
            {
                textBox2.Clear();
                textBox3.Clear();
                textBox2.Focus();
                MessageBox.Show("Password does not match, Please re-enter the password");
            }
        }

        private void GoLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
