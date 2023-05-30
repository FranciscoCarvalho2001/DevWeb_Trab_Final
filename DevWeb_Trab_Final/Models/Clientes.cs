using System.ComponentModel.DataAnnotations;

namespace DevWeb_Trab_Final.Models
{
    public class Clientes
    {

        public Clientes() {
            ListaDipositivos = new HashSet<Dispositivos>();
        }

        /// <summary>
        /// Id do cliente
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do cliente
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        public string Nome { get; set; }

        /// <summary>
        /// Nº de Identificação fiscal do cliente
        /// </summary>
        public int NIF { get; set; }

        /// <summary>
        /// morada
        /// </summary>   
        public string Morada { get; set; }

        /// <summary>
        /// Código postal
        /// </summary>
        [Display(Name = "Código Postal")]
        [RegularExpression("[1-9][0-9]{3}-[0-9]{3} [A-ZÇÁÃÂÀÕ]+", ErrorMessage = "O {0} tem de ser de forma XXXX-XXX NOME DA TERRA")]
        [StringLength(50)]
        public string codPostal { get; set; }
        /// <summary>
        /// Email do cliente
        /// </summary>
        [EmailAddress(ErrorMessage = "O {0} não está escrito corretamente")]
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email não é valido.")]
        [StringLength(40)]
        public string Email { get; set; }

        /// <summary>
        /// Telemóvel do cliente
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [Display(Name = "Telemóvel")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O {0} deve ter {1} digitos")]
        [RegularExpression("9[1236][0-9]{7}", ErrorMessage = "O número de {0} deve começar por 91,92,93,96 e só pode escrever digitos")]
        public String Telemovel { get; set; }

        //*************************************************

        public ICollection<Dispositivos> ListaDipositivos { get; set; }

    }
}
