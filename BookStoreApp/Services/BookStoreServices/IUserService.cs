namespace BookStoreApp.Services.BookServices;

public interface IUserService{
    User RegisterUser(User user);
    bool Login(User user);
}