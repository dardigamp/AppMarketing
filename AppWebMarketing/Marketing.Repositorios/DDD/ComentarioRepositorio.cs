using Marketing.Repositorios.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing.Repositorios.DDD
{
    public class ComentarioRepositorio : GenericRepository<EFMarketingRepository, Comentario>        
    {
        public ComentarioRepositorio(EFMarketingRepository context) : base(context)
        {

        }
    }
}
