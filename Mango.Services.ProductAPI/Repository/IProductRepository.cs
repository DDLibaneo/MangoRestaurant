using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI.Repository;

public interface IProductRepository
{
    Task<IEnumerable<ProductDto>> GetAll();

    Task<IEnumerable<ProductDto>> GetByName(string name);

    Task<ProductDto> GetById(Guid id);

    Task<ProductDto> Create(ProductDto productDto);

    Task<ProductDto> Update(ProductDto productDto);

    Task<bool> Delete(Guid id);
}