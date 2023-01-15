using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BookStoreApp.Services.BookServices;


using BookStoreApp.Models;
namespace BookStoreApp.Controllers;
[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{

    private readonly IBookService _BookService;

    public BookController(IBookService BookService)
    {
        _BookService = BookService;
    }

    [HttpGet(Name = "GetBook")]
    public ActionResult<List<Book>> GetAllBooks()
    {
        var result=_BookService.GetAllBooks();
        return Ok(result);
    }
    [HttpGet]
    [Route("{id}")]
    public ActionResult<Book> GetBook(int id)
    {
        var result=_BookService.GetBook(id);
        return Ok(result);
    }
    [HttpPost]
    [Route("[action]")]
    public ActionResult<List<Book>> AddBook(Book book){
       var result=_BookService.AddBook(book);
        return Ok(result);
    }
    [HttpPut]
    [Route("[action]")]
    public ActionResult<Book> UpdateBook(Book book){
        var result = _BookService.UpdateBook(book);
        
        return Ok(result);

    }
    [HttpDelete]
    [Route("[action]/{id}")]
    public ActionResult<Book> DeleteBook(int id){
        var result = _BookService.DeleteBook(id);
        if(result==null){
            return NotFound("Book Not Found");
        }
        return Ok(result);    
    }
}
