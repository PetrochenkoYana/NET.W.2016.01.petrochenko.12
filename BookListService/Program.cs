using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookListService
{
    class Program
    {
        static void Main(string[] args)
        {
            BookListStorage bookListStorage=new BookListStorage("C:\\Users\\Yana_Petrochenko\\Documents\\Visual Studio 2015\\Projects\\NET.W.2016.01.petrochenko.12\\BookListService\\file.txt");
            //List<Book> list = bookListStorage.LoadBooks();
            BookListService bookListService=new BookListService();
            bookListService.AddBook(new Book(123102, "Picture of Dorian Grey", "Oskar Wild", 300, 1890, 1000000));
            bookListService.AddBook(new Book(12354, "Angelika", "Ann and Serge Gollon", 550, 1917, 1000000));
            bookListService.AddBook(new Book(12349, "Gone with the wind", "Margaret Mitchell", 2000, 1936, 1000000));
            bookListService.AddBook(new Book(12356, "Farengate 451", "Ray Bradbury", 2000, 1950, 1000000));
            //bookListService.RemoveBook(new Book(12346, "Angelika", "Ann and Serge Gollon", 550, 1917, 1000000));
            //bookListService.FindBookByIsbn(12346);//exception
            bookListService.SortBookByIsbn();
            Console.ReadKey();
        }
    }
}
