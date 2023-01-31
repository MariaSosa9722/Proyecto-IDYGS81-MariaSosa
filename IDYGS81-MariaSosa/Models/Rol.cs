using System.ComponentModel.DataAnnotations;

namespace IDYGS81_MariaSosa.Models
{
    public class Rol
    {
        [Key]
        public int PkRol { get; set; } 
        public string Nombre { get; set; }
    }
}
