using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Interior_decorating_company_models;

namespace Interior_decorating_company.DAL.Controllers

{
    [ApiController]
    [Route("/Designproject")]
    public class DesignprojectController : ControllerBase
    {
        ApplicationContext db;
        public DesignprojectController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Designproject>>> Get()
        {
            return await db.Designprojects.ToListAsync();
        }


        [HttpGet("GetDesignproject/id={id}")]
        public async Task<ActionResult<LinkedList<Designproject>>> Get(int Id)
        {
            Designproject designproject = await db.Designprojects.FirstOrDefaultAsync(x => x.Design_project_Id == Id);
            if (designproject == null)
                return NotFound();
            return new ObjectResult(designproject);
        }

        
        [HttpPost("PostDesignproject")]
        public async Task<ActionResult<Designproject>> Post(Designproject designproject)
        {
            if (designproject == null)
            {
                return BadRequest();
            }

            db.Designprojects.Add(designproject);
            await db.SaveChangesAsync();
            return Ok(designproject);
        }

        // PUT api/users/
        [HttpPut]
        public async Task<ActionResult<Designproject>> Put(Designproject designproject)
        {
            if (designproject == null)
            {
                return BadRequest();
            }
            if (!db.Designprojects.Any(x => x.Design_project_Id == designproject.Design_project_Id))
            {
                return NotFound();
            }

            db.Update(designproject);
            await db.SaveChangesAsync();
            return Ok(designproject);
        }

        // DELETE api/users/5
        [HttpDelete("{Id}")]
        public async Task<ActionResult<Designproject>> Delete(int Id)
        {
            Designproject designproject = db.Designprojects.FirstOrDefault(x => x.Design_project_Id == Id);
            if (designproject == null)
            {
                return NotFound();
            }
            db.Designprojects.Remove(designproject);
            await db.SaveChangesAsync();
            return Ok(designproject);
        }
    }
}
