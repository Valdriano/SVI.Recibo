using System.Collections.Generic;

namespace SVI.Recibo.Web.Models
{
    public class Fornecedor
    {
        public Fornecedor()
        {
            Recibos = new List<Recibo>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Fantasia { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public int CEP { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public int IdEstado { get; set; }
        public int IdMunicipio { get; set; }
        public byte[] Logo { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual Municipio Municipio { get; set; }

        public virtual ICollection<Recibo> Recibos { get; set; }
    }
}