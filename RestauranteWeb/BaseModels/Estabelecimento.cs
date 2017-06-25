using System.ComponentModel.DataAnnotations;

namespace BaseModels
{
    public class Estabelecimento
    {
        [Key]
        public int EstabelecimentoID { get; set; }
        [Required(ErrorMessage = "* Campo Obrigatorio"), Display(Name = "Nome do proprietário:")]
        public string NameOnwer { get; set; }
        [Required(ErrorMessage = "* Campo Obrigatorio"), Display(Name = "Emal do proprietário:")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "* Campo Obrigatorio"), Display(Name = "Telefone do proprietário:")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage =("*")), StringLength(10,ErrorMessage =("O nome do restaurante pode ter no maximo 10 caractéres"))]
        public string RestaurantName { get; set; }
        [Required(ErrorMessage =("*")),DataType(DataType.MultilineText)]
        public string RestaurantDescription { get; set; }
        [Required(ErrorMessage = ("*"))]
        public string RestaurantCity { get; set; }
        [Required(ErrorMessage = ("*"))]
        public string RestaurantState { get; set; }
        [Required(ErrorMessage = ("*"))]
        public string RestaurantCountry { get; set; }

        public string RestaurantPostalCode { get; set; }
        [Required]
        public bool Ativo { get; set; }
    }
}
