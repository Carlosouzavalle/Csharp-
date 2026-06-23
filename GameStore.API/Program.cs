using GameStore.API.Models;
using GameStore.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("Frontend",
        policy =>
        {
            policy
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});



builder.Services.AddOpenApi();



builder.Services.AddDbContext<GameStoreContext>(options =>
{
    options.UseSqlite("Data Source=gamestore.db");
});


// var games = new List<Game>
// aqui era a lista de jogos, mas agora vamos usar o banco de dados, então não precisamos mais disso
// GameStoreContext db;

var app = builder.Build();

app.UseCors("Frontend");


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}



// GET
// app.MapGet("/games", (GameStoreContext db) =>
// {
//     return db.Games.ToList();
// });


// POST 
app.MapPost("/games", (GameStoreContext db, Game game) =>
{
    db.Games.Add(game);
    db.SaveChanges();

    return Results.Created($"/games/{game.Id}", game);
});


// GET by id
app.MapGet("/games/search", (GameStoreContext db, string query) =>
{
    Console.WriteLine($"Buscando: {query}");

    var games = db.Games
        .Where(g => g.Title.Contains(query))
        .ToList();

    return Results.Ok(games);
});

app.MapGet("/games/{id:int}", (GameStoreContext db, int id) =>
{
    var game = db.Games.FirstOrDefault(g => g.Id == id);

    if (game is null)
    {
        return Results.NotFound();
    }

    return Results.Ok(game);
});



app.Run();