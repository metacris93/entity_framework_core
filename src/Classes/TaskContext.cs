using entity_framework.src.Models;
using Microsoft.EntityFrameworkCore;

namespace entity_framework.src.Classes;
public class TaskContext : DbContext
{
  public DbSet<Category> Categories {get;set;}
  public DbSet<Task_> Tasks {get;set;}

  public TaskContext(DbContextOptions<TaskContext> options) : base(options){}
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    List<Category> categoryInit = new List<Category>();
    categoryInit.Add(new Category() { 
      Id = Guid.Parse("879fde45-be65-46b0-8822-5f367041b717"),
      Name = "Actividades pendientes",
      Level = 20
    });
    categoryInit.Add(new Category() { 
      Id = Guid.Parse("879fde45-be65-46b0-8822-5f367041b710"),
      Name = "Actividades personales",
      Level = 10
    });

    modelBuilder.Entity<Category>(category =>
    {
      category.ToTable("Category");
      category.HasKey(p => p.Id);
      category.Property(p => p.Name).IsRequired().HasMaxLength(150);
      category.Property(p => p.Description).IsRequired(false);
      category.Property(p => p.Level);
      category.HasData(categoryInit);
    });

    List<Task_> taskInit = new List<Task_>();
    taskInit.Add(new Task_() {
      Id = Guid.Parse("879fde45-be65-46b0-8822-5f367041b711"),
      CategoryId = Guid.Parse("879fde45-be65-46b0-8822-5f367041b717"),
      TaskPriority = Priority.Medium,
      Title = "Pago de servicios publicos",
      CreatedAt = DateTime.Now
    });
    taskInit.Add(new Task_() {
      Id = Guid.Parse("879fde45-be65-46b0-8822-5f367041b709"),
      CategoryId = Guid.Parse("879fde45-be65-46b0-8822-5f367041b710"),
      TaskPriority = Priority.Low,
      Title = "Ver pelicula en Netflix",
      CreatedAt = DateTime.Now
    });

    modelBuilder.Entity<Task_>(task => 
    {
      task.ToTable("Task");
      task.HasKey(p => p.Id);
      task.HasOne(p => p.Category).WithMany(p => p.Tasks).HasForeignKey(p => p.CategoryId);
      task.Property(p => p.Title).IsRequired().HasMaxLength(150);
      task.Property(p => p.Description).IsRequired(false);
      task.Property(p => p.TaskPriority);
      task.Property(p => p.CreatedAt);
      task.Ignore(p => p.Resume);
      task.HasData(taskInit);
    });
  }
}