﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4dotnet
{
    class customer
    {
        int custid, age, phone;
        string custname, city;
        public customer()
        {
            custid = 46;
            custname = "harsha";
            age = 21;
            phone = 6547;
            city = "Hyd";
        }
        public void Acceptcustomer()
        {
            Console.WriteLine("enter customer details:");
            custid = Convert.ToInt32(Console.ReadLine());
            custname = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            phone = Convert.ToInt32(Console.ReadLine());
            city = Console.ReadLine();



        }
        public void DisplaycustomerDetails()
        {
            Console.WriteLine($"customer Name : {custname}\n " +
                $"customerid :{custid}\n " +
                $"Age:{age} \n" +
                $"customerno :{phone}\n" +
                $"customercity :{city}\n");
            Console.ReadLine();
        }
        ~customer()
        {
            Console.WriteLine("bye from customer");
            Console.ReadLine();
        }
    }
        class Details
          {
              static void Main()
               {
                 customer c = new customer();
                 c.DisplaycustomerDetails();
                 Console.ReadLine();
               }
          }
}
