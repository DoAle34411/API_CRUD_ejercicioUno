using API_CRUD_ejercicioUno.Data;
using API_CRUD_ejercicioUno.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_CRUD_ejercicioUno.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ApplicationDBContext _db;
        public ProductoController(ApplicationDBContext db)
        {
            _db = db;
        }
        // GET: api/<ProductoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
           List<Producto> products = await _db.producto.ToListAsync();
            return Ok(products) ;
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Producto producto = await _db.producto.FirstOrDefaultAsync(x=>x.IdProducto==id);
            if (producto == null)
            {
                return BadRequest();
            }

            return Ok(producto);

        }

        // POST api/<ProductoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Producto producto)
        {
            Producto producto2 = await _db.producto.FirstOrDefaultAsync(x => x.IdProducto == producto.IdProducto);
            if (producto == null && producto2 == null)
            {
                return BadRequest("No existe :( ");
            }
            else 
            {
                await _db.producto.AddAsync(producto);
                await _db.SaveChangesAsync();
                return Ok(producto);
            }
            
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
