using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookListService
{
    internal class BookListService
    {
        private List<Book> bookList;

        public BookListService()
        {
            bookList = new List<Book>();
        }
        
        /// <summary>
        /// Addition book to booklist
        /// </summary>
        /// <param name="book">Book for addition</param>
        public void AddBook(Book book)
        {
            
            if(bookList.Contains(book))
                throw new Exception("This book already exists in this list");
            else
              bookList.Add(book);
        }

        /// <summary>
        /// Removal book out of booklist
        /// </summary>
        /// <param name="book">Book for removal</param>
        public void RemoveBook(Book book)
        {
            if (bookList.Contains(book)==false)
                throw new Exception("This book doesn't exist in current list");
            else
                bookList.Remove(book);
        }

        private void SortBookByTag(List<Book> list)
        {
            bookList = list;
        }

        /// <summary>
        /// Sorting with different tags
        /// </summary>
        public void SortBookByIsbn() =>SortBookByTag(bookList.OrderBy(book => book.ISBN).ToList());
        public void SortBookByAuthor() => SortBookByTag(bookList.OrderBy(book => book.Author).ToList());
        public void SortBookByTitle() => SortBookByTag(bookList.OrderBy(book => book.Title).ToList());
        public void SortBookByNumberPages() => SortBookByTag(bookList.OrderBy(book => book.NumberPages).ToList());
        public void SortBookByPublishYear() => SortBookByTag(bookList.OrderBy(book => book.PublishYear).ToList());
        public void SortBookByEdition() => SortBookByTag(bookList.OrderBy(book => book.Edition).ToList());
        /// <summary>
        /// Trying to find Book by tag
        /// </summary>
        public Book FindBookByIsbn(int isbn)=>FindBookByTag(bookList.Where(book => book.ISBN == isbn));
        public Book FindBookByAuthor(string author)=>FindBookByTag(bookList.Where(book => book.Author == author));
        public Book FindBookByTitle(string title) => FindBookByTag(bookList.Where(book => book.Title == title));
        public Book FindBookByNumberPages(int numberPages) => FindBookByTag(bookList.Where(book => book.NumberPages == numberPages));
        public Book FindBookByPublishYear(int publishYear) => FindBookByTag(bookList.Where(book => book.PublishYear == publishYear));
        public Book FindBookByEdition(int edition) => FindBookByTag(bookList.Where(book => book.Edition== edition));

        private Book FindBookByTag(IEnumerable<Book> list)
        {
            try
            {
                return list.First();
            }
            catch (Exception)
            {
                throw new Exception("Book with such tag-information does not exist");
            }

        }



    }
}
