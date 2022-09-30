using System;
using System.ComponentModel.DataAnnotations;


namespace API
{
    public class Produto
    {
        public Produto() => CriadoEm = DateTime.Now;

        [Key()]
        public int ProdutoId { get; set; }

        public String NomeProduto { get; set; }

        public String Categoria { get; set; }

        public int Preco { get; set; }

        // public String fornecedor { get; set; }
        // public String Estoque { get; set; }

        public DateTime CriadoEm { get; set; }


    }

}