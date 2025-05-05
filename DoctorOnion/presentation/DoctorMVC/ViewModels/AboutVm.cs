using Doctor.Application.Dtos.Procedure;
using Doctor.Domain.Entities;

namespace DoctorMVC.ViewModels
{
    public class AboutVm
    {
        public IEnumerable<ProcedureItemDto>? ProcedureItems { get; set; }
    }
}
