using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ProdutoRepository
{
    private List<Produto> produtos = new List<Produto>();
    private int proximoId = 1;

    public void Adicionar(Produto produto)
    {
        produto.Id = proximoId;
        produtos.Add(produto);
        proximoId++;
    }

    public void Remover(int id)
    {
        Produto produtoParaRemover = produtos.Find(p => p.Id == id);
        if (produtoParaRemover != null)
        {
            produtos.Remove(produtoParaRemover);
        }
    }

    public void Editar(int id, string novoNome)
    {
        Produto produtoParaEditar = produtos.Find(p => p.Id == id);
        if (produtoParaEditar != null)
        {
            produtoParaEditar.Nome = novoNome;
        }
    }

    public List<Produto> Listar()
    {
        return produtos;
    }
}
