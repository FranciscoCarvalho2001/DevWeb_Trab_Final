using System.ComponentModel.DataAnnotations;
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
        /// Data do inicio da reparação
        /// </summary>
        [Display(Name = "Data de início da reparação")]
        public DateTime DataInicio { get; set; }

        /// <summary>
        /// Data do fim da reparação
        /// </summary>
        [Display(Name = "Data do fim da reparação")]
        public DateTime? DataFim { get; set; }

        /// <summary>
        /// Custo da reparação
        /// </summary>
        public decimal Custo { get; set; }

        /// <summary>
        /// Atributo de auxílio à adição do 
        /// custo de um dispositivo
        /// </summary>
        [NotMapped] // esta anotação impede a EF de exportar este atributo para a BD
        [RegularExpression("[0-9]+(.|,)?[0-9]{0,2}",
         ErrorMessage = "Só pode escrever algarismos e, se desejar, duas casas decimais no {0}")]
        [Display(Name = "Preço")]
        public string CustoAux { get; set; }

        /// <summary>
        /// Observações relativas ao estado da reparação
        /// </summary>
        [StringLength(255)]
        public string Observacao { get; set; }
        //*************************************************

        [ForeignKey(nameof(Dispositivo))]
        [Display(Name = "Dispositivo")]
        public int DispositivoFK { get; set; }
        public Dispositivos Dispositivo { get; set; }

        [ForeignKey(nameof(Funcionarios))]
        [Display(Name = "Funcionário")]
        public int FuncionariosFK { get; set; }
        public Funcionarios Funcionarios { get; set; } 

    }
}
