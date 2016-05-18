using AutoMapper;
using Marketing.Repositorios.DDD;
using Marketing.Repositorios.Dominio;
using Marketing.Servicios.Clientes.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing.Servicios.Clientes
{
    public class ServicioClientes
    {
        private IMarketingRepository _contexto;

        public ServicioClientes()
        {
            _contexto = new EFMarketingRepository();
        }

        public IList<ClienteDto> Buscar(string Busqueda)
        {
            var clientes = _contexto.ClienteRepository.GetAll(); //repositorioCliente.Traer();
            if (!string.IsNullOrEmpty(Busqueda)) clientes = clientes.Where(x => x.RazonSocial.Contains(Busqueda));

            return Mapper.Map<IList<Cliente>, IList<ClienteDto>>(clientes.ToList());
        }
    }
}
