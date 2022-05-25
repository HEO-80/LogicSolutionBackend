using LogicSolutions.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogicSolutionBackenProject.Models
{
    public class Map
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Lat { get; set; }
        public int Long { get; set; }

        public int VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }


        
    }

}

