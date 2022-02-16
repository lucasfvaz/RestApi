using RestApiModeloDDD.Domain.Core.Intefaces.Repositorys;
using RestApiModeloDDD.Domain.Core.Intefaces.Services;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Domain.Service
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }

    }
}
