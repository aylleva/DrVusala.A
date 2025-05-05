
using AutoMapper;
using Doctor.Application.Dtos.Slide;
using Doctor.Application.Interfaces.Repositories;
using Doctor.Application.Interfaces.Services;
using Doctor.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Doctor.Persistence.Implementations.Services
{
    internal class SlideService : ISlidesService
    {
        private readonly ISlideRepository repository;
        private readonly IMapper mapper;

        public SlideService(ISlideRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<SlideItemDto>> GetAllAsync()
        {
          var slides=await repository.GetAllAsync().ToListAsync();
            return mapper.Map<IEnumerable<SlideItemDto>>(slides);
        }

        public async Task<GetSlideDto> GetByIdAsync(int Id)
        {
           var slide=await repository.GetByIdAsync(Id);
            if (slide == null) throw new Exception("Slide was not found");
            return mapper.Map<GetSlideDto>(slide);
        }
      
        public async Task CreateAsync(CreateSlideDto slideDto)
        {
            await repository.AddAsync(mapper.Map<Slides>(slideDto));
            await repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            var slide = await repository.GetByIdAsync(Id);
            if (slide == null) throw new Exception("Slide was not found");

             repository.Delete(slide);
            await repository.SaveChangesAsync();
        }
        public async Task UpdateAsync(int Id, UpdateSlideDto slideDto)
        {
            var slide = await repository.GetByIdAsync(Id);
            if (slide == null) throw new Exception("Slide was not found");

             repository.UpdateAsync(mapper.Map(slideDto,slide));
            await repository.SaveChangesAsync();
        }
    }
}
