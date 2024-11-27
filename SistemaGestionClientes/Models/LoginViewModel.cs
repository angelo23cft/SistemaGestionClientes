using System.ComponentModel.DataAnnotations;

namespace SistemaGestionClientes.Models
{
    public class LoginViewModel
    {
        [Required]
        public string NombreUsuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }
    }
}
