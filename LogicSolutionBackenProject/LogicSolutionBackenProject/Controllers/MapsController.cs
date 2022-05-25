using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LogicSolutionBackenProject.Models;
using LogicSolutions.Data;

namespace LogicSolutionBackenProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MapsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Maps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Map>>> Getmaps()
        {
            return await _context.maps.ToListAsync();
        }

        // GET: api/Maps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Map>> GetMap(int id)
        {
            var map = await _context.maps.FindAsync(id);

            if (map == null)
            {
                return NotFound();
            }

            return map;
        }

        // PUT: api/Maps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMap(int id, Map map)
        {
            if (id != map.Id)
            {
                return BadRequest();
            }

            _context.Entry(map).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapExists(id))
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

        // POST: api/Maps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Map>> PostMap(Map map)
        {

            try
            {
                _context.maps.Add(map);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetMap", new { id = map.Id }, map);
            }
            catch (Exception e)
            {
                throw new Exception("{0} Exception caught.", e);
               
            }
          
        }

        // DELETE: api/Maps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMap(int id)
        {
            var map = await _context.maps.FindAsync(id);
            if (map == null)
            {
                return NotFound();
            }

            _context.maps.Remove(map);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MapExists(int id)
        {
            return _context.maps.Any(e => e.Id == id);
        }
    }
}
