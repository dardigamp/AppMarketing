using Marketing.Repositorios.Dominio;

namespace Marketing.Repositorios.DDD
{
    public class StandRepositorio : GenericRepository<EFMarketingRepository, Stand>
    {
        public StandRepositorio(EFMarketingRepository context) : base(context)
        {

        }
    }
}
