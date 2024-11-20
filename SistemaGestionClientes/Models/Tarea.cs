namespace SistemaGestionClientes.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } // Detalle de la tarea
        public DateTime FechaLimite { get; set; } // Fecha de vencimiento
        public bool Completada { get; set; } // Estado de la tarea
        public int ProyectoId { get; set; } // Relación con Proyecto
        public Proyecto Proyecto { get; set; } // Navegación
    }
}
