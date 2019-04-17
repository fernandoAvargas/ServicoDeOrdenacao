
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Model;
using System.Collections.Generic;

namespace ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface
{
    public interface IBooksOrderer
    {
        List<BookModel> BooksOrderer(List<BookModel> BookModel, int titleAsc = 1, int authorAsc = 1, int editAsc = 1); 
    }
}
