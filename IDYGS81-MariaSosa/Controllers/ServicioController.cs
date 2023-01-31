using IDYGS81_MariaSosa.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace IDYGS81_MariaSosa.Controllers
{
    public class ServicioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServicioController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var res = _context.Servicios.ToList();

            return View(res);
        }
    }
}
