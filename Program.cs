using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        ProdutoRepository repository = new ProdutoRepository();

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adicionar produto");
            Console.WriteLine("2 - Remover produto");
            Console.WriteLine("3 - Editar produto");
            Console.WriteLine("4 - Listar produtos");
            Console.WriteLine("0 - Sair");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:

                    Console.WriteLine("Digite o nome do produto:");
                    string nomeProduto = Console.ReadLine();
                    Produto novoProduto = new Produto { Nome = nomeProduto };
                    repository.Adicionar(novoProduto);
                    Console.WriteLine("Produto adicionado com sucesso!");
                    break;
                case 2:

                    Console.WriteLine("Digite o ID do produto a ser removido:");
                    int idRemover = int.Parse(Console.ReadLine());
                    repository.Remover(idRemover);
                    Console.WriteLine("Produto removido com sucesso!");
                    break;
                case 3:

                    Console.WriteLine("Digite o ID do produto a ser editado:");
                    int idEditar = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o novo nome do produto:");
                    string novoNome = Console.ReadLine();
                    repository.Editar(idEditar, novoNome);
                    Console.WriteLine("Produto editado com sucesso!");
                    break;

                case 4:
                    Console.WriteLine("Lista de Produtos:");
                    var produtos = repository.Listar();
                    foreach (var produto in produtos)
                    {
                        Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}");
                    }
                    break;

                case 0:
                    Console.WriteLine("Programa finalizado!");
                    return;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}




