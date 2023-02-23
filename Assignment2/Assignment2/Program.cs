using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Qeustion1();
             p.Question2();
            Console.ReadLine();

        }


        public void Qeustion1()
        {
            int[] arr1 = new int[100];
            int i, mx, mn, n;
            float sum = 0, avg = 0;


            Console.Write("\n\n Assgnment One Q1:\n");
            Console.Write("--------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            mx = arr1[0];
            mn = arr1[0];


            for (i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }


                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }


            for (i = 0; i < n; i++)
            {
                sum += arr1[i];
            }
            avg = sum / n;
            Console.Write("Maximum element is : {0}\n", mx);
            Console.Write("Minimum element is : {0}\n\n", mn);
            Console.Write("Sum {0} \n ", sum);
            Console.Write("Average {0} ", avg);
        }

        public void Question2()
        {
            int[] arr1 = new int[100];
            int i, mx, mn;
            float sum = 0, avg = 0;


            Console.Write("\n\n Assgnment One Q1:\n");
            Console.Write("--------------------------------------------------\n");



            Console.Write("Input 10 Marks:\n");
            for (i = 0; i <= 10; i++)
            {
                Console.Write("Mark- {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            mx = arr1[0];
            mn = arr1[0];


            for (i = 1; i <= 10; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }


                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }


            for (i = 0; i <= 10; i++)
            {
                sum += arr1[i];
            }
            avg = sum / 10;


            Console.Write("Maximum Marks is : {0}\n", mx);
            Console.Write("Minimum Marks  is : {0}\n\n", mn);
            Console.Write("Sum  of Marks {0} \n ", sum);
            Console.Write("Average of Marks  {0} \n ", avg);

            Array.Sort(arr1);
            Console.WriteLine("Ascending : ");

            foreach (int value in arr1)
            {
                Console.Write(value + " ");
            }

            Array.Reverse(arr1);
            Console.WriteLine("Desending : ");

            foreach (int value in arr1)
            {
                Console.Write(value + " ");
            }


        }






    }

}

