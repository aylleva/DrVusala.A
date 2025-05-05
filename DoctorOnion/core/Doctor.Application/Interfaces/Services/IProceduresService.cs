
using Doctor.Application.Dtos.Procedure;


namespace Doctor.Application.Interfaces.Services
{
    public interface IProceduresService
    {
        Task<IEnumerable<ProcedureItemDto>> GetAllAsync();
        Task<GetProcedureDto> GetByIdAsync(int Id);
        Task CreateAsync(CreateProcedureDto proDto);
        Task UpdateAsync(int Id, UpdateProcedureDto proDto);
        Task DeleteAsync(int Id);
    }
}
