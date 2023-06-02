using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace DevWeb_Trab_Final.Models
{
    public class Dispositivos
    {
        public Dispositivos() {
            ListaReparacao = new HashSet<Reparacao>();
        }

        /// <summary>
        /// Id do despositivo
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tipo de dispositivo
        /// </summary>
        public string Tipo { get; set; }

        /// <summary>
        /// Data de Registo do dispositivo
        /// </summary>
        public DateTime DataReg{ get; set; }   

        /// <summary>
        /// Modelo do dispositivo
        /// </summary>
        public string Modelo { get; set; }

        /// <summary>
        /// Foto do dispositivo
        /// </summary>
        public string Foto { get; set; }

        /// <summary>
        /// Descrição do estado do dispositivo
        /// </summary>
        public string Estado { get; set; }
        //*************************************************

        public ICollection<Reparacao> ListaReparacao { get; set; }

        [ForeignKey(nameof(Cliente))]
        public int ClienteFK { get; set; }
        public Clientes Cliente { get; set; }

    }
}
