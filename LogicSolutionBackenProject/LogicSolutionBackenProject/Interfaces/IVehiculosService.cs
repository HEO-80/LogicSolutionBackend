using LogicSolutionBackenProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicSolutionBackenProject.Interfaces
{
    public interface IVehiculosService
    {

        //Users
        Task<List<VehiculoDto>> GetAllAsync();

        //Task<VehiculoDto> GetUserByIdAsync(string id);
        //Task<ApplicationUserDto> GetUserByEmailAsync(string Email);


        //Task<VehiculoDto> CreateAsync(VehiculoDto vehiculo, string password);
        //Task<VehiculoDto> CreateUserAsync(VehiculoDto vehiculo, string password);

        //Task<VehiculoDto> UpdateUserAsync(VehiculoDto vehiculo);
        //Task<VehiculoDto> UpdateUserNamedAsync(VehiculoDto vehiculo);


    }
}
