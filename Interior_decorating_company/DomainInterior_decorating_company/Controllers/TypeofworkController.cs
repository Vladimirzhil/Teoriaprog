
using Interior_decorating_company_models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Nodes;



namespace Domain.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/Domain/Typeofwork")]
    public class TypeofworksController : ControllerBase
    {
        private readonly string? _dalUrl;
        private readonly HttpClient _client;

        public TypeofworksController(IConfiguration conf)
        {
            _dalUrl = conf.GetValue<string>("DalUrl");
            _client = new HttpClient();
        }

        [HttpGet]
        public async Task<ActionResult<Typeofwork[]>> GetTypeofwroks()
        {
            var response = await _client.GetAsync($"{_dalUrl}/Typeofwork");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            if (content == null) return NotFound();

            return JsonSerializer.Deserialize<Typeofwork[]>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? Array.Empty<Typeofwork>();
        }
        [HttpPost]
        public async Task<ActionResult<Typeofwork>> PostTypeofwork(Typeofwork typeofwork)
        {
            JsonContent content = JsonContent.Create(typeofwork);
            using var result = await _client.PostAsync($"{_dalUrl}/Orderforobject/PostTypeofwork", content);
            var dalTypeofwork = await result.Content.ReadFromJsonAsync<Typeofwork>();
            Console.WriteLine($"{dalTypeofwork?.Order_number_Id}");
            if (dalTypeofwork == null)
                return BadRequest();
            else
                return dalTypeofwork;
        }
    }
}