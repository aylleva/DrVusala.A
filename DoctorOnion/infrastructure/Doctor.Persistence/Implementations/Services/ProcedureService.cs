using AutoMapper;
using Doctor.Application.Dtos.Procedure;
using Doctor.Application.Interfaces.Repositories;
using Doctor.Application.Interfaces.Services;
using Doctor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor.Persistence.Implementations.Services
{
    internal class ProcedureService : IProceduresService
    {
        private readonly IProceduresRepository repository;
        private readonly IMapper mapper;

        public ProcedureService(IProceduresRepository repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ProcedureItemDto>> GetAllAsync()
        {
            var pros= await repository.GetAllAsync().ToListAsync();
            return mapper.Map<IEnumerable<ProcedureItemDto>>(pros);
        }

        public async Task<GetProcedureDto> GetByIdAsync(int Id)
        {
            var pro=await repository.GetByIdAsync(Id);
            if (pro == null) throw new Exception("Procedure is not found");
            return mapper.Map<GetProcedureDto>(pro);
        }
        public async Task CreateAsync(CreateProcedureDto proDto)
        {
            await repository.AddAsync(mapper.Map<Procedures>(proDto));
            await repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(int Id, UpdateProcedureDto proDto)
        {
            var pro = await repository.GetByIdAsync(Id);
            if (pro == null) throw new Exception("Procedure was not found");

            repository.UpdateAsync(mapper.Map(proDto, pro));
             await repository.SaveChangesAsync();
        }
        public async Task DeleteAsync(int Id)
        {
            var pro = await repository.GetByIdAsync(Id);
            if (pro == null) throw new Exception("Procedure was not found");

            repository.Delete(pro);
            await repository.SaveChangesAsync();
        }

      

      
    }
}
