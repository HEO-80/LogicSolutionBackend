using LogicSolutionBackenProject.Dtos;
using LogicSolutions.Data;
using LogicSolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicSolutionBackenProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlotasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FlotasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Flotas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flota>>> Getflotas()
        {
            var flotas = await _context.flotas.ToListAsync();

            var flotasDto = new List<FlotaDto>();

            foreach (var flota in flotas)
            {

                var vehiculos=await _context.vehiculos.Where(v => v.flota.Id == flota.Id).ToListAsync();
                var flotaDto = new FlotaDto
                {
                    Id = flota.Id,
                    NombreFlota = flota.NombreFlota,
                    TipoDeCarga = flota.TipoDeCarga,
                    Vehiculos = vehiculos,
                    CantidadVehiculos = vehiculos.Count()
                };

                flotasDto.Add(flotaDto);
            }

            return flotasDto;
        }

        // GET: api/Flotas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Flota>> GetFlota(string id)
        {
            var flota = await _context.flotas.FindAsync(id);

            if (flota == null)
            {
                return NotFound();
            }

            return flota;
        }

        // PUT: api/Flotas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlota(int id, Flota flota)
        {
            if (id != flota.Id)
            {
                return BadRequest();
            }

            _context.Entry(flota).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlotaExists(id))
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

        // POST: api/Flotas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Flota>> PostFlota(Flota flota)
        {
            _context.flotas.Add(flota);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FlotaExists(flota.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFlota", new { id = flota.Id }, flota);
        }

        // DELETE: api/Flotas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlota(int id)
        {
            var flota = await _context.flotas.FindAsync(id);

            if (flota == null)
            {
                return NotFound();
            }

            _context.flotas.Remove(flota);
            await _context.SaveChangesAsync();

            return Ok(flota);
        }

        private bool FlotaExists(int id)
        {
            return _context.flotas.Any(e => e.Id == id);


        }
    }
}
