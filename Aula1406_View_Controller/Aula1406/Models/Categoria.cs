// faz diferença sim carregar os using entao delete-as se nao for usar
using System.ComponentModel.DataAnnotations;

namespace Aula1406.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }
        [Required(ErrorMessage ="Favor preencher o campo nome!")]// pode utilizar colchetes ou sepando por vigula
        [StringLength(10, ErrorMessage ="Não pode exceder o  tamanho de 10 caracteries!")]
        public string Nome { get; set; }
        [Display(Name ="Descrição"),DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
        [Required]
        public bool Ativo { get; set; }
    }
}