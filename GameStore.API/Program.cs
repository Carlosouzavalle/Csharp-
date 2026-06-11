using GameStore.API.Models;

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

var app = builder.Build();

app.UseCors("Frontend");


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


var games = new List<Game>
{
    new Game
    {
        Id = 1,
        Title = "Hollow Knight",
        Genre = "Metroidvania",
        Price = 46.90m
    },

    new Game
    {
        Id = 2,
        Title = "Celeste",
        Genre = "Platformer",
        Price = 39.90m
    }
};


// GET
app.MapGet("/games", () =>
{
    return games;
});


// POST 
// vai enviar mais não salva, para salvar tem que adicionar a lista
app.MapPost("/games", (Game game) =>
{
    games.Add(game);

    return Results.Created($"/games/{game.Id}", game);
});


app.MapGet("/games/{id}", (int id) =>
{
   var game = games.FirstOrDefault(g => g.Id == id); 
    if (game is null)
    {
        return Results.NotFound("Sorry, game not found.");
    }
    return Results.Ok(game);
});



//PUT
app.MapPut("/games/{id}", (int id, Game updateGame) =>
{
    var game = games.FirstOrDefault(g => g.Id == id);
    
    if (game is null)
    {
        return Results.NotFound("Sorry, but i cant find this game.");
    }

    game.Id = updateGame.Id;
    game.Title = updateGame.Title;
    game.Genre = updateGame.Genre;
    game.Price = updateGame.Price;

    return Results.Ok(game);
});


// DELETE 
app.MapDelete("/games/{id}", (int id) =>
{
    var game = games.FirstOrDefault(g => g.Id == id);

    if (game is null)
    {
        return Results.NotFound("Sorry, but i cant find this game.");
    }
    games.Remove(game);
    return Results.NoContent();
});


// PATCH
app.MapPatch("/games/{id}", (int id, Game updateGame) =>
{
    var game = games.FirstOrDefault(g => g.Id == id);

    if(game is null)
    {
        return Results.NotFound("Sorry, but i cant find this game.");
    }

    if (!string.IsNullOrEmpty(updateGame.Title))
    {
        game.Title = updateGame.Title;
    }

    if (!string.IsNullOrEmpty(updateGame.Genre))
    {
        game.Genre = updateGame.Genre;
    }

    if (updateGame.Price != 0)
    {
        game.Price = updateGame.Price;
    }

    return Results.Ok(game);
});




app.Run();