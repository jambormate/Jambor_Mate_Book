using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	internal class Book
	{
		string title;
		string author;
		int pageCount;
		int releaseYear;

		public Book(string title, string author, int pageCount, int releaseYear)
		{
			this.title = title;
			this.author = author;
			this.pageCount = pageCount;
			this.releaseYear = releaseYear;
		}

		public string Title { get => title; }
		public string Author { get => author;  }
		public int PageCount { get => pageCount;}
		public int ReleaseYear { get => releaseYear; }
        public static Book GetBookByTitle(Book[] books, string title)
        {
            foreach (Book book in books)
            {
                if (book.Title == title)
                {
                    return book;
                }
            }
            return null;
        }
        public void EditBookData()
        {
            Console.Write("Új cím: ");
            string inputTitle = Console.ReadLine();
            if (!string.IsNullOrEmpty(inputTitle))
            {
                this.title = inputTitle;
            }

            Console.Write("Új szerző: ");
            string inputAuthor = Console.ReadLine();
            if (!string.IsNullOrEmpty(inputAuthor))
            {
                this.author = inputAuthor;
            }

            Console.Write("Új lapszám: ");
            string inputPageCount = Console.ReadLine();
            if (!string.IsNullOrEmpty(inputPageCount))
            {
                this.pageCount = Convert.ToInt32(inputPageCount);
            }

            Console.Write("Új kiadási év: ");
            string inputReleaseYear = Console.ReadLine();
            if (!string.IsNullOrEmpty(inputReleaseYear))
            {
                this.releaseYear = Convert.ToInt32(inputReleaseYear);
            }
        }


    }
}
