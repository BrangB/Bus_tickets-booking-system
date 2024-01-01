namespace Bus_Ticket_Booking_System
{
    partial class PaymentPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.backPrevPage = new System.Windows.Forms.PictureBox();
            this.xMark = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.amountSeat = new System.Windows.Forms.Label();
            this.selectedSeats = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Buy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPrevPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMark)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.backPrevPage);
            this.panel1.Controls.Add(this.xMark);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 69);
            this.panel1.TabIndex = 0;
            // 
            // backPrevPage
            // 
            this.backPrevPage.Image = ((System.Drawing.Image)(resources.GetObject("backPrevPage.Image")));
            this.backPrevPage.Location = new System.Drawing.Point(12, 12);
            this.backPrevPage.Name = "backPrevPage";
            this.backPrevPage.Size = new System.Drawing.Size(19, 16);
            this.backPrevPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backPrevPage.TabIndex = 4;
            this.backPrevPage.TabStop = false;
            this.backPrevPage.Click += new System.EventHandler(this.backPrevPage_Click);
            // 
            // xMark
            // 
            this.xMark.Image = ((System.Drawing.Image)(resources.GetObject("xMark.Image")));
            this.xMark.Location = new System.Drawing.Point(335, 12);
            this.xMark.Name = "xMark";
            this.xMark.Size = new System.Drawing.Size(13, 10);
            this.xMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.xMark.TabIndex = 1;
            this.xMark.TabStop = false;
            this.xMark.Click += new System.EventHandler(this.xMark_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(30, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "35000 MMK per seat";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Controls.Add(this.amountSeat);
            this.panel2.Controls.Add(this.selectedSeats);
            this.panel2.Location = new System.Drawing.Point(21, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 54);
            this.panel2.TabIndex = 2;
            // 
            // amountSeat
            // 
            this.amountSeat.AutoSize = true;
            this.amountSeat.BackColor = System.Drawing.Color.Transparent;
            this.amountSeat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountSeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.amountSeat.Location = new System.Drawing.Point(201, 20);
            this.amountSeat.Name = "amountSeat";
            this.amountSeat.Size = new System.Drawing.Size(113, 18);
            this.amountSeat.TabIndex = 4;
            this.amountSeat.Text = "2 x 35000 MMK";
            // 
            // selectedSeats
            // 
            this.selectedSeats.AutoSize = true;
            this.selectedSeats.BackColor = System.Drawing.Color.Transparent;
            this.selectedSeats.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.selectedSeats.Location = new System.Drawing.Point(11, 20);
            this.selectedSeats.Name = "selectedSeats";
            this.selectedSeats.Size = new System.Drawing.Size(54, 18);
            this.selectedSeats.TabIndex = 3;
            this.selectedSeats.Text = "A1, D2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel3.Controls.Add(this.TotalAmount);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(64, 289);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 54);
            this.panel3.TabIndex = 3;
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.TotalAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.TotalAmount.Location = new System.Drawing.Point(120, 19);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(89, 18);
            this.TotalAmount.TabIndex = 5;
            this.TotalAmount.Text = "70000 MMK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.label5.Location = new System.Drawing.Point(16, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total";
            // 
            // Buy
            // 
            this.Buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy.ForeColor = System.Drawing.Color.White;
            this.Buy.Location = new System.Drawing.Point(112, 422);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(134, 42);
            this.Buy.TabIndex = 4;
            this.Buy.Text = "Buy";
            this.Buy.UseVisualStyleBackColor = false;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 500);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPrevPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMark)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label amountSeat;
        private System.Windows.Forms.Label selectedSeats;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.PictureBox xMark;
        private System.Windows.Forms.PictureBox backPrevPage;
    }
}