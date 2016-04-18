using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketing.Repositorios.Dominio;

namespace Marketing.Repositorios.DDD
{
    public class ClienteRepositorio : GenericRepository<EFMarketingRepository, Cliente>
    {
        public ClienteRepositorio(EFMarketingRepository context) : base(context)
        {

        }
    }
}
