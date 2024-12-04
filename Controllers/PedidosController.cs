using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PedidosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Pedidos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pedido>>> GetPedidos()
        {
            return await _context.Pedidos.ToListAsync();
        }

        // GET: api/Pedidos/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Pedido>> GetPedido(int id)
        {
            var pedido = await _context.Pedidos.FindAsync(id);

            if (pedido == null)
            {
                return NotFound();
            }

            return pedido;
        }

        // POST: api/Pedidos
        [HttpPost]
        public async Task<ActionResult<Pedido>> PostPedido(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPedido", new { id = pedido.id }, pedido);
        }

        // PUT: api/Pedidos/id
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedido(int id, Pedido pedido)
        {
            if (id != pedido.id)
            {
                return BadRequest();
            }

            _context.Entry(pedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Pedidos/id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePedido(int id)
        {
            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }

            _context.Pedidos.Remove(pedido);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PedidoExists(int id)
        {
            return _context.Pedidos.Any(e => e.id == id);
        }

        [HttpPost("{pedidoId}/adicionar-produto/{produtoId}")]
        public async Task<IActionResult> AdicionarProdutoAoPedido(int pedidoId, int produtoId)
        {
            var pedido = await _context.Pedidos.FindAsync(pedidoId);
            if (pedido == null || pedido.StatusId != 1) // StatusId 1 = Aguardando Finalização
            {
                return BadRequest("Pedido não encontrado ou já finalizado.");
            }

            var produto = await _context.Produtos.FindAsync(produtoId);
            if (produto == null)
            {
                return NotFound("Produto não encontrado.");
            }

            var produtoPedido = new ProdutoPedido
            {
                PedidoId = pedidoId,
                ProdutoId = produtoId
            };

            _context.ProdutosPedidos.Add(produtoPedido);
            pedido.valor += (int)produto.preco; // Ajusta o valor do pedido
            await _context.SaveChangesAsync();

            return Ok(new { mensagem = "Produto adicionado ao pedido com sucesso.", pedido });
        }
        [HttpPost("{pedidoId}/finalizar")]
        public async Task<IActionResult> FinalizarPedido(int pedidoId)
        {
            var pedido = await _context.Pedidos.FindAsync(pedidoId);
            if (pedido == null || pedido.StatusId != 1) // StatusId 1 = Aguardando Finalização
            {
                return BadRequest("Pedido não encontrado ou já finalizado.");
            }

            pedido.StatusId = 2; // StatusId 2 = Finalizado
            await _context.SaveChangesAsync();

            return Ok(new { mensagem = "Pedido finalizado com sucesso.", pedido });
        }
    }
}
