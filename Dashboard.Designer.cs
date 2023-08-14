namespace PoliceStation
{
    partial class DashboardPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPage));
            panel1 = new Panel();
            panel2 = new Panel();
            Dashboard = new Label();
            pictureBox1 = new PictureBox();
            CASES = new Label();
            pictureBox2 = new PictureBox();
            CRIMINALS = new Label();
            pictureBox3 = new PictureBox();
            OFFICER = new Label();
            pictureBox4 = new PictureBox();
            CHARGES = new Label();
            pictureBox5 = new PictureBox();
            LOGOUT = new Label();
            pictureBox6 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Location = new Point(163, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 452);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(Dashboard);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(145, 50);
            panel2.TabIndex = 1;
            // 
            // Dashboard
            // 
            Dashboard.AutoSize = true;
            Dashboard.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Dashboard.Location = new Point(37, 13);
            Dashboard.Margin = new Padding(4, 0, 4, 0);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(104, 21);
            Dashboard.TabIndex = 9;
            Dashboard.Text = "Dashboard";
            Dashboard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CASES
            // 
            CASES.AutoSize = true;
            CASES.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CASES.Location = new Point(49, 125);
            CASES.Margin = new Padding(4, 0, 4, 0);
            CASES.Name = "CASES";
            CASES.Size = new Size(62, 21);
            CASES.TabIndex = 11;
            CASES.Text = "CASES";
            CASES.TextAlign = ContentAlignment.MiddleCenter;
            CASES.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 115);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // CRIMINALS
            // 
            CRIMINALS.AutoSize = true;
            CRIMINALS.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CRIMINALS.Location = new Point(49, 197);
            CRIMINALS.Margin = new Padding(4, 0, 4, 0);
            CRIMINALS.Name = "CRIMINALS";
            CRIMINALS.Size = new Size(103, 21);
            CRIMINALS.TabIndex = 13;
            CRIMINALS.Text = "CRIMINALS";
            CRIMINALS.TextAlign = ContentAlignment.MiddleCenter;
            CRIMINALS.Click += label3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(15, 187);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // OFFICER
            // 
            OFFICER.AutoSize = true;
            OFFICER.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            OFFICER.Location = new Point(49, 267);
            OFFICER.Margin = new Padding(4, 0, 4, 0);
            OFFICER.Name = "OFFICER";
            OFFICER.Size = new Size(79, 21);
            OFFICER.TabIndex = 15;
            OFFICER.Text = "OFFICER";
            OFFICER.TextAlign = ContentAlignment.MiddleCenter;
            OFFICER.Click += OFFICER_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(15, 257);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // CHARGES
            // 
            CHARGES.AutoSize = true;
            CHARGES.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CHARGES.Location = new Point(49, 339);
            CHARGES.Margin = new Padding(4, 0, 4, 0);
            CHARGES.Name = "CHARGES";
            CHARGES.Size = new Size(91, 21);
            CHARGES.TabIndex = 11;
            CHARGES.Text = "CHARGES";
            CHARGES.TextAlign = ContentAlignment.MiddleCenter;
            CHARGES.Click += CHARGES_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(15, 329);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 41);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // LOGOUT
            // 
            LOGOUT.AutoSize = true;
            LOGOUT.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LOGOUT.Location = new Point(49, 411);
            LOGOUT.Margin = new Padding(4, 0, 4, 0);
            LOGOUT.Name = "LOGOUT";
            LOGOUT.Size = new Size(83, 21);
            LOGOUT.TabIndex = 17;
            LOGOUT.Text = "LOGOUT";
            LOGOUT.TextAlign = ContentAlignment.MiddleCenter;
            LOGOUT.Click += LOGOUT_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(15, 401);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(33, 41);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // DashboardPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(860, 496);
            Controls.Add(LOGOUT);
            Controls.Add(pictureBox6);
            Controls.Add(CHARGES);
            Controls.Add(OFFICER);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(CRIMINALS);
            Controls.Add(pictureBox3);
            Controls.Add(CASES);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label Dashboard;
        private Label CASES;
        private PictureBox pictureBox2;
        private Label CRIMINALS;
        private PictureBox pictureBox3;
        private Label OFFICER;
        private PictureBox pictureBox4;
        private Label CHARGES;
        private PictureBox pictureBox5;
        private Label LOGOUT;
        private PictureBox pictureBox6;
    }
}