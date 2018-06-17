using System.Collections.Generic;

namespace SVI.Recibo.Model
{
    public class Estados : IEntity
    {
        public Estados()
        {
            Configuracoes = new HashSet<Configuracao>();
            Municipios = new HashSet<Municipio>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual HashSet<Configuracao> Configuracoes { get; set; }
        public virtual HashSet<Municipio> Municipios { get; set;}
    }
}
