using AutoMapper;
using Mango.Services.ProductAPI.DbContexts;
using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.Dto;
using Mango.Services.ProductAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

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

    public async Task<IEnumerable<ImageDto>> GetAll()
    {
        var images = await _db.Images.ToListAsync();

        return _mapper.Map<List<ImageDto>>(images);
    }

    public async Task<ImageDto> Get(Guid id)
    {
        var images = await _db.Images
            .FirstOrDefaultAsync(i => i.Id == id);

        return _mapper.Map<ImageDto>(images);
    }

    public async Task<IEnumerable<ImageDto>> GetByName(string name)
    {
        var images = await _db.Images
            .Where(i => i.Name.Contains(name))
            .ToListAsync();

        return _mapper.Map<List<ImageDto>>(images);
    }

    public async Task<ImageDto> Create(ImageDto dto)
    {
        var image = _mapper.Map<Image>(dto);

        _db.Images.Add(image);
        await _db.SaveChangesAsync();

        return _mapper.Map<ImageDto>(image);
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
