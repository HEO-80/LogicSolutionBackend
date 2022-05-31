using AutoMapper;
using LogicSolutionBackenProject.Dtos;
using LogicSolutionBackenProject.Models;
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
    public class VehiculosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VehiculosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Vehiculos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehiculoDto>>> Getvehiculos()

        {
            
            var vehicles = await _context.vehiculos.ToListAsync();

            var vehiclesDto = vehicles
                .Select(v => new VehiculoDto
                {
                    Id = v.Id,
                    Nombre = v.Nombre,
                    Tipo = v.Tipo,
                    FechaRegistro = v.FechaRegistro,
                    Itv = v.Itv,
                    Carga = v.Carga,
                    FlotaId = v.FlotaId,
                    Maps = _context.maps
                                .Where(m => m.VehiculoId == v.Id)
                                .Select(m => new MapDto
                                {
                                    Id = m.Id,
                                    Name = m.Name,
                                    Lat = m.Lat,
                                    Long = m.Long,
                                    VehiculoId = m.VehiculoId
                                })
                                .ToList()
                })
                .ToList();

            return vehiclesDto;

        }

        // GET: api/Vehiculos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vehiculo>> GetVehiculo(int id)
        {
            var vehiculo = await _context.vehiculos.FindAsync(id);

            if (vehiculo == null)
            {
                return NotFound();
            }

            return vehiculo;
        }

        // PUT: api/Vehiculos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehiculo(int id, Vehiculo vehiculo)
        {
            if (id != vehiculo.Id)
            {
                return BadRequest();
            }

            _context.Entry(vehiculo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehiculoExists(id))
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

        // POST: api/Vehiculos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VehiculoDto>> PostVehiculo(VehiculoDto vehiculo)
        {
            var dbvehicle = new Vehiculo

            {
                Nombre = vehiculo.Nombre,
                Tipo = vehiculo.Tipo,
                FechaRegistro = vehiculo.FechaRegistro,
                Itv = vehiculo.Itv,
                Carga = vehiculo.Carga,
                FlotaId = vehiculo.FlotaId,
                MapId = vehiculo.mapId

            };

            await _context.AddAsync(dbvehicle);

            await _context.SaveChangesAsync();

            // By default Id=0, but when all the changes are confirmed .NET changes the Id property to the one assigned by the SQL Server
            //if (dbvehicle.Id!=0 )
            //{
            //    foreach (var flota in vehiculo.Flotas)
            //    {
            //       await _context.AddAsync(dbvehicle);
            //    }
            //}

            //else

            //{
            //    return null;
            //}

            //var generatedVehiculo = await _context.vehiculos.FindAsync(vehiculo.Id);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Vehiculo, VehiculoDto>();
            });

            var mapper = config.CreateMapper();

            return mapper.Map<VehiculoDto>(dbvehicle);

            //_context.vehiculos.Add(vehiculo);

            //await _context.SaveChangesAsync();

            //return CreatedAtAction("GetVehiculo", new { id = vehiculo.Id }, vehiculo);
        }






        // DELETE: api/Vehiculos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehiculo(int id)
        {
            var vehiculo = await _context.vehiculos.FindAsync(id);
            if (vehiculo == null)
            {
                return NotFound();
            }

            _context.vehiculos.Remove(vehiculo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VehiculoExists(int id)
        {
            return _context.vehiculos.Any(e => e.Id == id);
        }
    }
}
