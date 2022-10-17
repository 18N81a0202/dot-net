using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace day6dotnet
{
    struct books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;



        public void getValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }



        public void display()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id :{0}", book_id);
        }
    }



    class TestStructure
    {
        public static void Main(string[] args)
        {
            books book1 = new books();
            books book2 = new books();
            books book3 = new books();



            book1.getValues("PE", "HARSHINI", "EEE", 2);
            book2.getValues("PS", "SUPRIYA", "EEE", 2);
            book3.getValues("CS", "SHIVANI", "EEE", 2);

            book1.display();
            book2.display();
            book3.display();



            Console.ReadLine();
        }
    }
}
