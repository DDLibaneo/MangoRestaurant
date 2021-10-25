using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI.Repository.Interfaces;

public interface ICategoryRepository : ICrudRepository<CategoryDto>
{
    Task<IEnumerable<CategoryDto>> GetByName(string name);
}