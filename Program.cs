var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (minimal_api.Dominio.DTOs.LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "administrador@teste.com" && loginDTO.Senha == "123456")
    {
        return Results.Ok("Login com sucesso");
    }
    else
    {
        return Results.Unauthorized();
    }
});

app.UseSwagger();
app.UseSwaggerUI();

app.Run();