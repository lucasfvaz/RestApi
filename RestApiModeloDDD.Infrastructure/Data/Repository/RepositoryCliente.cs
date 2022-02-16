using RestApiModeloDDD.Domain.Core.Intefaces.Repositorys;
using RestApiModeloDDD.Domain.Entitys;


namespace RestApiModeloDDD.Infrastructure.Data.Repository
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext sqlContext;
        public RepositoryCliente(SqlContext sqlContext)
        : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
