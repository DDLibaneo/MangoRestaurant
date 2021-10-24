using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI.Repository;

public interface IProductRepository : ICrudRepository<ProductDto>
{
    Task<IEnumerable<ProductDto>> GetByName(string name);
}