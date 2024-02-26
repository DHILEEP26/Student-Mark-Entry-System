using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Mark_Entry_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UserControl1 uc=new UserControl1();
            adduserControl(uc);
            
        }

        private void adduserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are You Sure,You Want To Logout ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes) 
            {
                Form1 loginform= new Form1();   
                loginform.Show();
                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            UserControl1 uc = new UserControl1();
            adduserControl(uc);

        }

        private void AddMark_btn_Click(object sender, EventArgs e)
        {
            AddStudent uc=new AddStudent();
            adduserControl(uc);
        }

        private void UpdateDetail_btn_Click(object sender, EventArgs e)
        {
            UpdateStudent uc=new UpdateStudent();
            adduserControl(uc);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
