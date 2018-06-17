namespace SVI.Recibo.Model
{
    public class Municipio : IEntity
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdEstado { get; set; }

        public virtual Estados Estado { get; set; }
    }
}
