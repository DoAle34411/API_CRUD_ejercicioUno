using System.ComponentModel.DataAnnotations;

namespace API_CRUD_ejercicioUno.Models
{
    public class Producto
    {
        [Required]
        public int IdProducto { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int Cantidad { get; set; }

    }
}
