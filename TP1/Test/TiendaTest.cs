using Xunit;

public class TiendaTests
{
    [Fact]
    public void AgregarProducto_ProductoSeAgrega()
    {
        var tienda = new Tienda();
        var producto = new Producto("Pan", 50, "Alimentos");

        tienda.AgregarProducto(producto);

        var buscado = tienda.BuscarProducto("Pan");

        Assert.NotNull(buscado);
        Assert.Equal("Pan", buscado.Nombre);
    }

    [Fact]
    public void EliminarProducto_ProductoExistente_SeElimina()
    {
        var tienda = new Tienda();
        var producto = new Producto("Jugo", 120, "Bebidas");

        tienda.AgregarProducto(producto);
        tienda.EliminarProducto("Jugo");

        Assert.Throws<KeyNotFoundException>(
            () => tienda.BuscarProducto("Jugo"));
    }
}



