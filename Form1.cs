using Student_Mark_Entry_System.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Mark_Entry_System
{
    public partial class Form1 : Form
    {
        DataLayer.Tableusers objLogin=new DataLayer.Tableusers();
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            Users users = new Users();
            users.Name = login_username.Text;   
            users.Password=login_password.Text;
            objLogin.saveData(users);

        }
    }
}
