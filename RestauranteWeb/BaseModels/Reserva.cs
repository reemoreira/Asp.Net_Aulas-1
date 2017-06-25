using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BaseModels
{
    public class Reserva
    {
        [Key]
        public int ReservaID { get; set; }
        [Required]
        public int QtdPessoas { get; set; }
        [Required]
        public int EstabelecimentoID { get; set; }//FK
        [Required]
        public int CLienteID { get; set; }//FK
        [Required]
        public int MesaID { get; set; }//FK

        [Required(ErrorMessage = "É necessário selecionar Mesa(s) para efetuar a reserva")]
        public List<Mesa> Mesa { get; set; }
        [Required]
        public Cliente Cliente { get; set; }
        [Required (ErrorMessage ="É necessário selecionar um restaurante para efetuar a reserva")]
        public Estabelecimento Restaurante { get; set; }
        [Required(ErrorMessage ="É necessário um horário e uma data para realizar a reserva"),Display(Name ="Selecione uma Data e Horário:")]
        public DateTime DataHorario { get; set; }
    }
}
