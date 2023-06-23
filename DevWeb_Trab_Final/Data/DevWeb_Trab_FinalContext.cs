
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DevWeb_Trab_Final.Models;

namespace DevWeb_Trab_Final.Data
{
    public class DevWeb_Trab_Final_User : IdentityUser
    {
        /// <summary>
        /// 
        /// </summary>
        public string NomeUtilizador { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DataRegisto { get; set; }
    }

    public class DevWeb_Trab_FinalContext : IdentityDbContext<DevWeb_Trab_Final_User>
    {
        public DevWeb_Trab_FinalContext (DbContextOptions<DevWeb_Trab_FinalContext> options)
            : base(options)
        {
        }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                /*
                 * esta instrução importa todas as tarefas associadas ao método
                 * qd foi definida na superclasse
                 * */
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<IdentityRole>().HasData(
                 new IdentityRole { Id = "1", Name = "Administrador", NormalizedName = "ADMINISTRADOR" },
                 new IdentityRole { Id = "2", Name = "Funcionario", NormalizedName = "FUNCIONARIO" },
                 new IdentityRole { Id = "3", Name = "Cliente", NormalizedName = "CLIENTE" }
            );
            }

        public DbSet<DevWeb_Trab_Final.Models.Clientes> Clientes { get; set; } = default!;

        public DbSet<DevWeb_Trab_Final.Models.Funcionarios> Funcionarios { get; set; }

        public DbSet<DevWeb_Trab_Final.Models.Dispositivos> Dispositivos { get; set; }

        public DbSet<DevWeb_Trab_Final.Models.Reparacao> Reparacao { get; set; }
    }
}
