using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Marcus_2_ano
{
    public class Pedido
    {
        public int Id { get; }
        public Cliente Cliente { get; }
        public List<ItemPedido> Itens { get; }
        public DateTime Data { get; }
        public decimal ValorTotal => Itens.Sum(i => i.Subtotal);

        public Pedido(int id, Cliente cliente, List<ItemPedido> itens)
        {
            Id = id;
            Cliente = cliente;
            Itens = itens;
            Data = DateTime.Now;
        }
    }
}
