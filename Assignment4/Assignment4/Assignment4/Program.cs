using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("-----------------First Question-------------------");
            // Saledetails s = new Saledetails(12, 34,0,0, Convert.ToDateTime("09/02/2023")); //
            //s.Sales();
            //// s.Showdata();
            // Console.WriteLine("-----------------Second Question-------------------"); 
           
            Scholarship s = new Scholarship(200,45);
            float scholarshipamount = s.Merit();
            Console.WriteLine("Scholarship Amount:{0}", scholarshipamount);
            //  Doctor d = new Doctor("Konsam Devkanta","Shillong","KIORTY", 1200, "NEUROLOGY");

            Console.ReadLine();
        }
       
    }
    
}
