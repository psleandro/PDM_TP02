using System;
using System.Collections.Generic;
using System.Text;

namespace PDM_TP02
{
    class Produto
    {
        public Produto (int id, string descricao, string categoria, int quantidade, decimal preco)
        {
            Id = id;
            Descricao = descricao;
            Categoria = categoria;
            Quantidade = quantidade;
            Preco = preco;
        }
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string Categoria { get; set; }

        public int Quantidade { get; set; }

        public decimal Preco { get; set; }

        public override string ToString()
        {
            return Descricao;
        }
    }

}
