using AutoMapper;
using Mango.Services.ProductAPI.DbContexts;
using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.Dto;
using Mango.Services.ProductAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Mango.Services.ProductAPI.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public CategoryRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDto>> GetAll()
        {
            var categories = await _db.Categories.ToListAsync();

            return _mapper.Map<List<CategoryDto>>(categories);
        }

        public async Task<CategoryDto> Get(Guid id)
        {
            var category = await _db.Categories
                .FirstOrDefaultAsync(c => c.Id == id);

            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<IEnumerable<CategoryDto>> GetByName(string name)
        {
            var categories = await _db.Categories
                .Where(c => c.Name.Contains(name))
                .ToListAsync();

            return _mapper.Map<List<CategoryDto>>(categories);
        }

        public async Task<CategoryDto> Create(CategoryDto dto)
        {
            var category = _mapper.Map<Category>(dto);

            _db.Categories.Add(category);
            await _db.SaveChangesAsync();

            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<CategoryDto> Put(CategoryDto dto)
        {
            if (dto.Id == Guid.Empty)
                throw new ArgumentException("The Id is Required.");

            var category = await _db.Categories
                .SingleOrDefaultAsync(c => c.Id == dto.Id);

            if (category == null)
                throw new Exception($@"Category Id '{dto.Id}' not found.");

            _db.Categories.Update(category);
            await _db.SaveChangesAsync();

            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<bool> Delete(Guid id)
        {
            try
            {
                var category = await _db.Categories
                    .FirstOrDefaultAsync(c => c.Id == id);

                if (category == null)
                    return false;

                _db.Categories.Remove(category);
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
}
