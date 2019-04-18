
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Model;
using System.Collections.Generic;

namespace ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface
{
    public interface IBooksOrderer
    {
        List<BookModel> BooksOrderer(List<BookModel> BookModel, int order); 
    }
}
