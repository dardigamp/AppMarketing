using System;

namespace Marketing.Repositorios.Dominio
{
    public class FotoVisita: Entidad
    {
        public String Ruta { get; set; }
        public virtual Stand Stand { get; set; }
    }
}