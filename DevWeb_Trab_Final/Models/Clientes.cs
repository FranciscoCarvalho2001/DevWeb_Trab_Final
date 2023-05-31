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
        /// Morada do cliente
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal do cliente
        /// </summary>
        public string CodPostal { get; set; }

        /// <summary>
        /// Email do cliente
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Telemóvel do cliente
        /// </summary>
        public string Telemovel { get; set; }

        //*************************************************

        public ICollection<Dispositivos> ListaDipositivos { get; set; }

    }
}
