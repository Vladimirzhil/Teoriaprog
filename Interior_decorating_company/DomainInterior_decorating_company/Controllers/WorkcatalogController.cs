
using Interior_decorating_company_models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Nodes;



namespace Domain.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/Domain/Workcatalog")]
    public class WorkcatalogsController : ControllerBase
    {
        private readonly string? _dalUrl;
        private readonly HttpClient _client;

        public WorkcatalogsController(IConfiguration conf)
        {
            _dalUrl = conf.GetValue<string>("DalUrl");
            _client = new HttpClient();
        }
        [HttpGet("GetWorkcatalogByName")]
        public async Task<ActionResult<Workcatalog[]>> GetWorkcatalogs(string? name)
        {
            var response = await _client.GetAsync($"{_dalUrl}/Workcatalog?name={name}");
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<Workcatalog[]>() ?? Array.Empty<Workcatalog>();
            if (string.IsNullOrWhiteSpace(name)) return result;
            return Array.FindAll(result, p => !string.IsNullOrWhiteSpace(p.Name) && p.Name.Contains(name));
        }
    }
}