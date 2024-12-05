using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosPedidoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdutosPedidoController(AppDbContext context)
        {
            _context = context;
        }

        // Método GET: api/ProdutoPedidos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoPedido>>> GetProdutoPedidos()
        {
            return await _context.ProdutosPedidos.ToListAsync();
        }

        // Método GET: api/ProdutoPedidos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoPedido>> GetProdutoPedido(int id)
        {
            var produtoPedido = await _context.ProdutosPedidos.FindAsync(id);

            if (produtoPedido == null)
            {
                return NotFound();
            }

            return produtoPedido;
        }

        // Método POST: api/ProdutoPedidos
        [HttpPost]
        public async Task<ActionResult<ProdutoPedido>> PostProdutoPedido(ProdutoPedido produtoPedido)
        {
            _context.ProdutosPedidos.Add(produtoPedido);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProdutoPedido", new { id = produtoPedido.ProdutoId }, produtoPedido);
        }

        // Método DELETE: api/ProdutoPedidos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProdutoPedido(int id)
        {
            var produtoPedido = await _context.ProdutosPedidos.FindAsync(id);
            if (produtoPedido == null)
            {
                return NotFound();
            }

            _context.ProdutosPedidos.Remove(produtoPedido);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
