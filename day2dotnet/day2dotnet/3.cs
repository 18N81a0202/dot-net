using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2dotnet
{
    class strings
    {
        static void Main()
        {
            string s1 = "man";
            string s2 = "man";
            bool result = string.Equals(s1, s2);
            Console.WriteLine(" length of the word:" + s1.Length);
            Console.WriteLine(result);
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();
            string reverseString = string.Empty;
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reverseString += originalString[i];
            }
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();
        }
    }
}    


