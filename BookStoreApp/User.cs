namespace BookStoreApp.Models;

public class User{
    public int ID {get; set;}
    public string Email{get;set;}
    public string Name{get;set;}
    
    public string Password{get;set;}

    public override bool Equals(object obj)
    {
        User u=(User)obj;
        return this.Email.Equals(u.Email) && this.Password.Equals(u.Password);
    }
    // public override string ToString()
    // {
    //     string str= Console.WriteLine("{0},{1}",Email,Name);
    //     return str;
    // }

}