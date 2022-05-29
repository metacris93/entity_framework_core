using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity_framework.src.Models;

[Table("Category")]
public class Category
{
  [Key]
  public Guid Id {get;set;}

  [Required]
  [MaxLength(150)]
  public string Name {get;set;}

  public string Description {get;set;}

  public virtual ICollection<Task_> Tasks {get;set;}
}