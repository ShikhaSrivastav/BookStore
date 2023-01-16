global using BookStoreApp.Models;
using BookStoreApp.Services.BookServices;
using BookStoreApp.Data.DataContext;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBookService,BookService>();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddDbContext<DataContext>();
// builder.Services.AddDbContext<DataContextBook>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
