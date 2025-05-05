using Doctor.Application.Dtos.Procedure;
using Doctor.Application.Dtos.Slide;
using Doctor.Domain.Entities;

namespace DoctorMVC.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<ProcedureItemDto> Procedures { get; set; } 
        public IEnumerable<SlideItemDto> Slides { get; set; }
    }
}
