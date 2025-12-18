// ==================================================
// 3. BLL - ProdutosBLL.cs
// ==================================================
using System.Collections.Generic;
using GVC.MODEL;
using GVC.DAL;

namespace GVC.BLL
{
    public class ProdutosBLL
    {
        private readonly ProdutoDALL _dal = new ProdutoDALL();

        public List<ProdutosModel> ListarTodos() => _dal.ListarTodos();

        public ProdutosModel? BuscarPorId(long id) => _dal.BuscarPorId(id);

        public long Inserir(ProdutosModel produto)
        {
            // Validações básicas de negócio (você pode expandir)
            if (string.IsNullOrWhiteSpace(produto.NomeProduto))
                throw new Exception("Nome do produto é obrigatório.");

            if (produto.PrecoCusto < 0)
                throw new Exception("Preço de custo não pode ser negativo.");

            if (produto.PrecoDeVenda < 0)
                throw new Exception("Preço de venda não pode ser negativo.");

            return _dal.Inserir(produto);
        }

        public bool Alterar(ProdutosModel produto)
        {
            if (produto.ProdutoID <= 0)
                throw new Exception("ID do produto inválido.");

            return _dal.Alterar(produto);
        }

        public bool Excluir(long id)
        {
            if (id <= 0)
                throw new Exception("ID inválido.");

            return _dal.Excluir(id);
        }
    }
}