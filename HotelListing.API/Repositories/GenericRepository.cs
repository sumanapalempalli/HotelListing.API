using AutoMapper;
using AutoMapper.QueryableExtensions;
using HotelListing.API.Contracts;
using HotelListing.API.Data;
using HotelListing.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly HotelListAPIDbContext _context;
        private readonly IMapper _mapper;

        public GenericRepository(HotelListAPIDbContext context,IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int? id)
        {
            var entity=await GetAsync(id);
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity=await GetAsync(id);
            return entity != null;
        }

        public async Task<IList<T>> GetAllAsync()
        {
           return  await _context.Set<T>().ToListAsync();
        }

        public async Task<PagedResult<TResult>> GetAllAsync<TResult>(QueryParameters queryParameters)
        {
            var totalcount=await _context.Set<T>().CountAsync();

            var items=await _context.Set<T>().Skip(queryParameters.StartIndex).
                Take(queryParameters.PageSize)
                .ProjectTo<TResult>(_mapper.ConfigurationProvider).
                ToListAsync();
            return new PagedResult<TResult>
            {
                PageNumber = queryParameters.PageNumber,
                Items = items,
                TotalRecords = totalcount,
                RecordNumber = queryParameters.PageSize
            };
        }

        public async Task<T> GetAsync(int? id)
        {
           if(id is null)
            {
                return null;
            }
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
