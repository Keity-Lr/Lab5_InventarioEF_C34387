using Lab5_InventarioEF_C34387.Models;
using System.Collections.Generic;

namespace Lab5_InventarioEF_C34387.Repositories
{
    public interface IProductoRepository
    {
        List<Producto> ObtenerTodos();
        Producto ObtenerPorId(int id);
        void Agregar(Producto p);
        void Actualizar(Producto p);
        void Eliminar(int id);
    }
}
