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
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<AuditoriaAtencion> AuditoriasAtencion { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<RestriccionAcceso> RestriccionesAcceso { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
    :   base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgendaCliente>().ToTable("agenda_clientes");
            modelBuilder.Entity<Usuario>().ToTable("usuarios");
            modelBuilder.Entity<Equipo>().ToTable("equipos");
            modelBuilder.Entity<AuditoriaAtencion>().ToTable("auditoria_atenciones");
            modelBuilder.Entity<Proyecto>().ToTable("proyectos");
            modelBuilder.Entity<Tarea>().ToTable("tareas");
            modelBuilder.Entity<RestriccionAcceso>().ToTable("restricciones_acceso");
        }
    }
}