using System.ComponentModel.DataAnnotations;

namespace SVI.Recibo.Web.ViewModels
{
    public class MunicipioViewModel
    {
        [Display( Name = "Código Município:" )]
        public int Id { get; set; }

        [Display( Name = "Município:" )]
        [Required( ErrorMessage = "O Município é obrigatório" )]
        [MaxLength( 40, ErrorMessage = "O município deve ter no máximo 40 caracteres" )]
        public string Descricao { get; set; }

        [Display( Name = "Estado:" )]
        [Required( ErrorMessage = "O Estado é obrigatório" )]
        public int IdEstado { get; set; }
    }
}