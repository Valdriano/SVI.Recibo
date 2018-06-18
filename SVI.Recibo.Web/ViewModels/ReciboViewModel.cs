using SVI.Recibo.Web.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace SVI.Recibo.Web.ViewModels
{
    public class ReciboViewModel
    {
        [Display( Name = "Código Recibo" )]
        public int Id { get; set; }

        [Display( Name = "Fornecedor" )]
        [Required( ErrorMessage = "É obrigatório informa o fornecedor" )]
        public int IdFornecedor { get; set; }

        [Display( Name = "Valor" )]
        [Range( 0.01, 9999999.99, ErrorMessage = "O valor de está em 0,01 á 9.999.999,99" )]
        [DataType( DataType.Currency )]
        public decimal Valor { get; set; }

        [Display( Name = "Referente" )]
        [Required( ErrorMessage = "A referência deve ser informada" )]
        [MaxLength( 100, ErrorMessage = "A referência deve ter no máximo 100 caracteres" )]
        public string Referencia { get; set; }

        [Display( Name = "Data" )]
        [DataType( DataType.Date )]
        public DateTime Data { get; set; }

        [Display( Name = "Estado" )]
        [Required( ErrorMessage = "O Estado é obrigatório" )]
        public int IdEstado { get; set; }

        [Display( Name = "Município" )]
        [Required( ErrorMessage = "O Município é obrigatório" )]
        public int IdMunicipio { get; set; }

        [Display(Name = "Quantidade de impressões")]
        public int QuantidadeImpressao { get; set; }


        public virtual Estado Estado { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Municipio Municipio { get; set; }
    }
}