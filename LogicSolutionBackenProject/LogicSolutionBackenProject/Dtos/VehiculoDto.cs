using LogicSolutionBackenProject.Dtos;
using LogicSolutions.Models;
using System;
using System.Collections.Generic;

namespace LogicSolutionBackenProject.Models
{
    public class VehiculoDto 
    { 

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Img { get; set; }
        
        public string Comentario { get; set; }

        public string Tipo { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public int Itv { get; set; }

        public string Carga { get; set; }

        public string Docs { get; set; }
        
        public int  Kmrecorridos { get; set; }

        //public int [] Flotas { get; set; }
        public int? FlotaId { get; set; }

        public List<MapDto> Maps { get; set; }

        public int? mapId { get; set; }


    }
}
