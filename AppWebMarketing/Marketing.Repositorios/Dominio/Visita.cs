using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing.Repositorios.Dominio
{
    public class Visita: Entidad
    {
        public DateTime Fecha { get; set; }
        public String Observacion { get; set; }
        public virtual Stand Stand { get; set; }

        public virtual IList<FotoVisita> Fotografias { get; set; }
        public virtual IList<Comentario> Comentarios { get; set; }

    }
}
