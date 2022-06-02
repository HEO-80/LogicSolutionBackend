using AutoMapper;
using LogicSolutionBackenProject.Dtos;
using LogicSolutions.Data;
using LogicSolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
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

                var vehiculos = await _context.vehiculos.Where(v => v.flota.Id == flota.Id).ToListAsync();
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
        public async Task<ActionResult<FlotaDto>> GetFlota(int id)
        {
            var flota = await _context.flotas.FindAsync(id);

            var vehiculos = await _context.vehiculos.Where(v => v.flota.Id == flota.Id).ToListAsync();

            var flotaDto = new FlotaDto
            {
                Id = flota.Id,
                NombreFlota = flota.NombreFlota,
                TipoDeCarga = flota.TipoDeCarga,
                CantidadVehiculos = vehiculos.Count(),
                Vehiculos = vehiculos
            };

            if (flota == null)
            {
                return NotFound();
            }

            return flotaDto;
        }

        // PUT: api/Flotas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<FlotaDto> PutFlota(FlotaDto flotaDto)
        {

            var flotaDb = await _context.flotas.FirstOrDefaultAsync(f => f.Id == flotaDto.Id);


            if (flotaDb == null) throw new Exception($"UserId [{flotaDto.Id}] does not exist.");


            if (!string.IsNullOrEmpty(flotaDto.NombreFlota) && !string.IsNullOrWhiteSpace(flotaDto.NombreFlota))
            {
                if (flotaDb.NombreFlota != flotaDto.NombreFlota)
                {
                    flotaDb.NombreFlota = flotaDto.NombreFlota;
                }
            }

            if (!string.IsNullOrEmpty(flotaDto.TipoDeCarga) && !string.IsNullOrWhiteSpace(flotaDto.TipoDeCarga))
            {
                if (flotaDb.TipoDeCarga != flotaDto.TipoDeCarga)
                {
                    flotaDb.TipoDeCarga = flotaDto.TipoDeCarga;
                }
            }

            //var flotas = await _context.flotas.ToListAsync();

            var config2 = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Flota, FlotaDto>();
            });


            var mapper2 = config2.CreateMapper();
            var flotaUpdated = mapper2.Map<FlotaDto>(flotaDb);

            //3. try GetUserId
            try
            {
                //var appflota = flotas.FirstOrDefault(u => u.Id == flotaDb.Id);
                //var uflotas = await _context.flotas.AddAsync(FlotaDto);
                await _context.SaveChangesAsync();
                //flotaO.Vehiculos = uflotas.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception(@"idRole not found or wrong");

            }

            return flotaUpdated;
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
