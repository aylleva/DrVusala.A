using Doctor.Application.Dtos.Procedure;

namespace DoctorMVC.ViewModels
{
    public class ProcedureVm
    {
        public IEnumerable<ProcedureItemDto>? ProcedureItems { get; set; }
    }
}
