using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public abstract class Student
    {
        public string Name;
        public int Stud_Id;
        public double Grade;

        public abstract bool Ispassed(double grade);
    }

    class Undergraduate : Student
    {
        public override bool Ispassed(double grade)
        {
            if (grade > 70.0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

    class Graduate : Student
    {
        public override bool Ispassed(double grade)
        {
            if (grade > 80.0)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
    }

    class student
    {
        static void Main(string[] args)
        {

            Undergraduate u = new Undergraduate();


            Console.WriteLine("****************Under Graduate******************");
            Console.Write("Enter the  UG Student Name: ");
            u.Name = Console.ReadLine();

            Console.WriteLine("Enter the Student ID: ");
            u.Stud_Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Grade for the Course: ");
            u.Grade = Convert.ToDouble(Console.ReadLine());


            bool status = u.Ispassed(u.Grade);
            Console.WriteLine("Status for {0} with ID {1}: {2}", u.Name, u.Stud_Id, status);


            Graduate g = new Graduate();


            Console.WriteLine("*******************Graduate***************  ");
            Console.Write("Enter the Graduate Student Name: ");
            g.Name = Console.ReadLine();

            Console.Write("Enter the student ID: ");
            g.Stud_Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the grade for the course: ");
            g.Grade = Convert.ToDouble(Console.ReadLine());


            status = g.Ispassed(g.Grade);
            Console.WriteLine("Status for {0} with ID {1}: {2}", g.Name, g.Stud_Id, status);

            Console.ReadLine();
        }
    }

}
