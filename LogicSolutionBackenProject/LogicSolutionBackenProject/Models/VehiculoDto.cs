using System;

namespace LogicSolutionBackenProject.Models
{
    public class VehiculoDto
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Tipo { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int Itv { get; set; }

        public string Carga { get; set; }

        public string [] flota { get; set; }

    }
}
