using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI.Repository;

public interface ICategoryRepository
{
    Task<IEnumerable<CategoryDto>> GetAll();

    Task<IEnumerable<CategoryDto>> GetByName(string name);

    Task<CategoryDto> GetById(Guid id);

    Task<CategoryDto> Create(CategoryDto category);

    Task<CategoryDto> Update(CategoryDto category);

    Task<bool> Delete(Guid id);
}