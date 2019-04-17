using System.Collections.Generic;

namespace ServiceBooksOrdererDDD.SeviceBooksOrderer.Model
{
    public class BookModel
    {

        public BookModel()
        {

        }

        public int idBook { get; set; }
        public string title { get; set; }
        public List<AuthorBookModel> AuthorBookModel { get; set; }
        public int editionYear { get; set; }
        public bool active { get; set; }

        public BookModel(int idBook, string title, List<AuthorBookModel> AuthorBookModel, int editionYear, bool active)
        {
            this.idBook = idBook;
            this.title = title;
            this.AuthorBookModel = AuthorBookModel;
            this.editionYear = editionYear;
            this.active = active;
        }

    }
}
