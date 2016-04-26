using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Marketing.Servicios.Campanas.Dtos;
using SistemaMarketing.Models;

namespace SistemaMarketing.Mapeos
{
    public class AutoMapperConfiguracion
    {
        public static void Configuracion()
        {
            //Mapper.CreateMap<CampanaViewModel, CampanaDto>();
            //Mapper.CreateMap<CampanaDto, CampanaViewModel >().MaxDepth(2);
            Mapper.CreateMap<CampanaDto , CampanaViewModel>();
            Mapper.CreateMap<CampanaViewModel, CampanaDto>();

        }
    }
}