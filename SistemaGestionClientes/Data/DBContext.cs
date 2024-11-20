using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using SistemaGestionClientes.Models;

namespace SistemaGestionClientes.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<AgendaCliente> AgendaClientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=infolutions_agenda_cliente;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgendaCliente>().ToTable("agenda_clientes");
        }
    }
}