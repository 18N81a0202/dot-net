using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace day6dotnet
{
    class items
    {
        static void Main(string[] args)
        {
            List<string> stationery = new List<string>
            {
                "Pen",
                "pencil",
                " notebook",
                "Eraser",
                "sharpener",
            };
            Console.WriteLine("Stationery item:");
            foreach (var item in stationery)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}