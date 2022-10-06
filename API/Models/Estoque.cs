using System;
using System.ComponentModel.DataAnnotations;

namespace API

{
    public class Estoque
    {
        public Estoque() => CriadoEm = DateTime.Now;

        [Key()]
        public int EstoqueId { get; set; } 
        //public int ProdutoId { get; set; } 
        public Produto Produto { get; set; } 
        
        public int ValorProduto { get; set; }

        public string TipoEstoque { get; set; } 

        public DateTime CriadoEm { get; set; }
        
    
        
     }
}