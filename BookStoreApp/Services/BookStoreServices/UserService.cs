namespace BookStoreApp.Services.BookServices;

public interface UserService{
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
    
    public ActionResult<User> RegisterUser(User user){
        users.Add(user);
        Console.WriteLine("User Registered");
        return Ok(user);
    }
 
    public ActionResult<bool> Login(User user){
        if(users.Contains(user)){
            Console.WriteLine("Logged in successfully");
            return true;
        }
        return false;
    }
    
}