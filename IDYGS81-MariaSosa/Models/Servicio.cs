using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;

namespace IDYGS81_MariaSosa.Models
{
    public class Servicio
    {
        [Key]
        public int PkServicio { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

    }
}
