using System.IO.Pipelines;
using System.Runtime.InteropServices;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddCors();

var app = builder.Build();
// This will serve files in the wwwroot folder as static files, such as index.html
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader()
);


// i use this to make a test
app.MapGet("/", () => "API OK");


// Upload de Mangas
app.MapPost("/upload/{manga}/{capitulo}", async (string manga, string capitulo, HttpRequest request) =>
{
    if (request.Form.Files.Count == 0)
        return Results.BadRequest("Nenhum arquivo enviado");

    var file = request.Form.Files[0];

    var pasta = Path.Combine("wwwroot", "mangas", manga, capitulo);

    Directory.CreateDirectory(pasta);

    var filePath = Path.Combine(pasta, file.FileName);

    using var stream = new FileStream(filePath, FileMode.Create);

    await file.CopyToAsync(stream);

    return Results.Ok("Upload feito");
});


// app.MapGet("/mangas", () =>
// {
//     return new[] { "naruto", "boruto" };
// });


//Listagem de captilos
app.MapGet("/manga/{manga}/{capitulo}", (string manga, string capitulo) =>
{
    var pasta = Path.Combine("wwwroot", "mangas", manga, capitulo);

    if (!Directory.Exists(pasta))
        return Results.NotFound("Capítulo não encontrado");

    var arquivos = Directory.GetFiles(pasta)
        .Select(f => $"/mangas/{manga}/{capitulo}/{Path.GetFileName(f)}")
        .ToList();

    return Results.Ok(arquivos);
});


// listar os mangas disponiveis
app.MapGet("/mangas", () =>
{
    var pasta = Path.Combine("wwwroot", "mangas");
    
    if(!Directory.Exists(pasta))
        return Results.NotFound("Nenhum manga encontrado");

    var mangas = Directory.GetDirectories(pasta)
        .Select(dir => Path.GetFileName(dir))
        .ToList();

    return Results.Ok(mangas);
});


app.Run();