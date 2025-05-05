
using AutoMapper;
using Doctor.Application.Dtos.Slide;
using Doctor.Domain.Entities;

namespace Doctor.Application.MappingProfile
{
    internal class SlideMapping:Profile
    {
        public SlideMapping()
        {
            CreateMap<Slides, SlideItemDto>();
            CreateMap<Slides, GetSlideDto>();
            CreateMap<CreateSlideDto, Slides>();
            CreateMap<UpdateSlideDto, Slides>();
        }
    }
}
