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
    public partial class UpdateStudent : UserControl
    {
        DataLayer.TableStudent objUpdt= new DataLayer.TableStudent();
        DataLayer.TableStudent objDel= new DataLayer.TableStudent();
        public UpdateStudent()
        {
            InitializeComponent();
            displayStudentForUpdate();
        }

        public void displayStudentForUpdate()
        {
            DBclass ed = new DBclass();
            List<DBclass> listdata = ed.studentsListData();
            dataGridView1.DataSource= listdata;
        }
        public void clearfield()
        {
            update_stRoll.Text=string.Empty;
            update_stName.Text=string.Empty;
            update_Tamil.Text=string.Empty;
            update_English.Text=string.Empty;
            update_Maths.Text=string.Empty;
            update_Science.Text=string.Empty;
            update_Social.Text=string.Empty;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                update_stRoll.Text=row.Cells[0].Value.ToString();
                update_stName.Text=row.Cells[1].Value.ToString();
                update_Tamil.Text=row.Cells[2].Value.ToString();
                update_English.Text=row.Cells[3].Value.ToString();
                update_Maths.Text=row.Cells[4].Value.ToString();
                update_Science.Text=row.Cells[5].Value.ToString();
                update_Social.Text=row.Cells[6].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Student_Marks student_Marks = new Student_Marks();
            student_Marks.Student_Roll=update_stRoll.Text;
            student_Marks.Student_Name=update_stName.Text;
            student_Marks.Tamil_mark=update_Tamil.Text;
            student_Marks.English_mark=update_English.Text;
            student_Marks.Maths_mark=update_Maths.Text;
            student_Marks.Science_mark=update_Science.Text;
            student_Marks.Social_mark=update_Social.Text;
            objUpdt.updateStudent(student_Marks);
            displayStudentForUpdate();
            clearfield();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Student_Marks student_Marks=new Student_Marks();
            student_Marks.Student_Roll =update_stRoll.Text;
            student_Marks.Student_Name =update_stName.Text;
            student_Marks.Tamil_mark=update_Tamil.Text; 
            student_Marks.English_mark =update_English.Text;    
            student_Marks.Maths_mark =update_Maths.Text;    
            student_Marks.Science_mark =update_Science.Text;    
            student_Marks.Social_mark =update_Social.Text;
            objDel.deleteStudent(student_Marks);
            displayStudentForUpdate();
            clearfield();

        }
    }
}
