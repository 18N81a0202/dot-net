using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4dotnet
{
    class Doctor
    {
        private int regno;
        private string name;
        private int feecharged;
        public int Regno
        {
            set
            {
                regno = value;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }

        }
        public int Feecharged
        {
            set
            {
                feecharged = value;
            }
        }
        public  void GetDetails()
        {
            Console.WriteLine("Regno:" + regno);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Feecharged:" + feecharged);
        }
    }
    class User
    {
        public static void Main()
        {
            Doctor d = new Doctor();
            d.Regno = 123;
            d.Name = "A";
            d.Feecharged = 200;
            d.GetDetails();
            Console.ReadLine();
        }


    }
}


