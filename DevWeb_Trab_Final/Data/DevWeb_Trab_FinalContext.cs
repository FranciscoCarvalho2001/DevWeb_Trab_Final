using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DevWeb_Trab_Final.Models;

namespace DevWeb_Trab_Final.Data
{
    public class DevWeb_Trab_FinalContext : DbContext
    {
        public DevWeb_Trab_FinalContext (DbContextOptions<DevWeb_Trab_FinalContext> options)
            : base(options)
        {
        }

        public DbSet<DevWeb_Trab_Final.Models.Clientes> Clientes { get; set; } = default!;
    }
}
