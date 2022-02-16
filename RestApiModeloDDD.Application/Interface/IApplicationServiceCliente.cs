using RestApiModeloDDD.Application.Dto;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interface
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDto clienteDto);
        void Udate(ClienteDto clienteDto);
        void Remove(ClienteDto clienteDto);
        IEnumerable<ClienteDto> GetAll();
        ClienteDto GetById(int id);


    }
}
