namespace SVI.Recibo.Web.Models
{
    public class Configuracao
    {
        public int Id { get; set; }
        public string Proprietario { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string Licenca { get; set; }
        public int IdEstado { get; set; }
        public int IdMunicipio { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual Municipio Municipio { get; set; }
    }
}