using System.Linq.Expressions;

public class Tienda
{
    List<Producto> inventario = [];

    public Tienda()
    {
        inventario = new List<Producto>();
    }

    public void AgregarProducto(Producto producto)
    {
        inventario.Add(producto);
    }

    public Producto BuscarProducto(string nombre)
    {
        var producto = inventario.FirstOrDefault(p => p.Nombre == nombre);
        if (producto == null)
            throw new KeyNotFoundException($"Producto '{nombre}' no encontrado.");
        return producto;
    }

    public void EliminarProducto(string nombre)
    {
        var producto = inventario.FirstOrDefault(p => p.Nombre == nombre);
        if (producto == null)
            throw new KeyNotFoundException($"No se puede eliminar '{nombre}', no existe.");
        inventario.Remove(producto);
    }

    public void MostrarInventario()
    {
        foreach (var producto in inventario)
        {
            Console.WriteLine(producto.Nombre);
        }
    }

    public void AplicarDescuento(IProducto producto, decimal porcentaje)
    {
        if (producto == null) throw new ArgumentNullException(nameof(producto));
        decimal nuevoPrecio = producto.Precio * (1 - porcentaje / 100);
        producto.ActualizarPrecio(nuevoPrecio);
    }

    public decimal CalcularTotalCarrito(List<string> carrito)
    {
        decimal total = 0;
        foreach (var nombre in carrito)
        {
            var producto = BuscarProducto(nombre);
            total += producto.Precio;
        }
        return total;
    }
}

