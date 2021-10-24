using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI.Repository;

public interface ICategoryRepository : ICrudRepository<CategoryDto>
{
    Task<IEnumerable<CategoryDto>> GetByName(string name);
}