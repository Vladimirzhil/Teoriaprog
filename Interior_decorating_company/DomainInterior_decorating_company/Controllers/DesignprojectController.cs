
using Interior_decorating_company_models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Nodes;



namespace Domain.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/Domain/Designproject")]
    public class DesignprojectsController : ControllerBase
    {
        private readonly string? _dalUrl;
        private readonly HttpClient _client;

        public DesignprojectsController(IConfiguration conf)
        {
            _dalUrl = conf.GetValue<string>("DalUrl");
            _client = new HttpClient();
        }
        [HttpGet("GetDesignprojectByName")]
        public async Task<ActionResult<Designproject[]>> GetDesignprojects(string? name)
        {
            var response = await _client.GetAsync($"{_dalUrl}/Designproject?name={name}");
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<Designproject[]>() ?? Array.Empty<Designproject>();
            if (string.IsNullOrWhiteSpace(name)) return result;
            return Array.FindAll(result, p => !string.IsNullOrWhiteSpace(p.Design_project_name) && p.Design_project_name.Contains(name));
        }
    }
}