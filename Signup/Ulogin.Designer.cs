namespace Signup
{
    partial class Ulogin
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_user = new System.Windows.Forms.Label();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.textbox_username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.button_signup = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(394, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(366, 84);
            this.label6.TabIndex = 0;
            this.label6.Text = "Car Rental ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel3.Controls.Add(this.label_user);
            this.panel3.Controls.Add(this.textbox_password);
            this.panel3.Controls.Add(this.textbox_username);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(219, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(727, 509);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(320, 15);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(75, 37);
            this.label_user.TabIndex = 5;
            this.label_user.Text = "User";
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(335, 241);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textbox_password.Size = new System.Drawing.Size(206, 22);
            this.textbox_password.TabIndex = 4;
            this.textbox_password.UseSystemPasswordChar = true;
            this.textbox_password.TextChanged += new System.EventHandler(this.textbox_password_TextChanged);
            // 
            // textbox_username
            // 
            this.textbox_username.Location = new System.Drawing.Point(335, 137);
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textbox_username.Size = new System.Drawing.Size(206, 22);
            this.textbox_username.TabIndex = 3;
            this.textbox_username.TextChanged += new System.EventHandler(this.textbox_username_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(145, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "UserName:";
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(219, 633);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(135, 45);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_signup
            // 
            this.button_signup.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signup.Location = new System.Drawing.Point(815, 643);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(131, 47);
            this.button_signup.TabIndex = 3;
            this.button_signup.Text = "sign up";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ulogin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1178, 798);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Name = "Ulogin";
            this.Load += new System.EventHandler(this.Ulogin_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.TextBox textbox_username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.Label label_user;
    }
}

