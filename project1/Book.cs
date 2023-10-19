namespace Project1
{
    public class Book
    {
        public Book(string title, string author, int pages, int wordCount)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.wordCount = wordCount;

        }

        public Book()
        {

        }

        private string title;
        private string author;
        private int pages;
        private int wordCount;
    }
}
