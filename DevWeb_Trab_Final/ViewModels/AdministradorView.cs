using DevWeb_Trab_Final.Models;
namespace DevWeb_Trab_Final.ViewModels
{
    public class AdministradorView
    {
        public List<Funcionarios> Funcionarios { get; set; }
        public List<Clientes> Clientes { get; set; }
        public List<Dispositivos> Dispositivos { get; set;}
        public List<Reparacao> Reparacao { get; set; }
    }
}
