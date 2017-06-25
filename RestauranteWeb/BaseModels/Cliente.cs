using System.ComponentModel.DataAnnotations;

namespace BaseModels
{
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }
        [Required(ErrorMessage = "* Campo Obrigatorio"),Display(Name ="Nome:")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="* Campo Obrigatorio"),StringLength(11,ErrorMessage =("Tamanho do CPF deve ser de 11 números")), Display(Name ="Cpf:")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "* Campo Obrigatorio"), StringLength(14, ErrorMessage = ("O número de telefone está inválido")),Display(Name ="Número de telefone:")]
        public string PhoneNumber { get; set; }
        [Required,Display(Name ="Email:")]
        public string Email { get; set; }
        [Required]
        public bool Ativo { get; set; }
    }
}
