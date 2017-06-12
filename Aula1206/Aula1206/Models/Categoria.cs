using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula1206.Models
{
    public class Categoria
    {
        //nome da class seguindo de id o entity ja reconhece como Pk
        public int CategoriaID { get; set; }
        [Required(ErrorMessage ="*")]
        public string Nome { get; set; }
        [Display(Name = "Descrição"), DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        public bool Ativo { get; set; }
    }
}