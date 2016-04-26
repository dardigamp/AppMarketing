using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SistemaMarketing.Models
{
    public class GrabaCampanaViewModel
    {
        public String Nombre { get; set; }
        [Required]
        public String Descripcion { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaFin { get; set; }
        [Required]
        public string Estado { get; set; }
    }
}