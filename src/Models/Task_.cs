using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity_framework.src.Models;

[Table("Task")]
public class Task_
{
  [Key]
  public Guid Id { get; set; }

  [ForeignKey("Category")]
  public Guid CategoryId { get; set; }

  [Required]
  [MaxLength(150)]
  public string Title { get; set; }
  public string Description { get; set; }
  public Priority TaskPriority { get; set; }
  public DateTime Created_at { get; set; }
  public virtual Category Category { get; set; }
  [NotMapped]
  public string Resume { get; set; }
}
public enum Priority
{
  Low,
  Medium,
  High
}