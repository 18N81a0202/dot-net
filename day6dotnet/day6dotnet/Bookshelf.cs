using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6dotnet
{
    class BookShelf
    {
        Books a;
        public static void SetIndexer(Books a)
        {
            a[0] = "A";
            a[1] = "B";
            a[2] = "C";
            a[3] = "D";
            a[4] = "D";

            a[0L] = "abc";
            a[1L] = "guh";
            a[2L] = "hui";
            a[3L] = "jgl";
            a[4L] = "toy";
            a.Display();
        }
        public BookShelf()
        {
            a = new Books();
            SetIndexer(a);
        }
    }
    class Books
    {
        string[] BookName = new string[5];
        string[] AuthorName = new string[5];
        public string this[int Bname]
        {
            get { return BookName[Bname]; }
            set { BookName[Bname] = value; }
        }
        public string this[long Aname]
        {
            get { return AuthorName[Aname]; }
            set { AuthorName[Aname] = value; }
        }
        public void Display()
        {
            Console.WriteLine("---BookS_Details---");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("The author of {0} is {1} ", BookName[i], AuthorName[i]);
            }
        }
    }
    class Driven_Bookshelf
    {
        public static void Main(string[] args)
        {
            BookShelf i = new BookShelf();
            Console.Read();
        }
    }
}

