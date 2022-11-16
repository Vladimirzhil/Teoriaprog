using Lab3v2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab3v2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly TypeofworkContext _сontext;


        public MainController(TypeofworkContext сontext)
        {
            _сontext = сontext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Typeofwork>>> GetTypeofworks()
        {
            if (_сontext.Typeofworks == null)
            {
                return NotFound();
            }
            return await _сontext.Typeofworks.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Typeofwork>> GetTypeofwork(int id)
        {
            if (_сontext.Typeofworks == null)
            {
                return NotFound();
            }
            var typeofwork = await _сontext.Typeofworks.FindAsync(id);
            if (typeofwork == null)
            {
                return NotFound();
            }

            return typeofwork;
        }
        [HttpPost]
        public async Task<ActionResult<Typeofwork>> PostTypeofwork(Typeofwork typeofwork)
        {
            _сontext.Typeofworks.Add(typeofwork);
            await _сontext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTypeofwork), new { id = typeofwork.Id }, typeofwork);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeofwork(int id, Typeofwork typeofwork)
        {
            if (id != typeofwork.Id)
            {
                return BadRequest();
            }
            _сontext.Entry(typeofwork).State = EntityState.Modified;
            try
            {
                await _сontext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeofworkExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeofwork(int id)
        {
            if (_сontext.Typeofworks == null)
            {
                return NotFound();
            }
            var typeofwork = await _сontext.Typeofworks.FindAsync(id);
            if ( typeofwork == null)
            {
                return NotFound();
            }

            _сontext.Typeofworks.Remove(typeofwork);
            await _сontext.SaveChangesAsync();

            return NoContent();
        }
        private bool TypeofworkExists(long id)
        {
            return (_сontext.Typeofworks?.Any(e => e.Id == id)).GetValueOrDefault();
        }

    }
}
