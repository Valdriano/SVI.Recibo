using System.ComponentModel.DataAnnotations;

namespace SVI.Recibo.Web.ViewModels
{
    public class EstadoViewModel
    {
        [Display( Name = "Código" )]
        public int Id { get; set; }

        [Display( Name = "Estado" )]
        [Required( ErrorMessage = "O nome do Estado é obrigatório" )]
        [MinLength( 4, ErrorMessage = "O nome do Estado deve ser maior que 4 caracteres" )]
        [MaxLength(40, ErrorMessage = "O nome do Estado deve ser menor ou igual a 40 caracteres")]
        public string Descricao { get; set; }
    }
}