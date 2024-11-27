using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using SistemaGestionClientes.Data;
using SistemaGestionClientes.Models;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace SistemaGestionClientes.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            // Buscar usuario en la base de datos
            var user = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.NombreUsuario == model.NombreUsuario);

            if (user == null || user.Contraseña != model.Contraseña) // Puedes agregar hash aquí
            {
                ModelState.AddModelError("", "Credenciales inválidas");
                return View(model);
            }

            // Configuración de Claims
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.NombreUsuario),
                new Claim(ClaimTypes.Role, user.Rol),
                new Claim("EquipoId", user.EquipoId.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            // Iniciar sesión
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity)
            );

            // Redirigir según el rol del usuario
            if (user.Rol == "admin")
            {
                return RedirectToAction("Index", "Home"); // Página para administradores
            }
            else if (user.Rol == "usuario")
            {
                return RedirectToAction("Dashboard", "Usuario"); // Página para usuarios comunes
            }

            // Redirigir a página de error si el rol no es válido
            return RedirectToAction("AccessDenied", "Auth");
        }

        // Logout
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Auth");
        }
    }
}
