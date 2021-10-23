using System.ComponentModel.DataAnnotations;

namespace Mango.Services.ProductAPI.Models;

public class Image
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string ImageUrl { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
}
