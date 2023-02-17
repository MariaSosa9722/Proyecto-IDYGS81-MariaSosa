using IDYGS81_MariaSosa.Context;
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
    }
}
