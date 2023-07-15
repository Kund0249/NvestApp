using System;
using System.Collections;
using System.Data.SqlClient;

namespace ADOExaple
{
    class EmployeeRepository
    {
        string connectionstring = @"data source=.;database=Sample;trusted_connection=true";

        public ArrayList GetEmployees()
        {
            ArrayList employeelist = new ArrayList();


            SqlConnection con = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("select * from TEMPLOYEE", con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Employee employee = new Employee()
                //{
                //    EmpCode = Convert.ToInt32(reader["EmpCode"]),
                //    EmpName = reader["EmpName"].ToString(),
                //    Gender = reader["Gender"].ToString()
                //};

                //employeelist.Add(employee);

                //employeelist.Add(new Employee()
                //{
                //    EmpCode = Convert.ToInt32(reader["EmpCode"]),
                //    EmpName = reader["EmpName"].ToString(),
                //    Gender = reader["Gender"].ToString()
                //});

              
            }
            con.Close();
            return employeelist;
        }

        public void Save(Employee employee)
        {
            //Insert into TEMPLOYEE Values(7,'John','M')

            //string query = string.Format("Insert into TEMPLOYEE Values({0},'{1}','{2}')", 
            //    employee.EmpCode, employee.EmpName, employee.Gender);

            SqlConnection con = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("",con);

            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
