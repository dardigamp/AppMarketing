using System;

namespace Marketing.Repositorios.Dominio
{
    public class FotoStand: Entidad
    {
        public String Ruta { get; set; }
        public virtual Stand Stand { get; set; }

    }
}