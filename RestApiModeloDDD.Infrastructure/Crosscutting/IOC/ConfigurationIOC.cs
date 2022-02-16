using Autofac;
using RestApiModeloDDD.Application;
using RestApiModeloDDD.Application.Interface.Mappers;
using RestApiModeloDDD.Application.Mappers;
using RestApiModeloDDD.Domain.Core.Intefaces.Repositorys;
using RestApiModeloDDD.Domain.Core.Intefaces.Services;
using RestApiModeloDDD.Domain.Service;
using RestApiModeloDDD.Infrastructure.Data.Repository;

namespace RestApiModeloDDD.Infrastructure.Crosscutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceCliente>().As<ApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<ApplicationServiceProduto>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();


            #endregion
        }
    }
}
