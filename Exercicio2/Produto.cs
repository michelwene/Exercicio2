using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    class Produto
    {
        private int codigo;
        private string nome;
        private int estoque;
        private Double valor;


        public Produto()
        {

        }
        public Produto(int codigo, string nome, int estoque, double valor)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.estoque = estoque;
            this.valor = valor;
            Console.WriteLine("Estocagem de produtos: ");
        }
        public void adicionarProdutos(int estoque)
        {
            this.estoque = estoque;
            Console.WriteLine("Entrada de produtos: " + estoque);

        }
    
        public void retirarProduto(int estoque)
        {
            this.estoque -= estoque;
            Console.WriteLine("Retirada de produtos: -" + estoque + "\n");
        }
        public void ImprimirDados()
        {
            Console.WriteLine("Código: "+ codigo);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Estoque:" + estoque);
            Console.WriteLine("Valor: " + valor+"\n");

        }
    }
}
