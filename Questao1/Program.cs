using System;
using System.Globalization;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)

        {
            Hardware produto = new Hardware();
            Hardware produto2 = new Hardware();


            Console.WriteLine("BEM VINDO AO SISTEMA DE CADASTRO");

            produto.id = 1;
            produto.descricao = "Processador Intel core I7";
            produto.valor = 6533.00;
            produto.fabricante = "Intel";

            produto2.id = 2;
            produto2.descricao = "Processador Ryzen 5";
            produto2.valor = 1343.00;
            produto2.fabricante = "AMD";             

            Console.WriteLine(produto.GetDetalhesHardware());
            Console.WriteLine(produto2.GetDetalhesHardware());


        }
    }
}
