using System.ComponentModel.DataAnnotations;

namespace Mango.Services.ProductAPI.Models;

/// <summary>
/// Association model between models Image and Product.
/// </summary>
public class ProductImage
{
    [Key]
    public Guid Id { get; set; }

    public Product Product { get; set; }

    [Required]
    public Guid ProductId { get; set; }

    public Image Image { get; set; }

    [Required]
    public Guid ImageId { get; set; }
}
