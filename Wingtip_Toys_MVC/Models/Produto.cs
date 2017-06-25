
using BaseModels;
using System.ComponentModel.DataAnnotations;

namespace BaseModels
{
    public class Produto
    {
        [Key]
        public int ProdutoID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Display(Name ="Descrição"),DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
        [Display(Name ="Preço"),DataType(DataType.Currency)]
        public decimal Preco { get; set; }
        public bool Ativo { get; set; }
        
        public int CategoriaID { get; set; } 
        //prof coloca anderline para diferenciar
        
        public virtual Categoria _Categoria { get; set; }
    }
}
