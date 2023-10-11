using API_CRUD_ejercicioUno.Models;
using Microsoft.EntityFrameworkCore;

namespace API_CRUD_ejercicioUno.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(

            DbContextOptions<ApplicationDBContext> options 
            
            ) : base( options ) { }
        DbSet<Producto> producto { get; set; }
    }
}
