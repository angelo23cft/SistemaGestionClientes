using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SistemaGestionClientes.Controllers
{
    [Authorize(Roles = "usuario")] // Solo accesible para usuarios con rol "usuario"
    public class UsuarioController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
