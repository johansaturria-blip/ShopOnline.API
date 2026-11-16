using Microsoft.EntityFrameworkCore;
using ShopOnline.API.Data;
using Scalar.AspNetCore; // 1. Añade este using arriba

var builder = WebApplication.CreateBuilder(args);

// Configuración de la base de datos SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configurar controladores ignorando ciclos de referencias en JSON
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });

// OpenAPI nativo para .NET 10
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi(); // Reemplaza a AddSwaggerGen

var app = builder.Build();

// Configuración del pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); // Genera el documento OpenAPI en /openapi/v1.json

    // 2. Agrega esta línea para activar la interfaz visual interactiva
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();