using System;

namespace BaseModels
{
    public class Folha
    {
        public int FolhaID { get; set; }
        public int FuncionarioID { get; set; }
        public DateTime MesAno { get; set; }
        public int QtdHorasTrabalhadas { get; set; }
        public float ValorHora { get; set; }

        public Funcionario Funcionario { get; set; }
    }
}
