using AutoMapper;
using Mango.Services.ProductAPI.DbContexts;
using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.Dto;
using Mango.Services.ProductAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

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

    public async Task<ImageDto> Update(ImageDto dto)
    {
        if (dto.Id == Guid.Empty)
            throw new ArgumentException("The Id is Required.");

        var image = await _db.Images
            .SingleOrDefaultAsync(i => i.Id == dto.Id);

        if (image == null)
            throw new Exception($@"Image Id '{dto.Id}' not found.");

        _db.Images.Update(image);
        await _db.SaveChangesAsync();

        return _mapper.Map<ImageDto>(image);
    }

    public async Task<bool> Delete(Guid id)
    {
        try
        {
            var image = await _db.Images
                .FirstOrDefaultAsync(i => i.Id == id);

            if (image == null) 
                return false;

            _db.Images.Remove(image);
            await _db.SaveChangesAsync();

            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            return false;
        }
    }
}
