using AutoMapper;
using LogicSolutionBackenProject.Dtos;
using LogicSolutionBackenProject.Models;
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
                    Img = v.Img,
                    Docs = v.Docs,
                    Kmrecorridos = v.KmRecorridos,
                    Comentario = v.Comentario,
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
        public async Task<ActionResult<VehiculoDto>> GetVehiculo(int id)
        {
            var vehiculo = await _context.vehiculos.FindAsync(id);


            if (vehiculo == null)
            {
                return NotFound();
            }

            var vehiculoDto = new VehiculoDto
            {
                Id = vehiculo.Id,
                Nombre = vehiculo.Nombre,
                Tipo = vehiculo.Tipo,
                FechaRegistro = vehiculo.FechaRegistro,
                Itv = vehiculo.Itv,
                Carga = vehiculo.Carga,
                FlotaId = vehiculo.FlotaId,
                Img = vehiculo.Img,
                Comentario = vehiculo.Comentario,
                Docs = vehiculo.Docs,
                Kmrecorridos = vehiculo.KmRecorridos,
                Maps = _context.maps
                                .Where(m => m.VehiculoId == vehiculo.Id)
                                .Select(m => new MapDto
                                {
                                    Id = m.Id,
                                    Name = m.Name,
                                    Lat = m.Lat,
                                    Long = m.Long,
                                    VehiculoId = m.VehiculoId
                                })
                                .ToList()
            };




            return vehiculoDto;
        }

        // PUT: api/Vehiculos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<VehiculoDto> PutVehiculo(VehiculoDto vehiculoDto)
        {


            var vehiculoDb = await _context.vehiculos.FirstOrDefaultAsync(f => f.Id == vehiculoDto.Id);


            if (vehiculoDb == null) throw new Exception($"UserId [{vehiculoDto.Id}] does not exist.");


            if (!string.IsNullOrEmpty(vehiculoDto.Nombre) && !string.IsNullOrWhiteSpace(vehiculoDto.Nombre))
            {
                if (vehiculoDb.Nombre != vehiculoDto.Nombre)
                {
                    vehiculoDb.Nombre = vehiculoDto.Nombre;
                }
            }

            if (!string.IsNullOrEmpty(vehiculoDto.Img) && !string.IsNullOrWhiteSpace(vehiculoDto.Img))
            {
                if (vehiculoDb.Img != vehiculoDto.Img)
                {
                    vehiculoDb.Img = vehiculoDto.Img;
                }
            }

            if (!string.IsNullOrEmpty(vehiculoDto.Tipo) && !string.IsNullOrWhiteSpace(vehiculoDto.Tipo))
            {
                if (vehiculoDb.Tipo != vehiculoDto.Tipo)
                {
                    vehiculoDb.Tipo = vehiculoDto.Tipo;
                }
            }

            if (!string.IsNullOrEmpty(vehiculoDto.Carga) && !string.IsNullOrWhiteSpace(vehiculoDto.Carga))
            {
                if (vehiculoDb.Carga != vehiculoDto.Carga)
                {
                    vehiculoDb.Carga = vehiculoDto.Carga;
                }
            }

            if (!string.IsNullOrEmpty(vehiculoDto.Comentario) && !string.IsNullOrWhiteSpace(vehiculoDto.Comentario))
            {
                if (vehiculoDb.Comentario != vehiculoDto.Comentario)
                {
                    vehiculoDb.Comentario = vehiculoDto.Comentario;
                }
            }
            if (!string.IsNullOrEmpty(vehiculoDto.Docs) && !string.IsNullOrWhiteSpace(vehiculoDto.Docs))
            {
                if (vehiculoDb.Docs != vehiculoDto.Docs)
                {
                    vehiculoDb.Docs = vehiculoDto.Docs;
                }
            }

            if (vehiculoDto.Kmrecorridos.Equals(false))
            {
                if (vehiculoDb.KmRecorridos != vehiculoDto.Kmrecorridos)
                {
                    vehiculoDb.KmRecorridos = vehiculoDto.Kmrecorridos;
                }
            }

            if (vehiculoDto.FlotaId.HasValue)
            {
                if (vehiculoDb.FlotaId != vehiculoDto.FlotaId)
                {
                    vehiculoDb.FlotaId = vehiculoDto.FlotaId;
                }
            }

            if (vehiculoDto.mapId.HasValue)
            {
                if (vehiculoDb.MapId != vehiculoDto.mapId)
                {
                    vehiculoDb.MapId = vehiculoDto.mapId;
                }
            }

            //var flotas = await _context.flotas.ToListAsync();

            var config2 = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Vehiculo, VehiculoDto>();
            });


            var mapper2 = config2.CreateMapper();
            var vehiculoUpdated = mapper2.Map<VehiculoDto>(vehiculoDb);

            //3. try 
            try
            {

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(@"idRole not found or wrong");

            }

            return vehiculoUpdated;
        }
        //    if (id != vehiculo.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(vehiculo).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!VehiculoExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

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
                Img = vehiculo.Img,
                Comentario = vehiculo.Comentario,
                MapId = vehiculo.mapId,
                Docs = vehiculo.Docs,
                KmRecorridos = vehiculo.Kmrecorridos

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
