using DevWeb_Trab_Final.Models;
namespace DevWeb_Trab_Final.ViewModels
{
    public class AdministradorView
    {
        /// <summary>
        /// Lista dos Funcionarios
        /// </summary>
        public List<Funcionarios> Funcionarios { get; set; }

        /// <summary>
        /// Lista dos Clientes
        /// </summary>
        public List<Clientes> Clientes { get; set; }

        /// <summary>
        /// Lista dos Dispositivos
        /// </summary>
        public List<Dispositivos> Dispositivos { get; set;}

        /// <summary>
        /// Lista das Reparações
        /// </summary>
        public List<Reparacao> Reparacao { get; set; }
    }
}
