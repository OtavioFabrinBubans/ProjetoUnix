using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnixsGeradorDeProvas.Models
{
    public class PoloModel
    {

        [Required]
        public int? Id { get; set; }

        [Required]
        public string Descricao { get; set; }

    }
}