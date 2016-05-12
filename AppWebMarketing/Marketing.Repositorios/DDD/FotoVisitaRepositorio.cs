using Marketing.Repositorios.Dominio;

namespace Marketing.Repositorios.DDD
{
    public class FotoVisitaRepositorio : GenericRepository<EFMarketingRepository, FotoVisita>
    {
        public FotoVisitaRepositorio(EFMarketingRepository context) : base(context)
        {

        }
    }
}
