using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;
using Student_Mark_Entry_System.Module;
namespace Student_Mark_Entry_System
{
    public class DBclass
    {
        public string RollNo {  get; set; } 
        public string Student_Name { get; set; }
        public int TamilMark {  get; set; }
        public int EnglishMark { get; set; }
        public int MathsMark { get; set; }
        public int ScienceMark { get; set; }
        public int SocialMark { get; set; }
        public int TotalMark {  get; set; }

        SqlConnection connect=new SqlConnection(@"Data Source=LAPTOP-OF5DRCJC\SQLEXPRESS;Initial Catalog=Training_db;Integrated Security=True;Encrypt=False");

        public List<DBclass> studentsListData()
        {
            List<DBclass> listdata = new List<DBclass>();
            if(connect.State!=ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SP_SEL_Student";
 
                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader(); 
                        while (reader.Read()) 
                        {
                            DBclass ed= new DBclass();
                            ed.RollNo=reader["Student_RollNo"].ToString();
                            ed.Student_Name=reader["Student_Name"].ToString() ;
                            ed.TamilMark=(int)reader["Tamil"];
                            ed.EnglishMark=(int)reader["English"];
                            ed.MathsMark=(int)reader["Maths"];
                            ed.ScienceMark=(int)reader["Science"];
                            ed.SocialMark=(int)reader["Social"];
                            ed.TotalMark=(int)reader["Total"];
                            listdata.Add(ed);

                        }
                    }
                }
                catch(Exception ex)  
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }



