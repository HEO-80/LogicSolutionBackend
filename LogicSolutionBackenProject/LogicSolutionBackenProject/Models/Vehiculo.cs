using LogicSolutionBackenProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LogicSolutions.Models
{
    public class Vehiculo
    {

        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Img { get; set; }

        public string Comentario { get; set; }

        public string Tipo { get; set; }
    
        public DateTime? FechaRegistro { get; set; }

        public int Itv { get; set; }

        public string Carga { get; set; }

        public string Docs { get; set; }

        public double KmRecorridos { get; set; }

        public int? FlotaId { get; set; }

        [JsonIgnore]
        public Flota flota { get; set; }

        public int? MapId { get; set; }
        public Map map { get; set; }

    }
}
