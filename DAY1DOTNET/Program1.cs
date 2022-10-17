using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2

{
	class Program
	{ 
	    static void main(string[] args)
		{
			Console.WriteLine("check whether two integers equal or not: \n");
			Console.WriteLine("--------------------------------------------");
			Console.Write("\n\n");
  
			int num1=5, num2=5;
			if(num1==num2)
			{
				Console.WriteLine("num1 and num2 are equal\n", num1, num2);
			}
			else
			{
				Console.WriteLine("not equal");
			}
			Console.ReadKey();

		}


	}
}
