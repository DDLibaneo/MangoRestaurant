using System.ComponentModel.DataAnnotations;

namespace Mango.Services.ProductAPI.Models;

public class Category
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string Description { get; set; }
}
