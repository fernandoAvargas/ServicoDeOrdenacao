
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Model;
using System.Collections.Generic;

namespace ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface
{
    interface IBooksOrderer
    {
        List<BookModel> BooksOrderer(List<BookModel> BookModel, int idOrder, int titleOrder, int authorOrder, int editOrder); 
    }
}
