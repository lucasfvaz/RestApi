using RestApiModeloDDD.Application.Dto;
using RestApiModeloDDD.Application.Interface.Mappers;
using RestApiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Application.Mappers
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome,
                Valor = produtoDto.Valor
            };
            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };
            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutoDto(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(c => new ProdutoDto { Id = c.Id, Nome = c.Nome, Valor = c.Valor });
            return dto;
        }

        public void listar(Produto produto)
        {
            List<Produto> produtos = new List<Produto>();
            foreach (var p in produtos)
            {
                Console.WriteLine("Produto: " + p);
            }
        }

        public static void adicionar(ProdutoDto produto)
        {
            var produtoDTO = new ProdutoDto()
            {

            };
        }


    }
}
