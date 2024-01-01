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

namespace Bus_Ticket_Booking_System
{
    public partial class BookingPage : Form
    {

        private int[] occupiedSeat;
        private string message;
        private string bookSeatNum;
        public BookingPage()
        {
            InitializeComponent();

            //getting occupiedSeats from txt file and change string into int Array
            string occupiedSeatsString =  File.ReadAllText(@"C:\Users\DELL\Desktop\Bus Ticket Booking System\Bus Ticket Booking System\bin\Debug\occupiedSeats.txt");
            string[] strArray = occupiedSeatsString.Split(',');
            occupiedSeat = Array.ConvertAll(strArray, int.Parse);

        }

        private void xMark_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void backToPrevPage_Click(object sender, EventArgs e)
        {
            new MainPage().Show();
            this.Hide();
        }

        private void BookingPage_Load(object sender, EventArgs e)
        {
            //width and height of seats
            int buttonWidth = 49;
            int buttonHeight = 41;
            int buttonCount = 16;

            // Define the starting position of the buttons
            int startX = 108;
            int startY = 224;

            for (int i = 0; i < buttonCount; i++)
            {
                Button button = new Button();
                button.Text = $"{i + 1}";
                button.BackColor = Color.LightBlue;
                button.Size = new Size(buttonWidth, buttonHeight);


                // Naming the button names
                if(i < 8 && i % 2 == 0)
                {
                    button.Name = $"A{i + 1}";
                }
                if(i < 8 && i % 2 != 0)
                {
                    button.Name = $"B{i + 1}";
                }
                if(i > 7 && i % 2 == 0)
                {
                    button.Name = $"C{i + 1}";
                }
                if (i > 7 && i % 2 != 0)
                {
                    button.Name = $"D{i + 1}";
                }

                //check the occupied seats
                foreach(int item in occupiedSeat)
                {
                    if(item == i + 1)
                    {
                        button.BackColor = Color.MediumBlue;
                        button.ForeColor = Color.White;
                    }
                }


                // layout seats
                if(i < 2)
                {
                    button.Location = new Point(startX + i * (buttonWidth + 40), startY);
                }
                if(i >= 2)
                {
                    button.Location = new Point(startX + (i - 2) * (buttonWidth +40), startY + 55);
                }
                if(i >= 4)
                {
                    button.Location = new Point(startX + (i - 4) * (buttonWidth + 40), startY + 110);
                }
                if (i >= 6)
                {
                    button.Location = new Point(startX + (i - 6) * (buttonWidth + 40), startY + 165);
                }
                if (i >= 8)
                {
                    button.Location = new Point(startX - 40 + (i - 5) * (buttonWidth + 40), startY);
                }
                if (i >= 10)
                {
                    button.Location = new Point(startX - 40 + (i - 7) * (buttonWidth + 40), startY + 55);
                }
                if (i >= 12)
                {
                    button.Location = new Point(startX - 40 + (i - 9) * (buttonWidth + 40), startY + 110);
                }
                if (i >= 14)
                {
                    button.Location = new Point(startX - 40 + (i - 11) * (buttonWidth + 40), startY + 165);
                }
                panel1.Controls.Add(button);
                button.Click += new EventHandler(button_Click);
                
            }
        }

        // Method that make to be able to book, check occupied seat with colors
        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(button.BackColor == Color.LimeGreen)
            {
                button.ForeColor = Color.Black;
                button.BackColor = Color.SkyBlue;
            }
            else if(button.BackColor == Color.MediumBlue)
            {
                MessageBox.Show("This seat is occupied");
            }
            else
            {
                button.BackColor = Color.LimeGreen;
                button.ForeColor = Color.Black;
            }

        }

        public void conBtn_Click(object sender, EventArgs e)
        {
            int amount = 0;
            
            // using foreach loop to filter limeGreen buttons
            foreach (Control control in panel1.Controls)
            {
                if (control is Button button && button.BackColor == Color.LimeGreen)
                {
                    message += $"{button.Name} ";
                    bookSeatNum += $", {button.Text}";
                    amount++;
                }
            }

            //uploading data as a txt file
            File.WriteAllText(@"C:\Users\DELL\Desktop\Bus Ticket Booking System\Bus Ticket Booking System\bin\Debug\selectedSeats.txt", $"{message}");
            File.WriteAllText(@"C:\Users\DELL\Desktop\Bus Ticket Booking System\Bus Ticket Booking System\bin\Debug\selectedSeatsAmount.txt", $"{amount}");
            File.WriteAllText(@"C:\Users\DELL\Desktop\Bus Ticket Booking System\Bus Ticket Booking System\bin\Debug\currentSelectedSeatsNum.txt", $"{bookSeatNum}");

            new PaymentPage().Show();
            this.Hide();

        }
    }
}
