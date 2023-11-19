using API_Multimedios2023.Data;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Se debe agregar el contexto

builder.Services.AddScoped<Contexto>();

//Se agrega la configuracion del string de conexion
// Obtener la cadena de conexi�n de la configuraci�n
string connectionString = builder.Configuration.GetConnectionString("StringConexion");

// Crear una instancia de ServerVersion con la versi�n adecuada de MySQL
var serverVersion = new MySqlServerVersion(new Version(8, 0, 26));

// Configurar la conexi�n a la base de datos MySQL
builder.Services.AddDbContext<Contexto>(options =>
    options.UseMySql(connectionString, serverVersion));

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

