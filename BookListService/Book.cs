using System;

namespace BookListService
{
    internal class Book:IEquatable<Book>,IComparable<Book>
    {
        public int ISBN { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int NumberPages { get; private set; }
        public int PublishYear { get; private set; }
        public int Edition { get; private set; }

        public Book() { }
        public Book(int isbn, string title, string author, int numberPages, int publishYear, int edition)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            NumberPages = numberPages;
            PublishYear = publishYear;
            Edition = edition;
        }

        public override bool Equals(object obj) => Equals((Book)obj);
        public override int GetHashCode() => ISBN;
        public override string ToString() => string.Format(nameof(ISBN)+": "+ISBN.ToString()+", " + nameof(Title) + ": " + Title + ", " + nameof(Author) + ": " + Author + ", " +nameof(NumberPages) + ": " +NumberPages + ", " +nameof(PublishYear) + ": " +PublishYear + ", " +nameof(Edition) + ": " +Edition);

        public bool Equals(Book other)
        {
            if(other==null)
                throw new ArgumentNullException();
            else
                return this.ISBN.Equals(other.ISBN);
        }

        public int CompareTo(Book other)
        {
            if (other == null)
                throw new ArgumentNullException();
            else
                return this.ISBN.CompareTo(other.ISBN);
        }
    }
}
