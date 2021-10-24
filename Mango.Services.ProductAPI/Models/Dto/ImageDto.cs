namespace Mango.Services.ProductAPI.Models.Dto;

public class ImageDto : IDto
{
    public Guid Id { get; set; }

    public string? ImageUrl { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }
}
