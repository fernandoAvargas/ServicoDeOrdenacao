
using ServiceBooksOrdererDDD.SeviceBooksOrderer.Domain.SeviceBooksOrderer.Model;
using System.Collections.Generic;

namespace ServiceBooksOrdererDDD.SeviceBooksOrderer.Service.Service.Interface
{
    public interface IBooksOrderer
    {
        // <summary>Método que deve ser implementado com lógica de ordenação de livros.
        // Parâmetro BookList: recebe uma lista de livros
        // Parâmetro order: recebe o número da ordenação(1 = ascendente, 2 = descrescente)
        // Desenvolvido por: Fernando A. Vargas
        // Data: 18/04/2019
        // Solicitantes: MGN / FGV
        // Versão: 1.2       
        // </summary> 
        List<BookModel> BooksOrderer(List<BookModel> BookList, int order); 
    }
}
