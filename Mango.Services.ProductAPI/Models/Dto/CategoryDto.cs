namespace Mango.Services.ProductAPI.Models.Dto;

public class CategoryDto : IDto
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }
}
