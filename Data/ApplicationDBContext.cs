using API_CRUD_ejercicioUno.Models;
using Microsoft.EntityFrameworkCore;

namespace API_CRUD_ejercicioUno.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(

            DbContextOptions<ApplicationDBContext> options 
            
            ) : base( options ) { }
        public DbSet<Producto> producto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasData(
                new Producto()
                {
                    IdProducto = 1,
                    Nombre = "A Court of Thorns and Roses",
                    Descripcion = "High Fantasy",
                    Cantidad = 20
                },
            new Producto()
            {
                IdProducto = 2,
                Nombre = "A Court of Mist and Fury",
                Descripcion = "High Fantasy",
                Cantidad = 20
            },
            new Producto()
            {
                IdProducto = 3,
                Nombre = "A Court of Wind and Ruins",
                Descripcion = "High Fantasy",
                Cantidad = 20
            },
            new Producto()
            {
                IdProducto = 4,
                Nombre = "A Court of Frost and Starlight",
                Descripcion = "High Fantasy",
                Cantidad = 20
            },
            new Producto()
            {
                IdProducto = 5,
                Nombre = "A Court of Silver Flames",
                Descripcion = "High Fantasy",
                Cantidad = 20
            }
                );
        }
    }
}
