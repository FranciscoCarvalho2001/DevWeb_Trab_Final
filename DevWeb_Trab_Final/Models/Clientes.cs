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
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório")]
        [RegularExpression("[0-9]{9}", ErrorMessage = "O NIF {0} deve conter 9 dígitos")]
        public int NIF { get; set; }

        /// <summary>
        /// morada
        /// </summary>   
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório")]
        public string Morada { get; set; }

        /// <summary>
        /// Código postal
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório")]
        [Display(Name = "Código Postal")]
        [RegularExpression("[1-9][0-9]{3}-[0-9]{3} [A-ZÇÁÉÍÓÚÊÂÎÔÛÀÃÕ ]+", ErrorMessage = "O {0} tem de ser da forma XXXX-XXX NOME DA TERRA")]
        public string CodPostal { get; set; }
        /// <summary>
        /// Email do cliente
        /// </summary>
        [EmailAddress(ErrorMessage = "O {0} não está escrito corretamente")]
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [RegularExpression("[a-z._0-9]+@+[a-z]+.com")]
        [StringLength(40)]
        public string Email { get; set; }

        /// <summary>
        /// Telemóvel do cliente
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório")]
        [Display(Name = "Telemóvel")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O {0} deve ter {1} digitos")]
        [RegularExpression("9[1236][0-9]{7}", ErrorMessage = "O número de {0} deve começar por 91, 92, 93 ou 96, e ter 9 dígitos")]
        public string Telemovel { get; set; }

        //*************************************************
        /// <summary>
        /// atributo para efetuar a ligação entre a base 
        /// de dados do 'negócio' e a base de dados da autenticação
        /// </summary>
        public string UserId { get; set; }

        //*************************************************
        public ICollection<Dispositivos> ListaDipositivos { get; set; }

    }
}
