using RestApiModeloDDD.Application.Dto;
using RestApiModeloDDD.Application.Interface;
using RestApiModeloDDD.Application.Interface.Mappers;
using RestApiModeloDDD.Domain.Core.Intefaces.Services;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto serviceProduto;
        private readonly IMapperProduto maperProduto;
        public void Add(ProdutoDto produtoDto)
        {
            var produto = maperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = serviceProduto.GetAll();
            return maperProduto.MapperListProdutoDto(produtos);
        }

        public ProdutoDto GetById(int id)
        {
            var produtos = serviceProduto.GetById(id);
            return maperProduto.MapperEntityToDto(produtos);
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produtos = maperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Remove(produtos);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produtos = maperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Update(produtos);
        }
    }
}
