using Mango.Services.ProductAPI.Models.Dto;
using System;

namespace Mango.Services.ProductAPI.Repository.Interfaces;

public interface ICrudRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll();

    Task<T> Get(Guid id);

    Task<T> Create(T dto);

    Task<T> Put(T dto);

    Task<bool> Delete(Guid id);
}
