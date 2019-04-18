namespace ServiceBooksOrdererDDD.SeviceBooksOrderer.Model
{
    public class BookModel
    {
        public BookModel()
        {

        }

        public int idBook { get; set; }
        public string title { get; set; }
        public string authorName { get; set; }
        public int editionYear { get; set; }
        public bool active { get; set; }

        public BookModel(int idBook, string title, string authorName, int editionYear, bool active)
        {
            this.idBook = idBook;
            this.title = title;
            this.authorName = authorName;
            this.editionYear = editionYear;
            this.active = active;
        }

    }
}
