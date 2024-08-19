namespace D05_Task
{
    class Library
    {
        public List<Book> books { get; set; }

        public Library(List<Book> Books = null)
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        #region SearchFunction
        public Book SearchBook(string title)
        {
            string input = title.ToLower();
            foreach (Book book in books)
            {
                string temp = book.Title.ToLower();
                if (temp.Contains(input))
                    return book;
            }
            return null;
        }
        #endregion

        #region BorrowFunction
        public bool BorrowBook(string title)
        {

            Book comp = SearchBook(title);
            if (comp != null)
            {
                comp.Availability = false;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"You can Borrow {comp.Title}");
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"This {title} Book not Availabil For Borrow!");
                Console.ResetColor();
                return false;
            }
        }
        #endregion

        #region ReturnFunction
        public bool ReturnBook(string title)
        {
            Book comp = SearchBook(title);
            if (comp != null)
            {
                comp.Availability = true;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{comp.Title} has been Returnd");
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"We cant find {title} book");
                Console.ResetColor();
                return false;
            }

        }
        #endregion
    }
}
