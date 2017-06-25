
using System.ComponentModel.DataAnnotations;

namespace BaseModels
{
    public class Categoria
    {
        //sempre lembrar do using para dataanottations
        [Key]
        public int CategoriID { get; set; }
        [Required (ErrorMessage ="*"),
        StringLength(10,ErrorMessage ="Tamanho Máximo 10 caracteres")]
        public string Nome { get; set; }
        [Display (Name ="Descrição"),
        DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
        [Required]
        public bool Ativo { get; set; }
    }
}
