﻿namespace SistemaGestionClientes.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; } 
        public string Contraseña { get; set; }
        public string Rol { get; set; } 
        public int EquipoId { get; set; } 
    }
}
