namespace Mango.Services.ProductAPI.Models.Dto;

public class ProductDto
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public double Price { get; set; }

    public string Description { get; set; }

    public Category Category { get; set; }

    public Guid CategoryId { get; set; }
}