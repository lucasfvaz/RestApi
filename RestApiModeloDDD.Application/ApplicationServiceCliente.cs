using RestApiModeloDDD.Application.Dto;
using RestApiModeloDDD.Application.Interface;
using RestApiModeloDDD.Application.Interface.Mappers;
using RestApiModeloDDD.Domain.Core.Intefaces.Services;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente serviceCliente;
        private readonly IMapperCliente mapperCliente;

        public void Add(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Add(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientes = serviceCliente.GetAll();
            return mapperCliente.MapperListClienteDto(clientes);
        }

        public ClienteDto GetById(int id)
        {
            var cliente = serviceCliente.GetById(id);
            return mapperCliente.MapperEntityToDto(cliente);
        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Remove(cliente);
        }

        public void Udate(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Update(cliente);
        }
    }
}
