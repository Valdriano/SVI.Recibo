using System.ComponentModel.DataAnnotations;

namespace SVI.Recibo.Web.ViewModels
{
    public class FornecedorViewModel
    {
        [Display( Name = "Código:" )]
        public int Id { get; set; }

        [Display( Name = "Fornecedor:" )]
        [Required( ErrorMessage = "O nome do fornecedor é obrigatório" )]
        [MaxLength( 40, ErrorMessage = "O nome do fornecedor deve ter no máximo 40 caracteres" )]
        public string Nome { get; set; }

        [Display( Name = "Fantasia:" )]
        [MaxLength( 40, ErrorMessage = "O nome fantasia deve ter no máximo 40 caracteres" )]
        public string Fantasia { get; set; }

        [Display( Name = "CPF:" )]
        [MaxLength( 11, ErrorMessage = "O CPF deve conter 11 digitos" )]
        public long CPF { get; set; }

        [Display( Name = "CPNJ:" )]
        [MaxLength( 14, ErrorMessage = "O CNPJ deve conter 14 digitos" )]
        public long CNPJ { get; set; }

        [Display( Name = "CEP:" )]
        [MaxLength( 8, ErrorMessage = "O CEP deve conter 8 digitos" )]
        public int CEP { get; set; }

        [Display( Name = "Bairro:" )]
        [Required( ErrorMessage = "O bairro e obrigatório" )]
        [MaxLength( 40, ErrorMessage = "O bairro deve ter no máximo 40 caracteres" )]
        public string Bairro { get; set; }

        [Display( Name = "Logradouro:" )]
        [Required( ErrorMessage = "O logradouro e obrigatório" )]
        [MaxLength( 40, ErrorMessage = "O logradouro deve ter no máximo 40 caracteres" )]
        public string Logradouro { get; set; }


        [Display( Name = "Número:" )]
        [Required( ErrorMessage = "O numero e obrigatório" )]
        [MaxLength( 10, ErrorMessage = "O número deve ter no máximo 40 caracteres" )]
        public string Numero { get; set; }


        [Display( Name = "Complemento:" )]
        [MaxLength( 40, ErrorMessage = "O complemento deve ter no máximo 40 caracteres" )]
        public string Complemento { get; set; }

        [Display( Name = "Estado:" )]
        [Required( ErrorMessage = "O Estado é obrigatório" )]
        public int IdEstado { get; set; }

        [Display( Name = "Município:" )]
        [Required( ErrorMessage = "O Município é obrigatório" )]
        public int IdMunicipio { get; set; }

        [Display( Name = "Logo Tipo:" )]
        [DataType( DataType.ImageUrl )]
        public byte[] Logo { get; set; }
    }
}