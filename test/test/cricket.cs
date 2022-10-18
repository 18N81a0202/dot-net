using System;
using System.Collections;
namespace test
{
    class cricket
    {
       public void pointscalculation(int no_of_matches)
        {
            ArrayList matches = new ArrayList();
            matches.Add(no_of_matches);
            matches.Add(230);
            matches.Add(205);
            matches.Add(125);
            matches.Add(157);
            matches.Add(197);
            matches.Add(146);
            matches.Add(137);
            matches.Add(147);
            matches.Add(117);
            matches.Add(146);
            Console.Write("no of matches score: ");
            foreach (int i in matches)
            {
                Console.Write(i + " ");
            }
            int sum = 0;
            foreach (int i in matches)
            {
                sum += i;
            }
            Console.WriteLine("Sum = {0}", sum);
            Console.ReadLine();

        }
        static void display()
        {
            cricket c = new cricket();
            c.pointscalculation();
        }

    }
}
