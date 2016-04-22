using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Marketing.Repositorios.Dominio
{
    public class Campana : Entidad
    {        
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1, MinimumLength = 1)]
        public string Estado { get; set; }
        public virtual IList<Venta> Ventas { get; set; }
    }
}
