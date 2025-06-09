using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Marcus_2_ano
{
    public class Produto
    {
        public int Id { get; }
        public string Nome { get; }
        public decimal Preço { get; }
        public string Categoria { get; }

        public Produto(int id, string nome, decimal preço, string categoria)
        {
            if (preço <= 0)
                throw new ArgumentException("Preço inválido.");

            Id = id;
            Nome = nome;
            Preço = preço;
            Categoria = categoria;
        }
    }

}
