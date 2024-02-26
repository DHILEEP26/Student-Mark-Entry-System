using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Student_Mark_Entry_System.Module;

namespace Student_Mark_Entry_System
{
    public partial class RegisterForm : Form
    {
       
       DataLayer.Tableusers objReg=new DataLayer.Tableusers();
        public RegisterForm()
        {
            InitializeComponent();
        }
       

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Signin_btn_Click(object sender, EventArgs e)
        {
            Form1 loginform= new Form1();
            loginform.Show();
            this.Hide();    
        }

        private void Signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            Signup_password.PasswordChar=Signup_showPass.Checked ? '\0' : '*';
            signup_conformpass.PasswordChar=Signup_showPass.Checked ? '\0' : '*';
        }

        private void Signup2_btn_Click(object sender, EventArgs e)
        {

            Users users = new Users();
            users.regName=Signup_username.Text;
            users.regPassword=Signup_password.Text;
            users.regConfirm=signup_conformpass.Text;
            objReg.checkData(users);

        }

    }
}
