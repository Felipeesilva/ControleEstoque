using System;

namespace API

{
    public class Fornecedor
    {
        public Fornecedor() => CriadoEm = DateTime.Now;

        public int FornecedorId { get; set; }

        public string NomeFornecedor { get; set; }

        public string CnpjFornecedor { get; set; }

        public string EmailFornecedor { get; set; }


}