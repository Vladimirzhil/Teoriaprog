using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Interior_decorating_company_models;

namespace Interior_decorating_company.DAL.Controllers

{
    [ApiController]
    [Route("/Client")]
    public class ClientController : ControllerBase
    {
        ApplicationContext db;
        public ClientController (ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> Get()
        {
            return await db.Clients.ToListAsync();
        }


        [HttpGet("GetClient/id={id}")]
        public async Task<ActionResult<LinkedList<Client>>> GetClient(int id)
        {
        Client client = await db.Clients.FirstOrDefaultAsync(x => x.ClientId == id);
            if (client == null)
                return NotFound();
            return new ObjectResult(client);
        }



    [HttpPost]
        public async Task<ActionResult<Client>> Post(Client client)
        {
            if (client == null)
            {
                return BadRequest();
            }

            db.Clients.Add(client);
            await db.SaveChangesAsync();
            return Ok(client);
        }

       
        [HttpPut]
        public async Task<ActionResult<Client>> Put(Client client)
        {
            if (client == null)
            {
                return BadRequest();
            }
            if (!db.Clients.Any(x => x.ClientId == client.ClientId))
            {
                return NotFound();
            }

            db.Update(client);
            await db.SaveChangesAsync();
            return Ok(client);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Client>> Delete(int Id)
        {
            Client client = db.Clients.FirstOrDefault(x => x.ClientId == Id);
            if (client == null)
            {
                return NotFound();
            }
            db.Clients.Remove(client);
            await db.SaveChangesAsync();
            return Ok(client);
        } 
    } 
}
