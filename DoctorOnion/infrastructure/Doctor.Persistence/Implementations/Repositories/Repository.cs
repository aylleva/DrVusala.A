using Doctor.Application.Interfaces.Repositories.Abstract;
using Doctor.Domain.Entities;
using Doctor.Persistence.DAL;
using Microsoft.EntityFrameworkCore;

namespace Doctor.Persistence.Implementations.Repositories
{
    internal class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _table;
        public Repository(AppDbContext context)
        {
           _context = context;
            _table=context.Set<T>();
        }

        public IQueryable<T> GetAllAsync()
        {
            IQueryable<T> query = _table;
            return query;
        }

        public async Task<T> GetByIdAsync(int Id)
        {
            IQueryable<T> query = _table;

           return await query.FirstOrDefaultAsync(q=>q.Id==Id);
        }
        public async Task AddAsync(T entity)
        {
            await _table.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _table.Remove(entity);
        }

        public void UpdateAsync(T entity)
        {
            _table.Update(entity);
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
