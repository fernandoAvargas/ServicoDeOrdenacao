
using System;
using System.Collections.Generic;

namespace ServiceBooksOrdererDDD.SeviceBooksOrderer.Model
{
    public class AuthorBookModel
    {
        public AuthorBookModel()
        {

        }

        public int idAuthor { get; set; }
        public string name { get; set; }
        public bool active { get; set; }

        public AuthorBookModel(int idAuthor, string name, bool active)
        {
            this.idAuthor = idAuthor;
            this.name = name;
            this.active = active;
        }
    }
}
