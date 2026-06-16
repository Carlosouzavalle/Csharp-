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
app.MapGet("/games", (GameStoreContext db) =>
{
    return db.Games.ToList();
});


// POST 
app.MapPost("/games", (GameStoreContext db, Game game) =>
{
    db.Games.Add(game);
    db.SaveChanges();

    return Results.Created($"/games/{game.Id}", game);
});


// GET by id
app.MapGet("/games/{id}", (GameStoreContext db, int id) =>
{
   var game = db.Games.FirstOrDefault(g => g.Id == id); 
    if (game is null)
    {
        return Results.NotFound("Sorry, game not found.");
    }
    return Results.Ok(game);
});



//PUT
// O PUT é usado para atualizar um recurso inteiro, ou seja, você precisa enviar todos os campos do jogo, mesmo que não queira atualizá-los. Se um campo não for enviado, ele será definido como o valor padrão (por exemplo, string vazia para strings e 0 para números).
app.MapPut("/games/{id}", (GameStoreContext db, int id, Game updateGame) =>
{
    var game = db.Games.FirstOrDefault(g => g.Id == id);
    
    if (game is null)
    {
        return Results.NotFound("Sorry, but i cant find this game.");
    }

    game.Title = updateGame.Title;
    game.Genre = updateGame.Genre;
    game.Price = updateGame.Price;
    db.SaveChanges();

    return Results.Ok(game);
});


// DELETE 
// Aqui vai remover o jogo do banco de dados, então não precisamos mais da lista de jogos, porque agora estamos usando o banco de dados para armazenar os jogos.
app.MapDelete("/games/{id}", (GameStoreContext db, int id) =>
{
    var game = db.Games.FirstOrDefault(g => g.Id == id);

    if (game is null)
    {
        return Results.NotFound("Sorry, but i cant find this game.");
    }

    // db.Games.Remove(game); // Aqui era para remover o jogo da lista, mas agora vamos remover do banco de dados, então usamos o db.Games.Remove(game) para remover o jogo do banco de dados.
    db.Games.Remove(game);
    db.SaveChanges();
    return Results.NoContent();
});


// PATCH
// O PATCH é usado para atualizar um recurso parcialmente, ou seja, você pode enviar apenas os campos que deseja atualizar. Se um campo não for enviado, ele manterá o valor atual no banco de dados.
app.MapPatch("/games/{id}", (GameStoreContext db, int id, Game updateGame) =>
{
    var game = db.Games.FirstOrDefault(g => g.Id == id);

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


    db.SaveChanges();
    
    return Results.Ok(game);
});




app.Run();