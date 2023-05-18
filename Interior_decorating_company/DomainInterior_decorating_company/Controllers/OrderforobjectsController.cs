
using Interior_decorating_company_models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Nodes;



namespace Domain.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/Domain/Orderforobject")]
    public class OrderforobjectsController : ControllerBase
    {
        private readonly string? _dalUrl;
        private readonly HttpClient _client;

        public OrderforobjectsController(IConfiguration conf)
        {
            _dalUrl = conf.GetValue<string>("DalUrl");
            _client = new HttpClient();
        }

        [HttpGet]
        public async Task<ActionResult<Orderforobject[]>> GetOrderforobjects()
        {
            var response = await _client.GetAsync($"{_dalUrl}/Orderforobject");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            if (content == null) return NotFound();

            return JsonSerializer.Deserialize<Orderforobject[]>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? Array.Empty<Orderforobject>();
        }
        [HttpPost]
        public async Task<ActionResult<Orderforobject>> PostOrderforobject(Orderforobject orderforobject)
        {
            JsonContent content = JsonContent.Create(orderforobject);
            using var result = await _client.PostAsync($"{_dalUrl}/Orderforobject/PostOrderforobject", content);
            var dalOrderforobject = await result.Content.ReadFromJsonAsync<Orderforobject>();
            Console.WriteLine($"{dalOrderforobject?.Order_number_Id}");
            if (dalOrderforobject == null)
                return BadRequest();
            else
                return dalOrderforobject;
        }
    }
}