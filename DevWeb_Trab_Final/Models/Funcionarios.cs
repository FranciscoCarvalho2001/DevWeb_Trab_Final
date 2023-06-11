using System.ComponentModel.DataAnnotations;

namespace DevWeb_Trab_Final.Models
{
    public class Funcionarios
    {
        public Funcionarios() { 
            ListaRepara = new HashSet<Reparacao>();
        }   

        /// <summary>
        /// Id de Funcionário
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do funcionário
        /// </summary>º
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        public string Nome { get; set; }

        /// <summary>
        /// Morada do funcionário
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal do funcionário
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [Display(Name = "Código Postal")]
        [RegularExpression("[1-9][0-9]{3}-[0-9]{3} [A-ZÇÁÉÍÓÚÊÂÎÔÛÀÃÕ ]+", ErrorMessage = "O {0} tem de ser da forma XXXX-XXX NOME DA TERRA")]
        public string CodPostal { get; set; }

        /// <summary>
        /// email do funcionário
        /// </summary>
        [EmailAddress(ErrorMessage = "O {0} não está escrito corretamente")]
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [RegularExpression("[a-z._0-9]+@+[a-z]+.com")]
        [StringLength(40)]
        public string Email { get; set; }

        /// <summary>
        /// Telemóvel do Funcionário
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório")]
        [Display(Name = "Telemóvel")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O {0} deve ter {1} digitos")]
        [RegularExpression("9[1236][0-9]{7}", ErrorMessage = "O número de {0} deve começar por 91, 92, 93 ou 96, e ter 9 dígitos")]
        public string Telemovel { get; set; }

        /// <summary>
        /// Especilização do funcionário
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório")]
        public string Especializacao { get; set; }

        //*************************************************

        public ICollection<Reparacao> ListaRepara { get; set; }

    }
}
