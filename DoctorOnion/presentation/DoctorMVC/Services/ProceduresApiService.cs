using Doctor.Application.Dtos.Procedure;
using Newtonsoft.Json;


namespace DoctorMVC.Services
{
    public class ProceduresApiService
    {
        private readonly HttpClient _httpClient;
        public ProceduresApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("DoctorAPI");
        }
        public async Task<IEnumerable<ProcedureItemDto>> GetAllProcedures()
        {
           
            var response = await _httpClient.GetAsync("Procedures/GetProcedures");

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var datas = JsonConvert.DeserializeObject<IEnumerable<ProcedureItemDto>>(jsonString);
                return datas;
            }

            return new List<ProcedureItemDto>();
        }
    }
}
