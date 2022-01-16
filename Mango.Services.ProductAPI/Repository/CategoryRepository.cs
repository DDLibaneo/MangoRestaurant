using AutoMapper;
using Mango.Services.ProductAPI.DbContexts;
using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.Dto;
using Mango.Services.ProductAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

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
            var category = await _db.Categories.FirstOrDefaultAsync(c => c.Id == id);

            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<IEnumerable<CategoryDto>> GetByName(string name)
        {
            var categories = await _db.Categories.Where(c => c.Name.Contains(name))
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

        public Task<CategoryDto> Update(CategoryDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
