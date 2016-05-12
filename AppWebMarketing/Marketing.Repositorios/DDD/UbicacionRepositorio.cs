using Marketing.Repositorios.Dominio;

namespace Marketing.Repositorios.DDD
{
    public class UbicacionRepositorio : GenericRepository<EFMarketingRepository, Ubicacion>
    {
        public UbicacionRepositorio(EFMarketingRepository context) : base(context)
        {

        }
    }
}
