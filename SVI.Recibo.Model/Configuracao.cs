namespace SVI.Recibo.Model
{
    public class Configuracao : IEntity
    {
        public int Id { get; set; }
        public string Licenca { get; set; }
        public string Proprietario { get; set; }
        public string Email { get; set; }
        public int IdEstado { get; set; }
        public int IdMunicipio { get; set; }

        public virtual Estados Estado { get; set; }
        public virtual Municipio Municipio { get; set; }
    }
}
