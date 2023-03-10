using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BookStoreApp.Services.BookServices;


using BookStoreApp.Models;
namespace BookStoreApp.Controllers;
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService  _UserService;

    public UserController(IUserService UserService)
    {
        _UserService = UserService;
    }
    [HttpPost]
    [Route("[action]")]
    public ActionResult<User> RegisterUser(User user){
       var result=_UserService.RegisterUser(user);
        return Ok(result);
    }
    [HttpPost]
    [Route("[action]")]
    public ActionResult<bool> Login(User user){
        var result=_UserService.Login(user);
        return Ok(result);
    }

}

