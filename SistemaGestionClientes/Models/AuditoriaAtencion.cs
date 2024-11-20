namespace SistemaGestionClientes.Models
{
    public class AuditoriaAtencion
    {
        public int Id { get; set; }
        public int ClienteId { get; set; } // Relación con AgendaCliente
        public int UsuarioId { get; set; } // Relación con Usuario
        public DateTime FechaAtencion { get; set; } // Fecha y hora de atención
        public string Comentarios { get; set; } // Comentarios realizados
        public int EquipoId { get; set; } // Equipo que realizó la atención
    }
}
