using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing.Repositorios.Dominio
{
    public class Campana : Entidad
    {        
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public char Estado { get; set; }
        public virtual IList<Campana> Campanas { get; set; }
    }
}
