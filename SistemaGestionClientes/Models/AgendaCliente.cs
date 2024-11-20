namespace SistemaGestionClientes.Models
{
    public class AgendaCliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Proyecto { get; set; }
        public string Empresa { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime FechaDeIngreso { get; set; }
        public DateTime HoraDeAgenda { get; set; }
        public DateTime? FechaHoraAtencionOficina { get; set; }
        public bool Revisado { get; set; } // Indica si el cliente ha sido revisado
        public string Comentarios { get; set; } // Comentarios de la atención
        public int EquipoAtencion { get; set; } // Equipo que realizó la atención
    }
}
