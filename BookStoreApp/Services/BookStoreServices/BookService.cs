namespace BookStoreApp.Services.BookServices;

public interface BookService{
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
           
    
    public ActionResult<List<Book>> GetAllBooks()
    {
        return Ok(books);
    }
        public ActionResult<Book>? GetBook(int id)
    {
        var book = books.Find(x => x.ID == id);
        if(book is null){
            return null;
        }

        return Ok(book);
    }
   
    public ActionResult<List<Book>> AddBook(Book book){
        books.Add(book);
        return Ok(books);
    }
   
    public ActionResult<Book>? UpdateBook(Book book){
        var newbook = books.Find(x => x.ID == book.ID);
        if(newbook is null){
            return null;
        }
        newbook.Name=book.Name;
        newbook.Author=book.Author;
        newbook.YOR=book.YOR;
        return Ok(newbook);

    }
       
    public ActionResult<Book> DeleteBook(int id){
        var book = books.Find(x => x.ID == id);
        books.Remove(book);
        return Ok(book);    
    }
}