// global using Microsoft.EntityFrameworkCore;
// namespace BookStoreApp.Data.DataContext;
// public class DataContextBook:DbContext{

//     public DbSet<Book> Books {get; set;}

//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
//         base.OnConfiguring(optionsBuilder);

//         string conString=@"Server=.\\SQLExpress;Database=BookStore;Trusted_Connection=true;TrustServerCertificate=true;)";       
//         optionsBuilder.UseSqlServer(conString);
//     }

//         protected override void OnModelCreating(ModelBuilder modelBuilder)
//         {
//             base.OnModelCreating(modelBuilder);
//             modelBuilder.Entity<Book>(entity => 
//             {
//             entity.Property(e => e.ID);
//             entity.Property(e => e.Name).IsRequired();
//             entity.Property(e => e.Author).IsRequired();
//             entity.Property(e => e.YOR).IsRequired();

//             });
//             modelBuilder.Entity<Book>().ToTable("books");

//         }


// }