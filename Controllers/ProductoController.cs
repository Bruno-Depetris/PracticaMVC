using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PracticaMVC.Models;

namespace PracticaMVC.Controllers {
    public class ProductoController : Controller {

        private readonly TiendaSimpleContext _context;

        public ProductoController(TiendaSimpleContext context) {
            _context = context;
        }   
        public async Task<IActionResult> Index() {
            return View(await _context.Productos.ToListAsync());
        }

        public IActionResult Crate() {

            ViewData["Producto"] = new SelectList(_context.Productos, "ProductoId", "Nombre");
            return View();
        }
    }
}
