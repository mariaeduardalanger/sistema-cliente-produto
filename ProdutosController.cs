using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaEstagio.Models;
using SistemaEstagio.Data;

namespace SistemaEstagio.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProdutosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var produtos = await _context.Produtos.Include(p => p.Cliente).ToListAsync();
            return View(produtos);
        }

        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nome");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Produto produto)
        {
            ModelState.Clear();
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // --- NOVIDADES: EDITAR, DETALHES E EXCLUIR ---

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null) return NotFound();
            
            // Carrega a lista de clientes para o dropdown na tela de edição
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nome", produto.IdCliente);
            return View(produto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Produto produto)
        {
            if (id != produto.IdProduto) return NotFound();
            ModelState.Clear();

            try
            {
                _context.Update(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nome", produto.IdCliente);
                return View(produto);
            }
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var produto = await _context.Produtos
                .Include(p => p.Cliente)
                .FirstOrDefaultAsync(m => m.IdProduto == id);
            if (produto == null) return NotFound();
            return View(produto);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var produto = await _context.Produtos
                .Include(p => p.Cliente)
                .FirstOrDefaultAsync(m => m.IdProduto == id);
            if (produto == null) return NotFound();
            return View(produto);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}