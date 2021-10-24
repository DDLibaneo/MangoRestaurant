namespace Mango.Services.ProductAPI.Models.Dto;

public class ProductImageDto
{
    public Guid Id { get; set; }

    public Product Product { get; set; }

    public Guid ProductId { get; set; }

    public Image Image { get; set; }
    
    public Guid ImageId { get; set; }
}
