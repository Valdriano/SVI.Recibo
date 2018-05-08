using System;

namespace SVI.Recibo.Model
{
    public class Recibo
    {
        public int IDRecibo { get; set; }
        public int IDFornecedor { get; set; }
        public DateTime DataHora { get; set; }
        public decimal Valor { get; set; }
        public string Referencia { get; set; }

        public virtual Fornecedor _Fornecedor { get; set; }
    }
}
