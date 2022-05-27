using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LogicSolutions.Models
{
    public class Flota
    {

        public int Id { get; set; }

        public string NombreFlota { get; set; }

        public string TipoDeCarga { get; set; }

        public int CantidadVehiculos { get; set; }

        [NotMapped]
        public List<Vehiculo>  Vehiculos { get; set; }


    }


}
