using Doctor.Application.Dtos.Slide;
using Newtonsoft.Json;

namespace DoctorMVC.Services
{
    public class SlidesGetApiService
    {
        private readonly HttpClient _httpClient;
        public SlidesGetApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("DoctorAPI");
        }
        public async Task<IEnumerable<SlideItemDto>> GetAllSlides()
        {
            var response = await _httpClient.GetAsync("Procedures/GetSlides");

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var datas = JsonConvert.DeserializeObject<IEnumerable<SlideItemDto>>(jsonString);
                return datas;
            }

            return new List<SlideItemDto>();
        }
    }
}
