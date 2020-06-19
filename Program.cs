using System;

namespace Aula20_21_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cliente lucca = new Cliente("luccao");
            lucca.Endereco = "Av. espacial, 102";
            Restaurante mcDonalds = new Restaurante("McDonalds", "Av Paulista, 123");

            Pedido pedido1 = new Pedido();
            pedido1.Cliente = lucca;
            pedido1.Restaurante = mcDonalds;

            Console.WriteLine( pedido1.EntregarPedido() );

        }
    }
}
