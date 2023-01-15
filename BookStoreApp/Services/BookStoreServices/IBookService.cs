namespace BookStoreApp.Services.BookServices;

public interface IBookService{
    List<Book> GetAllBooks();
    Book? GetBook(int id);
    List<Book> AddBook(Book book);
    Book? UpdateBook(Book book);
    Book DeleteBook(int id);
}