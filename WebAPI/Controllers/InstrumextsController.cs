using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models.Entits;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumextsController : ControllerBase
    {
        private readonly DataContext _context;

        public InstrumextsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Instrumexts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Instrumexts>>> GetInstrumexts()
        {
            return await _context.Instrumexts.ToListAsync();
        }

        // GET: api/Instrumexts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Instrumexts>> GetInstrumexts(int id)
        {
            var instrumexts = await _context.Instrumexts.FindAsync(id);

            if (instrumexts == null)
            {
                return NotFound();
            }

            return instrumexts;
        }

        // PUT: api/Instrumexts/5
        [HttpPut("{id}")]
        public async Task<bool> PutInstrumexts(int id, Instrumexts instrumexts)
        {
            if (id != instrumexts.Id)
            {
                return false;
            }

            _context.Entry(instrumexts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstrumextsExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }

            return true;
        }

        // POST: api/Instrumexts
        [HttpPost]
        public async Task<bool> PostInstrumexts(Instrumexts instrumexts)
        {
            _context.Instrumexts.Add(instrumexts);
            await _context.SaveChangesAsync();

            return true;
        }

        // DELETE: api/Instrumexts/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteInstrumexts(int id)
        {
            var instrumexts = await _context.Instrumexts.FindAsync(id);
            if (instrumexts == null)
            {
                return false;
            }

            _context.Instrumexts.Remove(instrumexts);
            await _context.SaveChangesAsync();

            return true;
        }

        private bool InstrumextsExists(int id)
        {
            return _context.Instrumexts.Any(e => e.Id == id);
        }
    }
}
