using System.ComponentModel.DataAnnotations.Schema;

namespace DevWeb_Trab_Final.Models {
    public class Fotografias {

        /// <summary>
        /// Id da Fotografia
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do Ficheiro da Fotografia
        /// </summary>
        public string NomeFoto { get; set; }

        //*************************************************

        [ForeignKey(nameof(Dispositivo))]
        public int DispositivoFK { get; set; }
        public Dispositivos Dispositivo { get; set; }
 
    }
}
