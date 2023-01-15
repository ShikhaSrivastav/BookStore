namespace BookStoreApp.Models;

public class Book{

    public int ID{get;set;}
    public String Name{get;set;}=string.Empty;
    public String Author{get;set;}=string.Empty;
    public string YOR{get;set;}

    // public override string ToString()
    // {
    //     string str= Console.WriteLine("{0},{1},{2}",Name,Author,YOR);
    //     return str;
    // }

}