        public int displayResult(Student_Result student_Result)
        {
            int count = 0;
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmdget = new SqlCommand($"SP_SEL_PASS_FAIL", connect);
                    cmdget.CommandType = CommandType.StoredProcedure;
                    cmdget.Parameters.AddWithValue("@Operation",SqlDbType.NVarChar).Value = student_Result.Operation;    
                     count = (int)cmdget.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:"+ ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }

            }
            return count;

        }

        public void  loginCheck(Users users)
        {
            if (users.Name==""||users.Password=="")
            {
                MessageBox.Show("Please Fill The UserName and Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand($"SP_SAV_User", connect);
                        cmd.CommandType= CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userName",SqlDbType.NVarChar).Value= users.Name;
                        cmd.Parameters.AddWithValue("@userPassword", SqlDbType.NVarChar).Value= users.Password;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count >=1)
                        {
                            MessageBox.Show("Login Successfully !", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            Form1 loginform = new Form1();
                            loginform.Hide();
                            
                        }
                        else
                        {
                            MessageBox.Show("Incorrect UserName or Password !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:"+ ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }
        public void registerCheck(Users users)
        {
            if (users.regName==""||users.regPassword=="")
            {
                MessageBox.Show("Please Fill The UserName and Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (users.regPassword!=users.regConfirm)
            {
                MessageBox.Show("Password and ReEnter Password are not same", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                       // SqlCommand cmdget = new SqlCommand($"SELECT COUNT(ID) FROM users WHERE User_Name='{users.regName.Trim()}'", connect);
                        SqlCommand cmdget = new SqlCommand($"SP_COUNT_User", connect);
                        cmdget.CommandType=CommandType.StoredProcedure;
                        cmdget.Parameters.AddWithValue("@userName",SqlDbType.NVarChar).Value = users.regName;
                        int count = (int)cmdget.ExecuteScalar();
                        if (count>=1)
                        {
                            MessageBox.Show($"{users.regName.Trim()} is Already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {

                            // SqlCommand cmd = new SqlCommand($"INSERT INTO users(User_Name,User_Password) VALUES('{users.regName.Trim()}','{users.regPassword.Trim()}')", connect);
                            SqlCommand cmd = new SqlCommand($"SP_REG_VALUE", connect);
                            cmd.CommandType=CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@userName",SqlDbType.NVarChar).Value=users.regName;
                            cmd.Parameters.AddWithValue("@userPassword", SqlDbType.NVarChar).Value=users.regPassword;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Registered Successfully !", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:"+ ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();

                    }
                }
            }
        }


        public void AddStudent(Student_Marks student_Marks)
        {
            if (student_Marks.Student_Roll==""||student_Marks.Student_Name==""||student_Marks.Tamil_mark==""||student_Marks.English_mark==""||student_Marks.Maths_mark==""||student_Marks.Science_mark==""||student_Marks.Social_mark=="")
            {
                MessageBox.Show("Please Fill All The Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        SqlCommand cmdcheck = new SqlCommand($"SP_COUNT_STD", connect);
                        cmdcheck.CommandType = CommandType.StoredProcedure;
                        cmdcheck.Parameters.AddWithValue("@studentRollNo", SqlDbType.NVarChar).Value = student_Marks.Student_Roll;
                        int count = (int)cmdcheck.ExecuteScalar();
                        if (count>=1)
                        {
                            MessageBox.Show("The ROll Number is already Taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            //SqlCommand cmdinsert = new SqlCommand($"INSERT INTO Student_marks(Student_RollNo,Student_name,Tamil,English,Maths,Science,Social) VALUES('{student_Marks.Student_Roll.Trim()}','{student_Marks.Student_Name.Trim()}',{int.Parse(student_Marks.Tamil_mark)},{int.Parse(student_Marks.English_mark)},{int.Parse(student_Marks.Maths_mark)},{int.Parse(student_Marks.Science_mark)},{int.Parse(student_Marks.Social_mark)})", connect);
                            SqlCommand cmdinsert = new SqlCommand("SP_SAV_StudentMark", connect);
                            cmdinsert.CommandType = CommandType.StoredProcedure;

                            cmdinsert.Parameters.AddWithValue("@Student_RollNo", SqlDbType.NVarChar).Value=student_Marks.Student_Roll;
                            cmdinsert.Parameters.AddWithValue("@Student_name", SqlDbType.NVarChar).Value=student_Marks.Student_Name;
                            cmdinsert.Parameters.AddWithValue("@Tamil", SqlDbType.Int).Value=int.Parse(student_Marks.Tamil_mark);
                            cmdinsert.Parameters.AddWithValue("@English", SqlDbType.Int).Value=int.Parse(student_Marks.English_mark);
                            cmdinsert.Parameters.AddWithValue("@Maths", SqlDbType.Int).Value=int.Parse(student_Marks.Maths_mark);
                            cmdinsert.Parameters.AddWithValue("@Science", SqlDbType.Int).Value=int.Parse(student_Marks.Science_mark);
                            cmdinsert.Parameters.AddWithValue("@Social", SqlDbType.Int).Value=int.Parse(student_Marks.Social_mark);
                            cmdinsert.ExecuteNonQuery();
                           
                            MessageBox.Show("Inserted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:"+ ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        public void UpdateStudent(Student_Marks student_Marks)
        {

            if (student_Marks.Student_Roll==""||student_Marks.Student_Name==""||student_Marks.Tamil_mark==""||student_Marks.English_mark==""||student_Marks.Maths_mark==""||student_Marks.Science_mark==""||student_Marks.Social_mark=="")
            {
                MessageBox.Show("Please Fill All The Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are You Sure You Want To UPDATE"+ "Student_RollNo: " + student_Marks.Student_Roll.Trim()+" ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        //SqlCommand cmdup = new SqlCommand($"UPDATE Student_marks SET Student_RollNo='{student_Marks.Student_Roll.Trim()}',Student_name='{student_Marks.Student_Name.Trim()}',Tamil={int.Parse(student_Marks.Tamil_mark.Trim())},English={int.Parse(student_Marks.English_mark.Trim())},Maths={int.Parse(student_Marks.Maths_mark.Trim())},Science={int.Parse(student_Marks.Science_mark.Trim())},Social={int.Parse(student_Marks.Social_mark.Trim())} WHERE Student_RollNo='{student_Marks.Student_Roll.Trim()}' ", connect);
                        SqlCommand cmdup = new SqlCommand($"SP_UPD_STD", connect);
                        cmdup.CommandType = CommandType.StoredProcedure;
                        cmdup.Parameters.AddWithValue("@RollNum", SqlDbType.NVarChar).Value=student_Marks.Student_Roll;
                        cmdup.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value=student_Marks.Student_Name;
                        cmdup.Parameters.AddWithValue("@Tamil", SqlDbType.Int).Value=int.Parse(student_Marks.Tamil_mark);
                        cmdup.Parameters.AddWithValue("@English", SqlDbType.Int).Value=int.Parse(student_Marks.English_mark);
                        cmdup.Parameters.AddWithValue("@Maths", SqlDbType.Int).Value=int.Parse(student_Marks.Maths_mark);
                        cmdup.Parameters.AddWithValue("@Science", SqlDbType.Int).Value=int.Parse(student_Marks.Science_mark);
                        cmdup.Parameters.AddWithValue("@Social", SqlDbType.Int).Value=int.Parse(student_Marks.Social_mark);
                        cmdup.ExecuteNonQuery();
                        MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:"+ ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        public void deleteStudent(Student_Marks student_Marks)
        {
            if (student_Marks.Student_Roll==""||student_Marks.Student_Name==""||student_Marks.Tamil_mark==""||student_Marks.English_mark==""||student_Marks.Maths_mark==""||student_Marks.Science_mark==""||student_Marks.Social_mark=="")
            {
                MessageBox.Show("Please Fill All The Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are You Sure You Want To DELETE "+"Student_RollNo: " + student_Marks.Student_Roll.Trim()+" ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        SqlCommand cmdup = new SqlCommand($"SP_DEL_mark", connect);
                        cmdup.CommandType = CommandType.StoredProcedure;
                        cmdup.Parameters.AddWithValue("@Student_RollNo",SqlDbType.NVarChar).Value = student_Marks.Student_Roll;
                        cmdup.ExecuteNonQuery();
                        
                        MessageBox.Show("Successfully! DELETED", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:"+ ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }

}
