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
    public class TypeMusicLocalsController : ControllerBase
    {
        private readonly DataContext _context;

        public TypeMusicLocalsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/TypeMusicLocals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeMusicLocal>>> GetTypeMusicLocals()
        {
            return await _context.TypeMusicLocals.ToListAsync();
        }

        // GET: api/TypeMusicLocals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeMusicLocal>> GetTypeMusicLocal(int id)
        {
            var typeMusicLocal = await _context.TypeMusicLocals.FindAsync(id);

            if (typeMusicLocal == null)
            {
                return NotFound();
            }

            return typeMusicLocal;
        }

        // PUT: api/TypeMusicLocals/5
        [HttpPut("{id}")]
        public async Task<bool> PutTypeMusicLocal(int id, TypeMusicLocal typeMusicLocal)
        {
            if (id != typeMusicLocal.Id)
            {
                return false;
            }

            _context.Entry(typeMusicLocal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeMusicLocalExists(id))
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

        // POST: api/TypeMusicLocals
        [HttpPost]
        public async Task<bool> PostTypeMusicLocal(TypeMusicLocal typeMusicLocal)
        {
            _context.TypeMusicLocals.Add(typeMusicLocal);
            await _context.SaveChangesAsync();

            return true;
        }

        // DELETE: api/TypeMusicLocals/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteTypeMusicLocal(int id)
        {
            var typeMusicLocal = await _context.TypeMusicLocals.FindAsync(id);
            if (typeMusicLocal == null)
            {
                return false;
            }

            _context.TypeMusicLocals.Remove(typeMusicLocal);
            await _context.SaveChangesAsync();

            return true;
        }

        private bool TypeMusicLocalExists(int id)
        {
            return _context.TypeMusicLocals.Any(e => e.Id == id);
        }
    }
}
