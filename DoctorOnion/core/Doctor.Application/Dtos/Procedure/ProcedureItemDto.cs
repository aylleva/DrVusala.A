using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor.Application.Dtos.Procedure
{
   public record ProcedureItemDto(string Name, string About, string Description,string İcon,string Mainİmage,
       string AddImage, string Permanence,bool IsMain);
    
}
