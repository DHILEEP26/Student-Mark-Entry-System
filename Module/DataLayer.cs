using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Student_Mark_Entry_System.Module
{
    public class DataLayer
    {
        public class Tableusers
        {
            public bool saveData(Users users)
            {
                bool result=false;
                DBclass objDB=new DBclass();
                objDB.loginCheck(users);
                return result;
            }

            public bool checkData(Users users) 
            {
                bool result=false;
                DBclass objDB=new DBclass();
                objDB.registerCheck(users);
                return result;
            }
        }

        public class TableStudent
        {
            public bool addStudent(Student_Marks student_Marks)
            {
                bool result=false;  
                DBclass objDB=new DBclass();
                objDB.AddStudent(student_Marks);
                return result;

            }

            public bool updateStudent(Student_Marks student_Marks) 
            {
                bool result=false;
                DBclass objDB=new DBclass();
                objDB.UpdateStudent(student_Marks);
                return result;
            
            }

            public bool deleteStudent(Student_Marks student_Marks)
            {
                bool result=false;  
                DBclass objDB=new DBclass();
                objDB.deleteStudent(student_Marks);
                return result;
            }
        }

        public class TableResult
        {
            public int displayResult(Student_Result student_Result)
            {
                int result=0;   
                DBclass objDB=new DBclass();
                result= objDB.displayResult(student_Result);
                return result;
            }
        }
    }
}
