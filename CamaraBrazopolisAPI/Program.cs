using CamaraBrazopolisAPI.Data;
using CamaraBrazopolisAPI.Middleware;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Configurar conex�o com o banco
var connectionString = builder.Configuration.GetConnectionString("Camara");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

//Add Mapper para mapear as classes DTO para as classes modelo
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin() // Permitir qualquer origem (não recomendado para produção)
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();
app.UseMiddleware<ExceptionMiddleware>();
app.UseCors();

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
