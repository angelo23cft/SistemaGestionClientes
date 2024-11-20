namespace SistemaGestionClientes.Models
{
    public class RestriccionAcceso
    {
        public int Id { get; set; }
        public string DireccionIP { get; set; } // Dirección IP permitida
        public string Descripcion { get; set; } // Ejemplo: "Oficina principal"
    }
}
