using System;

namespace Mango.Services.ProductAPI.Repository;

public interface IBasicRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll();

    Task<IEnumerable<T>> GetByName(string name);

    Task<T> GetById(Guid id);

    Task<T> Create(T dto);

    Task<T> Update(T dto);

    Task<bool> Delete(Guid id);
}
