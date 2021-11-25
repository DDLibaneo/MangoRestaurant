using AutoMapper;
using Mango.Services.ProductAPI.DbContexts;
using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.Dto;
using Mango.Services.ProductAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Mango.Services.ProductAPI.Repository;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public ProductRepository(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProductDto>> GetAll()
    {
        var products = await _db.Products.ToListAsync();
        
        return _mapper.Map<List<ProductDto>>(products);
    }

    public async Task<ProductDto> Get(Guid id)
    {
        var product = await _db.Products.FirstOrDefaultAsync(p => p.Id == id);
        
        return _mapper.Map<ProductDto>(product);
    }

    public async Task<IEnumerable<ProductDto>> GetByName(string name)
    {
        var products = await _db.Products.Where(p => p.Name.Contains(name))
            .ToListAsync();

        return _mapper.Map<List<ProductDto>>(products);
    }

    public async Task<ProductDto> Create(ProductDto dto)
    {
        var product = _mapper.Map<Product>(dto);

        _db.Products.Add(product);
        await _db.SaveChangesAsync();

        return _mapper.Map<ProductDto>(product);
    }

    public async Task<ProductDto> Update(ProductDto dto)
    {
        if (dto.Id == Guid.Empty)
            throw new ArgumentException("The Id is Required.");
        
        var product = await _db.Products.SingleOrDefaultAsync(p => p.Id == dto.Id);

        if (product == null)
            throw new Exception($@"Product of Id '{dto.Id}' not found.");

        _db.Products.Update(product);
        await _db.SaveChangesAsync();

        return _mapper.Map<ProductDto>(product);
    }

    public async Task<bool> Delete(Guid id)
    {
        try
        {
            var product = await _db.Products.FirstOrDefaultAsync(u => u.Id == id);

            if (product == null)
                return false;    
            
            _db.Products.Remove(product);
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
