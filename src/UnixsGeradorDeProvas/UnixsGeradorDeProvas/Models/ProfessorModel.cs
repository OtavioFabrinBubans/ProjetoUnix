using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UnixGeradorDeProvas.Dominio;

namespace UnixsGeradorDeProvas.Models
{
    public class ProfessorModel
    {

        [Required]
        public int? Id { get; set; }

        [Required]
        public string Nome { get; set; }


        [Required]
        public int PoloId { get; set; }
        [Required]
        public virtual Polo Polo { get; set; }
    }
}