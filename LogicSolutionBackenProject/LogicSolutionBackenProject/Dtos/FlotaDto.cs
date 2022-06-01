using LogicSolutions.Models;
using System.Collections.Generic;

namespace LogicSolutionBackenProject.Dtos
{
    public class FlotaDto : Flota
    {
        public int CantidadVehiculos { get; set; }

        public List<Vehiculo> Vehiculos { get; set; }

    }
}
