using Mango.Services.ProductAPI.Models.Dto;
using System;

namespace Mango.Services.ProductAPI.Repository;

public interface ICrudRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll();

    Task<T> GetById(Guid id);

    Task<T> Create(T dto);

    Task<T> Update(T dto);

    Task<bool> Delete(Guid id);
}
