using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace mini_project
{
    class Program
    {
        public static SqlConnection con; 
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        static void Main(string[] args)
        {

            Console.WriteLine("---------------Employee Management Portal----------");
            Console.WriteLine("\r\nType Role: Admin = 1 ,User = 2 ");
            int role =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose Oeration");
            if(role==1)
            Console.WriteLine("Admin \n  1:Display\n 2:Insert \n 3:Update \n  4:Delete");
            else
                Console.WriteLine("User \n 1:Display \n 2:Update Profiles ");
            int  operation =Convert.ToInt32(Console.ReadLine());
          
           
            switch (role)

            {

                case 1:

                    switch (operation)

                    {

                        case 1:
                            DisplayEmp();
                            

                            break;

                        case 2:

                            InsertData();

                            break;


                        case 3:

                           UpdateData();

                            break;

                        case 4:
                            DeleteData();

                            break;

                    }

                    break;



                case 2:

                    switch (operation)

                    {

                        case 1:

                            DisplayEmp();
                            break;

                        case 2:

                            UpdateProfiles();

                            break;

                    }

                    break;



                default:

                    Console.WriteLine("Invalid Role/Usertype");

                    break;

            }

            Console.ReadLine();





        }

        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=DESKTOP-RLOTTM7\\SQLEXPRESS ;Initial Catalog=DevDB;" +
                "Integrated Security=true;");
            con.Open();
            return con;
        }

        public static void DisplayEmp()
        {
            try
            {
                con = getConnection(); // gets the connection details after executing the getConnection method
                cmd = new SqlCommand("select * from employee", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // Console.WriteLine(dr[0] + " |" + dr[1] + "| " + dr[2]);
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Employee Id : {0}", dr[0]);
                    Console.WriteLine("Employee Name : {0}", dr[1]);
                    Console.WriteLine("Employee Address : {0}", dr[2]);
                    Console.WriteLine("Employee Phone_no : {0}", dr[3]);
                    Console.WriteLine("Employee City : {0}", dr[4]);
                    Console.WriteLine("Employee DeptId : {0}", dr[5]);
                    Console.WriteLine("Employee Salary : {0}", dr[6]);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("Some Error Occured.. Try after sometime");
                Console.WriteLine(se.Message);
            }
        }
        #region
        public static void InsertData()
        {
            con = getConnection();
            Console.WriteLine("Enter Employee Id:");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            string empname = Console.ReadLine();
            Console.WriteLine("Enter Employee Address:");
            string empaddress = Console.ReadLine();
            Console.WriteLine("Enter Employee Phone No:");
            int empphone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee City:");
            string empcity = Console.ReadLine();
            Console.WriteLine("Enter Employee DeptNo:");
            int deptno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary:");
            float esalary = Convert.ToSingle(Console.ReadLine());
        
            cmd = new SqlCommand("insert into Employee values(@eid,@ename,@eaddress,@ephn,@ecity,@edno,@esal)", con);
            cmd.Parameters.AddWithValue("@eid", empid);
            cmd.Parameters.AddWithValue("@ename", empname);
            cmd.Parameters.AddWithValue("@eaddress", empaddress);
            cmd.Parameters.AddWithValue("@ephn", empphone);
            cmd.Parameters.AddWithValue("@ecity", empcity);
            cmd.Parameters.AddWithValue("@edno", deptno);
            cmd.Parameters.AddWithValue("@esal", esalary);

            int res = cmd.ExecuteNonQuery();
            if (res > 0)
                Console.WriteLine("Record inserted..");
            else
                Console.WriteLine("not inserted");
        }
        #endregion

        public static void DeleteData()
        {
            con = getConnection();
            Console.WriteLine("Enter Employee id :");
            int eid = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from employee where empid=@empcode");
            cmd1.Parameters.AddWithValue("@empcode", eid);
            cmd1.Connection = con;

            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();
            Console.WriteLine("Are you sure ? You won't be able to revert this!? Y/N");
            string res = Console.ReadLine();
            if (res == "y" || res == "Y")
            {
                cmd = new SqlCommand("delete from employee where empid=@empcode", con);
                cmd.Parameters.AddWithValue("@empcode", eid);
                con.Open();

                int rw = cmd.ExecuteNonQuery();
                if (rw > 0)
                    Console.WriteLine("Record Deleted..");
                else
                    Console.WriteLine("Not deleted");
            }

        }
        public static void UpdateData()
        {
            con = getConnection();
            Console.WriteLine("Enter Employee id :");
            int eid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee New Depno :");
            int edno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee New Salary :");
            float empsal = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("Select * from employee where empid=@empcode");
            cmd1.Parameters.AddWithValue("@empcode", eid);
            cmd1.Connection = con;

            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();
            Console.WriteLine("Are you sure to updates the records ?  Y/N");
            string res = Console.ReadLine();
            if (res == "y" || res == "Y")
            {
                cmd = new SqlCommand("update employee set deptID = @empdno,empsal = @empsal  where empid=@empcode", con);
                cmd.Parameters.AddWithValue("@empcode", eid);
                cmd.Parameters.AddWithValue("@empdno", edno);
                cmd.Parameters.AddWithValue("@empsal", empsal);
                con.Open();

                int rw = cmd.ExecuteNonQuery();
                if (rw > 0)
                    Console.WriteLine("Record Updated..");
                else
                    Console.WriteLine("Not updated");
            }

        }

        public static void UpdateProfiles()
        {
            con = getConnection();
            Console.WriteLine("Enter  Your Employee id :");
            int eid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee New Phone No:");
           string emphone = Console.ReadLine();
            SqlCommand cmd1 = new SqlCommand("Select * from employee where empid=@empcode");
            cmd1.Parameters.AddWithValue("@empcode", eid);
            cmd1.Connection = con;

            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();
            Console.WriteLine("Are you sure to updates the records ?  Y/N");
            string res = Console.ReadLine();
            if (res == "y" || res == "Y")
            {
                cmd = new SqlCommand("update employee set phone = @emphone  where empid=@empcode", con);
                cmd.Parameters.AddWithValue("@empcode", eid);
                cmd.Parameters.AddWithValue("@emphone", emphone);
                con.Open();

                  int rw = cmd.ExecuteNonQuery();
                if (rw > 0)
                    Console.WriteLine("Record Updated..");
                else
                    Console.WriteLine("Not updated");
            }

        }
    }
}