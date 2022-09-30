using System;
using System.ComponentModel.DataAnnotations;

namespace API

{
    public class Estoque
    {
        public Estoque() => CriadoEm = DateTime.Now;

        [Key()]
        public string EstoqueId { get; set; } 

        public string ProdutoId { get; set; } 
        public virtual Produto produto { get; set; } 
        
        public int QuantidadeProduto { get; set; }

        public int ValorProduto { get; set; }

        public DateTime CriadoEm { get; set; }
        
    
        
     }
}