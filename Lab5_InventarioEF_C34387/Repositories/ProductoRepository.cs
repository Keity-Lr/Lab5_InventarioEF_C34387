using Lab5_InventarioEF_C34387.Data;
using Lab5_InventarioEF_C34387.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Lab5_InventarioEF_C34387.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly AppDbContext _context;

        public ProductoRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Producto> ObtenerTodos()
        {
            return _context.Productos.ToList();
        }

        public Producto ObtenerPorId(int id)
        {
            return _context.Productos.Find(id);
        }

        public void Agregar(Producto p)
        {
            _context.Productos.Add(p);
            _context.SaveChanges();
        }

        public void Actualizar(Producto p)
        {
            _context.Productos.Update(p);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var p = _context.Productos.Find(id);
            if (p != null)
            {
                _context.Productos.Remove(p);
                _context.SaveChanges();
            }
        }
    }
}
