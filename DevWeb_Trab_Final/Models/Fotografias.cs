using System.ComponentModel.DataAnnotations.Schema;

namespace DevWeb_Trab_Final.Models {
    public class Fotografias {

        public int Id { get; set; }

        public string NomeFoto { get; set; }

        //*************************************************

        [ForeignKey(nameof(Dispositivo))]
        public int DispositivoFK { get; set; }
        public Dispositivos Dispositivo { get; set; }
 
    }
}
