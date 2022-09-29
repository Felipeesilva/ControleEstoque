using System;

namespace API

{
    public class Estoque
    {
        public Estoque() => CriadoEm = DateTime.Now;

        public string Produto { get; set; } 

        public int QuantidadeProduto { get; set; }

        public int ValorProduto { get; set; }
        
     }
}
