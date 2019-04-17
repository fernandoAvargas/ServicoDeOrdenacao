using System.Collections.Generic;

namespace ServiceBooksOrdererDDD.SeviceBooksOrderer.Model
{
    public class BookModel
    {
        public int idLivro { get; set; }
        public string title { get; set; }
        public List<AuthorBookModel> AuthorBookModel { get; set; }
        public int editionYear { get; set; }
        public bool active { get; set; }

    }
}
