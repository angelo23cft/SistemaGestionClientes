namespace SistemaGestionClientes.Models
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; } // Ejemplo: "Equipo Lenovo 1"
        public string DireccionIP { get; set; } 
        public bool Activo { get; set; } 
    }
}
