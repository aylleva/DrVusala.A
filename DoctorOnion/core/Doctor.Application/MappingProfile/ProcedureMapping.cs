using AutoMapper;
using Doctor.Application.Dtos.Procedure;
using Doctor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor.Application.MappingProfile
{
    public class ProcedureMapping:Profile
    {
        public ProcedureMapping()
        {
            CreateMap<Procedures, ProcedureItemDto>();
            CreateMap<Procedures,GetProcedureDto>();
            CreateMap<CreateProcedureDto, Procedures>();
            CreateMap<UpdateProcedureDto, Procedures>();
        }
    }
}
