using System.Text.Json.Serialization;
using entity_framework.src.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
// builder.Services.AddDbContext<TaskContext>(p => p.UseInMemoryDatabase("TasksDB"));
builder.Services.AddDbContext<TaskContext>(p => p.UseNpgsql(connectionString));

var app = builder.Build();
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconnection", ([FromServices] TaskContext dbContext) => 
{
  //nos asegura que la base de datos este creada, si no esta creada la crea
  dbContext.Database.EnsureCreated();
  return Results.Ok("Base de datos en memoria: " + dbContext.Database.IsInMemory());
});

app.MapGet("/api/tasks", ([FromServices] TaskContext dbContext) => 
{
  return Results.Ok(dbContext.Tasks);
});

app.MapGet("/api/tasks/priority/{level}", ([FromServices] TaskContext dbContext, int level) => 
{
  return Results.Ok(
    dbContext.Tasks
      .Include(a => a.Category)
      .Where(a => (int)a.TaskPriority == level)
  );
});

app.Run();
