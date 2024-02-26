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
    public partial class AddStudent : UserControl
    {
        DataLayer.TableStudent objInsert=new DataLayer.TableStudent();

        public AddStudent()
        {
            InitializeComponent();
            displayStudentData();
        }

        public void clearField() 
        {
            addStudent_name.Text=string.Empty;
            addStudent_roll.Text=string.Empty;
            TamilMark.Text=string.Empty;
            EnglishMark.Text=string.Empty;
            MathsMark.Text=string.Empty;    
            ScienceMark.Text=string.Empty;
            SocialMark.Text=string.Empty;

        }
        public void displayStudentData()
        {
            DBclass ed=new DBclass();
            List<DBclass> listdata=ed.studentsListData();
            dataGridView1.DataSource= listdata;
        }
        private void addStudent_addbtn_Click(object sender, EventArgs e)
        {

            Student_Marks student_Marks = new Student_Marks();
            student_Marks.Student_Roll=addStudent_roll.Text;
            student_Marks.Student_Name=addStudent_name.Text;
            student_Marks.Tamil_mark=TamilMark.Text;
            student_Marks.English_mark=EnglishMark.Text;
            student_Marks.Maths_mark=MathsMark.Text;
            student_Marks.Science_mark=ScienceMark.Text;
            student_Marks.Social_mark=SocialMark.Text;
            objInsert.addStudent(student_Marks);
            displayStudentData();
            clearField();   


        }

        private void addStudent_clrbtn_Click(object sender, EventArgs e)
        {
             clearField();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            displayStudentData();
        }
    }
}
