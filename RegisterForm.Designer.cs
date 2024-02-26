namespace Student_Mark_Entry_System
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.Signup2_btn = new System.Windows.Forms.Button();
            this.Signup_showPass = new System.Windows.Forms.CheckBox();
            this.Signup_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Signup_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Signin_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.signup_conformpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Signup2_btn
            // 
            this.Signup2_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Signup2_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup2_btn.FlatAppearance.BorderSize = 0;
            this.Signup2_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Signup2_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Signup2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signup2_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup2_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Signup2_btn.Location = new System.Drawing.Point(306, 430);
            this.Signup2_btn.Name = "Signup2_btn";
            this.Signup2_btn.Size = new System.Drawing.Size(115, 52);
            this.Signup2_btn.TabIndex = 24;
            this.Signup2_btn.Text = "SIGNUP";
            this.Signup2_btn.UseVisualStyleBackColor = false;
            this.Signup2_btn.Click += new System.EventHandler(this.Signup2_btn_Click);
            // 
            // Signup_showPass
            // 
            this.Signup_showPass.AutoSize = true;
            this.Signup_showPass.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_showPass.Location = new System.Drawing.Point(443, 382);
            this.Signup_showPass.Name = "Signup_showPass";
            this.Signup_showPass.Size = new System.Drawing.Size(154, 25);
            this.Signup_showPass.TabIndex = 23;
            this.Signup_showPass.Text = "Show Password";
            this.Signup_showPass.UseVisualStyleBackColor = true;
            this.Signup_showPass.CheckedChanged += new System.EventHandler(this.Signup_showPass_CheckedChanged);
            // 
            // Signup_password
            // 
            this.Signup_password.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_password.Location = new System.Drawing.Point(306, 238);
            this.Signup_password.Multiline = true;
            this.Signup_password.Name = "Signup_password";
            this.Signup_password.PasswordChar = '*';
            this.Signup_password.Size = new System.Drawing.Size(264, 36);
            this.Signup_password.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password :";
            // 
            // Signup_username
            // 
            this.Signup_username.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_username.Location = new System.Drawing.Point(306, 150);
            this.Signup_username.Multiline = true;
            this.Signup_username.Name = "Signup_username";
            this.Signup_username.Size = new System.Drawing.Size(264, 36);
            this.Signup_username.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "REGISTER ACCOUNT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Signin_btn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 552);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(11, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Student Mark Entry System";
            // 
            // Signin_btn
            // 
            this.Signin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Signin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signin_btn.FlatAppearance.BorderSize = 0;
            this.Signin_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.Signin_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.Signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signin_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signin_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Signin_btn.Location = new System.Drawing.Point(15, 471);
            this.Signin_btn.Name = "Signin_btn";
            this.Signin_btn.Size = new System.Drawing.Size(236, 52);
            this.Signin_btn.TabIndex = 9;
            this.Signin_btn.Text = "SIGNIN";
            this.Signin_btn.UseVisualStyleBackColor = false;
            this.Signin_btn.Click += new System.EventHandler(this.Signin_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(53, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Login Your Account";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(586, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(24, 24);
            this.exit.TabIndex = 25;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // signup_conformpass
            // 
            this.signup_conformpass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_conformpass.Location = new System.Drawing.Point(309, 326);
            this.signup_conformpass.Multiline = true;
            this.signup_conformpass.Name = "signup_conformpass";
            this.signup_conformpass.PasswordChar = '*';
            this.signup_conformpass.Size = new System.Drawing.Size(264, 36);
            this.signup_conformpass.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "ReEnter Password :";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(609, 552);
            this.Controls.Add(this.signup_conformpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Signup2_btn);
            this.Controls.Add(this.Signup_showPass);
            this.Controls.Add(this.Signup_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Signup_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Signup2_btn;
        private System.Windows.Forms.CheckBox Signup_showPass;
        private System.Windows.Forms.TextBox Signup_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Signup_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Signin_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.TextBox signup_conformpass;
        private System.Windows.Forms.Label label1;
    }
}