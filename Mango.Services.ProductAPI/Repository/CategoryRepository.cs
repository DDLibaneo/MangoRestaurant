using Mango.Services.ProductAPI.Models.Dto;
using Mango.Services.ProductAPI.Repository.Interfaces;

namespace Mango.Services.ProductAPI.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task<IEnumerable<CategoryDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> Create(CategoryDto dto)
        {
            throw new NotImplementedException();
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
