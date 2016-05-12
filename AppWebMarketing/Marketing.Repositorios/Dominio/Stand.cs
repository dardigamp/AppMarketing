using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing.Repositorios.Dominio
{
    public class Stand : Entidad
    {
        public String Descripcion { get; set; }
        public String Tamano  { get; set; }
        public String Plano { get; set; }
        public virtual IList<FotoStand> Fotografias { get; set; }
        public virtual IList<Ubicacion> Ubicaciones { get; set; }

        public virtual IList<Visita> Visitas { get; set; }
    }
}
