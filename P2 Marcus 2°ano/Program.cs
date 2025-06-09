using P2_Marcus_2_ano;
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        var produto1 = new Produto(1, "Mouse", 50.00m, "Eletrônico");
        var produto2 = new Produto(2, "Calça", 30.00m, "Promoção");
        var produto3 = new Produto(3, "Teclado", 120.00m, "Eletrônco");

        var cliente = new Cliente(1, "Marcus", "Marcus@email.com", "44591286835");

        var itens = new List<ItemPedido>
        {
            new ItemPedido(produto1, 2),
            new ItemPedido(produto2, 3),
            new ItemPedido(produto3, 1)
        };
    }
}
