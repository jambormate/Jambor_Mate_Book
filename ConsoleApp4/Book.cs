﻿using System;
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

		public string Title { get => title; set => title = value; }
		public string Author { get => author; set => author = value; }
		public int PageCount { get => pageCount; set => pageCount = value; }
		public int ReleaseYear { get => releaseYear; set => releaseYear = value; }

	}
}
