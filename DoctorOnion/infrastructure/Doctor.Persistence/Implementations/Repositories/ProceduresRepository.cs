using Doctor.Application.Interfaces.Repositories;
using Doctor.Domain.Entities;
using Doctor.Persistence.DAL;


namespace Doctor.Persistence.Implementations.Repositories
{
    internal class ProceduresRepository:Repository<Procedures>,IProceduresRepository
    {
        public ProceduresRepository(AppDbContext context):base(context) { }
       
    }
}
