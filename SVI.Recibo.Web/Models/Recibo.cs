using System;

namespace SVI.Recibo.Web.Models
{
    public class Recibo
    {
        public int Id { get; set; }
        public int IdFornecedor { get; set; }
        public decimal Valor { get; set; }
        public string Referencia { get; set; }
        public DateTime Data { get; set; }
        public int IdEstado { get; set; }
        public int IdMunicipio { get; set; }
        public int QuantidadeImpressao { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Municipio Municipio { get; set; }
    }
}