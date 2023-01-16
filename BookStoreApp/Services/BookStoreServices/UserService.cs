namespace BookStoreApp.Services.BookServices;

public class UserService:IUserService{
     public static List<User> users=new List<User>{
        new User{
            ID=1,
            Email="shikha@123",
            Name="Shikha",
            Password="abc"
        },
        new User{
            ID=2,
            Email="shruti@123",
            Name="Shruti",
            Password="xyz"

        }
    };
    
    public User RegisterUser(User user){
        users.Add(user);
        Console.WriteLine("User Registered");
        return user;
    }
 
    public bool Login(User user){
        if(users.Contains(user)){
            Console.WriteLine("Logged in successfully");
            return true;
        }
        return false;
    }
    
}