namespace ConsoleApp4
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Book book1 = new("A Kis Herceg", "Antoine de Saint-Exupéry", 96, 1943);
            Book book2 = new("Egri Csillagok", "Gárdonyi Géza", 393, 1901);
            Book book3 = new("Háború és béke", "Lev Nyikolajevics Tolsztoj", 1225, 1865);
            Book[] books = new Book[] { book1, book2, book3 };
            Console.WriteLine((Book.GetBookByTitle(books, "A Kis Herceg")).Title);
        }
	}
}
