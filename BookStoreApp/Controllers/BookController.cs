using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using BookStoreApp.Models;
namespace BookStoreApp.Controllers;
[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{


    private readonly ILogger<BookController> _logger;

    public BookController(ILogger<BookController> logger)
    {
        _logger = logger;
    }

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
    public static List<User> users=new List<User>{
        new User{
            Email="shikha@123",
            Name="Shikha",
            Password="abc"
        },
        new User{
            Email="shruti@123",
            Name="Shruti",
            Password="xyz"

        }
    };
    [HttpGet(Name = "GetBook")]
    public ActionResult<List<Book>> GetAllBooks()
    {
        return Ok(books);
    }
    [HttpGet]
    [Route("{id}")]
    public ActionResult<Book> GetAllBooks(int id)
    {
        var book = books.Find(x => x.ID == id);
        if(book==null){
            return NotFound("Sorry book does not exist");
        }

        return Ok(book);
    }
    [HttpPost]
    [Route("[action]")]
    public ActionResult<List<Book>> AddBook(Book book){
        books.Add(book);
        return Ok(books);
    }
    [HttpPut]
    [Route("[action]")]
    public ActionResult<Book> UpdateBook(Book book){
        var newbook = books.Find(x => x.ID == book.ID);
        if(newbook==null){
            return NotFound("Book not found to update");
        }
        newbook.Name=book.Name;
        newbook.Author=book.Author;
        newbook.YOR=book.YOR;
        return Ok(newbook);

    }
    [HttpDelete]
    [Route("[action]/{id}")]
    public ActionResult<Book> DeleteBook(int id){
        var book = books.Find(x => x.ID == id);
        books.Remove(book);
        return Ok(book);    
    }
    [HttpPost]
    public ActionResult<User> RegisterUser(User user){
        
    }
}
