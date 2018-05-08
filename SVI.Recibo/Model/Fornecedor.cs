using System.Collections.Generic;

namespace SVI.Recibo.Model
{
    public class Fornecedor
    {
        public Fornecedor()
        {
            _Recibos = new List<Recibo>();
        }

        public int IDFornecedor { get; set; }
        public string Nome { get; set; }
        public long CPFCNPJ { get; set; }
        public string Bairro { get; set; }
        public string Lougradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public int CEP { get; set; }

        public virtual IList<Recibo> _Recibos { get; set; }
    }
}
