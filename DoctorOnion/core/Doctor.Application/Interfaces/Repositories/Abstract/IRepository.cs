using Doctor.Domain.Entities;


namespace Doctor.Application.Interfaces.Repositories.Abstract
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
         IQueryable<T> GetAllAsync();
         Task<T> GetByIdAsync(int Id);
         Task AddAsync(T entity);
         void UpdateAsync(T entity);
         void Delete(T entity);
         Task<int> SaveChangesAsync(); 
    }
}
