using Dotnet.Mongo;
using MongoDB.Driver;
using Sample.Models;

var builder = WebApplication.CreateBuilder(args);
var Configuration = builder.Configuration;

MongodbConfig mongodbConfig = Configuration.GetMongodbConfig();
builder.Services.AddSingleton(mongodbConfig);

var app = builder.Build();

IMongoCollection<Blog?> _blog = MongodbCollectionService.GetCollection<Blog?>(Configuration);

app.MapGet("/", () => {
    return _blog.Find(b => true).ToList();
});

app.MapPost("/blogs", async (Blog blog) => {
    await _blog.InsertOneAsync(blog);
    return Results.Ok(blog);
});

app.Run();
