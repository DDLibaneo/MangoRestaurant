using AutoMapper;
using Mango.Services.ProductAPI.DbContexts;
using Mango.Services.ProductAPI.Models.Dto;
using Mango.Services.ProductAPI.Repository.Interfaces;

namespace Mango.Services.ProductAPI.Repository;

public class ImageRepository : IImageRepository
{
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public ImageRepository(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public Task<IEnumerable<ImageDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<ImageDto> Get(Guid id)
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
