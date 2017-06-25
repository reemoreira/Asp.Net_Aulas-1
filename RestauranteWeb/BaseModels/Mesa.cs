using System.ComponentModel.DataAnnotations;

namespace BaseModels
{
    public class Mesa
    {
        [Key]
        public int MesaID { get; set; }
        [Required(ErrorMessage ="*")]
        public int Numero { get; set; }
        [Required(ErrorMessage = ("*"))]
        public int QtdCadeiras { get; set; }
        [Required]
        public bool Ativo { get; set; }//relacionado ao estado(excluido/ativo) da mesa
        [Required]
        public bool Status { get; set; }//relacionado ao estado(reservada/não reservada) da mesa
    }
}
