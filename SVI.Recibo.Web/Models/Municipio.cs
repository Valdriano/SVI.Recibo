using System.Collections.Generic;

namespace SVI.Recibo.Web.Models
{
    public class Municipio
    {
        public Municipio()
        {
            Configuracoes = new List<Configuracao>();
            Fornecedores = new List<Fornecedor>();
            Recibos = new List<Recibo>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdEstado { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual ICollection<Configuracao> Configuracoes { get; set; }
        public virtual ICollection<Fornecedor> Fornecedores { get; set; }
        public virtual ICollection<Recibo> Recibos { get; set; }
    }
}