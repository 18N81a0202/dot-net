using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2dotnet
{
    class Arrays
    {

        public static void Main()
        {
            Arrays array = new Arrays();
            //array.ArrayAverage();
            //array.ArrayMaxMin();
            array.Arraytotal();
            Console.Read();
        }
        //1a
        #region
       
        public void ArrayAverage()
        {
            int[] M = { 1, 2, 3, 4, 5 };

            int i = 0;
            int total = 0;
            float average;
            for (i = 0; i < M.Length; i++)
            {
                total = total + M[i];
            }

            average = (float)total / M.Length;

            Console.WriteLine("Average of Array elements: " + average);
        }


        #endregion

        //1b
        #region
        
        public void ArrayMaxMin()
        {
            int[] arr = new int[5] { 99, 95, 93, 89, 87 };
            int i, max, min, n;
            // size of the array
            n = 5;
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Maximum element = {0}\n", max);
            Console.Write("Minimum element = {0}\n\n", min);
        }
        #endregion


        //2
        #region
        public void Arraytotal()
        {
            double phy, chem, math, java, c, csharp, python, hin, tel, sci, rl, total;
            double Average;
            string nm;



            Console.Write("\n\n");
            Console.Write("Calculate the total, Average, minimum and maximum ,ascending and descending order marks of 10 subjects:\n");
            Console.Write("-------------------------------------------------------------------------------");
            Console.Write("\n\n");




            Console.Write("Input the Roll Number of the student :");
            rl = Convert.ToInt32(Console.ReadLine());



            Console.Write("Input the Name of the Student :");
            nm = Console.ReadLine();



            Console.Write("Input  the marks of phy subject : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  chem subject : ");
            chem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of mathsubject: ");
            math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of java subject: ");
            java = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of c subject: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of csharp subject: ");
            csharp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of python subject: ");
            python = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of hin subject: ");
            hin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of tel subject: ");
            tel = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of sci subject: ");
            sci = Convert.ToInt32(Console.ReadLine());



            total = phy + chem + math + java + c + csharp + python + hin + tel + sci;
            Average = total / 10.0;
            Console.Write("\nRoll No : {0}\nName of Student : {1}\n", rl, nm);
            Console.Write("Total Marks = {0}\nAverage = {1}\n", total, Average);
            Console.Write("Marks in Phy : {0}\nMarks in Chem : {1}\nMarks in math : {2}\nMarks in java : {3}\nMarks in c : {4}\nMarks in csharp : {5}\nMarks in python : {6}\nMarks in hin : {7}\nMarks in tel : {8}\nMarks in sci : {9}", phy, chem, math, java, c, csharp, python, hin, tel, sci);
            Console.Read();
        }

        #endregion

    }


}




