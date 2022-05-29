using entity_framework.src.Models;
using Microsoft.EntityFrameworkCore;

namespace entity_framework.src.Classes;
public class TaskContext : DbContext
{
  public DbSet<Category> Categories {get;set;}
  public DbSet<Task_> Tasks {get;set;}

  public TaskContext(DbContextOptions<TaskContext> options) : base(options){}
  // protected override void OnModelCreating(ModelBuilder modelBuilder)
  // {

  // }
}