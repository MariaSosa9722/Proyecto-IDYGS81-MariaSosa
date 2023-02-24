using IDYGS81_MariaSosa.Context;
using IDYGS81_MariaSosa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IDYGS81_MariaSosa.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly ApplicationDbContext _context;

        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var response = _context.Usuarios.Include(x => x.Roles).ToList();

            return View(response);
        }

        public IActionResult Crear(Usuario usuario)
        {
            Usuario res = new Usuario()
            {
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Correo = usuario.Correo,
                Password = usuario.Password,
                FKRol = usuario.FKRol
            };

            _context.Usuarios.Add(res);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));


        }

    }
}
