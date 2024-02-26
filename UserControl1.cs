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
    public partial class UserControl1 : UserControl
    {
       SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-OF5DRCJC\SQLEXPRESS;Initial Catalog=Training_db;Integrated Security=True;Encrypt=False");
       DataLayer.TableResult objRes= new DataLayer.TableResult();   

        public UserControl1()
        {
            InitializeComponent();
            displayTS();
            displayPS();
            displayFS();
            displayTable();
        }
        public void displayTS()
        {
/*            DBclass objTS= new DBclass();
            dashboard_TS.Text=objTS.displayResult("TOTAL").ToString();*/
            Student_Result student_Result= new Student_Result();
            student_Result.Operation="TOTAL";
            dashboard_TS.Text=objRes.displayResult(student_Result).ToString();    

        }

        public void displayPS()
        {
            /*            DBclass objPs=new DBclass();
                        dashboard_PS.Text=objPs.displayResult("PASS_TOTAL").ToString();*/
            Student_Result student_Result = new Student_Result();
            student_Result.Operation="PASS_TOTAL";
            dashboard_PS.Text=objRes.displayResult(student_Result).ToString();
        }

        public void displayFS()
        {
            /*            DBclass objgetFS=new DBclass();
                        dashboard_FS.Text=objgetFS.displayResult("FAIL_TOTAL").ToString();*/
            Student_Result student_Result = new Student_Result();
            student_Result.Operation="FAIL_TOTAL";
            dashboard_FS.Text=objRes.displayResult(student_Result).ToString();
        }

        public void displayTable()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Teacher",connect);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;  

        }


    }
}
