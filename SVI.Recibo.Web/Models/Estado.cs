using System.Collections.Generic;

namespace SVI.Recibo.Web.Models
{
    public class Estado
    {
        public Estado()
        {
            Configuracoes = new List<Configuracao>();
            Fornecedores = new List<Fornecedor>();
            Municipios = new List<Municipio>();
            Recibos = new List<Recibo>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Configuracao> Configuracoes { get; set; }
        public virtual ICollection<Fornecedor> Fornecedores { get; set; }
        public virtual ICollection<Municipio> Municipios { get; set; }
        public virtual ICollection<Recibo> Recibos { get; set; }
    }
}