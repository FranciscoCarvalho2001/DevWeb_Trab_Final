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
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Morada do funcionário
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal do funcionário
        /// </summary>
        public string CodPostal { get; set; }

        /// <summary>
        /// email do funcionário
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Telemóvel do Funcionário
        /// </summary>
        public int Telemovel { get; set; }

        /// <summary>
        /// Especilização do funcionário
        /// </summary>
        public string Especializacao { get; set; }

        //*************************************************

        public ICollection<Reparacao> ListaRepara { get; set; }

    }
}
