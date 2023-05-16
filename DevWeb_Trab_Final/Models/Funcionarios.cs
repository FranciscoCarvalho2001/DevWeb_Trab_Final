namespace DevWeb_Trab_Final.Models
{
    public class Funcionarios
    {
        public Funcionarios() { 
            ListaRepara = new HashSet<Funcionarios>();
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
        /// Telemóvel do Funcionário
        /// </summary>
        public int Telemovel { get; set; }

        /// <summary>
        /// Especilização do funcionário
        /// </summary>
        public string Especializacao { get; set; }

        //*************************************************

        public ICollection<Funcionarios> ListaRepara { get; set; }

    }
}
