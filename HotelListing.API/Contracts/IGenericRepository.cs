using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace HotelListing.API.Contracts
{
    public interface IGenericRepository<T> where T:  class
    {
        Task<IList<T>> GetAllAsync();
        Task<T> GetAsync(int? id);

        Task<T> AddAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task DeleteAsync(int? id);

        Task<bool> Exists(int id);


    }
}
