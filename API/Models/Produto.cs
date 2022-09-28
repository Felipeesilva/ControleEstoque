using System;

namespace API
{
    public class Produto
    {
        public Produto() => CriadoEm = DateTime.Now;

        public int ProdutoId { get; set; }

        public String NomeProduto { get; set; }

        public String Categoria { get; set; }

        public String Preco { get; set; }

        public String fornecedor { get; set; }

        public String Estoque { get; set; }

    }

}