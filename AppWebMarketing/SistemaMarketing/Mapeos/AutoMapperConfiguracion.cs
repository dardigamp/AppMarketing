using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Marketing.Servicios.Campanas.Dtos;
using SistemaMarketing.Models;
using Marketing.Servicios.Clientes.Dtos;
using Marketing.Servicios.Stands.Dtos;

namespace SistemaMarketing.Mapeos
{
    public class AutoMapperConfiguracion
    {
        public static void Configuracion()
        {
            //Mapper.CreateMap<CampanaViewModel, CampanaDto>();
            //Mapper.CreateMap<CampanaDto, CampanaViewModel >().MaxDepth(2);
            Mapper.CreateMap<CampanaDto , CampanaViewModel>();
            Mapper.CreateMap<StandDto, StandViewModel>();
            Mapper.CreateMap<ClienteDto, ClienteViewModel>();
            Mapper.CreateMap<CampanaViewModel, CampanaDto>();
            Mapper.CreateMap<StandViewModel, StandDto>();

        }
    }
}