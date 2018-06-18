using System.ComponentModel.DataAnnotations;

namespace SVI.Recibo.Web.ViewModels
{
    public class ConfiguracaoViewModel
    {
        [Display( Name = "Código" )]
        public int Id { get; set; }

        [Display( Name = "Proprietário" )]
        [Required( ErrorMessage = "O nome do proprietário é obrigatório" )]
        [MaxLength( 60, ErrorMessage = "O nome do proprietário deve ter no máximo 60 caracteres" )]
        public string Proprietario { get; set; }

        [Display( Name = "Email" )]
        [Required( ErrorMessage = "O email é obrigatório" )]
        [MaxLength( 100, ErrorMessage = "O email deve ter no máximo 100 caracteres" )]
        [DataType( DataType.EmailAddress )]
        public string Email { get; set; }

        [Display( Name = "CPF" )]
        [MaxLength( 11, ErrorMessage = "O CPF deve conter 11 digitos" )]
        public string CPF { get; set; }

        [Display( Name = "CPNJ" )]
        [MaxLength( 14, ErrorMessage = "O CNPJ deve conter 14 digitos" )]
        public string CNPJ { get; set; }

        [Display( Name = "Licença" )]
        public string Licenca { get; set; }

        [Display( Name = "Código do Estado" )]
        [Required( ErrorMessage = "O Estado é obrigatório" )]
        public int IdEstado { get; set; }

        [Display( Name = "Código do Município" )]
        [Required( ErrorMessage = "O Município é obrigatório" )]
        public int IdMunicipio { get; set; }
    }
}