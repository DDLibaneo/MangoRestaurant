using Mango.Services.ProductAPI.Models.Dto;
using Mango.Services.ProductAPI.Repository.Interfaces;

namespace Mango.Services.ProductAPI.Repository;

public class ImageRepository : IImageRepository
{

    public Task<IEnumerable<ImageDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<ImageDto> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ImageDto>> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public Task<ImageDto> Create(ImageDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<ImageDto> Update(ImageDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}
