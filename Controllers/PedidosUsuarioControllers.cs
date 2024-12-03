using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosUsuarioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PedidosUsuarioController (AppDbContext context)
        {
            _context = context;
        }

        // GET: api/PedidoUsuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PedidoUsuario>>> GetPedidoUsuarios()
        {
            return await _context.PedidosUsuario.ToListAsync();
        }

        // GET: api/PedidoUsuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PedidoUsuario>> GetPedidoUsuario(int id)
        {
            var pedidoUsuario = await _context.PedidosUsuario.FindAsync(id);

            if (pedidoUsuario == null)
            {
                return NotFound();
            }

            return pedidoUsuario;
        }

        // POST: api/PedidoUsuarios
        [HttpPost]
        public async Task<ActionResult<PedidoUsuario>> PostPedidoUsuario(PedidoUsuario pedidoUsuario)
        {
            _context.PedidosUsuario.Add(pedidoUsuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPedidoUsuario", new { id = pedidoUsuario.PedidoId }, pedidoUsuario);
        }

        // DELETE: api/PedidoUsuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePedidoUsuario(int id)
        {
            var pedidoUsuario = await _context.PedidosUsuario.FindAsync(id);
            if (pedidoUsuario == null)
            {
                return NotFound();
            }

            _context.PedidosUsuario.Remove(pedidoUsuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
