using RestApiModeloDDD.Application.Dto;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interface
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDto produtoDto);
        void Update(ProdutoDto produtoDto);
        void Remove(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> GetAll();
        ProdutoDto GetById(int id);

    }
}
