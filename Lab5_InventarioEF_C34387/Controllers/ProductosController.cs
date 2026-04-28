using Lab5_InventarioEF_C34387.Models;
using Lab5_InventarioEF_C34387.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Lab5_InventarioEF_C34387.Controllers
{
    public class ProductosController : Controller
    {
        private readonly IProductoRepository _repo;

        public ProductosController(IProductoRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var lista = _repo.ObtenerTodos();
            return View(lista);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producto p)
        {
            if (ModelState.IsValid)
            {
                _repo.Agregar(p);
                return RedirectToAction("Index");
            }
            return View(p);
        }

        public IActionResult Edit(int id)
        {
            var p = _repo.ObtenerPorId(id);
            return View(p);
        }

        [HttpPost]
        public IActionResult Edit(Producto p)
        {
            if (ModelState.IsValid)
            {
                _repo.Actualizar(p);
                return RedirectToAction("Index");
            }
            return View(p);
        }

        public IActionResult Delete(int id)
        {
            var p = _repo.ObtenerPorId(id);
            return View(p);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _repo.Eliminar(id);
            return RedirectToAction("Index");
        }
    }
}
