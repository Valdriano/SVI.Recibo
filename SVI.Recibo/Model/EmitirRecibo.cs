namespace SVI.Recibo.Model
{
    public class EmitirRecibo
    {
        public int IDRecibo { get; set; }
        public string NomeFornecedor { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Local { get; set; }
        public string CPFCNPJ { get; set; }
        public string Referente { get; set; }
        public decimal Valor { get; set; }
        public byte[] Logo { get; set; }
    }
}
