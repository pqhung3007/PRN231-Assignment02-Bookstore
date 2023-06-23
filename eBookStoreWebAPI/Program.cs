using BusinessObject;
using BusinessObject.DTO;
using DataAccess.DAO;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

static IEdmModel GetEdmModel()
{
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Author>("Authors");
    builder.EntitySet<Book>("Books");
    builder.EntitySet<Publisher>("Publishers");
    builder.EntitySet<User>("Users");

    return builder.GetEdmModel();
}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddOData(options =>
{
    options.Select().Filter().Count().OrderBy().Expand().SetMaxTop(100);

    options.EnableQueryFeatures();
    var routeOptions = options.AddRouteComponents("odata", GetEdmModel()).RouteOptions;

    routeOptions.EnableQualifiedOperationCall = true;
    routeOptions.EnableKeyInParenthesis = false;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplication();

builder.Services.AddScoped<IAuthorDAO, AuthorDAO>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();

builder.Services.AddScoped<IPublisherDAO, PublisherDAO>();
builder.Services.AddScoped<IPublisherRepository, PublisherRepository>();

builder.Services.AddScoped<IBookDAO, BookDAO>();
builder.Services.AddScoped<IBookRepository, BookRepository>();

builder.Services.AddScoped<IUserDAO, UserDAO>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddDbContext<BookStoreDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BookStoreDb")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseODataBatching();
app.UseRouting();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
