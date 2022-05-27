using LogicSolutions.Models;
using System.Collections.Generic;

namespace LogicSolutionBackenProject.Dtos
{
    public class FlotaDto : Flota
    {
        public List<Vehiculo> Vehiculos { get; set; }

    }
}
