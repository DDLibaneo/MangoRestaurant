using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI.Repository;

public interface IImageRepository : ICrudRepository<ImageDto>
{
    Task<IEnumerable<ImageDto>> GetByName(string name);
}
