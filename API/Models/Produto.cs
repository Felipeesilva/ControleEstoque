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

        public string Fornecedor { get; set; }
       // public virtual Fornecedor fornecedor { get; set; } 

        public DateTime CriadoEm { get; set; }


    }

}