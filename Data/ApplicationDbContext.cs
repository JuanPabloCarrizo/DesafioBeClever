using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Desafio.Models;

namespace Desafio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Registro> Registros { get; set; }
    }
}
