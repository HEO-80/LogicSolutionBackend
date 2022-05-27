using LogicSolutionBackenProject.Interfaces;
using LogicSolutionBackenProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicSolutionBackenProject.Services
{
    public class VehiculosServices : IVehiculosService
    {



        //private readonly IApplicationDbContext _context;
        //private readonly UserManager<ApplicationUser> _userManager;
        //private readonly RoleManager<IdentityRole> _roleManager;

        //public IdentityService(UserManager<ApplicationUser> userManager, IApplicationDbContext context, RoleManager<IdentityRole> roleManager)
        //{
        //    _userManager = userManager;
        //    _context = context;
        //    _roleManager = roleManager;
        //}

        //public async Task<List<VehiculoDto>> GetAllAsync()
        //{
        //var vehiculos = await _userManager.Users.ToListAsync();

        //var config = new MapperConfiguration(cfg =>
        //{
        //    cfg.CreateMap<Vehiculo, VehiculoDto>();
        //});

        //var mapper = config.CreateMapper();
        //var userList = mapper.Map<List<VehiculoDto>>(vehiculos);

        //foreach (var user in userList)
        //{
        //    var applicationUser = vehiculos.FirstOrDefault(u => u.Id == user.Id);
        //    var userRoles = await _userManager.GetRolesAsync(applicationUser);
        //    vehiculo.Roles = userRoles.ToArray();
        //}

        //return userList;
        public Task<List<VehiculoDto>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }


        //public async Task<List<VehiculoDto>> GetVehiculosAllAsync()
        //{
            //var vehiculosAll = await _roleManager.Roles.ToListAsync();

            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Vehiculo, VehiculoDto>();
            //});

            //var mapper = config.CreateMapper();
            //var vehiculosList = mapper.Map<List<VehiculoDto>>(vehiculosAll);

            //return vehiculosList;


            //public async Task<List<VehiculoDto>> GetAllAsync()
            ////Task<List<VehiculoDto>> IVehiculosService.GetAllAsync()
            //{
            //    throw new System.NotImplementedException();
            //}
        }
}
