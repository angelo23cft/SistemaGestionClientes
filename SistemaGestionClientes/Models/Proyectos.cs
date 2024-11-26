namespace SistemaGestionClientes.Models
{
    public class Proyecto 
    {
        public int Id { get; set; }
        public string Nombre { get; set; } // Nombre del proyecto
        public string Descripcion { get; set; } // Descripción detallada
        public int ClienteId { get; set; } // Relación con AgendaCliente
        public AgendaCliente Cliente { get; set; } // Navegación
    }
}
