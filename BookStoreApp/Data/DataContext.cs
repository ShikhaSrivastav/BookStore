global using Microsoft.EntityFrameworkCore;
namespace BookStoreApp.Data.DataContext;

public class DataContext:DbContext{

    public DbSet<User> Users {get; set;}
    public DbSet<Book> Books {get; set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        // string conString=@"("server=localhost;database=BookStoreApp;user=root;password=Shikha@3001")";  
        optionsBuilder.UseSqlServer("server=localhost;database=BookStoreApp;user=root;password=Shikha@3001");
    }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(entity => 
            {
                 entity.Property(e => e.ID);
            entity.Property(e => e.Email).IsRequired();
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.Password).IsRequired();

            });
             modelBuilder.Entity<Book>(entity => 
            {
            entity.Property(e => e.ID);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.Author).IsRequired();
            entity.Property(e => e.YOR).IsRequired();

            });
            // modelBuilder.Entity<User>().ToTable("users");

        }


}