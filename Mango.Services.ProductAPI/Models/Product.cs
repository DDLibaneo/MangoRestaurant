using System.ComponentModel.DataAnnotations;

namespace Mango.Services.ProductAPI.Models;

public class Product
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Range(1, 1000)]
    public double Price { get; set; }

    public string Description { get; set; }

    public Category Category { get; set; }

    [Required]
    public Guid CategoryId { get; set; }
}
