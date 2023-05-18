using System.ComponentModel.DataAnnotations.Schema;

namespace DevWeb_Trab_Final.Models
{
    public class Reparacao
    {
        /// <summary>
        /// Id da reparação
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Referência da foto da reparação
        /// </summary>
        public string Foto { get; set; }

        /// <summary>
        /// Data do inicio da reparação
        /// </summary>
        public DateTime DataInicio { get; set; }

        /// <summary>
        /// Data do fim da reparação
        /// </summary>
        public DateTime DataFim { get; set; }

        /// <summary>
        /// Custo da reparação
        /// </summary>
        public int Custo { get; set; }

        /// <summary>
        /// Observações relativas ao estado da reparação
        /// </summary>
        public string Observacao { get; set; }

        //*************************************************

        [ForeignKey(nameof(Dispositivo))]
        public int DispositivoFK { get; set; }
        public Dispositivos Dispositivo { get; set; }

        [ForeignKey(nameof(Funcionarios))]
        public int FuncionariosFK { get; set; }
        public Funcionarios Funcionarios { get; set; } 


    }
}
