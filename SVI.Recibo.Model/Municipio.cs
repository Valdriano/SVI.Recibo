using System.Collections.Generic;

namespace SVI.Recibo.Model
{
    public class Municipio : IEntity
    {
        public Municipio()
        {
            Configuracoes = new HashSet<Configuracao>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdEstado { get; set; }

        public virtual Estados Estado { get; set; }

        public virtual HashSet<Configuracao> Configuracoes { get; set; }
    }
}
