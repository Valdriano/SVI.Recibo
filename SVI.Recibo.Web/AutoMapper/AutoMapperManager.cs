using AutoMapper;
using SVI.Recibo.Web.Models;
using SVI.Recibo.Web.ViewModels;
using System;

namespace SVI.Recibo.Web.AutoMapper
{
    public class AutoMapperManager
    {
        private static readonly Lazy<AutoMapperManager> _instance = new Lazy<AutoMapperManager>( () =>
        {
            return new AutoMapperManager();
        }
        );

        public static AutoMapperManager Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private MapperConfiguration _config;

        public IMapper Mapper
        {
            get
            {
                return _config.CreateMapper();
            }
        }

        private AutoMapperManager()
        {
            _config = new MapperConfiguration( ( cfg ) =>
            {
                cfg.CreateMap<Configuracao, ConfiguracaoViewModel>();
                cfg.CreateMap<ConfiguracaoViewModel, Configuracao>();

                cfg.CreateMap<Estado, EstadoViewModel>();
                cfg.CreateMap<EstadoViewModel, Estado>();

                cfg.CreateMap<Fornecedor, FornecedorViewModel>();
                cfg.CreateMap<FornecedorViewModel, Fornecedor>();

                cfg.CreateMap<Municipio, MunicipioViewModel>();
                cfg.CreateMap<MunicipioViewModel, Municipio>();

                cfg.CreateMap<Models.Recibo, ReciboViewModel>();
                cfg.CreateMap<ReciboViewModel, Models.Recibo>();
            }
            );
        }
    }
}