using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto(1, "Celular", 0, 1999.99);
            produto.ImprimirDados();
            produto.adicionarProdutos(20);
            produto.retirarProduto(5);
            Produto produto1 = new Produto (1,"Celular", 15, 1999.99);
            produto.ImprimirDados();
        }
    }
}
