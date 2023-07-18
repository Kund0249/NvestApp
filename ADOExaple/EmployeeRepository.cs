using System;
using System.Collections;
using System.Data.SqlClient;

namespace ADOExaple
{
    class EmployeeRepository
    {
        string connectionstring = @"data source=.;database=Sample;trusted_connection=true";
        //@"data source=.;database=Sample;user=sa;password=admin@1234";

        public ArrayList GetEmployees()
        {
            ArrayList employeelist = new ArrayList();


            SqlConnection con = new SqlConnection(connectionstring);

            //SqlCommand cmd = new SqlCommand("select * from TEMPLOYEE", con);

            SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

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

                employeelist.Add(new Employee()
                {
                    EmpCode = Convert.ToInt32(reader["EmpCode"]),
                    EmpName = reader["EmpName"].ToString(),
                    Gender = reader["Gender"].ToString()
                });


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

            SqlCommand cmd = new SqlCommand("spInsertEmployee", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@EmpCode", employee.EmpCode);
            cmd.Parameters.AddWithValue("@EmpName", employee.EmpName);
            cmd.Parameters.AddWithValue("@Gender", employee.Gender);

            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
