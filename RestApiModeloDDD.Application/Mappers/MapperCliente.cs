using RestApiModeloDDD.Application.Dto;
using RestApiModeloDDD.Application.Interface.Mappers;
using RestApiModeloDDD.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Application.Mappers
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                Id = clienteDto.Id,
                Nome = clienteDto.Nome,
                SobreNome = clienteDto.SobreNome,
                Email = clienteDto.Email
            };

            return cliente;

        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            var clienteDto = new ClienteDto()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                SobreNome = cliente.SobreNome,
                Email = cliente.Email
            };
            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperListClienteDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(c => new ClienteDto { Id = c.Id, Nome = c.Nome, SobreNome = c.SobreNome, Email = c.Email });
            return dto;

        }
    }
}
