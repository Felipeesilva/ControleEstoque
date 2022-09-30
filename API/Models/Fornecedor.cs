using System;
using System.ComponentModel.DataAnnotations;


namespace API

{
    public class Fornecedor
    {
        public Fornecedor() => CriadoEm = DateTime.Now;
        
        [Key()]
        public int FornecedorId { get; set; }

        public string NomeFornecedor { get; set; }

        public string CnpjFornecedor { get; set; }

        public string EmailFornecedor { get; set; }

        public DateTime CriadoEm { get; set; }

    }

}