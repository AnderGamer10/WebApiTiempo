using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTiempo.Models
{
    public class InformacionTiempo
    {
        [Key]
        public string Id { get; set; }
        public string Municipio { get; set; }
        public string Region { get; set; }
        public string Ultima_hora { get; set; }
        public string Temperatura { get; set; }
        public string Humedad { get; set; }
        public string Velocidad_Viento { get; set; }
        public string Precipitacion_Acumulada { get; set; }
        public string GpxX { get; set; }
        public string GpxY { get; set; }
    }
}
