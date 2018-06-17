using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SVI.Recibo.Web.Models
{
    public class Configuracao
    {
        public int Id { get; set; }
        public string Proprietario { get; set; }
        public string Email { get; set; }
        public long CPF { get; set; }
        public long CNPJ { get; set; }
        public string Licenca { get; set; }
        public int IdEstado { get; set; }
        public int IdMunicipio { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual Municipio Municipio { get; set; }
    }
}