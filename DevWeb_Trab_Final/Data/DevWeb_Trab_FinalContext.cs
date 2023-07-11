
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
        /// Nome do Utilizador
        /// </summary>
        public string NomeUtilizador { get; set; }

        /// <summary>
        /// Data de Registo do Utilizador
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

                /// <summary>
                /// Roles existentes no Site
                /// </summary>
                modelBuilder.Entity<IdentityRole>().HasData(
                    new IdentityRole { Id = "a", Name = "Administrador", NormalizedName = "ADMINISTRADOR" },
                    new IdentityRole { Id = "f", Name = "Funcionario", NormalizedName = "FUNCIONARIO" },
                    new IdentityRole { Id = "c", Name = "Cliente", NormalizedName = "CLIENTE" }
                );

                // Inicalização das Tabelas da DB

                /// <summary>
                /// Tabela Funcionarios
                /// </summary>
                modelBuilder.Entity<Funcionarios>().HasData(
                    new Funcionarios { Id = 1, Nome = "Daniel Filipe", Morada = "Rua da Pedrada", CodPostal = "2300-450 TRAMAGAL", Email = "daniel@gmail.com", Telemovel = "912123123", Especializacao = "Computadores", UserId = "f1" },
                    new Funcionarios { Id = 2, Nome = "Rodrigo Antunes", Morada = "Rua do Pinheiro", CodPostal = "2305-670 ALBUFEIRA", Email = "rodrigo@gmail.com", Telemovel = "915789789", Especializacao = "Computadores", UserId = "f2" },
                    new Funcionarios { Id = 3, Nome = "Leia Marques", Morada = "Avenida 31 de Outubro", CodPostal = "2200-301 BRAGA", Email = "leia.marques@gmail.com", Telemovel = "962231123", Especializacao = "Telemóveis", UserId = "f3" },
                    new Funcionarios { Id = 4, Nome = "Carlos Tomaz", Morada = "Praça da Nogueira", CodPostal = "2731-659 BEJA", Email = "carlos@gmail.com", Telemovel = "932553923", Especializacao = "Eletrodomésticos", UserId = "f4" },
                    new Funcionarios { Id = 5, Nome = "Tiago Roberto Varandas", Morada = "Praia de Lagos", CodPostal = "3030-155 SAGRES", Email = "tiago_varandas@gmail.com", Telemovel = "922456123", Especializacao = "Tablets", UserId = "f5" }
                );
                
                /// <summary>
                /// Tabela Clientes
                /// </summary>
                modelBuilder.Entity<Clientes>().HasData(
                    new Clientes { Id = 1, Nome = "Alberto Santos", NIF = 249249249, Morada = "Bairo Rui Lopes", CodPostal = "2500-654 PORTIMÃO", Email = "alberto@hotmail.com", Telemovel = "969777666", UserId = "c1" },
                    new Clientes { Id = 2, Nome = "Maria João", NIF = 256249999, Morada = "Canto da Cerejeiras", CodPostal = "2678-283 LISBOA", Email = "maria.joao@hotmail.com", Telemovel = "933751916", UserId = "c2" },
                    new Clientes { Id = 3, Nome = "Catarina Moedas", NIF = 189234831, Morada = "Rua Salvador Sobral", CodPostal = "1672-123 AVEIRO", Email = "catarina@hotmail.com", Telemovel = "919744531", UserId = "c3" },
                    new Clientes { Id = 4, Nome = "Gustavo Palhinha", NIF = 222738901, Morada = "Placeta dos Santos Simões", CodPostal = "3111-879 CASAIS", Email = "gustavo_pal@hotmail.com", Telemovel = "923321348", UserId = "c4" }
                );

                /// <summary>
                /// Tabela Dispositivos
                /// </summary>
                modelBuilder.Entity<Dispositivos>().HasData(
                    new Dispositivos { Id = 1, Tipo = "PC-Alberto", DataReg = new DateTime(2023, 2, 13, 14, 20, 48, 435, DateTimeKind.Local).AddTicks(8516), Modelo = "Asus", Estado = "Ecrã Partido", ClienteFK = 1 },
                    new Dispositivos { Id = 2, Tipo = "MicroOndas-Maria", DataReg = new DateTime(2023, 5, 9, 18, 10, 14, 435, DateTimeKind.Local).AddTicks(8516), Modelo = "Samsung", Estado = "Não liga", ClienteFK = 2 },
                    new Dispositivos { Id = 3, Tipo = "Telemovel-Maria", DataReg = DateTime.Now, Modelo = "Xiaomi", Estado = "Não faz chamadas", ClienteFK = 2 },
                    new Dispositivos { Id = 4, Tipo = "Tablet-Catarina", DataReg = new DateTime(2023, 6, 23, 12, 50, 22, 435, DateTimeKind.Local).AddTicks(8516), Modelo = "Apple", Estado = "Tem virus", ClienteFK = 3 },
                    new Dispositivos { Id = 5, Tipo = "Relogio-Gustavo", DataReg = new DateTime(2023, 3, 30, 9, 35, 34, 435, DateTimeKind.Local).AddTicks(8516), Modelo = "Sony", Estado = "Não deixa mudar as horas", ClienteFK = 4 },
                    new Dispositivos { Id = 6, Tipo = "Portatil-Gustavo", DataReg = new DateTime(2023, 7, 9, 14, 55, 44, 435, DateTimeKind.Local).AddTicks(8516), Modelo = "HP", Estado = "Bateria quase a rebentar", ClienteFK = 4 },
                    new Dispositivos { Id = 7, Tipo = "Ventoinha-Alberto", DataReg = new DateTime(2023, 4, 4, 10, 20, 33, 435, DateTimeKind.Local).AddTicks(8516), Modelo = "Wahson", Estado = "Não vira", ClienteFK = 1 }
                );

                /// <summary>
                /// Tabela Fotografias
                /// </summary>
                modelBuilder.Entity<Fotografias>().HasData(
                    new Fotografias { Id = 1, NomeFoto = "noDispositivo.png", DispositivoFK = 1 },
                    new Fotografias { Id = 2, NomeFoto = "noDispositivo.png", DispositivoFK = 2 },
                    new Fotografias { Id = 3, NomeFoto = "noDispositivo.png", DispositivoFK = 3 },
                    new Fotografias { Id = 4, NomeFoto = "ipad.png", DispositivoFK = 4 },
                    new Fotografias { Id = 5, NomeFoto = "relogio.png", DispositivoFK = 5 },
                    new Fotografias { Id = 6, NomeFoto = "noDispositivo.png", DispositivoFK = 6 },
                    new Fotografias { Id = 7, NomeFoto = "ventoinha.png", DispositivoFK = 7 }
                );

                /// <summary>
                /// Tabela Reparação
                /// </summary>
                modelBuilder.Entity<Reparacao>().HasData(
                    new Reparacao { Id = 1, DataInicio = DateTime.Now, DataFim = null, Custo = 80.35m, CustoAux = "", Observacao = "É preciso comprar um ecrã novo", DispositivoFK = 1, FuncionariosFK = 1 },
                    new Reparacao { Id = 2, DataInicio = new DateTime(2023, 5, 9, 18, 15, 44, 435, DateTimeKind.Local).AddTicks(8516), DataFim = null, Custo = 50.43m, CustoAux = "", Observacao = "É preciso trocar a fonte de alimentação", DispositivoFK = 2, FuncionariosFK = 2 },
                    new Reparacao { Id = 3, DataInicio = new DateTime(2023, 5, 10, 19, 55, 59, 435, DateTimeKind.Local).AddTicks(8516), DataFim = null, Custo = 7.52m, CustoAux = "", Observacao = "É tambem preciso arranjar o cabo de alimentação", DispositivoFK = 2, FuncionariosFK = 4 },
                    new Reparacao { Id = 4, DataInicio = DateTime.Now, DataFim = null, Custo = 10.67m, CustoAux = "", Observacao = "É preciso mudar a antena", DispositivoFK = 3, FuncionariosFK = 4 },
                    new Reparacao { Id = 5, DataInicio = new DateTime(2023, 6, 24, 11, 28, 23, 435, DateTimeKind.Local).AddTicks(8516), DataFim = null, Custo = 20.20m, CustoAux = "", Observacao = "Tentar meter um antivírus", DispositivoFK = 4, FuncionariosFK = 3 },
                    new Reparacao { Id = 6, DataInicio = new DateTime(2023, 6, 25, 18, 48, 24, 435, DateTimeKind.Local).AddTicks(8516), DataFim = null, Custo = 40.00m, CustoAux = "", Observacao = "É preciso formatar o tablet", DispositivoFK = 4, FuncionariosFK = 5 },
                    new Reparacao { Id = 7, DataInicio = new DateTime(2023, 7, 11, 16, 30, 33, 435, DateTimeKind.Local).AddTicks(8516), DataFim = null, Custo = 8.90m, CustoAux = "", Observacao = "É preciso mudar os botões", DispositivoFK = 5, FuncionariosFK = 4 },
                    new Reparacao { Id = 8, DataInicio = new DateTime(2023, 7, 9, 15, 00, 12, 435, DateTimeKind.Local).AddTicks(8516), DataFim = null, Custo = 50.77m, CustoAux = "", Observacao = "É preciso encomendar uma bateria nova", DispositivoFK = 6, FuncionariosFK = 3 },
                    new Reparacao { Id = 9, DataInicio = new DateTime(2023, 2, 15, 13, 45, 51, 435, DateTimeKind.Local).AddTicks(8516), DataFim = new DateTime(2023, 2, 17, 14, 30, 11, 435, DateTimeKind.Local).AddTicks(8516), Custo = 10.00m, CustoAux = "", Observacao = "Arranjado", DispositivoFK = 1, FuncionariosFK = 5 },
                    new Reparacao { Id = 10, DataInicio = new DateTime(2023, 7, 12, 14, 25, 20, 435, DateTimeKind.Local).AddTicks(8516), DataFim = DateTime.Now, Custo = 20.30m, CustoAux = "", Observacao = "Arranjado", DispositivoFK = 3, FuncionariosFK = 5 },
                    new Reparacao { Id = 11, DataInicio = new DateTime(2023, 3, 30, 9, 50, 50, 435, DateTimeKind.Local).AddTicks(8516), DataFim = new DateTime(2023, 4, 1, 11, 33, 17, 435, DateTimeKind.Local).AddTicks(8516), Custo = 60.78m, CustoAux = "", Observacao = "Arranjado", DispositivoFK = 5, FuncionariosFK = 2 },
                    new Reparacao { Id = 12, DataInicio = new DateTime(2023, 4, 4, 10, 30, 34, 435, DateTimeKind.Local).AddTicks(8516), DataFim = new DateTime(2023, 4, 5, 17, 50, 25, 435, DateTimeKind.Local).AddTicks(8516), Custo = 60.78m, CustoAux = "", Observacao = "Arranjado", DispositivoFK = 7, FuncionariosFK = 4 }
                );

                // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- //
                
                /// <summary>
                /// Criação dos Utilizadores e Associação de Roles na DB 
                /// </summary>
                
                // Variavel da Password
                var passwordHasher = new PasswordHasher<DevWeb_Trab_Final_User>();
                // PASSWORD DEFAULT
                var password = "Aa*12345";
                // Fazer hash da Password
                var hashedPassword = passwordHasher.HashPassword(null, password);
                
                /// <summary>
                /// Utilizadores 
                /// </summary>
                modelBuilder.Entity<DevWeb_Trab_Final_User>().HasData(

                    // Administradores
                    new DevWeb_Trab_Final_User {
                        Id = "a1",
                        NomeUtilizador = "Administrador UM",
                        DataRegisto = new DateTime(2023, 1, 1, 9, 00, 00, 435, DateTimeKind.Local).AddTicks(8516),
                        UserName = "administrador_1@gmail.com",
                        NormalizedUserName = "ADMINISTRADOR_1@GMAIL.COM",
                        Email = "administrador_1@gmail.com",
                        NormalizedEmail = "ADMINISTRADOR_1@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = hashedPassword,
                        SecurityStamp = Guid.NewGuid().ToString()
                    },
                    new DevWeb_Trab_Final_User {
                        Id = "a2",
                        NomeUtilizador = "Administrador DOIS",
                        DataRegisto = new DateTime(2023, 1, 1, 9, 00, 00, 435, DateTimeKind.Local).AddTicks(8516),
                        UserName = "administrador_2@gmail.com",
                        NormalizedUserName = "ADMINISTRADOR_2@GMAIL.COM",
                        Email = "administrador_2@gmail.com",
                        NormalizedEmail = "ADMINISTRADOR_2@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = hashedPassword,
                        SecurityStamp = Guid.NewGuid().ToString()
                    },

                    // Funcionários
                    new DevWeb_Trab_Final_User {
                        Id = "f1",
                        NomeUtilizador = "Daniel Filipe",
                        DataRegisto = new DateTime(2023, 1, 20, 11, 00, 00, 435, DateTimeKind.Local).AddTicks(8516),
                        UserName = "daniel@gmail.com",
                        NormalizedUserName = "DANIEL@GMAIL.COM",
                        Email = "daniel@gmail.com",
                        NormalizedEmail = "DANIEL@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = hashedPassword,
                        SecurityStamp = Guid.NewGuid().ToString(),
                        PhoneNumber = "912123123"
                    },
                    new DevWeb_Trab_Final_User {
                        Id = "f2",
                        NomeUtilizador = "Rodrigo Antunes",
                        DataRegisto = new DateTime(2023, 1, 15, 14, 20, 00, 435, DateTimeKind.Local).AddTicks(8516),
                        UserName = "rodrigo@gmail.com",
                        NormalizedUserName = "RODRIGO@GMAIL.COM",
                        Email = "rodrigo@gmail.com",
                        NormalizedEmail = "RODRIGO@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = hashedPassword,
                        SecurityStamp = Guid.NewGuid().ToString(),
                        PhoneNumber = "915789789"
                    },
                    new DevWeb_Trab_Final_User {
                        Id = "f3",
                        NomeUtilizador = "Leia Marques",
                        DataRegisto = new DateTime(2023, 1, 29, 16, 00, 00, 435, DateTimeKind.Local).AddTicks(8516),
                        UserName = "leia.marques@gmail.com",
                        NormalizedUserName = "LEIA.MARQUES@GMAIL.COM",
                        Email = "leia.marques@gmail.com",
                        NormalizedEmail = "LEIA.MARQUES@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = hashedPassword,
                        SecurityStamp = Guid.NewGuid().ToString(),
                        PhoneNumber = "962231123"
                    },
                    new DevWeb_Trab_Final_User {
                        Id = "f4",
                        NomeUtilizador = "Carlos Tomaz",
                        DataRegisto = new DateTime(2023, 2, 2, 12, 15, 00, 435, DateTimeKind.Local).AddTicks(8516),
                        UserName = "carlos@gmail.com",
                        NormalizedUserName = "CARLOS@GMAIL.COM",
                        Email = "carlos@gmail.com",
                        NormalizedEmail = "CARLOS@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = hashedPassword,
                        SecurityStamp = Guid.NewGuid().ToString(),
                        PhoneNumber = "932553923"
                    },
                    new DevWeb_Trab_Final_User {
                        Id = "f5",
                        NomeUtilizador = "Tiago Roberto Varandas",
                        DataRegisto = new DateTime(2023, 2, 18, 11, 50, 00, 435, DateTimeKind.Local).AddTicks(8516),
                        UserName = "tiago_varandas@gmail.com",
                        NormalizedUserName = "TIAGO_VARANDAS@GMAIL.COM",
                        Email = "tiago_varandas@gmail.com",
                        NormalizedEmail = "TIAGO_VARANDAS@GMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = hashedPassword,
                        SecurityStamp = Guid.NewGuid().ToString(),
                        PhoneNumber = "922456123"
                    },

                    // Clientes
                    new DevWeb_Trab_Final_User {
                        Id = "c1",
                        NomeUtilizador = "Alberto Santos",
                        DataRegisto = new DateTime(2023, 2, 13, 14, 10, 00, 435, DateTimeKind.Local).AddTicks(8516),
                        UserName = "alberto@hotmail.com",
                        NormalizedUserName = "ALBERTO@HOTMAIL.COM",
                        Email = "alberto@hotmail.com",
                        NormalizedEmail = "ALBERTO@HOTMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = hashedPassword,
                        SecurityStamp = Guid.NewGuid().ToString(),
                        PhoneNumber = "969777666"
                    },
                    new DevWeb_Trab_Final_User {
                        Id = "c2",
                        NomeUtilizador = "Maria João",
                        DataRegisto = new DateTime(2023, 5, 9, 17, 59, 00, 435, DateTimeKind.Local).AddTicks(8516),
                        UserName = "maria.joao@hotmail.com",
                        NormalizedUserName = "MARIA.JOAO@HOTMAIL.COM",
                        Email = "maria.joao@hotmail.com",
                        NormalizedEmail = "MARIA.JOAO@HOTMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = hashedPassword,
                        SecurityStamp = Guid.NewGuid().ToString(),
                        PhoneNumber = "933751916"
                    },
                    new DevWeb_Trab_Final_User {
                        Id = "c3",
                        NomeUtilizador = "Catarina Moedas",
                        DataRegisto = new DateTime(2023, 6, 23, 12, 40, 00, 435, DateTimeKind.Local).AddTicks(8516),
                        UserName = "catarina@hotmail.com",
                        NormalizedUserName = "CATARINA@HOTMAIL.COM",
                        Email = "catarina@hotmail.com",
                        NormalizedEmail = "CATARINA@HOTMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = hashedPassword,
                        SecurityStamp = Guid.NewGuid().ToString(),
                        PhoneNumber = "919744531"
                    },
                    new DevWeb_Trab_Final_User {
                        Id = "c4",
                        NomeUtilizador = "Gustavo Palhinha",
                        DataRegisto = new DateTime(2023, 3, 30, 9, 30, 00, 435, DateTimeKind.Local).AddTicks(8516),
                        UserName = "gustavo_pal@hotmail.com",
                        NormalizedUserName = "GUSTAVO_PAL@HOTMAIL.COM",
                        Email = "gustavo_pal@hotmail.com",
                        NormalizedEmail = "GUSTAVO_PAL@HOTMAIL.COM",
                        EmailConfirmed = true,
                        PasswordHash = hashedPassword,
                        SecurityStamp = Guid.NewGuid().ToString(),
                        PhoneNumber = "923321348"
                    }
                );

                modelBuilder.Entity<IdentityUserRole<string>>().HasData(

                    // Role dos Administradores
                    new IdentityUserRole<string> { UserId = "a1", RoleId = "a" },
                    new IdentityUserRole<string> { UserId = "a2", RoleId = "a" },

                    // Role dos Funcionários
                    new IdentityUserRole<string> { UserId = "f1", RoleId = "f" },
                    new IdentityUserRole<string> { UserId = "f2", RoleId = "f" },
                    new IdentityUserRole<string> { UserId = "f3", RoleId = "f" },
                    new IdentityUserRole<string> { UserId = "f4", RoleId = "f" },
                    new IdentityUserRole<string> { UserId = "f5", RoleId = "f" },

                    // Role dos Clientes
                    new IdentityUserRole<string> { UserId = "c1", RoleId = "c" },
                    new IdentityUserRole<string> { UserId = "c2", RoleId = "c" },
                    new IdentityUserRole<string> { UserId = "c3", RoleId = "c" },
                    new IdentityUserRole<string> { UserId = "c4", RoleId = "c" }
                );
            }

        public DbSet<DevWeb_Trab_Final.Models.Clientes> Clientes { get; set; } = default!;

        public DbSet<DevWeb_Trab_Final.Models.Funcionarios> Funcionarios { get; set; }

        public DbSet<DevWeb_Trab_Final.Models.Dispositivos> Dispositivos { get; set; }

        public DbSet<DevWeb_Trab_Final.Models.Reparacao> Reparacao { get; set; }
    }
}
