using System;
namespace Marketing.Repositorios.Dominio
{
    public class Ubicacion: Entidad
    {
        public String Nombre { get; set; }

        public String Fotografia { get; set; }
        public virtual Stand Stand { get; set; }
    }
}