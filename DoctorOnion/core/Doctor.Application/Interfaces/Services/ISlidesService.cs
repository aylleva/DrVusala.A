using Doctor.Application.Dtos.Slide;


namespace Doctor.Application.Interfaces.Services
{
    public interface ISlidesService
    {
        Task<IEnumerable<SlideItemDto>> GetAllAsync();
        Task<GetSlideDto> GetByIdAsync(int Id);
        Task CreateAsync(CreateSlideDto slideDto);
        Task UpdateAsync(int Id,UpdateSlideDto slideDto);
        Task DeleteAsync(int Id);
    }
}
