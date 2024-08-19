namespace D05_Task
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool Availability { get; set; }

        public Book(string title, string author, string iSBN, bool availability = true)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Availability = availability;
        }
    }
}
