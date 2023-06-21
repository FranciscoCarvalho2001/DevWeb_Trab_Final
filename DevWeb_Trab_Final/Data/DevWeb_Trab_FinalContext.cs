
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DevWeb_Trab_Final.Models;

namespace DevWeb_Trab_Final.Data
{
    public class DevWeb_Trab_FinalContext : IdentityDbContext
    {
        public DevWeb_Trab_FinalContext (DbContextOptions<DevWeb_Trab_FinalContext> options)
            : base(options)
        {
        }

        public DbSet<DevWeb_Trab_Final.Models.Clientes> Clientes { get; set; } = default!;

        public DbSet<DevWeb_Trab_Final.Models.Funcionarios> Funcionarios { get; set; }

        public DbSet<DevWeb_Trab_Final.Models.Dispositivos> Dispositivos { get; set; }

        public DbSet<DevWeb_Trab_Final.Models.Reparacao> Reparacao { get; set; }
    }
}
