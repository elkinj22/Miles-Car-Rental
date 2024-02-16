using Miles_Car_Rental.Interfaces;
using Miles_Car_Rental.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Agregamos la inyección de dependencias para Vehiculo
builder.Services.AddSingleton<Ivehiculo, VehiculoService>();
builder.Services.AddSingleton<Ireserva, ReservaService>();
builder.Services.AddSingleton<Iconsultas,ConsultasService>();

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
