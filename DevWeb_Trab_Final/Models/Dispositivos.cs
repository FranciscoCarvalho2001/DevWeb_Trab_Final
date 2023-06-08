using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace DevWeb_Trab_Final.Models
{
    public class Dispositivos
    {
        public Dispositivos() {
            ListaReparacao = new HashSet<Reparacao>();
            ListaFotografias = new HashSet<Fotografias>();
        }

        /// <summary>
        /// Id do despositivo
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tipo de dispositivo
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório")]
        public string Tipo { get; set; }

        /// <summary>
        /// Data de Registo do dispositivo
        /// </summary>
        [Display(Name = "Data de registo")]
        public DateTime DataReg{ get; set; }

        /// <summary>
        /// Modelo do dispositivo
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório")]
        public string Modelo { get; set; }

        /// <summary>
        /// Foto do dispositivo
        /// </summary>
        [Display(Name = "Imagem do Dispositivo")]
        public string Foto { get; set; }

        /// <summary>
        /// Descrição do estado do dispositivo
        /// </summary>
        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório")]
        [Display(Name = "Descrição do estado do dispositivo")]
        public string Estado { get; set; }
        //*************************************************

        public ICollection<Reparacao> ListaReparacao { get; set; }
        public ICollection<Fotografias> ListaFotografias { get; set; }

        [ForeignKey(nameof(Cliente))]
        [Display(Name = "Cliente")]
        public int ClienteFK { get; set; }
        public Clientes Cliente { get; set; }

    }
}
