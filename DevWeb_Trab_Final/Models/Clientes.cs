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
        public string Nome { get; set; }

        /// <summary>
        /// Nº de Identificação fiscal do cliente
        /// </summary>
        public int NIF { get; set; }

        /// <summary>
        /// Email do cliente
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Telemóvel do cliente
        /// </summary>
        public int Telemovel { get; set; }

        //*************************************************

        public ICollection<Dispositivos> ListaDipositivos { get; set; }

    }
}
