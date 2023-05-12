﻿
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

        [HttpGet]
        public async Task<ActionResult<Workcatalog[]>> GetWorkcatalogs()
        {
            var response = await _client.GetAsync($"{_dalUrl}/Workcatalog");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            if (content == null) return NotFound();

            return JsonSerializer.Deserialize<Workcatalog[]>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? Array.Empty<Workcatalog>();
        }
    }
}