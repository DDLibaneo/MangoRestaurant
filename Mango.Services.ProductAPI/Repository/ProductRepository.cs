using Mango.Services.ProductAPI.Models.Dto;
using Mango.Services.ProductAPI.Repository.Interfaces;

namespace Mango.Services.ProductAPI.Repository;

public class ProductRepository : IProductRepository
{
    public Task<IEnumerable<ProductDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<ProductDto> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductDto>> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDto> Create(ProductDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDto> Update(ProductDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}
