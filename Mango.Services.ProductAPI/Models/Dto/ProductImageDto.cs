namespace Mango.Services.ProductAPI.Models.Dto;

public class ProductImageDto
{
    public Guid Id { get; set; }

    public ProductDto Product { get; set; }

    public Guid ProductId { get; set; }

    public ImageDto Image { get; set; }
    
    public Guid ImageId { get; set; }
}
