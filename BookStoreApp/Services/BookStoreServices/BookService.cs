namespace BookStoreApp.Services.BookServices;

public class BookService:IBookService{
    public static List<Book> books = new List<Book> {new Book
        {
            ID=2,
            Name="Harry Potter",
            Author="JK Rowling",
           YOR="1998"},
        new Book
        {
            ID=3,
            Name="Harry Potter",
            Author="JK Rowling",
           YOR="1998"}
           };
           
    
    public List<Book> GetAllBooks()
    {
        return books;
    }
        public Book? GetBook(int id)
    {
        var book = books.Find(x => x.ID == id);
        if(book is null){
            return null;
        }

        return book;
    }
   
    public List<Book> AddBook(Book book){
        books.Add(book);
        return books;
    }
   
    public Book? UpdateBook(Book book){
        var newbook = books.Find(x => x.ID == book.ID);
        if(newbook is null){
            return null;
        }
        newbook.Name=book.Name;
        newbook.Author=book.Author;
        newbook.YOR=book.YOR;
        return newbook;

    }
       
    public Book DeleteBook(int id){
        var book = books.Find(x => x.ID == id);
        books.Remove(book);
        return book;    
    }
}