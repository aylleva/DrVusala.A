using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor.Application.Dtos.Slide
{
   public record GetSlideDto(string Image, string Title, string Description, bool IsMain);
    
}
