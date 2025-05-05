using Doctor.Application.Interfaces.Repositories;
using Doctor.Domain.Entities;
using Doctor.Persistence.DAL;


namespace Doctor.Persistence.Implementations.Repositories
{
    internal class SlideRepository:Repository<Slides>,ISlideRepository
    {
        public SlideRepository(AppDbContext context):base(context) { }
      
    }
}
