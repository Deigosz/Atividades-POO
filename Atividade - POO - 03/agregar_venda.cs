using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace atv_poo3
{
    public class Venda
    {
        public Comprador Comprador { get; }
        public List<Produto> Produtos { get; }
        public double ValorTotal { get; private set; }

        public Venda(Comprador comprador)
        {
            Comprador = comprador;
            Produtos = new List<Produto>();
            ValorTotal = 0;
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
            ValorTotal += produto.Preco;

            double comissao = produto.Preco * 0.02;
            Vendedor.Comissao += comissao;
            Comprador.Verba -= produto.Preco;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Itens para vender ao comprador: {Comprador.Nome}");
            foreach (var produto in Produtos)
            {
                Console.WriteLine($"\t- {produto.Nome}, Preço: R${produto.Preco}");
            }
            Console.WriteLine($"Montante Total da Operação: R${ValorTotal}\n");
        }
    }


    public class Vendedor
    {
        public static double Comissao { get; set; }
        public string Nome { get; set; }
        public Vendedor(double comissao, string nome)
        {
            Comissao = comissao;
            Nome = nome;    
        }

        public void Mostrar_Atributos()
        {
            System.Console.Write($"Nome: {Nome}\tComissão: R$ {Comissao}");
        }

    }

    public class Produto
    {
        public string Codigo { get; } 
        public string Nome { get; set; }
        public double Preco { get; set; }
        public static int _contador { get; set; }


        public Produto(string nome, double preco)
        {
            _contador++;
            Codigo = "500" + _contador;
            Nome = nome;
            Preco = preco;
        }


        public void Mostrar_Atributos()
        {
            System.Console.Write($"Código: {Codigo} \tNome: {Nome} \tPreço: R$ {Preco}\n");
        }
    }

    public class Comprador
    {
        public double Verba { get; set; }
        public string Nome { get; set; }

        public Comprador(double verba, string nome)
        {   
            Nome = nome;
            Verba = verba;
        }

        public void Mostrar_Atributos()
        {
            System.Console.Write($"Sua verba é: R$ {Verba}\n");
        }

        
    }
}