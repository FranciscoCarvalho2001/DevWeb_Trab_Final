
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DevWeb_Trab_Final.Models;
using System.Security;

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
                 new IdentityRole { Id = "a", Name = "Administrador", NormalizedName = "ADMINISTRADOR" },
                 new IdentityRole { Id = "f", Name = "Funcionario", NormalizedName = "FUNCIONARIO" },
                 new IdentityRole { Id = "c", Name = "Cliente", NormalizedName = "CLIENTE" }
                );

            var passwordHasher = new PasswordHasher<DevWeb_Trab_Final_User>();
            var password = "asdfghjkl";
            var hashedPassword = passwordHasher.HashPassword(null, password);

                modelBuilder.Entity<DevWeb_Trab_Final_User>().HasData(
                    new DevWeb_Trab_Final_User {
                        Id = "1",
                        NomeUtilizador = "Administrador",
                        DataRegisto = DateTime.Now,
                        UserName = "administrador@gmail.com",
                        NormalizedUserName = "ADMINISTRADOR@GMAIL.COM",
                        Email = "administrador@gmail.com",
                        NormalizedEmail = "ADMINISTRADOR@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = hashedPassword,
                        SecurityStamp = Guid.NewGuid().ToString()
                    }
                );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string> { UserId = "1", RoleId = "a"}
                );
            }

        public DbSet<DevWeb_Trab_Final.Models.Clientes> Clientes { get; set; } = default!;

        public DbSet<DevWeb_Trab_Final.Models.Funcionarios> Funcionarios { get; set; }

        public DbSet<DevWeb_Trab_Final.Models.Dispositivos> Dispositivos { get; set; }

        public DbSet<DevWeb_Trab_Final.Models.Reparacao> Reparacao { get; set; }
    }
}
