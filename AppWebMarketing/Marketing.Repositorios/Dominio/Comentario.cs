using System;

namespace Marketing.Repositorios.Dominio
{
    public class Comentario: Entidad
    {
        public DateTime Fecha { get; set; }
        public String Descripcion { get; set; }
        public virtual Visita Visita { get; set; }
    }
}