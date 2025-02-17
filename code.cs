using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleEstoque
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public Produto(int id, string nome, int quantidade, decimal preco)
        {
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"ID: {Id} | Produto: {Nome} | Quantidade: {Quantidade} | Preço: R$ {Preco:F2}");
        }
    }

    public class Estoque
    {
        private List<Produto> produtos;
        private int proximoId;

        public Estoque()
        {
            produtos = new List<Produto>();
            proximoId = 1;
        }

        // Criar (Adicionar produto)
        public void AdicionarProduto(string nome, int quantidade, decimal preco)
        {
            Produto produto = new Produto(proximoId++, nome, quantidade, preco);
            produtos.Add(produto);
            Console.WriteLine("Produto adicionado com sucesso.");
        }

        // Ler (Exibir todos os produtos)
        public void ExibirEstoque()
        {
            if (produtos.Count == 0)
            {
                Console.WriteLine("Estoque vazio.");
                return;
            }

            Console.WriteLine("\n--- Estoque Atual ---");
            foreach (var produto in produtos)
            {
                produto.ExibirInformacoes();
            }
        }

        // Atualizar (Alterar informações do produto)
        public bool AtualizarProduto(int id, string novoNome, int novaQuantidade, decimal novoPreco)
        {
            Produto produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto != null)
            {
                produto.Nome = novoNome;
                produto.Quantidade = novaQuantidade;
                produto.Preco = novoPreco;
                Console.WriteLine("Produto atualizado com sucesso.");
                return true;
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
                return false;
            }
        }

        // Deletar (Remover produto)
        public bool DeletarProduto(int id)
        {
            Produto produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto != null)
            {
                produtos.Remove(produto);
                Console.WriteLine("Produto removido com sucesso.");
                return true;
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
                return false;
            }
        }

        // Buscar Produto por ID
        public Produto ObterProdutoPorId(int id)
        {
            return produtos.FirstOrDefault(p => p.Id == id);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Estoque estoque = new Estoque();
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("Sistema de Controle de Estoque");
                Console.WriteLine("1 - Adicionar Produto");
                Console.WriteLine("2 - Exibir Estoque");
                Console.WriteLine("3 - Atualizar Produto");
                Console.WriteLine("4 - Deletar Produto");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarProdutoMenu(estoque);
                        break;
                    case 2:
                        estoque.ExibirEstoque();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 3:
                        AtualizarProdutoMenu(estoque);
                        break;
                    case 4:
                        DeletarProdutoMenu(estoque);
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 5);
        }

        static void AdicionarProdutoMenu(Estoque estoque)
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.Write("Digite o preço: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            estoque.AdicionarProduto(nome, quantidade, preco);
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void AtualizarProdutoMenu(Estoque estoque)
        {
            Console.Write("Digite o ID do produto que deseja atualizar: ");
            int id = int.Parse(Console.ReadLine());

            Produto produto = estoque.ObterProdutoPorId(id);
            if (produto != null)
            {
                Console.WriteLine($"Produto encontrado: {produto.Nome}");
                Console.Write("Digite o novo nome: ");
                string novoNome = Console.ReadLine();
                Console.Write("Digite a nova quantidade: ");
                int novaQuantidade = int.Parse(Console.ReadLine());
                Console.Write("Digite o novo preço: ");
                decimal novoPreco = decimal.Parse(Console.ReadLine());

                estoque.AtualizarProduto(id, novoNome, novaQuantidade, novoPreco);
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void DeletarProdutoMenu(Estoque estoque)
        {
            Console.Write("Digite o ID do produto que deseja deletar: ");
            int id = int.Parse(Console.ReadLine());

            estoque.DeletarProduto(id);
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
