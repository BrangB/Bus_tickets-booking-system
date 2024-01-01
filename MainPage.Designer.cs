namespace Bus_Ticket_Booking_System
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.xmark = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeOfUser = new System.Windows.Forms.Label();
            this.makeBookingBtn = new System.Windows.Forms.Button();
            this.ExpenseTBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xmark)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.xmark);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, -30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 224);
            this.panel1.TabIndex = 0;
            // 
            // xmark
            // 
            this.xmark.Image = ((System.Drawing.Image)(resources.GetObject("xmark.Image")));
            this.xmark.Location = new System.Drawing.Point(958, 42);
            this.xmark.Name = "xmark";
            this.xmark.Size = new System.Drawing.Size(17, 13);
            this.xmark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.xmark.TabIndex = 6;
            this.xmark.TabStop = false;
            this.xmark.Click += new System.EventHandler(this.xmark_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.userName);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.balanceLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.typeOfUser);
            this.panel2.Location = new System.Drawing.Point(195, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 145);
            this.panel2.TabIndex = 5;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.userName.Location = new System.Drawing.Point(40, 80);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(209, 25);
            this.userName.TabIndex = 6;
            this.userName.Text = "Brang Tsawm Aung";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.panel3.Location = new System.Drawing.Point(325, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 100);
            this.panel3.TabIndex = 5;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.balanceLabel.Location = new System.Drawing.Point(413, 75);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(93, 30);
            this.balanceLabel.TabIndex = 4;
            this.balanceLabel.Text = "0 MMK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(413, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Your Balance";
            // 
            // typeOfUser
            // 
            this.typeOfUser.AutoSize = true;
            this.typeOfUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.typeOfUser.Location = new System.Drawing.Point(40, 31);
            this.typeOfUser.Name = "typeOfUser";
            this.typeOfUser.Size = new System.Drawing.Size(109, 25);
            this.typeOfUser.TabIndex = 2;
            this.typeOfUser.Text = "Customer";
            // 
            // makeBookingBtn
            // 
            this.makeBookingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.makeBookingBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeBookingBtn.ForeColor = System.Drawing.Color.White;
            this.makeBookingBtn.Location = new System.Drawing.Point(274, 261);
            this.makeBookingBtn.Name = "makeBookingBtn";
            this.makeBookingBtn.Size = new System.Drawing.Size(155, 50);
            this.makeBookingBtn.TabIndex = 1;
            this.makeBookingBtn.Text = "Make Booking";
            this.makeBookingBtn.UseVisualStyleBackColor = false;
            this.makeBookingBtn.Click += new System.EventHandler(this.makeBookingBtn_Click);
            // 
            // ExpenseTBtn
            // 
            this.ExpenseTBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.ExpenseTBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseTBtn.ForeColor = System.Drawing.Color.White;
            this.ExpenseTBtn.Location = new System.Drawing.Point(624, 261);
            this.ExpenseTBtn.Name = "ExpenseTBtn";
            this.ExpenseTBtn.Size = new System.Drawing.Size(155, 50);
            this.ExpenseTBtn.TabIndex = 3;
            this.ExpenseTBtn.Text = "Track Expense";
            this.ExpenseTBtn.UseVisualStyleBackColor = false;
            this.ExpenseTBtn.Click += new System.EventHandler(this.ExpenseTBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.LogoutBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Location = new System.Drawing.Point(454, 367);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(155, 50);
            this.LogoutBtn.TabIndex = 4;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.ExpenseTBtn);
            this.Controls.Add(this.makeBookingBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xmark)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label typeOfUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button makeBookingBtn;
        private System.Windows.Forms.Button ExpenseTBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox xmark;
    }
}