using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6dotnet
{
    public class products
    {
        public static void Main(string[] args)
        {
            List<Products> prolist = new List<Products>
            {
                new Products{Product_Id=1,Product_Name="Sugar",Price=40.0f},
                new Products{Product_Id=2,Product_Name="Dal",Price=130.0f},
                new Products{Product_Id=3,Product_Name="Atta",Price=49.0f},
                new Products{Product_Id=4,Product_Name="Salt",Price=18.0f},
                new Products{Product_Id=5,Product_Name="Milk",Price=90.0f},
                new Products{Product_Id=6,Product_Name="Curd",Price=3.0f},
                new Products{Product_Id=7,Product_Name="Onions",Price=48.0f},
                new Products{Product_Id=8,Product_Name="Potatoes",Price=45.0f},
                new Products{Product_Id=9,Product_Name="Tomatoes",Price=40.0f},
                new Products{Product_Id=10,Product_Name="Oil",Price=170.0f}
            };
            Display(prolist);
            Console.Read();
        }
        public static void Display(List<Products> products)
        {
            Console.WriteLine();
            var val = products.OrderBy(a => a.Price).ToList();
            foreach (var p in val)
            {
                Console.WriteLine("Id: {0}  Name: {1}   price: {2} ", p.Product_Id, p.Product_Name, p.Price);
            }
        }
    }

    public class Products
    {
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public float Price { get; set; }


    }
}