using IDYGS81_MariaSosa.Models;
using Microsoft.EntityFrameworkCore;

namespace IDYGS81_MariaSosa.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Rol> Roles { get; set; }
        public DbSet<Servicio> Servicios { get; set; }  
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
